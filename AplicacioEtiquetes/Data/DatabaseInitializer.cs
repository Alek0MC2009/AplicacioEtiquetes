using Helpers;
using System;
using System.Data.SQLite;
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
        private static string stringConexion = Consts.DB_CONNECTION;

        public static void Inicializar()
        {
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
