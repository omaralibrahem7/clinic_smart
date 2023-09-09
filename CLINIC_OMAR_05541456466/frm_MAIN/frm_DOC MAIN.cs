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

namespace CLINIC_OMAR_05541456466.frm_MAIN
{
    public partial class frm_DOC_MAIN : DevExpress.XtraEditors.XtraForm
    {
        public frm_DOC_MAIN()
        {
            InitializeComponent();
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            LIST_FROM.frm_LIST_DOC FLD = new LIST_FROM.frm_LIST_DOC();
            FLD.Show();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_ADD.frm_ADD_DOCTOR FDD = new frm_ADD.frm_ADD_DOCTOR();
            FDD.Show();
        }
    }
}