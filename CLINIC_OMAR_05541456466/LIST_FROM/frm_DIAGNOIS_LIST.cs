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
    public partial class frm_DIAGNOIS_LIST : DevExpress.XtraEditors.XtraForm
    {
        public frm_DIAGNOIS_LIST()
        {
            InitializeComponent();
        }

        CLASES.cls_DIG NCLS_DIG = new CLASES.cls_DIG();
        public void CLEAR_DATA()
        {
            DataTable DT = new DataTable();
            DT = NCLS_DIG.SLECECT_DIG(TXT_USER_NAME.Text);
            gridControl1.DataSource = DT;
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DIG_ID"]);
            //  gridView1.Columns.Remove(gridView1.Columns["DIG_NOTE"]);
            gridView1.Columns["DIG_CODE"].Caption = "رقم التشخيص";
            gridView1.Columns["DIG_NAME"].Caption = "اسم التشخيص";
            gridView1.Columns["DID_TYPE"].Caption = "نوع التشخيص";
            gridView1.Columns["DIG_NOTE"].Caption = "ملاحظات التشخيص";

        }
        private void frm_DIAGNOIS_LIST_Load(object sender, EventArgs e)
        {
            TXT_USER_NAME.Text = "";
            CLEAR_DATA();
        }

        private void TXT_USER_NAME_EditValueChanged(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }
    }
}