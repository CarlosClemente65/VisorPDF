using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisorPDF
{
    public static class GestionEnvios
    {
        public static void EnvioEmail()
        {
            // TODO : Implementar el envío de correo con el archivo PDF adjunto
            //if(string.IsNullOrEmpty(rutaArchivoPDF))
            //    return;

            //if (!File.Exists(rutaArchivoPDF))
            //    return;

            //string asunto = Uri.EscapeDataString("Envio documento PDF");
            //string cuerpo = Uri.EscapeDataString("Adjunto el archivo PDF.");
            //string mailto = $"mailto:?subject={asunto}&body={cuerpo}&attachment=\"{rutaArchivoPDF}\"";

            //ProcessStartInfo psi = new ProcessStartInfo
            //{
            //    FileName = mailto,
            //    UseShellExecute = true
            //};

            //Process.Start(psi);

            MessageBox.Show("Funcionalidad de envío de correo no implementada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ImprimirPDF()
        {
            // TODO : Implementar la impresión del archivo PDF
            MessageBox.Show("Funcionalidad de impresión no implementada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
