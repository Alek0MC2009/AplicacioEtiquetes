using System.Collections.Generic;
using System.IO;

namespace Helpers
{
    public class LectorConfig
    {
        private Dictionary<string, string> valores =  new Dictionary<string, string>();

        public void CargarConfiguracion()
        {
            string fileRoute = Consts.CONFIG_FILE;

            if (File.Exists(fileRoute))
            {
                foreach (string linea in File.ReadAllLines(fileRoute))
                {
                    if (string.IsNullOrWhiteSpace(linea) || linea.StartsWith("#")) // Ignoramos comentarios o lineas en blanco
                    {
                        continue;
                    }

                    string[] partes = linea.Split('=');
                    if (partes.Length == 2)
                    {
                        valores[partes[0].Trim()] = partes[1].Trim();
                    }
                }
            }
        }
        
        public string ObtenerValor(string clave, string valorPorDefecto)
        {
            if (valores.ContainsKey(clave))
            {
                return valores[clave];
            }
            return valorPorDefecto;
        }
    }
}