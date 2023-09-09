using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMART_OMAR_CLINIC.datssetTableAdapters;
using System.Data;



namespace SMART_CLINIC_2022.CLSESS
{
    internal class clsCOMPANY
    {
        public static long COM_ID;
        public static long COM_CODE;
        public static string COM_NAME;
        public static string COM_MOBAILE;
        public static string COM_STAT;
        public static long CLI_ID;


        public static COMPANY_TBLTableAdapter COMPANY_DATATABLE= new COMPANY_TBLTableAdapter();

        public System.Data.DataTable COM_ICLIST()
        {
             DataTable dataTable = new DataTable();
            dataTable = COMPANY_DATATABLE.GetData();
            return dataTable;
        }
        public DataTable SELECTCLINIC(string S_CLINIC_NAME)
        {
            DataTable DT = new DataTable();
            DT = COMPANY_DATATABLE.COMPANYBYCOM_NAME(S_CLINIC_NAME);
            COM_ID = Convert.ToInt64(DT.Rows[0][0]);
            COM_CODE = Convert.ToInt64(DT.Rows[0][1]);
            COM_NAME = DT.Rows[0][2].ToString();
            COM_MOBAILE = DT.Rows[0][3].ToString();
            COM_STAT = DT.Rows[0][4].ToString();
            return DT;
        }

    }
}
