using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CLINIC_OMAR_05541456466
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new frm_ADD.frm_CUSTUMAR_ADD());//frm_MED.frm_DIG_MED());
            Application.Run(new frm_USERLOGIN());
        }
    }
}
