using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;

namespace DAL.Com
{
    public class BillingService : BaseService
    {
        public string Entry(BilliingVO vo)
        {
            string billNO = string.Empty;
            DateTime now = DateTime.Now;
            billNO = GenBillNO(string.Format("{0:yyyyMMdd}", now), vo.Direct);
            if (StringUtil.isEmpty(billNO))
                return billNO;
            foreach (string orderNO in vo._OrderNOList)
            {
                BillingInfo binfo = new BillingInfo();
                binfo.BillNO = billNO;
                binfo.OrderNO = orderNO;
                Connector.Save<BillingInfo>(binfo);

                Order order = new Order();
                order.OrderNO__PK = orderNO;
                order.Handled = HANDLE_FLAG.HANDLED;
                Connector.Update<Order>(order);
            }
            Billing bill = new Billing();
            bill.Amount = vo.Amount;
            bill.BillNO__PK = billNO;
            bill.CrtTmst = now;
            bill.CrtUsrId = vo.CrtUsrId;
            bill.CustID = vo.CustID;
            bill.CustName = vo.CustName;
            bill.Direct = vo.Direct;
            bill.FactAmount = 0;
            Connector.Save<Billing>(bill);
            return billNO;
        }

        public int UpdateAmount(BillingChld chld, CustAcnt acnt)
        {
            DateTime now = DateTime.Now;
            int cnt = 0;
            Dictionary<string, object> values = null;
            long? acntId;
            if (null != acnt && null == acnt.ID__PK)
            {
                string acntSql = "SELECT MAX(ID) FROM CUST_ACNT WHERE AcntType=@type AND AcntNO=@acntNO AND CustID=@custId ";
                values = new Dictionary<string, object>();
                values.Add("type", acnt.AcntType);
                values.Add("acntNO", acnt.AcntNO);
                values.Add("custId", acnt.CustID);
                if (PAY_MODE.THIRD_PLATFORM == chld.PayMode)
                {
                    acnt.AcntType = ACNT_TYPE.THIRD_PLATFORM;
                    acntSql += "AND Platform=@patf ";
                    values.Add("patf", acnt.Platform);
                }
                else if (PAY_MODE.BANK_TRANSFER == chld.PayMode)
                {
                    acnt.AcntType = ACNT_TYPE.BANCK_NO;
                    acnt.Platform = null;
                }
                Connector.Save<CustAcnt>(acnt);
                acntId = Connector.ScalarLong(acntSql, values);
            }
            else if (null != acnt && null != acnt.ID__PK)
                acntId = (long)acnt.ID__PK;
            else
                acntId = null;
            chld.OprtTmst = now;
            chld.AcntId = acntId;
            cnt = Connector.Save<BillingChld>(chld);
            string sql = "UPDATE BILLING SET FactAmount=(SELECT SUM(Amount) FROM BILLING_CHLD WHERE BillNO=@billNO) "
                       + "WHERE BillNO=@billNO";
            values = new Dictionary<string, object>();
            values.Add("billNO", chld.BillNO);
            cnt += Connector.DbHelper.ExecuteSql(sql, values);
            return cnt;
        }

        public List<BilliingVO> LoadBills(Billing bill, bool? settled, DateTime? startDt, DateTime? endDt, PageVO page)
        {
            string sql = "SELECT b.BillNO,"
                        + "b.Direct,"
                        + "b.Amount,"
                        + "b.FactAmount,"
                        + "b.CustID,"
                        + "b.CustName,"
                        + "b.CrtTmst,"
                        + "b.CrtUsrId,"
                        + "u.UName as CrtUsrName "
                        + "FROM BILLING b,USR u "
                        + "WHERE b.CrtUsrId=u.UID ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            if (null != startDt && null == endDt)
                endDt = ((DateTime)startDt).AddMonths(1);
            else if (null == startDt && null != endDt)
                startDt = ((DateTime)endDt).AddMonths(-1);
            else if (null == startDt && null == endDt)
            {
                endDt = DateTime.Parse(DateTime.Now.ToShortDateString());
                startDt = ((DateTime)endDt).AddMonths(-3);
            }
            endDt = ((DateTime)endDt).AddDays(1);
            sql += "AND b.CrtTmst>=@StDt AND b.CrtTmst<@EndDt ";
            values.Add("StDt", startDt);
            values.Add("EndDt", endDt);
            if (null != bill.CustID && 0 != bill.CustID)
            {
                sql += "AND b.CustID=@custId ";
                values.Add("custId", bill.CustID);
            }
            if (!StringUtil.isEmpty(bill.BillNO__PK))
            {
                sql += "AND b.BillNO LIKE @billNO ";
                values.Add("billNO", bill.BillNO__PK);
            }
            if (!StringUtil.isEmpty(bill.Direct))
            {
                sql += "AND b.Direct=@direct ";
                values.Add("direct", bill.Direct);
            }
            if (null != settled)
            {
                if ((bool)settled)
                    sql += "AND b.Amount=b.FactAmount ";
                else
                    sql += "AND b.Amount<>b.FactAmount ";
            }
            sql += "ORDER BY (CASE WHEN b.Amount<>b.FactAmount THEN 1 ELSE 0 END) DESC,b.BillNO ASC ";
            if(null == page)
                return Connector.LoadModels<BilliingVO>(sql, values);
            else
                return Connector.LoadModelsByPage<BilliingVO>(sql, values, page);
        }

