using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINIC_OMAR_05541456466.LIST_FROM
{
    public partial class frm_APO_LIST : DevExpress.XtraEditors.XtraForm
    {
        public frm_APO_LIST()
        {
            InitializeComponent();
        }

        CLASES.cls_APO NCLS_APO = new CLASES.cls_APO();
        CLASES.cls_CUST NCLS_CUST = new CLASES.cls_CUST();
        CLASES.cls_DOCTOR NCLS_DOC = new CLASES.cls_DOCTOR();

        public void CLEAR_DATA() //دالة الاستدعاء
        {
            //استدعاء البيانات
            gridControl1.DataSource = NCLS_APO.APO_LIS_BY_F_DATEAND_S_DOC_CUST(TXT_TO_DATE.Text, txt_OF_date.Text,TXT_DOC_NAME.Text,TXT_CUST_NAME.Text);
            
            //حذف الاعمدة 
            gridView1.Columns.Remove(gridView1.Columns["APO_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DOC_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
           // gridView1.Columns.Remove(gridView1.Columns["APO_NOTE"]);
          
            //تسمية الاعمدة
            gridView1.Columns["APO_CODE"].Caption = " رقم الموعد";
            gridView1.Columns["APO_DATE"].Caption = "تاريخ الموعد";
            gridView1.Columns["APO_TIME"].Caption = "وقت الموعد";
            gridView1.Columns["APO_NAME"].Caption = "اسم الموعد";
            gridView1.Columns["APO_NAME"].Caption = "الملاحظات";
            gridView1.Columns["CUST_FULL_NAME"].Caption = "المريض";
            gridView1.Columns["DOC_NAME"].Caption = "الطبيب";

        
        }

         private void frm_APO_LIST_Load(object sender, EventArgs e)//دالة التشغيل
        {
            CLEAR_DATA(); //دالة الاستدعاء
                          //بيانات الدكتور
            TXT_DOC_ID.Enabled = false;
            TXT_DOC_ID.DataSource = NCLS_DOC.DOC_LIST();
            TXT_DOC_ID.ValueMember = "DOC_CODE";
            TXT_DOC_NAME.DataSource = TXT_DOC_ID.DataSource;
            TXT_DOC_NAME.ValueMember = "DOC_NAME";

            //بيانات المريض
            TXT_CUST_ID.Enabled = false;
            TXT_CUST_ID.DataSource = CLASES.cls_CUST.CUST_DATA_LIST.GetData("", "");
            TXT_CUST_ID.ValueMember = "CUST_CODE";
            TXT_CUST_NAME.DataSource = TXT_CUST_ID.DataSource;
            TXT_CUST_NAME.ValueMember = "CUST_FULL_NAME";
            gridView1.BestFitColumns();

            ///تفريغ البيانات عند التشغيل 
            TXT_CUST_ID.Text = "";
            TXT_CUST_NAME.Text = "";
            TXT_DOC_ID.Text = "";
            TXT_DOC_NAME.Text = "";
            TXT_TO_DATE.Value = DateTime.Now;
            txt_OF_date.Value = DateTime.Now;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXT_TO_DATE_ValueChanged(object sender, EventArgs e)//البحث عن تاريخ
        {
            CLEAR_DATA(); //دالة الاستدعاء

        }

        private void txt_OF_date_ValueChanged(object sender, EventArgs e)//البحث عن التاريخ
        {
            CLEAR_DATA(); //دالة الاستدعاء
        }

        private void TXT_CUST_NAME_TextChanged(object sender, EventArgs e)//تنفيذ البحث عن مريض
        {
            CLEAR_DATA(); //دالة الاستدعاء
           
        }

        private void TXT_DOC_NAME_TextChanged(object sender, EventArgs e)//تنفيد البحث عن طبيب
        {
            CLEAR_DATA();
          
        }

        private void BTN_CUST_LIST_Click(object sender, EventArgs e)//استدعاء المرضى
        {
            LIST_FROM.frm_CUST_LIST FRMCU = new LIST_FROM.frm_CUST_LIST();
            FRMCU.ShowDialog();
            TXT_CUST_ID.Text = CLASES.cls_CUST.CUST_CODE.ToString();
        }

        private void BTN_DOC_LIST_Click(object sender, EventArgs e)//استدعاء الاطباء
        {

            LIST_FROM.frm_LIST_DOC FRMDO = new LIST_FROM.frm_LIST_DOC();
            FRMDO.ShowDialog();
            TXT_DOC_ID.Text = CLASES.cls_DOCTOR.DOC_CODE.ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)//المسح
        {
            TXT_CUST_ID.Text = "";
            TXT_CUST_NAME.Text = "";
            TXT_DOC_ID.Text = "";
            TXT_DOC_NAME.Text = "";
            TXT_TO_DATE.Value = DateTime.Now;
            txt_OF_date.Value = DateTime.Now;

        }

        private void simpleButton2_Click(object sender, EventArgs e)//البحث
        {
            CLEAR_DATA();
        }

        private void simpleButton1_Click(object sender, EventArgs e)//الطباعة
        {

        }

    }
}