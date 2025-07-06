using games;
using pet;
using System.Security.Cryptography.X509Certificates;

namespace losos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}