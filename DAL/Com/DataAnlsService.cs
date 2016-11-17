using Model.Const;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Com
{
    public class DataAnlsService : BaseService
    {
        public AnlsRsltVO ProfitStatsByMonth(int year, short? subCatgId, int? goodsId)
        {
            string sql = "SELECT MONTH(ordr.CrtTmst) as mth,"
                        + "SUM((sout.Num - sout.RfNum) * (sout.Price - stin.Price)) as amnt "
                        + "FROM STOCKOUT sout,"
                        + "ORDERS ordr,"
                        + "INVENTORY inv,"
                        + "STOCKIN stin,"
                        + "GOODS g "
                        + "WHERE sout.OrderNO = ordr.OrderNO "
                        + "AND sout.InvID = inv.InvID "
                        + "AND inv.OrderNO = stin.OrderNO "
                        + "AND inv.GID = g.GID "
                        + "AND ordr.Direct =@direct ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("direct", DIRECT.STOCK_OUT);

            if (year != 0)
            {
                sql += "AND YEAR(ordr.CrtTmst)=@year ";
                values.Add("year",year);
            }

            if(null != subCatgId && subCatgId != 0)
            {
                sql += "AND g.SubCatgID=@catgId ";
                values.Add("catgId", subCatgId);
            }

            if (null != goodsId && goodsId != 0)
            {
                sql += "AND inv.GID=@gId ";
                values.Add("gId", goodsId);
            }
            sql += "GROUP BY MONTH(ordr.CrtTmst)";

            AnlsRsltVO vo = new AnlsRsltVO();
            List<object> xdata = new List<object>();
            List<decimal> ydata = new List<decimal>();

            DataTable dt = Connector.DbHelper.GetData(sql, values);
            if (null != dt)
            {
                Dictionary<int, decimal> map = new Dictionary<int, decimal>();
                int maxMth = year == DateTime.Now.Year ? DateTime.Now.Month : 12;
                foreach (DataRow row in dt.Rows)
                {
                    map.Add(StringUtil.Obj2Int(row["mth"]), StringUtil.Obj2Decimal(row["amnt"]));
                }

                for (int i = 1; i <= maxMth; i++)
                {
                    if (map.ContainsKey(i))
                        ydata.Add(map[i]);
                    else
                        ydata.Add(new decimal(0));
                    xdata.Add(i);
                }
            }
            vo.Xdata = xdata;
            vo.Ydata = ydata;
            return vo;
        }


        public AnlsRsltVO ProfitStatsByUsr(DateTime beginDt, DateTime endDt)
        {
            string sql = "SELECT u.UName as uname,"
                        + "SUM((sout.Num - sout.RfNum) * (sout.Price - stin.Price)) as amnt "
                        + "FROM STOCKOUT sout,"
                        + "ORDERS ordr,"
                        + "INVENTORY inv,"
                        + "STOCKIN stin,"
                        + "Usr u "
                        + "WHERE sout.OrderNO = ordr.OrderNO "
                        + "AND sout.InvID = inv.InvID "
                        + "AND inv.OrderNO = stin.OrderNO "
                        + "AND ordr.CrtUID = u.UID "
                        + "AND ordr.Direct =@direct ";
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("direct", DIRECT.STOCK_OUT);

            if (null != beginDt && null != endDt)
            {
                sql += "AND ordr.CrtTmst>=@StDt AND ordr.CrtTmst<@EndDt ";
                endDt = ((DateTime)endDt).AddDays(1);
                values.Add("StDt", beginDt);
                values.Add("EndDt", endDt);
            }
            sql += "GROUP BY u.UID,u.UName ORDER BY u.UName";

            AnlsRsltVO vo = new AnlsRsltVO();
            List<object> xdata = new List<object>();
            List<decimal> ydata = new List<decimal>();

            DataTable dt = Connector.DbHelper.GetData(sql, values);
            if (null != dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    xdata.Add(row["uname"]);
                    ydata.Add(StringUtil.Obj2Decimal(row["amnt"]));
                }            
            }
            vo.Xdata = xdata;
            vo.Ydata = ydata;
            return vo;
        }
    }
}
