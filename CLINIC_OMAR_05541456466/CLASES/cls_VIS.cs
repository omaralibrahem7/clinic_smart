using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;
using System.Data;

namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_VIS
    {
        public static long VIS_ID;
        public static long VIS_CODE;
        public static string VIS_NAME;
        public static string VIS_DATE;
        public static string VIS_TIME;
        public static string VIS_TYPE;
        public static long CUST_ID;
        public static long CLI_ID;
        public static long APO_ID;
        public static long DOC_ID;
        public static long MEDLIST_ID;
        public static long SERLIST_ID;
        public static long VIS_PRCE; 
        public static long VIS_DIS_COUNT;
        public static long VIS_TOTAL;



        public static VIS_TBLTableAdapter VIS_TABLE = new VIS_TBLTableAdapter();

        public DataTable VIS_LIST()
        {
            DataTable dt = new DataTable();
            dt = VIS_TABLE.GetData();
            return dt;
        }

        public DataTable SLECECT_VIS(long S_CUST_ID, long S_CLI_ID)
        {
            DataTable dt = new DataTable();
            dt = VIS_TABLE.VIS_BY_CUST_ID_AND_CLI_ID( S_CUST_ID,  S_CLI_ID);
            if (dt.Rows.Count > 0)
            {


                VIS_ID = Convert.ToInt64(dt.Rows[0]["VIS_ID"]);
                VIS_CODE = Convert.ToInt64(dt.Rows[0]["VIS_CODE"]);
                VIS_NAME = dt.Rows[0]["VIS_NAME"].ToString(); ;
                VIS_DATE = dt.Rows[0]["VIS_DATE"].ToString(); ;
                VIS_TIME = dt.Rows[0]["VIS_TIME"].ToString(); ;
                VIS_TYPE = dt.Rows[0]["VIS_TYPE"].ToString(); ;
                CUST_ID = Convert.ToInt64(dt.Rows[0]["CUST_ID"]);
                CLI_ID = Convert.ToInt64(dt.Rows[0]["CLI_ID"]); ;
                APO_ID = Convert.ToInt64(dt.Rows[0]["APO_ID"]); ;
                DOC_ID = Convert.ToInt64(dt.Rows[0]["DOC_ID"]); ;
                MEDLIST_ID = Convert.ToInt64(dt.Rows[0]["MEDLIST_ID"]); ;
                SERLIST_ID = Convert.ToInt64(dt.Rows[0]["SERLIST_ID"]); ;
                VIS_PRCE = Convert.ToInt64(dt.Rows[0]["VIS_PRCE"]); ;
                VIS_DIS_COUNT = Convert.ToInt64(dt.Rows[0]["VIS_DIS_COUNT"]); ;
                VIS_TOTAL = Convert.ToInt64(dt.Rows[0]["VIS_TOTAL"]); ;
            }
            return dt;
        }
    }
}
