using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;
using System.Data;
namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_SER
    {
        public static long SRE_ID;
        public static long SRE_CODE;
        public static string SRE_NAME;
        public static string SRE_TYPE;
        public static String SRE_PRICE;
        public static string SRE_NOTE;
        public static long CLI_ID;

        public static SER_TBLTableAdapter SER_TABLE = new SER_TBLTableAdapter();

        public DataTable SER_LIST()
        {
            DataTable dt = new DataTable();
            dt = SER_TABLE.GetData();
            return dt;
        }
        public DataTable SLECECT_SER(string s_clinic_name)
        {
            DataTable dt = new DataTable();
            dt = SER_TABLE.SEVICE_BY_SER_NAME(s_clinic_name);

            SRE_ID = Convert.ToInt64(dt.Rows[0]["SER_ID"]);
            SRE_CODE = Convert.ToInt64(dt.Rows[0]["SER_CODE"]);
            SRE_NAME = dt.Rows[0]["SERNAME"].ToString();
            SRE_TYPE = dt.Rows[0]["SER_TYPE"].ToString();
            SRE_PRICE = dt.Rows[0]["SER_PRICE"].ToString();
            SRE_NOTE = dt.Rows[0]["SER_NOTE"].ToString();
            CLI_ID = Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
            return dt;
               }

        }
    }
