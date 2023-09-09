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
    public partial class frm_LIST_DOC : DevExpress.XtraEditors.XtraForm
    {
        public frm_LIST_DOC()
        {
            InitializeComponent();
        }
        CLASES.cls_DOCTOR NCLS_DOC = new CLASES.cls_DOCTOR();
        public void GRID_DATA()
        {
            gridControl1.DataSource = NCLS_DOC.SELECT_DOC(TXT_USER_NAME.Text);
            gridView1.Columns.Remove(gridView1.Columns["DOC_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["USER_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DOC_DB"]);
            gridView1.Columns.Remove(gridView1.Columns["DOC_EXP"]);
            gridView1.Columns["DOC_CODE"].Caption = "رقم الطبيب";
            gridView1.Columns["DOC_NAME"].Caption = "اسم الطبيب";
            gridView1.Columns["DOC_MAJOR"].Caption = "تخصص الطبيب";
          //  gridView1.Columns["DOC_EXP"].Caption = "خبرة الطبيب";
         // gridView1.Columns["DOC_DB"].Caption = "مواليد الطبيب";
            gridView1.Columns["DOC_MOBAIL"].Caption = "رقم هاتف الطبيب";
            gridView1.Columns["DOC_ADDRESS"].Caption = "عنوان الطبيب";
        }
        private void frm_LIST_DOC_Load(object sender, EventArgs e)
        {
            TXT_USER_NAME.Text = "";
            GRID_DATA();
        }

        private void TXT_USER_NAME_EditValueChanged(object sender, EventArgs e)
        {
            GRID_DATA();
        }
       

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                NCLS_DOC.SELECT_DOC(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DOC_NAME"]).ToString());
                this.Close();
            }
        }
    }
}