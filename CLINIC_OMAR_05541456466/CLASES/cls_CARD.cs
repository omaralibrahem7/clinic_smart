using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;
using System.Data;
namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_CARD
    {
        public static long CARD_ID;
        public static string CARD_CODE;
        public static string CARD_NAME;
        public static string CARD_DATE;
        public static string CARD_STATE;
        public static int CARD_PER;
        public static string CARD_NOTE;
        public static long COM_ID;
        public static long CLI_ID;


        public static CARD_TB_LTableAdapter CARD_TABLE = new CARD_TB_LTableAdapter();
        public DataTable CARD_LIST()
        {
            DataTable dt = new DataTable();
            dt = CARD_TABLE.GetData();
            return dt;
        }
        public DataTable SLECECT_CARD(string s_CARD_name)
        {
            DataTable dt = new DataTable();
            dt = CARD_TABLE.CAED_BY_NAME(s_CARD_name);
            if (dt.Rows.Count > 0)
            {
            CARD_ID = Convert.ToInt64(dt.Rows[0]["CARD_ID"]);
            CARD_CODE = dt.Rows[0]["CARD_CODE"].ToString();
            CARD_NAME = dt.Rows[0]["CARD_NAME"].ToString();
            CARD_DATE = dt.Rows[0]["CARD_DATE"].ToString();
            CARD_STATE = dt.Rows[0]["CARD_STATE"].ToString();
            CARD_PER = Convert.ToInt32(dt.Rows[0]["CARD_PER"]);
            CARD_NOTE = dt.Rows[0]["CARD_NOTE"].ToString();
            COM_ID = Convert.ToInt64(dt.Rows[0]["COM_ID"]);
            CLI_ID = Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
        }
            return dt;
        }
    }
}
