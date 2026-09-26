using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using Models;

namespace Data
{
    public class PrecioRepository
    {
        private string cadenaConexion = Consts.DB_CONNECTION;

        public List<PrecioItem> ObtenerTodos()
        {
            List<PrecioItem> lista = new List<PrecioItem>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "SELECT Id, Valor, FechaCreacion FROM Precios ORDER BY Id DESC";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conexion))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read()) // Se puede optimizar? si pero aqui no me pagan ni un centimo
                        // Sorry bro
                    {
                        lista.Add(new PrecioItem
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Valor = reader["Valor"].ToString(),
                            FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])
                        }); 

                    }
                }
            }

            return lista;
        }
        public List<string> ObtenerListaSoloTexto()
        {
            List<string> lista = new List<string>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "SELECT Valor FROM Precios ORDER BY Id DESC";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conexion))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(reader["Valor"].ToString());
                    }
                }
            }

            return lista;
        }

        public void Guardar(string valorPrecio)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "INSERT INTO Precios (Valor) VALUES (@valor)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@valor", valorPrecio);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "DELETE FROM Precios WHERE Id = @id";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
