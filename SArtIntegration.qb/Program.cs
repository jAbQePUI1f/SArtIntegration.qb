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
                ApplicationConfiguration.Initialize();
                Application.Run(new loginScreen());
            }
            else
            {
                MessageBox.Show("Integrator is already running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}