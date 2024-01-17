using Microsoft.Extensions.Configuration;

namespace SArtIntegration.qb
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool openedApp = false;
            Mutex m = new Mutex(true, "PacketService", out openedApp);
            if (openedApp)
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new loginScreen());
            }
            else
            {
                MessageBox.Show("Invoice Integrator zaten çalýþýyor!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}