using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;
using System.Data;

namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_DIGLIST
    {
        public static long DIGLIST_ID;
        public static long DIGLIST_CODE;
        public static string DIGLIST_NAME;
        public static string DIGLIST_DATE;
        public static string DIGLIST_TIME;
        public static long DIG_ID;
        public static long CUST_ID;
        public static long VIS_ID;
        public static long CLI_ID;


        public static DIGLIST_TBLTableAdapter DIGLIST_TABLE = new DIGLIST_TBLTableAdapter();

        public DataTable DIGLIS_LIST()
        {
            DataTable dt = new DataTable();
            dt = DIGLIST_TABLE.GetData();
            return dt;
        }

        public DataTable SLECECT_DIGLIST(long S_DIGLIST_CODE)
        {
            DataTable dt = new DataTable();
            dt = DIGLIST_TABLE.DIGLIST_BY_DIGLIST_CODE(S_DIGLIST_CODE);
            if (dt.Rows.Count ==1)
            {
                DIGLIST_ID = Convert.ToInt64(dt.Rows[0]["DIGLIST_ID"]);
                DIGLIST_CODE = Convert.ToInt64(dt.Rows[0]["DIGLIST_CODE"]);
                DIGLIST_NAME = dt.Rows[0]["DIGLIST_NAME"].ToString(); ;
                DIGLIST_DATE = dt.Rows[0]["DIGLIST_DATE"].ToString(); ;
                DIGLIST_TIME = dt.Rows[0]["DIGLIST_TIME"].ToString(); ;
                DIG_ID = Convert.ToInt64(dt.Rows[0]["DIG_ID"]);
                CUST_ID = Convert.ToInt64(dt.Rows[0]["CUST_ID"]);
                VIS_ID = Convert.ToInt64(dt.Rows[0]["VIS_ID"]);
                CLI_ID = Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
            }
            return dt;
        }

    }
}
