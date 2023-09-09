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
    public partial class frm_CLINIC_ADD : DevExpress.XtraEditors.XtraForm
    {
        public frm_CLINIC_ADD()
        {
            InitializeComponent();
        }
        CLASES.cls_CLINIC NCLS_CLIN = new CLASES.cls_CLINIC();
        public void CLIN_DATA()
        {

            gridControl1.DataSource = NCLS_CLIN.CLINIC_LIST();
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns["CLI_CODE"].Caption = "رقم العيادة";
            gridView1.Columns["CLI_NAME"].Caption = "اسم العيادة";
            gridView1.Columns["CLI_LOC"].Caption = "الموقع";
            gridView1.Columns["CLI_NOTE"].Caption = "ملاحظات";
            TXT_CODE.Text = CLASES.cls_CLINIC.CLI_TABLE.MAX_CLI_CODE().Rows[0]["CLI_CODE"].ToString();
            TXT_NAME.Text = "";
            TXT_LOC.Text = "";
            TXT_NOTE.Text = "";

        }
        private void frm_CLINIC_ADD_Load(object sender, EventArgs e)
        {
            CLIN_DATA();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (TXT_CODE.Text!="" && TXT_NAME.Text!="")
            {
                CLASES.cls_CLINIC.CLI_TABLE.Insert_CLINIC(Convert.ToInt64(TXT_CODE.Text), TXT_NAME.Text, TXT_LOC.Text,TXT_NOTE.Text);
                CLIN_DATA();
            }
            else
            {
                MessageBox.Show("يوجد خطأ في ادخال البيانات ");
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                NCLS_CLIN.SLECECT_CLI(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CLI_NAME"]).ToString());
                TXT_CODE.Text = CLASES.cls_CLINIC.CLI_CODE.ToString();
                TXT_NAME.Text = CLASES.cls_CLINIC.CLI_NAME.ToString();
                TXT_LOC.Text = CLASES.cls_CLINIC.CLI_LOC.ToString();
                TXT_NOTE.Text = CLASES.cls_CLINIC.CLI_NOTE.ToString();
            }
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && TXT_CODE.Text != "" && TXT_NAME.Text != "")
            {
                CLASES.cls_CLINIC.CLI_TABLE.UpdateCLINIC(Convert.ToInt64(TXT_CODE.Text), TXT_NAME.Text, TXT_LOC.Text, TXT_NOTE.Text,CLASES.cls_CLINIC.CLI_ID, CLASES.cls_CLINIC.CLI_ID);
                CLIN_DATA();
            }
            else
            {
                MessageBox.Show("يوجد خطأفي التعديل ");
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && TXT_CODE.Text != "" && TXT_NAME.Text != "")
            {
                CLASES.cls_CLINIC.CLI_TABLE.Delete_CLINIC(CLASES.cls_CLINIC.CLI_ID);
                CLIN_DATA();
            }
            else
            {
                MessageBox.Show("يوجد خطأفي الحذف");
            }
        }

        private void BTN_CEALE_Click(object sender, EventArgs e)
        {
            CLIN_DATA();
        }
    }
}