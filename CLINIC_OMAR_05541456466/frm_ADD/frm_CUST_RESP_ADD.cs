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

namespace CLINIC_OMAR_05541456466.CLASES
{
    public partial class frm_CUST_RESP_ADD : DevExpress.XtraEditors.XtraForm
    {
        public frm_CUST_RESP_ADD()
        {
            InitializeComponent();
        }
        CLASES.cls_CUST NCLS_CUST = new CLASES.cls_CUST();
        CLASES.cls_ORDER NCLS_ORDER = new cls_ORDER();
        CLASES.cls_CARD NCLS_COM = new CLASES.cls_CARD();
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
            gridView1.Columns.Remove(gridView1.Columns["CUST_AGE"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_BD"]);
            //تسمية الاعمدة
            gridView1.Columns["CUST_CODE"].Caption = "رقم المريض";
            gridView1.Columns["CUST_FULL_NAME"].Caption = "اسم المريض";
            gridView1.Columns["CUST_MOBAIL"].Caption = "رقم الهاتف";
            gridView1.BestFitColumns();

            /////////////////////////////////////////////////////////
            //الجدول الثاني

            //استدعاء البيانات
            gridControl2.DataSource = NCLS_ORDER.ORDER_LIST();
            
            //حذف الاعمدة 
            gridView2.Columns.Remove(gridView2.Columns["CLI_ID"]);
            gridView2.Columns.Remove(gridView2.Columns["ORDER_ID"]);

            //تسمية الاعمدة
            gridView2.Columns["ORDER_CODE"].Caption = "رقم ";
            gridView2.Columns["ORDER_DATE"].Caption = "تاريخ الزيارة ";
            gridView2.Columns["ORDER_TIME"].Caption = "الوقت";
            gridView2.Columns["ORDER_NOTE"].Caption = "الملاحظات";
            gridView2.Columns["CUST_FULL_NAME"].Caption = "اسم المريض";
            gridView2.Columns["CUST_ID"].Caption = "رقم المريض";
            gridView1.BestFitColumns();
           
            
            //////////////////////////////////////////////////////////////////////////
         
            //الحالات الافتراضية
            TXT_SEARCH.Text = "";
            TXT_CODE.Text = CLASES.cls_CUST.CUST_TABLE.MAX_CODE_BY_CUST().Rows[0]["CUST_CODE"].ToString();
            TXT_F_NAME.Text = "";
            TXT_S_NAME.Text = "";
            TXT_L_NAME.Text = "";
            txt_date.Value = DateTime.Now;
            TXT_AGE.Text = "";
            TXT_ADDRESS.Text = "";
            TXT_MOBALE.Text = "";
            TXT_SEARCH.Text = "";
            TXT_STATE.Text = "غير مؤمن";
        }

        private void frm_CUST_RESP_ADD_Load(object sender, EventArgs e)
        {
          
            CLEAR_DATA();
        }

        private void TXT_STATE_SelectedIndexChanged(object sender, EventArgs e)//حالة التأمين
        {
            if (TXT_STATE.Text == "مؤمن")
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

        private void TXT_SEARCH_EditValueChanged(object sender, EventArgs e)
        {
            TXT_SEARCH.Text = "";
            //استدعاء البيانات
            gridControl1.DataSource = CLASES.cls_CUST.CUST_DATA_LIST.GetData(TXT_SEARCH.Text, TXT_SEARCH.Text);
            //حذف الاعمدة 
            gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CARD_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_ADDRESS"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_SAVE_STATE"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_AGE"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_BD"]);
            //تسمية الاعمدة
            gridView1.Columns["CUST_CODE"].Caption = "رقم المريض";
            gridView1.Columns["CUST_FULL_NAME"].Caption = "اسم المريض";
            gridView1.Columns["CUST_MOBAIL"].Caption = "رقم الهاتف";
            gridView1.BestFitColumns();

        }

