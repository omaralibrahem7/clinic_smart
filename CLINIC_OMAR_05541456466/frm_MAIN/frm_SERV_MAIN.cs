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
    public partial class frm_SERV_MAIN : DevExpress.XtraEditors.XtraForm
    {
        public frm_SERV_MAIN()
        {
            InitializeComponent();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_ADD.frm_SERVICE_ADD se = new frm_ADD.frm_SERVICE_ADD();
            se.Show();
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            LIST_FROM.frm_LIST_USER srl = new LIST_FROM.frm_LIST_USER();
            srl.Show();

        }
    }
}