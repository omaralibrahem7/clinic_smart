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
    public partial class frm_MEDCIN_ADD : DevExpress.XtraEditors.XtraForm
    {
        public frm_MEDCIN_ADD()
        {
            InitializeComponent();
        }
        CLASES.cls_MEDCIN Ncls_MEDCIN = new CLASES.cls_MEDCIN();

        public void CLEAR_DATA()
        {
            DataTable DT = new DataTable();
            DT = Ncls_MEDCIN.MED_LIST();
            gridControl1.DataSource = DT;
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["MED_ID"]);
            gridView1.Columns["MED_CODE"].Caption = "رقم الدواء";
            gridView1.Columns["MED_NAME"].Caption = "اسم الدواء";
            gridView1.Columns["MED_S_NAME"].Caption = "الاسم العلمي للدواء";
            gridView1.Columns["MED_SOURSE"].Caption = "مصدر الدواء";
            gridView1.Columns["MED_PRICE"].Caption = "سعر الدواء";
            TXT_CODE.Text = CLASES.cls_MEDCIN.MEDCIN_DATATABLE.MAX_CODE_BY_MED().Rows[0]["MED_CODE"].ToString();
            TXT_NAME.Text = "";
            TXT_S_NAME.Text = "";
            TXT_SOURS.Text = "";
            TXT_PRICE.Text = "0";
        }

        private void frm_MEDCIN_ADD_Load(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }

        private void BTN_CEALE_Click(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (TXT_NAME.Text != "" && TXT_CODE.Text != ""&& TXT_S_NAME.Text != "")
            {
                CLASES.cls_MEDCIN.MEDCIN_DATATABLE.Insert_MED(Convert.ToInt64(TXT_CODE.Text), TXT_NAME.Text, TXT_S_NAME.Text, TXT_SOURS.Text, Convert.ToInt64(TXT_PRICE.Text), 7);

            }
            else
            {
                MessageBox.Show("خطأ في اضافة اسم الشركة");
            }
            CLEAR_DATA();
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && TXT_CODE.Text != "" && TXT_NAME.Text != "")
            {
                CLASES.cls_MEDCIN.MEDCIN_DATATABLE.Update_MED(Convert.ToInt64(TXT_CODE.Text), TXT_NAME.Text, TXT_S_NAME.Text, TXT_SOURS.Text, Convert.ToInt64(TXT_PRICE.Text), 7, CLASES.cls_MEDCIN.MED_ID, CLASES.cls_MEDCIN.MED_ID);
                CLEAR_DATA();
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
                CLASES.cls_MEDCIN.MEDCIN_DATATABLE.Delete_MED(CLASES.cls_MEDCIN.MED_ID);
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
                Ncls_MEDCIN.MED_SELECT(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MED_NAME"]).ToString());
                TXT_CODE.Text = CLASES.cls_MEDCIN.MED_CODE.ToString();
                TXT_NAME.Text = CLASES.cls_MEDCIN.MED_NAME.ToString();
                TXT_S_NAME.Text = CLASES.cls_MEDCIN.MED_S_NAME.ToString();
                TXT_SOURS.Text = CLASES.cls_MEDCIN.MED_SOURS.ToString();
                TXT_PRICE.Text = CLASES.cls_MEDCIN.MED_PRICE.ToString();

            }
        }
    }
}