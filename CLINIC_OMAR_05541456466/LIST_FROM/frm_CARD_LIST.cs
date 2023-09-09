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
    public partial class frm_CARD_LIST : DevExpress.XtraEditors.XtraForm
    {
        public frm_CARD_LIST()
        {
            InitializeComponent();
        }
        public void CLEAR_DATA()
        {
            gridControl1.DataSource = CLASES.cls_CARD.CARD_TABLE.GetData();

            gridView1.Columns.Remove(gridView1.Columns["CARD_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["COM_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CARD_NOTE"]);
            gridView1.Columns["CARD_CODE"].Caption = "رقم البطاقة";
            gridView1.Columns["CARD_NAME"].Caption = "اسم البطاقة";
            gridView1.Columns["CARD_DATE"].Caption = "تاريخ الصلاحية";
            gridView1.Columns["CARD_STATE"].Caption = "حالة البطاقة";
            gridView1.Columns["CARD_PER"].Caption = "نسبة البطاقة";
        }
            private void frm_CARD_LIST_Load(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }

        CLASES.cls_CARD NCLS_CARD = new CLASES.cls_CARD();
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                NCLS_CARD.SLECECT_CARD(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CARD_NAME"]).ToString());
                this.Close();
            }
        }
    }
}