using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;

namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_COMPANY
    {
        public static long COM_ID;
        public static long COM_CODE;
        public static string COM_NAME;
        public static string COM_MOBAILE;
        public static string COM_STAT;
        public static long CLI_ID;

        public static COMPANY_TBLTableAdapter COMPANY_DATATABLE = new COMPANY_TBLTableAdapter();
      

        public DataTable COM_LIST()
        {
            DataTable DT = new DataTable();
            DT = COMPANY_DATATABLE.GetData();
            return DT;
        }
        public DataTable COM_SELECT(string S_COM_NAME)
        {
            DataTable dt = new DataTable();
            dt = COMPANY_DATATABLE.COMPANY_LIST_BY_COM_NAME(S_COM_NAME);
            if (dt.Rows.Count>0)
            {
                COM_ID =Convert.ToInt64( dt.Rows[0]["COM_ID"]);
                COM_CODE = Convert.ToInt64(dt.Rows[0]["COM_CODE"]);
                COM_NAME = dt.Rows[0]["COM_NAME"].ToString();
                COM_MOBAILE = dt.Rows[0]["COM_MOBAIL"].ToString();
                COM_STAT = dt.Rows[0]["COM_STATE"].ToString();
                CLI_ID = Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
            }
            return dt;
        }
    }
}
