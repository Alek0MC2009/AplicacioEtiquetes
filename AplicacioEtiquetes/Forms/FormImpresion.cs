using Data;
using Printing;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacioEtiquetes.Forms
{
    public partial class FormImpresion : Form
    {
        private PrecioRepository repository = new PrecioRepository();
        private Font fuenteMunson;
        private ImpresorGuillotinaConMarcas impresor;
        public FormImpresion()
        {
            InitializeComponent();
            fuenteMunson = new Font("Munson", 64f, FontStyle.Bold);

            CargarVistaPrevia(); // Cargamos el documento a imprimir
        }

        private void CargarVistaPrevia()
        {
            List<string> precios = repository.ObtenerListaSoloTexto();

            if (precios.Count == 0)
            {
                MessageBox.Show("No hay precios a imprimir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            impresor = new ImpresorGuillotinaConMarcas(precios, fuenteMunson);
            vistaPrevia.Document = impresor.CrearPrintDocument();
        }

        private void btnImprimirAhora_Click(object sender, EventArgs e)
        {
            if (impresor != null)
            {
                impresor.LanzarImpresionDirecta();
            }
        }
    }
}
