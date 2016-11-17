using System;

namespace Model.VO
{
    public class PageVO
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        private int pageNo;

        /// <summary>
        /// 每页数目
        /// </summary>
        private int pageSize = 22;

        /// <summary>
        /// 条目总数
        /// </summary>
        private int totalNum;

        /// <summary>
        /// 总页数
        /// </summary>
        private int totalPage;

        public int PageNo
        {
            get
            {
                return pageNo;
            }

            set
            {
                pageNo = value;
            }
        }

        public int PageSize
        {
            get
            {
                return pageSize;
            }

            set
            {
                pageSize = value;
            }
        }

        public int TotalNum
        {
            get
            {
                return totalNum;
            }

            set
            {
                totalNum = value;
            }
        }

        public int TotalPage
        {
            get
            {
                totalPage = int.Parse(Math.Ceiling((double)totalNum/pageSize)+"");
                return totalPage;
            }
        }
    }
}
