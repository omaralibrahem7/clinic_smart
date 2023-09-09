using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;
using System.Data;
namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_DIG
    {
        public static long DIG_ID;
        public static long DIG_CODE;
        public static string DIG_NAME;
        public static string DIG_TYPE;
        public static string DIG_NOTE;
        public static long CLI_ID;


        public static DIG_TBLTableAdapter DIG_TABLE = new DIG_TBLTableAdapter();
        public DataTable DIG_LIST()
        {
            DataTable dt = new DataTable();
            dt = DIG_TABLE.GetData();
            return dt;
        }
        public DataTable SLECECT_DIG(string s_DIG_name)
        {
            DataTable dt = new DataTable();
            dt = DIG_TABLE.DIG_BY_NAME(s_DIG_name);
            return dt;
        }
    }
}
