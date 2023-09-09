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
    public partial class frm_LIST_USER : DevExpress.XtraEditors.XtraForm
    {
        CLASES.cls_USER Ncls_USER = new CLASES.cls_USER();
        public frm_LIST_USER()
        {
            InitializeComponent();
        }
        public void GRID_LIST()
        {
            gridControl1.DataSource = CLASES.cls_USER.USER_TABLE.TXT_USER_LIST(TXT_USER_NAME.Text);
            gridView1.Columns.Remove(gridView1.Columns["USER_CODE"]);
            gridView1.Columns.Remove(gridView1.Columns["USER_PASSWORD"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns["USER_ID"].Caption = "رقم المستخدم";
            gridView1.Columns["USER_NAME"].Caption = "اسم المستخدم";
            gridView1.Columns["USER_TYPE"].Caption = "نوع المستخدم";
        }
        private void frm_LIST_DOCTOR_Load(object sender, EventArgs e)
        {
            TXT_USER_NAME.Text = "";
            GRID_LIST();
        }

        private void TXT_USER_NAME_EditValueChanged(object sender, EventArgs e)
        {
            GRID_LIST();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                Ncls_USER.SELECT_USER(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["USER_NAME"]).ToString());
                this.Close();
            }
        }
    }
}