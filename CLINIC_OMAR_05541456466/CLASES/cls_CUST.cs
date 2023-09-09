using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;
using System.Data;
namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_CUST
    {
        public static long CUST_ID;
        public static long CUST_CODE;
        public static string CUST_F_NAME;
        public static string CUST_S_NAME;
        public static string CUST_L_NAME;
        public static string CUST_AGE;
        public static string CUST_BD;
        public static string CUST_MOBAIL;
        public static string CUST_ADDRESS;
        public static string CUST_SAVE_STATE;
        public static long CARD_ID;
        public static long CLI_ID;

        public static CUST_TBLTableAdapter CUST_TABLE = new CUST_TBLTableAdapter();
        public static CUST_TBL1TableAdapter CUST_DATA_LIST = new CUST_TBL1TableAdapter();

       
        public DataTable CUST_LIST()
        {
            DataTable dt = new DataTable();
            dt = CUST_TABLE.GetData();
            return dt;
        }



        public DataTable SLECECT_CUST(string S_CUST_CODE, string S_CUST_NAME)
        {
            DataTable dt = new DataTable();
            dt = CUST_TABLE.CUST_BY_CUST_NAME_OR_CUST_CODE(S_CUST_CODE, S_CUST_NAME);
            if (dt.Rows.Count ==1)
            {
                CUST_ID = Convert.ToInt64(dt.Rows[0]["CUST_ID"]);
                CUST_CODE = Convert.ToInt64(dt.Rows[0]["CUST_CODE"]);
                CUST_F_NAME = dt.Rows[0]["CUST_F_NMAE"].ToString();
                CUST_S_NAME = dt.Rows[0]["CUST_S_NAME"].ToString();
                CUST_L_NAME = dt.Rows[0]["CUST_L_NAME"].ToString();
                CUST_AGE = dt.Rows[0]["CUST_AGE"].ToString();
                CUST_BD = dt.Rows[0]["CUST_BD"].ToString();
                CUST_MOBAIL = dt.Rows[0]["CUST_MOBAIL"].ToString();
                CUST_ADDRESS = dt.Rows[0]["CUST_ADDRESS"].ToString();
                CUST_SAVE_STATE = dt.Rows[0]["CUST_SAVE_STATE"].ToString();
                CARD_ID = Convert.ToInt64(dt.Rows[0]["CARD_ID"]);
                CLI_ID = Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
            }
            return dt;
        }

    }
}
