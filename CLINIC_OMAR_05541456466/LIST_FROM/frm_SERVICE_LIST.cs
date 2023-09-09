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
    public partial class frm_SERVICE_LIST : DevExpress.XtraEditors.XtraForm
    {
        public frm_SERVICE_LIST()
        {
            InitializeComponent();
        }
        public void CLEAR_DATA()
        {
            DataTable DT = new DataTable();
            DT = CLASES.cls_SER.SER_TABLE.SEVICE_BY_SER_NAME(TXT_USER_NAME.Text);
            gridControl1.DataSource = DT;
            gridControl1.DataSource = DT;
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["SER_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["SER_NOTE"]);
            gridView1.Columns["SER_CODE"].Caption = "رقم الاجراء";
            gridView1.Columns["SERNAME"].Caption = "اسم الاجراء";
            gridView1.Columns["SER_TYPE"].Caption = "نوع الاجراء";
            gridView1.Columns["SER_PRICE"].Caption = "سعر الاجراء";
        }
        private void frm_SERVICE_LIST_Load(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }

        private void TXT_USER_NAME_EditValueChanged(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }
    }
}