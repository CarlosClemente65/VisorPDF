using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VisorPDF
{
    public static class GestionArchivos
    {
        public static void AbrirArchivo(string rutaArchivo)
        {
            // Lógica para abrir el archivo PDF
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*",
                Title = "Abrir archivo PDF",
                Multiselect = false
            };

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                VisorPDF.frmVisorPDF.rutaArchivoPDF = ofd.FileName;
            }
        }

        
    }
}
