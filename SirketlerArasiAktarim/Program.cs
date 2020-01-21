using System;
using System.Windows.Forms;

namespace SirketlerArasiAktarim
{
    static class Program
    {
        public static object BonusSkins { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            DevExpress.UserSkins.BonusSkins.Register();
            
            Application.Run(new frmAnaForm());
        }
    }
}
