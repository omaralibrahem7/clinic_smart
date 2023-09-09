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
    public partial class frm_APO_ADD : DevExpress.XtraEditors.XtraForm
    {
        public frm_APO_ADD()
        {
            InitializeComponent();
        }
        CLASES.cls_APO NCLS_APO = new CLASES.cls_APO();
        CLASES.cls_CUST NCLS_CUST = new CLASES.cls_CUST();
        CLASES.cls_DOCTOR NCLS_DOC = new CLASES.cls_DOCTOR();

        public void CLEAR_DATA() //دالة الاستدعاء
        {
            //استدعاء البيانات
            gridControl1.DataSource = NCLS_APO.APO_LIS_BY_DOC_CUST(TXT_SEARCH.Text,TXT_SEARCH.Text);
            //حذف الاعمدة 
            gridView1.Columns.Remove(gridView1.Columns["APO_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DOC_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DOC_ADDRESS"]);
            gridView1.Columns.Remove(gridView1.Columns["APO_NOTE"]);
            //تسمية الاعمدة
            gridView1.Columns["APO_CODE"].Caption = " رقم الموعد";
            gridView1.Columns["APO_DATE"].Caption = "تاريخ الموعد";
            gridView1.Columns["APO_TIME"].Caption = "وقت الموعد";
            gridView1.Columns["APO_NAME"].Caption = "اسم الموعد";
            gridView1.Columns["CUST_FULL_NAME"].Caption = "المريض";
            gridView1.Columns["DOC_NAME"].Caption = "الطبيب";

            //بيانات الدكتور
            TXT_DOC_ID.Enabled = false;
            TXT_DOC_ID.DataSource = NCLS_DOC.DOC_LIST();
            TXT_DOC_ID.ValueMember = "DOC_ID";
            TXT_DOC_NAME.DataSource = TXT_DOC_ID.DataSource;
            TXT_DOC_NAME.ValueMember = "DOC_NAME";

            //بيانات المريض
            TXT_CUST_ID.Enabled = false;
            TXT_CUST_ID.DataSource = CLASES.cls_CUST.CUST_DATA_LIST.GetData("", "");
            TXT_CUST_ID.ValueMember = "CUST_ID";
            TXT_CUST_NAME.DataSource = TXT_CUST_ID.DataSource;
            TXT_CUST_NAME.ValueMember = "CUST_FULL_NAME";
            gridView1.BestFitColumns();
         
            //الحالات الافتراضية
            TXT_SEARCH.Text = "";
            TXT_DODE.Text = CLASES.cls_APO.APO_TABLE.MAX_APO_BY_CODE().Rows[0]["APO_CODE"].ToString();
            TXT_TIME.Text = string.Format(DateTime.Now.ToShortTimeString(), "HH:MI");
            txt_date.Value = DateTime.Now;
            TXT_NAME.Text = "";
            TXT_NOTE.Text = "";

             
        }
        private void frm_APO_ADD_Load(object sender, EventArgs e)//الواجهة الاساسية
        {
            TXT_SEARCH.Text = "";
            CLEAR_DATA();
        }

        private void TXT_SEARCH_EditValueChanged(object sender, EventArgs e)//البحث
        {
            CLEAR_DATA();
        }

        private void BTN_CUST_LIST_Click(object sender, EventArgs e)//استدعاء لائحة المريض
        {
            LIST_FROM.frm_CUST_LIST FRMCU = new LIST_FROM.frm_CUST_LIST();
            FRMCU.ShowDialog();
            TXT_CUST_ID.Text = CLASES.cls_CUST.CUST_CODE.ToString();
        }

        private void BTN_DOC_LIST_Click(object sender, EventArgs e)//استدعاء لائحة الاطباء
        {
            LIST_FROM.frm_LIST_DOC FRMDO = new LIST_FROM.frm_LIST_DOC();
            FRMDO.ShowDialog();
            TXT_DOC_ID.Text=CLASES.cls_DOCTOR.DOC_CODE.ToString();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)//جلب البيانات الى الخانات
        {
            if (gridView1.RowCount > 0)
            {
                NCLS_APO.SLECECT_APO(Convert.ToInt64( gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["APO_CODE"]).ToString()));
                TXT_DODE.Text = Convert.ToInt64( CLASES.cls_APO.APO_CODE).ToString();
                TXT_NAME.Text = CLASES.cls_APO.APO_CODE.ToString();
                txt_date.Value = Convert.ToDateTime(string.Format(CLASES.cls_APO.APO_DATE,"DD/MM/YYYY"));
                TXT_TIME.Text = string.Format(CLASES.cls_APO.APO_TIME, "HH:MI");
                TXT_NOTE.Text = CLASES.cls_APO.APO_NOTE.ToString();
               TXT_CUST_ID.Text = Convert.ToInt64(CLASES.cls_APO.CUST_ID).ToString();
                TXT_DOC_ID.Text = Convert.ToInt64(CLASES.cls_APO.DOC_ID).ToString();

            }
        }

        private void BTN_CEALE_Click(object sender, EventArgs e)//المسح
        {
            CLEAR_DATA();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {

            if (TXT_DODE.Text != "" && TXT_CUST_NAME.Text != "" && TXT_DOC_NAME.Text != "" && txt_date.Text != "" )
                {
                TimeSpan time = TimeSpan.Parse(TXT_TIME.Text);
                CLASES.cls_APO.APO_TABLE.Insert_APO(Convert.ToInt64(TXT_DODE.Text), Convert.ToDateTime(string.Format(txt_date.Value.ToString(),"YYYY/MM/DD")), TimeSpan.Parse( string.Format(TXT_TIME.Text,"HH:MI")),TXT_NAME.Text,TXT_NOTE.Text,7,Convert.ToInt64(TXT_CUST_ID.Text),Convert.ToInt64(TXT_DOC_ID.Text),CLASES.cls_VIS.VIS_ID);
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

            private void BTN_UPDATE_Click(object sender, EventArgs e)//تعديل
             {
                if (  TXT_CUST_NAME.Text != "" && TXT_DOC_NAME.Text != "" &&TXT_TIME.Text!="")
                {
                    CLASES.cls_APO.APO_TABLE.UpdateAPO(Convert.ToInt64(TXT_DODE.Text), Convert.ToDateTime(string.Format(txt_date.Value.ToString(), "YYYY/MM/DD")), TimeSpan.Parse(string.Format(TXT_TIME.Text, "HH:MI")), TXT_NAME.Text, TXT_NOTE.Text, 7, Convert.ToInt64(TXT_CUST_ID.Text), Convert.ToInt64(TXT_DOC_ID.Text),CLASES.cls_VIS.VIS_ID, CLASES.cls_APO.APO_ID, CLASES.cls_APO.APO_ID);
                    CLEAR_DATA();
                }
                else
                {
                BTN_UPDATE.Enabled = false;

                    MessageBox.Show("يوجد خطأفي التعديل ");
                }
            }
        

        private void BTN_DELETE_Click(object sender, EventArgs e)//الحذف
        {
        
        if (TXT_DODE.Text != "" && TXT_CUST_NAME.Text != "" && TXT_DOC_NAME.Text != "" && txt_date.Text != "")
        {
            CLASES.cls_APO.APO_TABLE.Delete_APO(CLASES.cls_APO.APO_ID);
                    CLEAR_DATA();
                }
                else
                {
                    MessageBox.Show("يوجد خطأفي الحذف");
                }
            }

           
        }
    }
