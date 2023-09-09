using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMART_OMAR_CLINIC.datssetTableAdapters;
using System.Data;

namespace SMART_CLINIC_2022.CLSESS
{
    internal class clsDOCTORS
    {
        public static long DOC_ID;
        public static long DOC_CODE;
        public static string DOC_NAME;
        public static string DOC_MAJOR;
        public static string DOC_EXP;
        public static string DOC_BD;
        public static string DOC_MOBAILE;
        public static string DOC_ADDRESS;
        public static long CLI_ID;
        public static long USER_ID;
        public static DOCTORS_TBLTableAdapter DOCD_DT = new DOCTORS_TBLTableAdapter();


        public DataTable DOC_LIST() 
        {
        DataTable dt = new DataTable();
            dt=DOCD_DT.GetData();
            return dt;
        }

        public DataTable SELECT_DOC(string S_DOC_NAME)
        {
                DataTable dt= new DataTable();
            dt=clsDOCTORS.DOCD_DT.DOC_LIST_BY_DOC_NAME(S_DOC_NAME);
            
            clsDOCTORS.DOC_ID = Convert.ToInt64(dt.Rows[0][0]); ;
            clsDOCTORS.DOC_CODE = Convert.ToInt64(dt.Rows[0][1]);
            clsDOCTORS.DOC_NAME = dt.Rows[0][2].ToString();
            clsDOCTORS.DOC_MAJOR = dt.Rows[0][3].ToString(); ;
            clsDOCTORS.DOC_EXP = dt.Rows[0][4].ToString(); ;
            clsDOCTORS.DOC_BD = dt.Rows[0][5].ToString(); ;
            clsDOCTORS.DOC_MOBAILE = dt.Rows[0][6].ToString(); ;
            clsDOCTORS.DOC_ADDRESS = dt.Rows[0][7].ToString(); ;
            clsDOCTORS.CLI_ID = Convert.ToInt64(dt.Rows[0][8]); ;
            clsDOCTORS.USER_ID = Convert.ToInt64(dt.Rows[0][9]); ;


            return dt;
        }


        public DataTable DOC_LIST_BY_USER_ID(long USER_ID)
        {
           
            DataTable dt = new DataTable();
            dt = clsDOCTORS.DOCD_DT.DOCLISTBYUSERID(USER_ID);

            if (dt.Rows.Count > 0)
            {
                clsDOCTORS.DOC_ID = Convert.ToInt64(dt.Rows[0][0]); ;
                clsDOCTORS.DOC_CODE = Convert.ToInt64(dt.Rows[0][1]);
                clsDOCTORS.DOC_NAME = dt.Rows[0][2].ToString();
                clsDOCTORS.DOC_MAJOR = dt.Rows[0][3].ToString(); ;
                clsDOCTORS.DOC_EXP = dt.Rows[0][4].ToString(); ;
                clsDOCTORS.DOC_BD = dt.Rows[0][5].ToString(); ;
                clsDOCTORS.DOC_MOBAILE = dt.Rows[0][6].ToString(); ;
                clsDOCTORS.DOC_ADDRESS = dt.Rows[0][7].ToString(); ;
                clsDOCTORS.CLI_ID = Convert.ToInt64(dt.Rows[0][8]); ;
                clsDOCTORS.USER_ID = Convert.ToInt64(dt.Rows[0][9]); ;
            }


            return dt;
        }

    }
}
   