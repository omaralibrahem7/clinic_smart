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

namespace CLINIC_OMAR_05541456466.frm_ADD
{
    public partial class frm_VIS_ADD : DevExpress.XtraEditors.XtraForm
    {
        public frm_VIS_ADD()
        {
            InitializeComponent();
        }
        CLASES.cls_ORDER NCLS_ORDER = new CLASES.cls_ORDER();
        CLASES.cls_CLINIC NCLS_CLI = new CLASES.cls_CLINIC();
        CLASES.cls_CUST NCLS_CUST = new CLASES.cls_CUST();
        CLASES.cls_VIS NCLS_VIS = new CLASES.cls_VIS();

        public void CLEAR_CUST_DATA()
        {
            gridControl1.DataSource = NCLS_ORDER.ORDER_LIST();

            //حذف الاعمدة 
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["ORDER_ID"]);

            //تسمية الاعمدة
            gridView1.Columns["ORDER_CODE"].Caption = "رقم ";
            gridView1.Columns["ORDER_DATE"].Caption = "تاريخ الزيارة ";
            gridView1.Columns["ORDER_TIME"].Caption = "الوقت";
            gridView1.Columns["ORDER_NOTE"].Caption = "الملاحظات";
            gridView1.Columns["CUST_FULL_NAME"].Caption = "اسم المريض";
            gridView1.Columns["CUST_ID"].Caption = "رقم المريض";
            gridView1.BestFitColumns();

            TXT_AGE.Text = "";
            TXT_CUST_ID.Text = "";
            TXT_DOC_NOTE.Text = "";
            TXT_F_NAME.Text = "";
            TXT_S_NAME.Text = "";
            TXT_L_NAME.Text = "";
            TXT_MOBALE.Text = "";
            TXT_NOTE.Text = "";
            TXT_PRE_TYPE.Text = "";
            txt_date.Value = DateTime.Now;
            TXT_COST.Text = "0";
            TXT_DIS_COUNT.Text = "0";
            TXT_TOTAL.Text = "0";

            TXT_CLI_ID.DataSource = NCLS_CLI.CLINIC_LIST();
            TXT_CLI_ID.ValueMember = "CLI_ID";
            TXT_CLI_NAME.DataSource = TXT_CLI_ID.DataSource;
            TXT_CLI_NAME.ValueMember = "CLI_NAME";
            
            TXT_CLI_ID.Text = "";
            TXT_CLI_NAME.Text = "";
            TXT_VIS_ID.Text = CLASES.cls_VIS.VIS_TABLE.MAX_CODE_AND_ID_BY_VIS().Rows[0]["VIS_ID"].ToString();
            CLASES.cls_VIS.VIS_ID = Convert.ToInt64(TXT_VIS_ID.Text);

            GRE_PRE.Enabled = false;
            GRE_SAVE.Enabled = false;
            GRI_SERVICE.Enabled = false;
            BTN_CUST_CARD.Enabled = false;
            
        }
        public void ORDER_LIST()
        {
            gridControl1.DataSource = NCLS_ORDER.ORDER_LIST();

            //حذف الاعمدة 
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["ORDER_ID"]);