        public BilliingVO LoadBill(string billNO, int custId, PageVO page)
        {
            string sql = "SELECT b.BillNO,"
                        + "b.Direct,"
                        + "b.Amount,"
                        + "b.FactAmount,"
                        + "b.CustID,"
                        + "b.CustName,"
                        + "b.CrtTmst,"
                        + "b.CrtUsrId,"
                        + "u.UName as CrtUsrName "
                        + "FROM BILLING b,USR u "
                        + "WHERE b.CrtUsrId=u.UID "
                        + "AND b.CustID=@custId "
                        + "AND b.BillNO=@billNO";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("custId", custId);
            values.Add("billNO", billNO);
            List<BilliingVO> list = Connector.LoadModels<BilliingVO>(sql, values);

            if (null == list || list.Count < 1)
                return null;

            sql = "SELECT * FROM BILLING_INFO WHERE BillNO=@billNO";
            values = new Dictionary<string, object>();
            values.Add("billNO", billNO);
            List<BillingInfo> binfos = Connector.LoadModels<BillingInfo>(sql, values);
            if (null != binfos && binfos.Count > 0)
            {
                List<string> orderNOs = new List<string>();
                foreach (BillingInfo binfo in binfos)
                    orderNOs.Add(binfo.OrderNO);
                list[0]._OrderNOList = orderNOs;
            }
            return list[0];
        }

        public List<BillingChldVO> LoadBillingChld(string billNO, PageVO page)
        {
            string sql = "SELECT b.ID,"
                       + "b.BillNO,"
                       + "b.Amount,"
                       + "b.PayMode,"
                       + "b.AcntId,"
                       + "b.OprtTmst,"
                       + "b.OprtUsrId,"
                       + "ca.AcntNO,"
                       + "ca.AcntType,"
                       + "ca.Platform,"
                       + "u.UName as OprtUsrName "
                       +"FROM BILLING_CHLD b "
                       + "JOIN USR u ON(b.OprtUsrId=u.UID ) "
                       + "LEFT JOIN CUST_ACNT ca ON(b.AcntId=ca.ID) "
                       + "WHERE b.BillNO=@billNO "
                       + "ORDER BY b.ID " ;
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("billNO", billNO);

            if(null == page)
                return Connector.LoadModels<BillingChldVO>(sql, values);
            else
                return Connector.LoadModelsByPage<BillingChldVO>(sql, values, page);
        }

        public List<CustAcnt> LoadCustAcntByKeywords(int custId, string acntType, string platform, string term)
        {
            string sql = "SELECT ID,"
                       + "AcntNO,"
                       + "AcntType,"
                       + "CustID,"
                       + "Platform,"
                       + "ST "
                       + "FROM CUST_ACNT "
                       + "WHERE CustID=@custId "
                       + "AND ST=@St "
                       + "AND AcntType=@type "
                       + "AND AcntNO LIKE @term ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("custId", custId);
            values.Add("St", ST.VALID);
            values.Add("type", acntType);
            values.Add("term", "%"+term+"%");
            if (ACNT_TYPE.THIRD_PLATFORM == acntType)
            {
                sql += "AND Platform=@patf ";
                values.Add("patf", platform);
            }
            sql += "ORDER BY Platform,AcntNO";

            PageVO page = new PageVO();
            page.PageNo = 1;
            page.PageSize = 20;
            return Connector.LoadModelsByPage<CustAcnt>(sql, values, page);
        }

        private string GenBillNO(string dtStr, string pymntDirect)
        {
            string billNO = null;
            string preStr = null;
            if (pymntDirect == PYMNT_DIRECT.PAY)
                preStr = BILLNO_PREF.PAY_BILL;
            else if (pymntDirect == PYMNT_DIRECT.RECEIVE)
                preStr = BILLNO_PREF.RECEIVE_BILL;
            else
                return billNO;
            string sql = "SELECT MAX(BillNO) FROM BILLING WHERE BillNO LIKE @today";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("today", preStr + dtStr + "%");
            billNO = Connector.ScalarStr(sql, values);
            if (null == billNO)
                billNO = preStr + dtStr + "001";
            else
            {
                long no = long.Parse(billNO.Replace(preStr, ""));
                billNO = preStr + (no + 1);
            }
            return billNO;
        }
    }
}

