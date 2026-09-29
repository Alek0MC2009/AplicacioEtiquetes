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
            LectorConfig lectorConfig = new LectorConfig();
            lectorConfig.CargarConfiguracion(); // Cargamos todo
            if (!File.Exists(Consts.CONFIG_FILE))
            {
                string contenidoArchivo = "fontSize=36";
                File.Create(Consts.CONFIG_FILE).Close();
                //File.OpenWrite(Consts.CONFIG_FILE);
                File.WriteAllText(Consts.CONFIG_FILE, contenidoArchivo);
            }
            Data.DatabaseInitializer.Inicializar();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormListaPrecios());
        }
    }
}
