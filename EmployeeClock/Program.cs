using Microsoft.Extensions.Configuration;

namespace EmployeeClock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Navigator.ShowForm("LoginForm");
            Application.Run();
        }
    }
}