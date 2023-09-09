using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMART_OMAR_CLINIC.datssetTableAdapters;
using System.Data;

namespace SMART_CLINIC_2022.CLSESS
{
    internal class clsCLINIC
    {
        public static long CLI_ID;
        public static long CLI_CODE;
        public static string CLI_NAME;
        public static string CLI_LOC;
        public static string CLI_NOTE;
        public static CLINIC_TBLTableAdapter CLINIC_DataTaBLE = new CLINIC_TBLTableAdapter();

        public DataTable CLINICLIST()
        { 
        DataTable dataTable= new DataTable();
            dataTable = CLINIC_DataTaBLE.GetData();
        return dataTable;
        }
    public DataTable SELECTCLINIC(string S_CLINIC_NAME)
        { 
        DataTable DT= new DataTable( );
            DT = CLINIC_DataTaBLE.CILINCBYCLI_NAME(S_CLINIC_NAME);
            CLI_ID = Convert.ToInt64(DT.Rows[0][0]);
            CLI_CODE= Convert.ToInt64(DT.Rows[0][1]);
            CLI_NAME = DT.Rows[0][2].ToString();
            CLI_LOC= DT.Rows[0][3].ToString();
            CLI_NOTE= DT.Rows[0][4].ToString();
            return DT;
        }

    
    
    }
}