            //تسمية الاعمدة
            gridView1.Columns["ORDER_CODE"].Caption = "رقم ";
            gridView1.Columns["ORDER_DATE"].Caption = "تاريخ الزيارة ";
            gridView1.Columns["ORDER_TIME"].Caption = "الوقت";
            gridView1.Columns["ORDER_NOTE"].Caption = "الملاحظات";
            gridView1.Columns["CUST_FULL_NAME"].Caption = "اسم المريض";
            gridView1.Columns["CUST_ID"].Caption = "رقم المريض";
            gridView1.BestFitColumns();
        }

        private void frm_VIS_ADD_Load(object sender, EventArgs e)//بداية التشغيل
        {
            CLEAR_CUST_DATA();
        }

        private void TXT_CUST_ID_EditValueChanged(object sender, EventArgs e)//فتح الازار
        {
            if (TXT_CUST_ID.Text==""&& TXT_F_NAME.Text==""&& TXT_VIS_ID.Text==""&& TXT_PRE_TYPE.Text=="")
            {
                CLEAR_CUST_DATA();
            }
            else
            {
                GRE_PRE.Enabled = true;
                GRE_SAVE.Enabled = true;
                GRI_SERVICE.Enabled = true;
            }
        }

        private void BTN_UPPDATE_Click(object sender, EventArgs e)//تحديث البيانات
        {
            ORDER_LIST();
        }

        private void CTN_CLEAR_Click(object sender, EventArgs e)//المسح الخانات
        {
            CLEAR_CUST_DATA();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)//جلب البيانات من الجدول 
        {
          
        }

        private void BTN_DELET_ORDER_Click(object sender, EventArgs e)//حذف القائمة
        {
           
        }

        private void BTN_CUST_Click(object sender, EventArgs e)//جلب بيانات المريض
        {
            try
            {
                LIST_FROM.frm_CUST_LIST FRMCL = new LIST_FROM.frm_CUST_LIST();
                FRMCL.ShowDialog();
                TXT_CUST_ID.Text = CLASES.cls_CUST.CUST_ID.ToString();
                TXT_F_NAME.Text = CLASES.cls_CUST.CUST_F_NAME;
                TXT_S_NAME.Text = CLASES.cls_CUST.CUST_S_NAME;
                TXT_L_NAME.Text = CLASES.cls_CUST.CUST_L_NAME;
                TXT_AGE.Text = CLASES.cls_CUST.CUST_AGE;
                txt_date.Value = Convert.ToDateTime(String.Format(CLASES.cls_CUST.CUST_BD, "DD/MM/YYYY"));
                TXT_MOBALE.Text = CLASES.cls_CUST.CUST_MOBAIL;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void BTN_CLI_Click_1(object sender, EventArgs e)//جلب بيانات العيادة
        {
            LIST_FROM.frm_CLINIC_LIST FRMCLI = new LIST_FROM.frm_CLINIC_LIST();
            FRMCLI.ShowDialog();
            TXT_CLI_ID.Text = CLASES.cls_CLINIC.CLI_ID.ToString();
            TXT_CLI_NAME.Text = CLASES.cls_CLINIC.CLI_NAME.ToString();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_VIS_ID.Text != "" && TXT_CUST_ID.Text != "" && TXT_CLI_ID.Text != "")
                {
                    CLASES.cls_VIS.VIS_TABLE.Insert_VIS(Convert.ToInt64(TXT_VIS_ID.Text), Convert.ToInt64(TXT_VIS_ID.Text), "", Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "YYYY/MM/DD")), TimeSpan.Parse(string.Format(DateTime.Now.Hour.ToString(), "") + ":" + string.Format(DateTime.Now.Minute.ToString(), "")), "", Convert.ToInt64(TXT_CUST_ID.Text), Convert.ToInt64(TXT_CLI_ID.Text), 30023, Convert.ToDecimal(TXT_COST.Text), Convert.ToDecimal(TXT_DIS_COUNT.Text), Convert.ToDecimal(TXT_TOTAL.Text), TXT_DOC_NOTE.Text,TXT_PRE_TYPE.Text);
                    ORDER_LIST();
        
                        CLEAR_CUST_DATA();
                    
                    MessageBox.Show("تم التسجيل بنجاح");
                }
                else
                {
                    MessageBox.Show("يوجد خطأ");                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
          
        }

    

        private void CTN_CLEAR_Click_1(object sender, EventArgs e)
        {
            CLEAR_CUST_DATA();
        }

        private void TXT_PRE_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (TXT_PRE_TYPE.Text=="بطاقة")
            {
                BTN_CUST_CARD.Enabled = true;
            }
            else
            {
                BTN_CUST_CARD.Enabled = false;
            }
        }

        private void BTN_DIG_Click(object sender, EventArgs e)
        {
            frm_MED.frm_DIG_MED frmDIG_MID = new frm_MED.frm_DIG_MED();
            frmDIG_MID.ShowDialog();
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                NCLS_CUST.SLECECT_CUST(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CUST_ID"]).ToString(), gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CUST_FULL_NAME"]).ToString());

                TXT_CUST_ID.Text = CLASES.cls_CUST.CUST_ID.ToString();
                CLASES.cls_VIS.VIS_ID = Convert.ToInt64(TXT_VIS_ID.Text);
                TXT_F_NAME.Text = CLASES.cls_CUST.CUST_F_NAME;
                TXT_S_NAME.Text = CLASES.cls_CUST.CUST_S_NAME;
                TXT_L_NAME.Text = CLASES.cls_CUST.CUST_L_NAME;
                TXT_AGE.Text = CLASES.cls_CUST.CUST_AGE;
                txt_date.Value = Convert.ToDateTime(String.Format(CLASES.cls_CUST.CUST_BD, "YYYY/MM/DD"));
                TXT_MOBALE.Text = CLASES.cls_CUST.CUST_MOBAIL;
            }
        }

        private void BTN_UPPDATE_Click_1(object sender, EventArgs e)
        {
            CLEAR_CUST_DATA();
        }

        private void BTN_DELET_ORDER_Click_1(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                CLASES.cls_ORDER.ORDER_TABLE.Delete_ORDER(Convert.ToInt64((gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["ORDER_CODE"]).ToString())));
                ORDER_LIST();
            }
        }

        private void BTN_SER_Click(object sender, EventArgs e)
        {
            frm_SERVICE_ADD f = new frm_SERVICE_ADD();
            f.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_APO_ADD a = new frm_APO_ADD();
            a.Show();
        }
    }
}