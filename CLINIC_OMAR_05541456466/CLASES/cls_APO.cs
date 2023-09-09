using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;
using System.Data;
namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_APO
    {
        public static long APO_ID;
        public static long APO_CODE;
        public static string APO_DATE;
        public static string APO_TIME;
        public static string APO_NAME;
        public static string APO_NOTE;
        public static long CLI_ID;
        public static long CUST_ID;
        public static long DOC_ID;

        public static APO_TBLTableAdapter APO_TABLE = new APO_TBLTableAdapter();

        public DataTable APO_LIST()
        {
            DataTable dt = new DataTable();
            dt = APO_TABLE.GetData();
            return dt;
        }


        public DataTable APO_LIS_BY_F_DATEAND_S_DOC_CUST(string F_DATE, string S_DATE, string S_DOC_NAME, string S_CUST_NAME)
        {
            DataTable dt = new DataTable();
            dt = APO_TABLE.APO_LIST_BY_BIRTH_OR_DOC_NAME_OR_CUST_NAME(F_DATE, S_DATE, S_DOC_NAME, S_CUST_NAME);
            return dt;
        }
   

        public DataTable APO_LIS_BY_DOC_CUST( string S_DOC_NAME, string S_CUST_NAME)
        {
            DataTable dt = new DataTable();
            dt = APO_TABLE.APO_LIST_BY_CUST_NAME_OR_DOC_NAME( S_DOC_NAME, S_CUST_NAME);
            return dt;
        }
        public DataTable SLECECT_APO(long S_APO_CODE)
        {
            DataTable dt = new DataTable();
            dt = APO_TABLE.APO_LIST_BY_CODE(S_APO_CODE);
            if (dt.Rows.Count >0)
            {
                APO_ID=Convert.ToInt64(dt.Rows[0]["APO_ID"]);
         APO_CODE= Convert.ToInt64(dt.Rows[0]["APO_CODE"]);
                APO_DATE=dt.Rows[0]["APO_DATE"].ToString(); 
                APO_TIME = dt.Rows[0]["APO_TIME"].ToString();
                APO_NAME = dt.Rows[0]["APO_NAME"].ToString(); ;
                APO_NOTE = dt.Rows[0]["APO_NOTE"].ToString(); ;
                CLI_ID=Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
                CUST_ID=Convert.ToInt64(dt.Rows[0]["CUST_ID"]);
             DOC_ID=Convert.ToInt64(dt.Rows[0]["DOC_ID"]);
    }
            return dt;
        }


    }
}
