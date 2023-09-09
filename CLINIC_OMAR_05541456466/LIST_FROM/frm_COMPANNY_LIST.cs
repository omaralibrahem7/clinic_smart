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
    
    public partial class frm_COMPANNY_LIST : DevExpress.XtraEditors.XtraForm
    {
        public frm_COMPANNY_LIST()
        {
            InitializeComponent();
        }
        CLASES.cls_COMPANY Ncls_CARD = new CLASES.cls_COMPANY();
        public void CLEAR_DATA()
        {
            DataTable DT = new DataTable();
            DT = CLASES.cls_COMPANY.COMPANY_DATATABLE.COMPANY_LIST_BY_COM_NAME(TXT_USER_NAME.Text);
            gridControl1.DataSource = DT;
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["COM_ID"]);
            gridView1.Columns["COM_CODE"].Caption = "رقم الشركة";
            gridView1.Columns["COM_NAME"].Caption = "اسم الشركة";
            gridView1.Columns["COM_MOBAIL"].Caption = "رقم هاتف الشركة";
            gridView1.Columns["COM_STATE"].Caption = "حالة الشركة ";
        }

        private void frm_COMPANNY_LIST_Load(object sender, EventArgs e)
        {
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
                Ncls_CARD.COM_SELECT(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["COM_NAME"]).ToString());
                this.Close();
            }
        }

    }
}