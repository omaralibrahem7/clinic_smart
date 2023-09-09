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
    public partial class frm_MEDCIN_LIST : DevExpress.XtraEditors.XtraForm
    {
        public frm_MEDCIN_LIST()
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
        }
        private void frm_MEDCIN_LIST_Load(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }

        private void TXT_USER_NAME_EditValueChanged(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }
    }
}