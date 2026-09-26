using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PrecioItem
    {
        public int Id { get; set; }
        public string Valor { get; set; }
        public DateTime FechaCreacion { get; set; } 

        public PrecioItem()
        {
            Valor = string.Empty;
            FechaCreacion = DateTime.Now;
        }

    }
}
