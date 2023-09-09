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
    public partial class frm_SERVICE_ADD : DevExpress.XtraEditors.XtraForm
    {
        public frm_SERVICE_ADD()
        {
            InitializeComponent();
        }
        CLASES.cls_SER Ncls_SER = new CLASES.cls_SER();
        public void CLEAR_DATA()
        {
            DataTable DT = new DataTable();
            DT = Ncls_SER.SER_LIST();
            gridControl1.DataSource = DT;
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["SER_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["SER_NOTE"]);
            gridView1.Columns["SER_CODE"].Caption = "رقم الاجراء";
            gridView1.Columns["SERNAME"].Caption = "اسم الاجراء";
            gridView1.Columns["SER_TYPE"].Caption = "نوع الاجراء";
            gridView1.Columns["SER_PRICE"].Caption = "سعر الاجراء";
            TXT_CODE.Text = CLASES.cls_SER.SER_TABLE.MAX_CODE_BY_SERVICE().Rows[0]["SER_CODE"].ToString();
            TXT_NAME.Text = "";
            TXT_type.Text = "";
            TXT_price.Text = "0";
            TXT_note.Text = "";
        }
        private void frm_SERVICE_ADD_Load(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }

        private void BTN_CEALE_Click(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (TXT_NAME.Text != "" && TXT_CODE.Text != "")
            {
                CLASES.cls_SER.SER_TABLE.Insert_SER(Convert.ToInt64(TXT_CODE.Text), TXT_NAME.Text, TXT_type.Text, TXT_price.Text,TXT_note.Text, 7);

            }
            else
            {
                MessageBox.Show("خطأ في اضافة اسم الاجراء");
            }
            CLEAR_DATA();
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && TXT_NAME.Text != "" && TXT_CODE.Text != "")
            {
                CLASES.cls_SER.SER_TABLE.Update77(Convert.ToInt64(TXT_CODE.Text), TXT_NAME.Text, TXT_type.Text, TXT_price.Text, TXT_note.Text, 7, CLASES.cls_SER.SRE_ID,CLASES.cls_SER.SRE_ID);
             CLEAR_DATA();
            }
            else
            {
                MessageBox.Show("خطأ في تعديل اسم الاجراء");
            }
            
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && TXT_CODE.Text != "" && TXT_NAME.Text != "")
            {
                CLASES.cls_SER.SER_TABLE.Delete_SER(CLASES.cls_SER.SRE_ID);
                CLEAR_DATA();
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
                Ncls_SER.SLECECT_SER(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["SERNAME"]).ToString());
                TXT_CODE.Text = CLASES.cls_SER.SRE_CODE.ToString();
                TXT_NAME.Text = CLASES.cls_SER.SRE_NAME.ToString();
                TXT_type.Text = CLASES.cls_SER.SRE_TYPE.ToString();
                TXT_price.Text = CLASES.cls_SER.SRE_PRICE.ToString();
                TXT_note.Text = CLASES.cls_SER.SRE_NOTE.ToString();

            }
        }
    }
}