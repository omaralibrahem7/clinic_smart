using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;
namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_MEDCIN
    {
        public static long MED_ID;
        public static long MED_CODE;
        public static string MED_NAME;
        public static string MED_S_NAME;
        public static string MED_SOURS;
        public static decimal MED_PRICE;
        public static long CLI_ID;


        public static MEDCEN_TBL1TableAdapter MEDCIN_DATATABLE = new MEDCEN_TBL1TableAdapter();


        public DataTable MED_LIST()
        {
            DataTable DT = new DataTable();
            DT = MEDCIN_DATATABLE.GetData();
            return DT;
        }
        public DataTable MED_SELECT(string S_MED_NAME)
        {
            DataTable dt = new DataTable();
            dt = MEDCIN_DATATABLE.MEDCEN_BY_NAME(S_MED_NAME);
            if (dt.Rows.Count > 0)
            {
                MED_ID = Convert.ToInt64(dt.Rows[0]["MED_ID"]);
                MED_CODE = Convert.ToInt64(dt.Rows[0]["MED_CODE"]);
                MED_NAME = dt.Rows[0]["MED_NAME"].ToString();
                MED_S_NAME = dt.Rows[0]["MED_S_NAME"].ToString();
                MED_SOURS = dt.Rows[0]["MED_SOURSE"].ToString();
                MED_PRICE = Convert.ToInt64(dt.Rows[0]["MED_PRICE"]);
                CLI_ID = Convert.ToInt64(dt.Rows[0]["CLI_ID"]);
            }
            return dt;
        }
    }
}
