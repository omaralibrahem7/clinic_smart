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

namespace CLINIC_OMAR_05541456466.frm_ADD
{
    public partial class frm_ADD_DOCTOR : DevExpress.XtraEditors.XtraForm
    {
        public frm_ADD_DOCTOR()
        {
            InitializeComponent();
        }
        CLASES.cls_DOCTOR nclsdoctor = new CLASES.cls_DOCTOR();
        CLASES.cls_USER Ncls_USER = new CLASES.cls_USER();

     


        public void CLEAR_DATA()
        {
            gridControl1.DataSource = nclsdoctor.DOC_LIST();
            if (gridView1.RowCount > 0)
            {
                gridView1.Columns.Remove(gridView1.Columns["DOC_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["USER_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
                gridView1.Columns["DOC_CODE"].Caption = "رقم الطبيب";
                gridView1.Columns["DOC_NAME"].Caption = "اسم الطبيب";
                gridView1.Columns["DOC_MAJOR"].Caption = "تخصص الطبيب";
                gridView1.Columns["DOC_EXP"].Caption = "خبرة الطبيب";
                gridView1.Columns["DOC_DB"].Caption = "مواليد الطبيب";
                gridView1.Columns["DOC_MOBAIL"].Caption = "رقم هاتف الطبيب";
                gridView1.Columns["DOC_ADDRESS"].Caption = "عنوان الطبيب";
            }

                COM_USER_ID.DataSource = Ncls_USER.USERLIST();
                COM_USER_ID.ValueMember = "USER_ID";
                COM_USER_NAME.DataSource = COM_USER_ID.DataSource;
                COM_USER_NAME.ValueMember = "USER_NAME";
            TXT_CODE.Text = CLASES.cls_DOCTOR.DOC_TABLE.MAX_DOC_CODE().Rows[0][1].ToString();

          
            TXT_NAME.Text = "";
            TXT_MAJ.Text = "";
            TXT_EXP.Text = "";
            TXT_MOBAILE.Text = "";
            TXT_ADDRESS.Text = "";

               
        }
        private void frm_ADD_DOCTOR_Load(object sender, EventArgs e)
        {
            CLEAR_DATA();

        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (TXT_ADDRESS.Text!="" && TXT_CODE.Text!="")
            {
               
                CLASES.cls_DOCTOR.DOC_TABLE.Insert_DOCTOR(Convert.ToInt64( TXT_CODE.Text), TXT_NAME.Text, TXT_MAJ.Text, TXT_EXP.Text,Convert.ToDateTime(txt_date.Value.ToString()), TXT_MOBAILE.Text, TXT_ADDRESS.Text, 7, Convert.ToInt64( COM_USER_ID.Text));
                CLEAR_DATA();
            }
            else
            {
                MessageBox.Show("الرجاء ادخال البيانات بشكل صحيح", "تحذير");
            }
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            if (TXT_ADDRESS.Text != "" && TXT_CODE.Text != "")
            {

                CLASES.cls_DOCTOR.DOC_TABLE.Update_DOCTOR(Convert.ToInt64(TXT_CODE.Text), TXT_NAME.Text, TXT_MAJ.Text, TXT_EXP.Text, Convert.ToDateTime(txt_date.Value.ToString()), TXT_MOBAILE.Text, TXT_ADDRESS.Text, 7, Convert.ToInt64(COM_USER_ID.Text),CLASES.cls_DOCTOR.DOC_ID, CLASES.cls_DOCTOR.DOC_ID);
                CLEAR_DATA();
            }
            else
            {
                MessageBox.Show("الرجاء ادخال البيانات بشكل صحيح", "تحذير");
            }

        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (TXT_ADDRESS.Text != "" && TXT_CODE.Text != "")
            {

                CLASES.cls_DOCTOR.DOC_TABLE.Delete_DOC(CLASES.cls_DOCTOR.DOC_ID);
                CLEAR_DATA();
            }
            else
            {
                MessageBox.Show("الرجاء ادخال البيانات بشكل صحيح", "تحذير");
            }
        }

        private void BTN_CEALE_Click(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }

        private void labelControl8_Click(object sender, EventArgs e)
        {
            LIST_FROM.frm_LIST_USER LSF = new LIST_FROM.frm_LIST_USER();
            LSF.ShowDialog();
            COM_USER_ID.Text = CLASES.cls_USER.USER_ID.ToString();
            COM_USER_NAME.Text = CLASES.cls_USER.USER_NAME;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
              nclsdoctor. SELECT_DOC(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gridView1.Columns["DOC_NAME"]).ToString());
                TXT_CODE.Text = CLASES.cls_DOCTOR.DOC_CODE.ToString();
                TXT_NAME.Text = CLASES.cls_DOCTOR.DOC_NAME;
                TXT_MAJ.Text = CLASES.cls_DOCTOR.DOC_MAJOR;
                TXT_EXP.Text = CLASES.cls_DOCTOR.DOC_EXP;
                txt_date.Value = Convert.ToDateTime(String.Format(CLASES.cls_DOCTOR.DOC_BD, "DD/MM/YYYY"));
                TXT_MOBAILE.Text = CLASES.cls_DOCTOR.DOC_MOBAILE;
                TXT_ADDRESS.Text = CLASES.cls_DOCTOR.DOC_ADDRESS;
                COM_USER_ID.Text = CLASES.cls_DOCTOR.USER_ID.ToString();
            }
        }

        private void LBL_USER_DoubleClick(object sender, EventArgs e)
        {
            LIST_FROM.frm_LIST_USER LSF = new LIST_FROM.frm_LIST_USER();
            LSF.ShowDialog();
            COM_USER_ID.Text = CLASES.cls_USER.USER_ID.ToString();
            COM_USER_NAME.Text = CLASES.cls_USER.USER_NAME;
        }

        private void LBL_USER_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LIST_FROM.frm_LIST_USER LSF = new LIST_FROM.frm_LIST_USER();
            LSF.ShowDialog();
            COM_USER_ID.Text = CLASES.cls_USER.USER_ID.ToString();
            COM_USER_NAME.Text = CLASES.cls_USER.USER_NAME;
        }
    }
}