        private void BTN_CARD_Click(object sender, EventArgs e)
        {
            LIST_FROM.frm_CARD_LIST FRMCR = new LIST_FROM.frm_CARD_LIST();
            FRMCR.ShowDialog();
            TXT_CARD_ID.Text = CLASES.cls_CARD.CARD_ID.ToString();
            TXT_CARD_NAME.Text = CLASES.cls_CARD.CARD_NAME;
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_CODE.Text != "" && TXT_F_NAME.Text != "" && TXT_L_NAME.Text != "" && TXT_MOBALE.Text != "")
                {
                    CLASES.cls_CUST.CUST_TABLE.Insert_CUST(Convert.ToInt64(TXT_CODE.Text), TXT_F_NAME.Text, TXT_S_NAME.Text, TXT_L_NAME.Text, TXT_AGE.Text, Convert.ToDateTime(txt_date.Text), TXT_MOBALE.Text, TXT_ADDRESS.Text, TXT_STATE.Text, Convert.ToInt64(TXT_CARD_ID.Text), 7);
                    NCLS_CUST.SLECECT_CUST(TXT_CODE.Text  , TXT_F_NAME + " " + TXT_S_NAME + " " + TXT_L_NAME);
                    CLASES.cls_ORDER.ORDER_TABLE.Insert_ORDER(Convert.ToInt64(CLASES.cls_ORDER.ORDER_TABLE.MAX_CODE_BY_ORDR().Rows[0]["ORDER_CODE"]), Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "YYYY/MM/DD")),TimeSpan.Parse(string.Format(DateTime.Now.Hour.ToString(), "") + ":" + string.Format(DateTime.Now.Minute.ToString(), "")), "",CLASES.cls_CUST.CUST_ID, 4);
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

        private void BTN_UPDATE_Click(object sender, EventArgs e)
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

            //if (TXT_CODE.Text != "" && TXT_F_NAME.Text != "" && TXT_L_NAME.Text != "" && TXT_MOBALE.Text != "")
            //{
            //    CLASES.cls_CUST.CUST_TABLE.Update_CUST(Convert.ToInt64(TXT_CODE.Text), TXT_F_NAME.Text, TXT_S_NAME.Text, TXT_L_NAME.Text, TXT_AGE.Text, Convert.ToDateTime(txt_date.Text), TXT_MOBALE.Text, TXT_ADDRESS.Text, TXT_STATE.Text, Convert.ToInt64(TXT_CARD_ID.Text), 7, CLASES.cls_CUST.CUST_ID, CLASES.cls_CUST.CUST_ID);
            //    CLEAR_DATA();
            //}
            //else
            //{
            //    MessageBox.Show("يوجد خطأفي التعديل ");
            //}



            if (gridView1.RowCount > 0)
            {
                NCLS_CUST.SLECECT_CUST(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CUST_CODE"]).ToString(), gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CUST_FULL_NAME"]).ToString());
                TXT_CODE.Text = CLASES.cls_CUST.CUST_CODE.ToString();
                TXT_F_NAME.Text = CLASES.cls_CUST.CUST_F_NAME;
                TXT_S_NAME.Text = CLASES.cls_CUST.CUST_S_NAME;
                TXT_L_NAME.Text = CLASES.cls_CUST.CUST_L_NAME;
                TXT_AGE.Text = CLASES.cls_CUST.CUST_AGE;
                txt_date.Value = Convert.ToDateTime(String.Format(CLASES.cls_CUST.CUST_BD, "DD/MM/YYYY"));
                TXT_MOBALE.Text = CLASES.cls_CUST.CUST_MOBAIL;
                TXT_ADDRESS.Text = CLASES.cls_CUST.CUST_ADDRESS;
                TXT_STATE.Text = CLASES.cls_CUST.CUST_SAVE_STATE;
                TXT_CARD_ID.Text = CLASES.cls_CUST.CARD_ID.ToString();
                TXT_F_NAME.Focus();
            }
        }

        private void BTN_UPDATE_Click_1(object sender, EventArgs e)
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

        private void BTN_CEALE_Click(object sender, EventArgs e)
        {
            CLEAR_DATA();//دالة الاستدعاء
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                NCLS_CUST.SLECECT_CUST((gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CUST_CODE"]).ToString()), TXT_F_NAME + " " + TXT_S_NAME + " " + TXT_L_NAME);
                CLASES.cls_ORDER.ORDER_TABLE.Insert_ORDER(Convert.ToInt64(CLASES.cls_ORDER.ORDER_TABLE.MAX_CODE_BY_ORDR().Rows[0]["ORDER_CODE"]), Convert.ToDateTime(string.Format(DateTime.Now.ToShortDateString(), "YYYY/MM/DD")), TimeSpan.Parse(string.Format(DateTime.Now.Hour.ToString(), "") + ":" + string.Format(DateTime.Now.Minute.ToString(), "")), "", CLASES.cls_CUST.CUST_ID, 7);
                CLEAR_DATA();
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount>0)
            {
                CLASES.cls_ORDER.ORDER_TABLE.Delete_ORDER(Convert.ToInt64((gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["ORDER_CODE"]).ToString())));
                CLEAR_DATA();
            }
        }
    }
}