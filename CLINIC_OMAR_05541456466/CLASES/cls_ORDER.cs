using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;


namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_ORDER
    {
        public static long ORDER_ID;
        public static long ORDER_CODE;
        public static string ORDER_DATE;
        public static string ORDER_TIME;
        public static string ORDER_NOTE;
        public static long CLI_ID;
        public static long CUST_ID;

        public static ORDER_TBLTableAdapter ORDER_TABLE = new ORDER_TBLTableAdapter();

        public DataTable ORDER_LIST()
        {
            DataTable dt = new DataTable();
            dt = ORDER_TABLE.ORDER_LIST();
            return dt;
        }



    }
}
