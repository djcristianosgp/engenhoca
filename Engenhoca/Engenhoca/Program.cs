using Engenhoca.Classes;
using Engenhoca.Telas;

namespace Engenhoca
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
            new ClsUteis().VerificaPastas();
            new ClsUteis().VerificaArquivos();
            new ClsUteis().Atalho();
            Application.Run(new frmPrincipal());
        }
    }
}