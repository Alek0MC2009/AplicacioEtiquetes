using Helpers;
using System;
using System.Data.SQLite;
using System.IO;

namespace Data
{
    // ====================================
    // @author Alejandro Bravo Lingyte || alejandrobravolingyte@gmail.com
    // @version 1.0
    // @date 25/09/2026
    // Clase para inicializar una base de datos simple sqlite
    // ====================================
    public static class DatabaseInitializer
    {
        public static void Inicializar()
        {
            // 1. Extraemos de forma dinámica la carpeta donde debe ir el archivo "precios.db"
            // Cambia al nombre de tu empresa
            string rutaArchivoDb = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Decomontsia", "precios.db");
            string rutaCarpeta = Path.GetDirectoryName(rutaArchivoDb);
            
            // 2. Si la carpeta "Decomontsia" no existe en AppData, la creamos
            if (!string.IsNullOrEmpty(rutaCarpeta) && !Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            // 3. Leemos tu cadena de conexión limpia desde Consts
            string stringConexion = Consts.DB_CONNECTION;

            // 4. Abrimos la conexión. Ahora sí encontrará la carpeta creada
            using(SQLiteConnection conexion = new SQLiteConnection(stringConexion))
            {
                conexion.Open();
                
                string sql = @"
                    CREATE TABLE IF NOT EXISTS Precios(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Valor TEXT NOT NULL,
                        FechaCreacion DATETIME DEFAULT CURRENT_TIMESTAMP
                    )";
                    
                using(SQLiteCommand cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}