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
    public partial class frm_ADD_COMPANY : DevExpress.XtraEditors.XtraForm
    {
        public frm_ADD_COMPANY()
        {
            InitializeComponent();
        }
        CLASES.cls_COMPANY Ncls_COMPANY = new CLASES.cls_COMPANY();

        public void CLEAR_DATA()
        {
            DataTable DT = new DataTable();
            DT = CLASES.cls_COMPANY.COMPANY_DATATABLE.GetData();
            gridControl1.DataSource = DT;
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["COM_ID"]);
            gridView1.Columns["COM_CODE"].Caption = "رقم الشركة";
            gridView1.Columns["COM_NAME"].Caption = "اسم الشركة";
            gridView1.Columns["COM_MOBAIL"].Caption = "رقم هاتف الشركة";
            gridView1.Columns["COM_STATE"].Caption = "حالة الشركة";
            TXT_CODE.Text = CLASES.cls_COMPANY.COMPANY_DATATABLE.MAX_COM_CODE().Rows[0]["COM_CODE"].ToString();
            TXT_NAME.Text = "";
            TXT_MOBA.Text = "";
            COM_state.Text = "فعالة";

        }
        private void frm_ADD_COMPANY_Load(object sender, EventArgs e)
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
                CLASES.cls_COMPANY.COMPANY_DATATABLE.Insert_COM(Convert.ToInt64(TXT_CODE.Text), TXT_NAME.Text, TXT_MOBA.Text, COM_state.Text, 7);

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
                CLASES.cls_COMPANY.COMPANY_DATATABLE.Update_COM(Convert.ToInt64(TXT_CODE.Text), TXT_NAME.Text, TXT_MOBA.Text, COM_state.Text, 7,CLASES.cls_COMPANY.COM_ID, CLASES.cls_COMPANY.COM_ID);
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
                CLASES.cls_COMPANY.COMPANY_DATATABLE.Delete_COM(CLASES.cls_COMPANY.COM_ID);
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
                Ncls_COMPANY.COM_SELECT(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["COM_NAME"]).ToString());
                TXT_CODE.Text = CLASES.cls_COMPANY.COM_CODE.ToString();
                TXT_NAME.Text = CLASES.cls_COMPANY.COM_NAME.ToString();
                TXT_MOBA.Text = CLASES.cls_COMPANY.COM_MOBAILE.ToString();
                COM_state.Text = CLASES.cls_COMPANY.COM_STAT.ToString();

            }
        }
    }
}