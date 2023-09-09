using DevExpress.XtraEditors.Popup;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMART_OMAR_CLINIC.datssetTableAdapters;
using System.Data;
using System;
using SMART_OMAR_CLINIC;

namespace SMART_CLINIC_2022.CLSESS
{
    internal class cls_users
    {
        public static long USER_ID;
        public static long USER_CODE;
        public static string USER_NAME;
        public static string USER_password;
        public static string USER_type;
        public static long CLI_ID;
          public static USER_TBLTableAdapter USER_DT = new USER_TBLTableAdapter();


        clsDOCTORS Nclsdoc = new clsDOCTORS();

        public DataTable USER_LIST() 
        { 
            DataTable dt = new DataTable();
            dt = cls_users.USER_DT.GetData();
            return dt;
        }

        public DataTable USER_LOGIN(string LOG_USER_NAME, string LOG_USER_PASSWORD, string LOG_USER_TYPE)
        {

            DataTable dataTable = new DataTable();
            dataTable = cls_users.USER_DT.USER_LOGIN_DATA(LOG_USER_NAME,LOG_USER_PASSWORD, LOG_USER_TYPE);

            if (dataTable.Rows.Count > 0)
            {
                cls_users.USER_ID = Convert.ToUInt32(dataTable.Rows[0][0].ToString());
                cls_users.USER_CODE = Convert.ToInt64(dataTable.Rows[0][1].ToString());
                cls_users.USER_NAME = dataTable.Rows[0][2].ToString();
                cls_users.USER_password = dataTable.Rows[0][3].ToString();
                cls_users.USER_type = dataTable.Rows[0][4].ToString();
                cls_users.CLI_ID = Convert.ToInt64(dataTable.Rows[0][5].ToString());

                if (cls_users.USER_type == "DOCTOR")
                {
                    Nclsdoc.DOC_LIST_BY_USER_ID(cls_users.USER_ID);
                }
            }

            return dataTable;
        }







    }
}
