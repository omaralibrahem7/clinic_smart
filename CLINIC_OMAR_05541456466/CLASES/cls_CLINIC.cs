using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;
using System.Data;
namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_CLINIC
    {

        public static long CLI_ID;
        public static long CLI_CODE;
        public static string CLI_NAME;
        public static string CLI_LOC;
        public static string CLI_NOTE;


        public static CLINIC_TBLTableAdapter CLI_TABLE = new CLINIC_TBLTableAdapter();
        public DataTable CLINIC_LIST()
        {
            DataTable dt = new DataTable();
            dt = CLI_TABLE.GetData();
            return dt;
        }
        public DataTable SLECECT_CLI(string s_clinic_name)
        {
            DataTable dt = new DataTable();
            dt = CLI_TABLE.CLINIC_BY_CLI_NAME(s_clinic_name);
            CLI_ID= Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
            CLI_CODE=Convert.ToInt64(dt.Rows[0]["CLI_CODE"]); ;
            CLI_NAME= dt.Rows[0]["CLI_NAME"].ToString();
            CLI_LOC = dt.Rows[0]["CLI_LOC"].ToString();
            CLI_NOTE = dt.Rows[0]["CLI_NOTE"].ToString();


            return dt;
        }
    }
}
