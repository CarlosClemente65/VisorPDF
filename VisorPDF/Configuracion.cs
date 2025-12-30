using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VisorPDF
{
    public static class Configuracion
    {
        public static ParametrosVisor ParametrosVisor { get; set; } = new ParametrosVisor();
        public static ParametrosGenerales ParametrosGenerales { get; set; } = new ParametrosGenerales();

        private static string rutaConfiguracion = "configuracion.json";

        public static readonly string[] ValoresZoom =
        {
            "200 %",
            "175 %",
            "150 %",
            "125 %",
            "100 %",
            "75 %",
            "50 %",
            "25 %"
        };

        private class DatosConfiguracion
        {
            public ParametrosVisor ParametrosVisor { get; set; }
            public ParametrosGenerales ParametrosGenerales { get; set; }
        }

        public static void CargarConfiguracion()
        {
            if(File.Exists(rutaConfiguracion))
            {
                // Cargar configuración desde el archivo JSON
                string json = File.ReadAllText(rutaConfiguracion);
                try
                {
                    // Deserializar los datos de configuración
                    var datos = JsonSerializer.Deserialize<DatosConfiguracion>(json);

                    if(datos != null)
                    {
                        ParametrosVisor = datos.ParametrosVisor;
                        ParametrosGenerales = datos.ParametrosGenerales;
                    }
                }

                catch
                {
                    // Si hay errores en el archivo JSON, se usan los valores por defecto
                    AsignarValoresDefecto();
                }
            }
            else
            {
                // No existe el archivo JSON, se usan los valores por defecto
                AsignarValoresDefecto();
                GuardarConfiguracion();
            }
        }

        private static void AsignarValoresDefecto()
        {
            int anchoPantalla = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            ParametrosVisor.PosicionX = anchoPantalla - ParametrosVisor.Ancho;
            ParametrosVisor.PosicionY = 0;
            ParametrosVisor.PosicionFormulario = FormStartPosition.Manual;
        }

        public static void GuardarConfiguracion()
        {
            var datosconfiguracion = new DatosConfiguracion
            {
                ParametrosVisor = ParametrosVisor,
                ParametrosGenerales = ParametrosGenerales
            };

            string json = JsonSerializer.Serialize(datosconfiguracion, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(rutaConfiguracion, json);
        }

        public static void ActualizarPosicionVentana(int x, int y, int ancho, int alto)
        {
            ParametrosVisor.PosicionX = x;
            ParametrosVisor.PosicionY = y;
            ParametrosVisor.Ancho = ancho;
            ParametrosVisor.Alto = alto;
            GuardarConfiguracion();
        }
    }


    public class ParametrosVisor
    {
        // Ubicacion de la ventana
        public int PosicionX { get; set; } = 0;
        public int PosicionY { get; set; } = 0;
        public int Ancho { get; set; } = 500;
        public int Alto { get; set; } = 600;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FormStartPosition PosicionFormulario { get; set; } = FormStartPosition.Manual;

        // Datos del zoom
        public int NivelZoom { get; set; } = 100;
    }

    public class ParametrosGenerales
    {
        public bool FijarVentana { get; set; } = false;
        public bool RutaPDFCompleta { get; set; } = false;
    }
}


