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
        private bool mitadAncho = false;

        // Necesitamos guardar los precios en una variable de clase para poder recargar la vista previa
        private List<string> _preciosActuales;

        // Constructor que recibe únicamente la lista de strings seleccionados
        public FormVistaPreviaCustom(List<string> preciosSeleccionados)
        {
            InitializeComponent();
            _preciosActuales = preciosSeleccionados;

            lectorConfig.CargarConfiguracion();
            string fontSize = lectorConfig.ObtenerValor("fontSize", "36");

            // Inicializamos el contador visual
            contadorFontSize.Value = int.Parse(fontSize);

            // Creamos la fuente inicial usando píxeles para que sea predecible
            fuenteMunson = new Font("Munson", int.Parse(fontSize), FontStyle.Bold, GraphicsUnit.Pixel);

            CargarVistaPrevia();
        }

        private void CargarVistaPrevia()
        {
            if (_preciosActuales == null || _preciosActuales.Count == 0)
            {
                MessageBox.Show("No hay precios para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // IMPORTANTE: Pasamos la variable mitadAncho en lugar de false
            impresor = new ImpresorGuillotinaConMarcas(_preciosActuales, fuenteMunson, mitadAncho);

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

        private void contadorFontSize_ValueChanged(object sender, EventArgs e)
        {
            int nuevoTamaño = (int)contadorFontSize.Value;

            // Si está a la mitad, ajustamos el tamaño para que no se salga de la caja pequeña
            int tamañoReal = mitadAncho ? (nuevoTamaño / 2) : nuevoTamaño;
            if (tamañoReal < 1) tamañoReal = 1;

            fuenteMunson = new Font("Munson", tamañoReal, FontStyle.Bold, GraphicsUnit.Pixel);

            // Refrescamos la vista previa
            CargarVistaPrevia();
        }

        private void checkboxMitad_CheckedChanged(object sender, EventArgs e)
        {
            mitadAncho = checkboxMitad.Checked;

            if (mitadAncho)
                contadorFontSize.Value = Consts.FontSizeMitad; // Ajusta este valor si ves que no encaja
            else
                contadorFontSize.Value = Consts.FontSizeNormal;

            CargarVistaPrevia();
        }
    }
}