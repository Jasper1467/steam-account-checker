using System;
using System.Windows.Forms;

namespace SAC
{
    internal static class Program
    {
        public static MainWindow mw = new MainWindow();
        public static ViewThirdPartyLibraries vtPLibWindow = new ViewThirdPartyLibraries();
        public static ViewSoftwareLicense vSLWindow = new ViewSoftwareLicense();

        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mw);
        }
    }
}
