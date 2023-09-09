using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLINIC_OMAR_05541456466.frm_MAIN
{
    public partial class frm_MAIN : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_MAIN()
        {
            InitializeComponent();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_DOC_MAIN fdm = new frm_DOC_MAIN();
            fdm.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(fdm);
            fdm.FormBorderStyle =FormBorderStyle.None;
            fdm.Dock = DockStyle.Fill;
            fdm.Show();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_CILIC_MAIN fdm = new frm_CILIC_MAIN();
            fdm.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(fdm);
            fdm.FormBorderStyle = FormBorderStyle.None;
            fdm.Dock = DockStyle.Fill;
            fdm.Show();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            //fluentDesignFormContainer1.Controls.Clear();
           CLASES.frm_CUST_RESP_ADD fdm = new CLASES.frm_CUST_RESP_ADD();
            //fdm.TopLevel = false;
            //fluentDesignFormContainer1.Controls.Add(fdm);
            //fdm.FormBorderStyle = FormBorderStyle.None;
            //fdm.Dock = DockStyle.Fill;
            fdm.Show();
        }

        private void ا_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
           frm_ADD.frm_VIS_ADD fdm = new frm_ADD.frm_VIS_ADD();
            fdm.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(fdm);
            fdm.FormBorderStyle = FormBorderStyle.None;
            fdm.Dock = DockStyle.Fill;
            fdm.Show();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_SERV_MAIN fdm = new frm_SERV_MAIN();
            fdm.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(fdm);
            fdm.FormBorderStyle = FormBorderStyle.None;
            fdm.Dock = DockStyle.Fill;
            fdm.Show();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_MED_MAIN fdm = new frm_MED_MAIN();
            fdm.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(fdm);
            fdm.FormBorderStyle = FormBorderStyle.None;
            fdm.Dock = DockStyle.Fill;
            fdm.Show();
        }
    }
}
