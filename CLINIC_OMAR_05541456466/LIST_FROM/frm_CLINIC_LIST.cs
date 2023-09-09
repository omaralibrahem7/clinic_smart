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
    public partial class frm_CLINIC_LIST : DevExpress.XtraEditors.XtraForm
    {
        public frm_CLINIC_LIST()
        {
            InitializeComponent();
        }
        CLASES.cls_CLINIC NCLS_CLIN = new CLASES.cls_CLINIC();
        public void CLIN_DATA()
        {
            DataTable DT = new DataTable();
            DT = CLASES.cls_CLINIC.CLI_TABLE.CLINIC_BY_CLI_NAME(TXT_USER_NAME.Text);
            gridControl1.DataSource = DT;
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns["CLI_CODE"].Caption = "رقم العيادة";
            gridView1.Columns["CLI_NAME"].Caption = "اسم العيادة";
            gridView1.Columns["CLI_LOC"].Caption = "الموقع";
            gridView1.Columns["CLI_NOTE"].Caption = "ملاحظات";
        }
            private void frm_CLINIC_LIST_Load(object sender, EventArgs e)
        {
            CLIN_DATA();
        }

        private void TXT_USER_NAME_EditValueChanged(object sender, EventArgs e)
        {
            CLIN_DATA();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                NCLS_CLIN.SLECECT_CLI(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CLI_NAME"]).ToString());
                this.Close();
            }
        }
    }
}