using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;
using System.Data;

namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_DOCTOR
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

        public static DOCTORS_TBLTableAdapter DOC_TABLE = new DOCTORS_TBLTableAdapter();
        //////////////////
        ///
        public DataTable DOC_LIST()
        {
            DataTable dt = new DataTable();
            dt = DOC_TABLE.GetData();
            return dt;
        }
        public DataTable SELECT_DOC(string S_DOC_NAME)
        {
            DataTable DDT = new DataTable();
            DDT = CLASES.cls_DOCTOR.DOC_TABLE.DOC_LIST_BY_DOC_NAME(S_DOC_NAME);
            if (DDT.Rows.Count > 0)
            {
                CLASES.cls_DOCTOR.DOC_ID = Convert.ToInt64(DDT.Rows[0][0]);
                CLASES.cls_DOCTOR.DOC_CODE = Convert.ToInt64(DDT.Rows[0][1]);
                CLASES.cls_DOCTOR.DOC_NAME = DDT.Rows[0][2].ToString();
                CLASES.cls_DOCTOR.DOC_MAJOR = DDT.Rows[0][3].ToString();
                CLASES.cls_DOCTOR.DOC_EXP = DDT.Rows[0][4].ToString();
                CLASES.cls_DOCTOR.DOC_BD = DDT.Rows[0][5].ToString();
                CLASES.cls_DOCTOR.DOC_MOBAILE = DDT.Rows[0][6].ToString();
                CLASES.cls_DOCTOR.DOC_ADDRESS = DDT.Rows[0][7].ToString();
                CLASES.cls_DOCTOR.CLI_ID = Convert.ToInt64(DDT.Rows[0][8]);
                CLASES.cls_DOCTOR.USER_ID = Convert.ToInt64(DDT.Rows[0][9]);
            }
            return DDT;

        }

        public DataTable SELECT_DOC(long USER_ID)
        {
            DataTable DDT = new DataTable();
            DDT = CLASES.cls_DOCTOR.DOC_TABLE.DOC_LIST_BY_ID(USER_ID);
            if (DDT.Rows.Count > 0)
            {
                CLASES.cls_DOCTOR.DOC_ID = Convert.ToInt64(DDT.Rows[0][0]);
                CLASES.cls_DOCTOR.DOC_CODE = Convert.ToInt64(DDT.Rows[0][1]);
                CLASES.cls_DOCTOR.DOC_NAME = DDT.Rows[0][2].ToString();
                CLASES.cls_DOCTOR.DOC_MAJOR = DDT.Rows[0][3].ToString();
                CLASES.cls_DOCTOR.DOC_EXP = DDT.Rows[0][4].ToString();
                CLASES.cls_DOCTOR.DOC_BD = DDT.Rows[0][5].ToString();
                CLASES.cls_DOCTOR.DOC_MOBAILE = DDT.Rows[0][6].ToString();
                CLASES.cls_DOCTOR.DOC_ADDRESS = DDT.Rows[0][7].ToString();
                CLASES.cls_DOCTOR.CLI_ID = Convert.ToInt64(DDT.Rows[0][8]);
                CLASES.cls_DOCTOR.USER_ID = Convert.ToInt64(DDT.Rows[0][9]);
            }

            return DDT;
        }

        


    }
}
