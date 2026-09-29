using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Helpers
{
    public static class Consts
    {
        public const int FontSize = 36;
        // Here you can change the name on AppData, default is Decomontsià.
        public static readonly string DB_CONNECTION = $"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Decomontsia", "precios.db")};Version=3;";
        public static readonly string CONFIG_FILE = $"{Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Decomontsia", "config.dcm")}";

    }
}
