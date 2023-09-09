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
    public partial class frm_DIAGNOIS_ADD : DevExpress.XtraEditors.XtraForm
    {
        public frm_DIAGNOIS_ADD()
        {
            InitializeComponent();
        }
        CLASES.cls_DIG NCLS_DIG = new CLASES.cls_DIG();

        public void CLIN_DATA()
        {
            gridControl1.DataSource = NCLS_DIG.DIG_LIST();
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DIG_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DIG_NOTE"]);
            gridView1.Columns["DIG_CODE"].Caption = "رقم التشخيص";
            gridView1.Columns["DIG_NAME"].Caption = "اسم التشخيص";
            gridView1.Columns["DID_TYPE"].Caption = "نوع التشخيص";
           
            TXT_CODE.Text = CLASES.cls_DIG.DIG_TABLE.MAX_DIG_CODE().Rows[0]["DIG_CODE"].ToString();
            TXT_NAME.Text = "";
            TXT_TYPE.Text = "";
            TXT_NOTE.Text = "";

        }
        private void frm_DIAGNOIS_ADD_Load(object sender, EventArgs e)
        {
            CLIN_DATA();
        }

        private void BTN_CEALE_Click(object sender, EventArgs e)
        {
            CLIN_DATA();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (TXT_CODE.Text != "" && TXT_NAME.Text != "")
            {
                CLASES.cls_DIG.DIG_TABLE.Insert_DIG(Convert.ToInt64(TXT_CODE.Text), TXT_NAME.Text, TXT_TYPE.Text, TXT_NOTE.Text,7);
                CLIN_DATA();
            }
            else
            {
                MessageBox.Show(" يوجد خطأ في ادخال بيانات التشخيص");
            }
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && TXT_NAME.Text != "" && TXT_CODE.Text != "")
            {
                CLASES.cls_DIG.DIG_TABLE.Update_DIG(Convert.ToInt64(TXT_CODE.Text), TXT_NAME.Text, TXT_TYPE.Text,  TXT_NOTE.Text, 7, CLASES.cls_DIG.DIG_ID, CLASES.cls_DIG.DIG_ID);
                CLIN_DATA();
            }
            else
            {
                MessageBox.Show("خطأ في تعديل اسم التشخيص");
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && TXT_CODE.Text != "" && TXT_NAME.Text != "")
            {
                CLASES.cls_DIG.DIG_TABLE.Delete_DIG(CLASES.cls_DIG.DIG_ID);
                CLIN_DATA();
            }
            else
            {
                MessageBox.Show("يوجد خطأفي الحذف");
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                NCLS_DIG.SLECECT_DIG(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DIG_NAME"]).ToString());
                TXT_CODE.Text = CLASES.cls_DIG.DIG_CODE.ToString();
                TXT_NAME.Text = CLASES.cls_DIG.DIG_NAME.ToString();
                TXT_TYPE.Text = CLASES.cls_DIG.DIG_TYPE.ToString();
                TXT_NOTE.Text = CLASES.cls_DIG.DIG_NOTE.ToString();

            }
        }
    }
}