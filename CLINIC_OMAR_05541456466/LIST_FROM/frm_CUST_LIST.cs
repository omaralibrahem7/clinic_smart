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
    public partial class frm_CUST_LIST : DevExpress.XtraEditors.XtraForm
    {
        public frm_CUST_LIST()
        {
            InitializeComponent();
        }
        CLASES.cls_CUST NCLS_CUST = new CLASES.cls_CUST();

        public void CLEAR_DATA() //دالة الاستدعاء
        {
            //استدعاء البيانات
            gridControl1.DataSource = CLASES.cls_CUST.CUST_DATA_LIST.GetData(TXT_USER_NAME.Text, TXT_USER_NAME.Text);
            //حذف الاعمدة 
            gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CARD_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_ADDRESS"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_SAVE_STATE"]);
            //تسمية الاعمدة
            gridView1.Columns["CUST_CODE"].Caption = "رقم المريض";
            gridView1.Columns["CUST_FULL_NAME"].Caption = "اسم المريض";
            gridView1.Columns["CUST_AGE"].Caption = "العمر";
            gridView1.Columns["CUST_BD"].Caption = "تاريخ الميلاد";
            gridView1.Columns["CUST_MOBAIL"].Caption = "رقم الهاتف";
        }

            private void frm_CUST_LIST_Load(object sender, EventArgs e)
        {
            TXT_USER_NAME.Text = "";
            CLEAR_DATA();
        }

        private void TXT_USER_NAME_EditValueChanged(object sender, EventArgs e)
        {
           
            CLEAR_DATA();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                NCLS_CUST.SLECECT_CUST(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CUST_CODE"]).ToString(), gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CUST_FULL_NAME"]).ToString());
                this.Close();
            }
        }
    }
}