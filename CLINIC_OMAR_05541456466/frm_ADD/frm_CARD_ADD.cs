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
    public partial class frm_CARD_ADD : DevExpress.XtraEditors.XtraForm
    {
        public frm_CARD_ADD()
        {
            InitializeComponent();
        }

        CLASES.cls_CARD NCLS_CARD = new CLASES.cls_CARD();
        CLASES.cls_COMPANY NCLS_COM = new CLASES.cls_COMPANY();
        public void CLEAR_DATA()
        {
            gridControl1.DataSource = NCLS_CARD.SLECECT_CARD(TXT_SEARCH.Text);
            
                gridView1.Columns.Remove(gridView1.Columns["CARD_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["COM_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["CARD_NOTE"]);
                gridView1.Columns["CARD_CODE"].Caption = "رقم البطاقة";
                gridView1.Columns["CARD_NAME"].Caption = "اسم البطاقة";
                gridView1.Columns["CARD_DATE"].Caption = "تاريخ الصلاحية";
                gridView1.Columns["CARD_STATE"].Caption = "حالة البطاقة";
                gridView1.Columns["CARD_PER"].Caption = "نسبة البطاقة";
                TXT_CODE.Text = CLASES.cls_CARD.CARD_TABLE.MAX_CARD_CODE().Rows[0]["CARD_CODE"].ToString();
                TXT_NAME.Text = "";
                TXT_SEARCH.Text = "";
                TXT_STATE.Text="فعالة";
                txt_date.Value = DateTime.Now;
                TXT_NOTE.Text = "";
                TXT_PRE.Text = "0";
            COM_ID.DataSource = NCLS_COM.COM_LIST();
            COM_ID.ValueMember ="COM_ID";
            COM_NAME.DataSource = COM_ID.DataSource;
            COM_NAME.ValueMember ="COM_NAME";


        }

        private void frm_CARD_ADD_Load(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }

        private void simpleButton1_Click(object sender, EventArgs e)//اختيار الكرت يتبع لأي شركة
        {
            LIST_FROM.frm_COMPANNY_LIST FRMC = new LIST_FROM.frm_COMPANNY_LIST();
            FRMC.ShowDialog();
            COM_ID.Text = CLASES.cls_COMPANY.COM_ID.ToString();
            COM_NAME.Text = CLASES.cls_COMPANY.COM_NAME;

        }

        private void BTN_CEALE_Click(object sender, EventArgs e)
        {
            CLEAR_DATA();
        }

        private void TXT_SEARCH_EditValueChanged(object sender, EventArgs e)
        {
            TXT_SEARCH.Text = "";
            CLEAR_DATA();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                NCLS_CARD.SLECECT_CARD(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CARD_NAME"]).ToString());
                TXT_CODE.Text = CLASES.cls_CARD.CARD_CODE;
                TXT_NAME.Text = CLASES.cls_CARD.CARD_NAME;
                txt_date.Value = Convert.ToDateTime(String.Format(CLASES.cls_CARD.CARD_DATE, "DD/MM/YYYY"));
                TXT_STATE.Text = CLASES.cls_CARD.CARD_STATE;
                TXT_PRE.Text = CLASES.cls_CARD.CARD_PER.ToString();
                TXT_NOTE.Text = CLASES.cls_CARD.CARD_NOTE;
                
            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (TXT_CODE.Text != "" && TXT_NAME.Text != "")
            {
                CLASES.cls_CARD.CARD_TABLE.Insert_CARD(TXT_CODE.Text, TXT_NAME.Text, Convert.ToDateTime(txt_date.Text), TXT_STATE.Text, Convert.ToInt64(TXT_PRE.Text),TXT_NOTE.Text, Convert.ToInt64(COM_ID.Text), 7);
                CLEAR_DATA();
            }
            else
            {
                MessageBox.Show("يوجد خطأ في ادخال البيانات ");
            }
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && TXT_CODE.Text != "" && TXT_NAME.Text != "")
            {
                CLASES.cls_CARD.CARD_TABLE.Update_CARD(TXT_CODE.Text, TXT_NAME.Text, Convert.ToDateTime(txt_date.Text), TXT_STATE.Text, Convert.ToInt64(TXT_PRE.Text), TXT_NOTE.Text, Convert.ToInt64(COM_ID.Text), 7,CLASES.cls_CARD.CARD_ID, CLASES.cls_CARD.CARD_ID);
                CLEAR_DATA();
            }
            else
            {
                MessageBox.Show("يوجد خطأفي التعديل ");
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && TXT_CODE.Text != "" && TXT_NAME.Text != "")
            {
                CLASES.cls_CARD.CARD_TABLE.Delete_CARD(CLASES.cls_CARD.CARD_ID);
                CLEAR_DATA();
            }
            else
            {
                MessageBox.Show("يوجد خطأفي الحذف");
            }
        }
    }
}