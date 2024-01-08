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
//            var configuration = new ConfigurationBuilder()
//.SetBasePath(Directory.GetCurrentDirectory())
//.AddJsonFile("appsettings.json")
//.Build();

            //string connectionString = configuration.GetConnectionString("DefaultConnection");
            //string setting1 = configuration["AppSettings:Setting1"];
            //string setting2 = configuration["AppSettings:Setting2"];

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new mainScreen());



        }
    }
}