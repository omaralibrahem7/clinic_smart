using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;
using System.Data;


namespace CLINIC_OMAR_05541456466.CLASES
{
    class cls_USER
    {
        public static long USER_ID;
        public static long USER_CODE;
        public static string USER_NAME;
        public static string USER_password;
        public static string USER_type;
        public static long CLI_ID;

        ///////////////////////////////////////////////////
        ///وظيفته الاتصال بقاعدة البيانات الخاصة بالداتا سيت 
        public static USER_TBLTableAdapter USER_TABLE= new USER_TBLTableAdapter();
        //////////////////////////////////////////
        /// دالة لربط قاعدة البيانات بغرضية التوجه 
        /// 
        public DataTable SELECT_USER(string S_USER_NAME)
        {
            DataTable DT = new DataTable();
            DT = USER_TABLE.USER_LIST_BY_NAME(S_USER_NAME);
            CLASES.cls_USER.USER_ID = Convert.ToInt64(DT.Rows[0][0].ToString());
            CLASES.cls_USER.USER_CODE = Convert.ToInt64(DT.Rows[0][1].ToString());
            CLASES.cls_USER.USER_NAME = DT.Rows[0][2].ToString();
            CLASES.cls_USER.USER_password = DT.Rows[0][3].ToString();
            CLASES.cls_USER.USER_type = DT.Rows[0][4].ToString();
            CLASES.cls_USER.CLI_ID = Convert.ToInt64(DT.Rows[0][5].ToString());
            return DT;


        }


        public DataTable USERLIST()
        {
            DataTable DT = new DataTable();
            DT = CLASES.cls_USER.USER_TABLE.GetData();
            return DT;
        }

        CLASES.cls_DOCTOR NCLS_DOC = new CLASES.cls_DOCTOR();
        public DataTable LOGIN(string LOG_USER_NAME, string LOG_USER_PASSWORD, string LOG_USER_TYPE)
        {
            DataTable DT = new DataTable();
            DT = CLASES.cls_USER.USER_TABLE.USER_LOGIN_DATA(LOG_USER_NAME, LOG_USER_PASSWORD, LOG_USER_TYPE);
            if (DT.Rows.Count>0)
            {
                CLASES.cls_USER.USER_ID = Convert.ToInt64(DT.Rows[0][0].ToString());
                CLASES.cls_USER.USER_CODE = Convert.ToInt64(DT.Rows[0][1].ToString());
                CLASES.cls_USER.USER_NAME = DT.Rows[0][2].ToString();
                CLASES.cls_USER.USER_password = DT.Rows[0][3].ToString();
                CLASES.cls_USER.USER_type = DT.Rows[0][4].ToString();
                CLASES.cls_USER.CLI_ID = Convert.ToInt64(DT.Rows[0][5].ToString());
                if (CLASES.cls_USER.USER_type == "DOCTOR")
                {
                NCLS_DOC.SELECT_DOC(CLASES.cls_USER.USER_ID);
                }
            }
         
            return DT;
        }

    }
}
