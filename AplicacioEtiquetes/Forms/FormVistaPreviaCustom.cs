using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Printing;
using Helpers;

namespace AplicacioEtiquetes.Forms
{
    public partial class FormVistaPreviaCustom : Form
    {
        private Font fuenteMunson;
        private ImpresorGuillotinaConMarcas impresor;
        private LectorConfig lectorConfig = new LectorConfig();
        

        // Constructor que recibe únicamente la lista de strings seleccionados
        public FormVistaPreviaCustom(List<string> preciosSeleccionados)
        {
            InitializeComponent();
            lectorConfig.CargarConfiguracion();
            string fontSize = lectorConfig.ObtenerValor("fontSize", "36");
            fuenteMunson = new Font("Munson", int.Parse(fontSize), FontStyle.Bold);

            CargarVistaPrevia(preciosSeleccionados);
        }

        private void CargarVistaPrevia(List<string> precios)
        {
            if (precios == null || precios.Count == 0)
            {
                MessageBox.Show("No hay precios para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Usamos la misma clase de impresión pasando solo la lista filtrada
            impresor = new ImpresorGuillotinaConMarcas(precios, fuenteMunson);

            // Asignamos el PrintDocument generado al PrintPreviewControl de esta ventana
            vistaPrevia.Document = impresor.CrearPrintDocument();
        }

        private void btnImprimirAhora_Click_1(object sender, EventArgs e)
        {
            if (impresor != null)
            {
                impresor.LanzarImpresionDirecta();
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}