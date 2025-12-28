using System;
using System.Reflection;

[assembly: AssemblyVersion("0.2.0.0")]
[assembly: AssemblyFileVersion("0.2.0.0")]
[assembly: AssemblyInformationalVersion("0.2.0.0")]

// Información del producto
[assembly: AssemblyProduct("Visor PDF")]
[assembly: AssemblyTitle("Aplicación para visualizar archivos PDF con funcionalidad básica")]
[assembly: AssemblyDescription("Aplicación para visualizar archivos PDF con funcionalidad básica")]
[assembly: AssemblyCopyright("© 2025 Diagram Software Europa")]


namespace VisorPDF
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
            Application.Run(new frmVisorPDF());
        }
    }
}