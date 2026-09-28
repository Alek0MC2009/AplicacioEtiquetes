using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Printing;

namespace AplicacioEtiquetes.Forms
{
    public partial class FormVistaPreviaCustom : Form
    {
        private Font fuenteMunson;
        private ImpresorGuillotinaConMarcas impresor;

        // Constructor que recibe únicamente la lista de strings seleccionados
        public FormVistaPreviaCustom(List<string> preciosSeleccionados)
        {
            InitializeComponent();

            fuenteMunson = new Font("Munson", 64f, FontStyle.Bold);

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