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
    public partial class frm_CUSTUMAR_ADD : DevExpress.XtraEditors.XtraForm
    {
        public frm_CUSTUMAR_ADD()
        {
            InitializeComponent();
        }


       
        CLASES.cls_CARD NCLS_COM = new CLASES.cls_CARD();
        CLASES.cls_CUST NCLS_CUST = new CLASES.cls_CUST();

        public void CLEAR_DATA() //دالة الاستدعاء
        {
            //استدعاء البيانات
            gridControl1.DataSource = CLASES.cls_CUST.CUST_DATA_LIST.GetData(TXT_SEARCH.Text, TXT_SEARCH.Text);
            //حذف الاعمدة 
            gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CARD_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_ADDRESS"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_SAVE_STATE"]);
           //تسمية الاعمدة
            gridView1.Columns["CUST_CODE"].Caption = "رقم المريض";
            gridView1.Columns["CUST_FULL_NAME"].Caption = "اسم المريض";
            gridView1.Columns["CUST_AGE"].Caption = "العمر";
            gridView1.Columns["CUST_BD"].Caption = "تاريخ الميلاد";
            gridView1.Columns["CUST_MOBAIL"].Caption = "رقم الهاتف";
            
            //الحالات الافتراضية
            TXT_SEARCH.Text = "";
            TXT_CODE.Text = CLASES.cls_CUST.CUST_TABLE.MAX_CODE_BY_CUST().Rows[0]["CUST_CODE"].ToString();
            TXT_F_NAME.Text = "";
            TXT_S_NAME.Text = "";
            TXT_L_NAME.Text="";
            txt_date.Value = DateTime.Now;
            TXT_AGE.Text = "";
            TXT_ADDRESS.Text = "";
            TXT_MOBALE.Text = "";
            TXT_SEARCH.Text = "";
            TXT_STATE.Text = "غير مؤمن";
       

            
        }
        private void frm_CUSTUMAR_ADD_Load(object sender, EventArgs e)//الوجهة الاساسية
        {
            CLEAR_DATA();
        }

        private void TXT_SEARCH_EditValueChanged(object sender, EventArgs e)//البحث
        {
            TXT_SEARCH.Text = "";
            CLEAR_DATA();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)//جلب البيانات من الجدول
        {
            if (gridView1.RowCount > 0)
            {
                NCLS_CUST.SLECECT_CUST(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CUST_CODE"]).ToString() , gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CUST_FULL_NAME"]).ToString());
                TXT_CODE.Text    = CLASES.cls_CUST.CUST_CODE.ToString();
                TXT_F_NAME.Text  = CLASES.cls_CUST.CUST_F_NAME;
                TXT_S_NAME.Text  = CLASES.cls_CUST.CUST_S_NAME;
                TXT_L_NAME.Text  = CLASES.cls_CUST.CUST_L_NAME;
                TXT_AGE.Text     = CLASES.cls_CUST.CUST_AGE;
              txt_date.Value = Convert.ToDateTime(String.Format(CLASES.cls_CUST.CUST_BD, "DD/MM/YYYY"));
                TXT_MOBALE.Text  = CLASES.cls_CUST.CUST_MOBAIL;
                TXT_ADDRESS.Text = CLASES.cls_CUST.CUST_ADDRESS;
                TXT_STATE.Text = CLASES.cls_CUST.CUST_SAVE_STATE;
                TXT_CARD_ID.Text = CLASES.cls_CUST.CARD_ID.ToString();
               
            }
        }

     
        private void BTN_CEALE_Click_1(object sender, EventArgs e)//المسح
        {
            CLEAR_DATA();
        }

        private void BTN_SAVE_Click_1(object sender, EventArgs e)//الاضافة
        {
            try
            {
                if (TXT_CODE.Text != "" && TXT_F_NAME.Text != "" && TXT_L_NAME.Text != "" && TXT_MOBALE.Text != "")
                {
                    CLASES.cls_CUST.CUST_TABLE.Insert_CUST(Convert.ToInt64(TXT_CODE.Text), TXT_F_NAME.Text, TXT_S_NAME.Text, TXT_L_NAME.Text, TXT_AGE.Text, Convert.ToDateTime(txt_date.Text), TXT_MOBALE.Text, TXT_ADDRESS.Text, TXT_STATE.Text, Convert.ToInt64(TXT_CARD_ID.Text), 7);
                    CLEAR_DATA();
                }
                else
                {
                    MessageBox.Show("يوجد خطأ في ادخال البيانات ");
                }
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
           

        }


        private void TXT_STATE_SelectedIndexChanged(object sender, EventArgs e)//حالة التأمين
        {
            if (TXT_STATE.Text=="مؤمن")
            {
                BTN_CARD.Enabled = true;
                TXT_CARD_ID.Enabled = true;
                TXT_CARD_NAME.Enabled = true;

                TXT_CARD_ID.DataSource = NCLS_COM.CARD_LIST();
                TXT_CARD_ID.ValueMember = "CARD_CODE";
                TXT_CARD_NAME.DataSource = TXT_CARD_ID.DataSource;
                TXT_CARD_NAME.ValueMember = "CARD_NAME";
            }
            else
            {
                BTN_CARD.Enabled = false;
                TXT_CARD_ID.Enabled = false;
                TXT_CARD_NAME.Enabled = false;
                TXT_CARD_NAME.Text = "غير مؤمن";
                TXT_CARD_ID.Text = "0";

            }
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)//التعديل
        {
            if (TXT_CODE.Text != "" && TXT_F_NAME.Text != "" && TXT_L_NAME.Text != "" && TXT_MOBALE.Text != "")
            {
                CLASES.cls_CUST.CUST_TABLE.Update_CUST(Convert.ToInt64(TXT_CODE.Text), TXT_F_NAME.Text, TXT_S_NAME.Text, TXT_L_NAME.Text, TXT_AGE.Text, Convert.ToDateTime(txt_date.Text), TXT_MOBALE.Text, TXT_ADDRESS.Text, TXT_STATE.Text, Convert.ToInt64(TXT_CARD_ID.Text), 7, CLASES.cls_CUST.CUST_ID, CLASES.cls_CUST.CUST_ID);
                CLEAR_DATA();
            }
            else
            {
                MessageBox.Show("يوجد خطأفي التعديل ");
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)//الحذف
        {
            //الحذف
            if (TXT_CODE.Text != "" && TXT_F_NAME.Text != "" && TXT_L_NAME.Text != "" && TXT_MOBALE.Text != "")
            {
                CLASES.cls_CUST.CUST_TABLE.Delete_CUST(CLASES.cls_CUST.CUST_ID);
                CLEAR_DATA();
            }
            else
            {
                MessageBox.Show("يوجد خطأفي الحذف");
            }
        }

        private void BTN_CARD_Click(object sender, EventArgs e)//استدعاء قيم البطاقات من اللائحة المخخصة لها
        {
            LIST_FROM.frm_CARD_LIST FRMCR = new LIST_FROM.frm_CARD_LIST();
            FRMCR.ShowDialog();
            TXT_CARD_ID.Text = CLASES.cls_CARD.CARD_ID.ToString();
            TXT_CARD_NAME.Text = CLASES.cls_CARD.CARD_NAME;
        }
    }
}