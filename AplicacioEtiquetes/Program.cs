using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacioEtiquetes.Forms;
using Helpers;
namespace AplicacioEtiquetes
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
             * Arreglado el bug de crasheos xq no existia la carpeta
             */
            string directorio = Path.GetDirectoryName(Consts.CONFIG_FILE);
            if (!string.IsNullOrEmpty(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

// 2. Si el archivo no existe, lo creamos con su contenido por defecto
            if (!File.Exists(Consts.CONFIG_FILE))
            {
                string contenidoArchivo = "fontSize=36";
                File.WriteAllText(Consts.CONFIG_FILE, contenidoArchivo);
            }

// 3. Ahora sí, cargamos la configuración de forma segura
            LectorConfig lectorConfig = new LectorConfig();
            lectorConfig.CargarConfiguracion();
            Data.DatabaseInitializer.Inicializar();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormListaPrecios());
        }
    }
}
