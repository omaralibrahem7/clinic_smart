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

namespace CLINIC_OMAR_05541456466.frm_MED
{
    public partial class frm_DIG_MED : DevExpress.XtraEditors.XtraForm
    {
        public frm_DIG_MED()
        {
            InitializeComponent();
        }
        CLASES.cls_DIG NCLS_DIG = new CLASES.cls_DIG();
        public void CLEAR_DIG_DATA()
        {
            DataTable DT = new DataTable();
            DT = NCLS_DIG.SLECECT_DIG(TXT_USER_NAME.Text);
            gridControl1.DataSource = DT;
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DIG_CODE"]);
            //  gridView1.Columns.Remove(gridView1.Columns["DIG_NOTE"]);
            gridView1.Columns["DIG_ID"].Caption = "رقم التشخيص";
            gridView1.Columns["DIG_NAME"].Caption = "اسم التشخيص";
            gridView1.Columns["DID_TYPE"].Caption = "نوع التشخيص";
            gridView1.Columns["DIG_NOTE"].Caption = "ملاحظات التشخيص";
            gridView1.BestFitColumns();
        }
        public void DIG_VIS_LIST()
        {
            gridControl2.DataSource =CLASES.cls_DIGLIST.DIGLIST_TABLE.DIGLIST_BY_VIS_ID_AND_CUST_ID(CLASES.cls_VIS.VIS_ID, CLASES.cls_CUST.CUST_ID);
            
            gridView2.Columns.Remove(gridView2.Columns["CLI_ID"]);
            gridView2.Columns.Remove(gridView2.Columns["DIGLIST_ID"]);
            gridView2.Columns.Remove(gridView2.Columns["DIGLIST_NAME"]);
            gridView2.Columns.Remove(gridView2.Columns["DIGLIST_TIME"]);
            gridView2.Columns.Remove(gridView2.Columns["CUST_ID"]);
            gridView2.Columns.Remove(gridView2.Columns["DIG_ID"]);
            gridView2.Columns.Remove(gridView2.Columns["VIS_ID"]);
            gridView2.Columns["DIGLIST_CODE"].Caption = "رقم التشخيص";
            gridView2.Columns["DIGLIST_DATE"].Caption = "تاريخ التشخيص";
            gridView2.Columns["DIG_NAME"].Caption = "اسم التشخيص";
            gridView2.Columns["DID_TYPE"].Caption = "نوع التشخيص";

            gridView2.BestFitColumns();
        }

        private void frm_DIG_MED_Load(object sender, EventArgs e)
        {
            TXT_USER_NAME.Text = "";
            CLEAR_DIG_DATA();
            DIG_VIS_LIST();
        }

        private void simpleButton3_Click(object sender, EventArgs e)//اضافة تشخيصجديد
        {
            frm_ADD.frm_DIAGNOIS_ADD FRMDA = new frm_ADD.frm_DIAGNOIS_ADD();
            FRMDA.ShowDialog();
            CLEAR_DIG_DATA();
        }

        private void TXT_USER_NAME_EditValueChanged(object sender, EventArgs e)///البحث في التشخيصات
        {
            CLEAR_DIG_DATA();
        }

        private void simpleButton5_Click(object sender, EventArgs e)///حذف من قائمة التشخيصات
        {
            if (gridView2.RowCount>0)
            {
                CLASES.cls_DIGLIST.DIGLIST_TABLE.DeleteDIGLIST(CLASES.cls_VIS.VIS_ID, Convert.ToInt64(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["DIGLIST_CODE"]).ToString()), CLASES.cls_CUST.CUST_ID);
                DIG_VIS_LIST();
                CLEAR_DIG_DATA();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)//////////اضافة تشخيص جديد
        {
            /////////////////////////////////////////////////////////////////////////////////////////////
            try
            {
                if (gridView1.RowCount > 0)
                {
                    CLASES.cls_DIGLIST.DIGLIST_TABLE.Insert_DIGLIST(Convert.ToInt64(CLASES.cls_DIGLIST.DIGLIST_TABLE.MAX_CODE_DIGLIST().Rows[0]["DIGLIST_CODE"].ToString()), gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DIG_NAME"]).ToString(), Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "YYYY/MM/DD")), TimeSpan.Parse(string.Format(DateTime.Now.Hour.ToString(), "") + ":" + string.Format(DateTime.Now.Minute.ToString(), "")), Convert.ToInt64(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DIG_ID"]).ToString()), CLASES.cls_CUST.CUST_ID, CLASES.cls_VIS.VIS_ID, 7);
                    DIG_VIS_LIST();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            CLASES.cls_DIGLIST.DIGLIST_TABLE.DeleteALL_DIG_LIST(CLASES.cls_VIS.VIS_ID, CLASES.cls_CUST.CUST_ID);
            DIG_VIS_LIST();
            CLEAR_DIG_DATA();
        }
    }
}