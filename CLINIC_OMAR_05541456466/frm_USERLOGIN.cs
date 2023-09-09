using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CLINIC_OMAR_05541456466.DataSet2TableAdapters;


namespace CLINIC_OMAR_05541456466
{
    public partial class frm_USERLOGIN : DevExpress.XtraEditors.XtraForm
    {
        public frm_USERLOGIN()
        {
            InitializeComponent();
        }

        CLASES.cls_USER NCLS_USER = new CLASES.cls_USER();
        CLASES.cls_DOCTOR NCLS_DOC = new CLASES.cls_DOCTOR();
        public static long LOG_UER_ID;
        public static String LOG_USER_NAME;
        public static String LOG_USER_PASSOWRD;
        public static String LOG_USER_TYPE;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CLASES.cls_USER.USER_TABLE.USER_LIST_BY_NAME(com_username.Text).Rows.Count>0)
            {
                LBL_TYPE.Text = CLASES.cls_USER.USER_TABLE.USER_LIST_BY_NAME(com_username.Text).Rows[0][4].ToString();
                NCLS_DOC.SELECT_DOC(CLASES.cls_USER.CLI_ID);
            }
           
        }
        private void frm_USERLOGIN_Load(object sender, EventArgs e)
        {
            com_username.DataSource = CLASES.cls_USER.USER_TABLE.GetData();
             com_username.ValueMember = "USER_NAME";
          
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
          

            NCLS_USER.LOGIN(com_username.Text, txt_PASSOWRD.Text, LBL_TYPE.Text);
            if (CLASES.cls_USER.CLI_ID==0)
            {
                MessageBox.Show("خطأ");
            }
            else
            {
                LOG_USER_NAME = com_username.Text;
                LOG_USER_PASSOWRD = txt_PASSOWRD.Text;
                LOG_USER_TYPE = LBL_TYPE.Text;
                frm_MAIN.frm_MAIN frm_main = new frm_MAIN.frm_MAIN();
                frm_main.Show();
               
            }
        }
    }
}
