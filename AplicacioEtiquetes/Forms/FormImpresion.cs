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
using Helpers;

namespace AplicacioEtiquetes.Forms
{
    public partial class FormImpresion : Form
    {
        private PrecioRepository repository = new PrecioRepository();
        private Font fuenteMunson;
        private ImpresorGuillotinaConMarcas impresor;
        private LectorConfig _lectorConfig = new LectorConfig();
        private bool mitadAncho = false;
        public FormImpresion()
        {
            InitializeComponent();
            _lectorConfig.CargarConfiguracion();
            string fontSize = _lectorConfig.ObtenerValor("fontSize", "36");
            contadorFontSize.Minimum = 6;
            contadorFontSize.Maximum = 100;
            contadorFontSize.Value = int.Parse(fontSize);
            fuenteMunson = new Font("Munson", int.Parse(fontSize), FontStyle.Bold);
            checkboxMitad.Checked = mitadAncho;
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

            impresor = new ImpresorGuillotinaConMarcas(precios, fuenteMunson, mitadAncho);
            vistaPrevia.Document = impresor.CrearPrintDocument();
        }

        private void btnImprimirAhora_Click(object sender, EventArgs e)
        {
            if (impresor != null)
            {
                impresor.LanzarImpresionDirecta();
            }
        }

        private void contadorFontSize_ValueChanged(object sender, EventArgs e)
        {
            // La fuente va directa, sin dividir. Si el usuario quiere que quepa, baja el número.
            int newSize = (int)contadorFontSize.Value;

            // Usamos GraphicsUnit.Pixel para que sea predecible (como hablamos antes)
            fuenteMunson = new Font("Munson", newSize, FontStyle.Bold, GraphicsUnit.Pixel);
            CargarVistaPrevia();
        }

        private void checkboxMitad_CheckedChanged(object sender, EventArgs e)
        {
            mitadAncho = checkboxMitad.Checked;

            // Ilogicamente este lenguaje hace cosas raras con la fuente xdd
            if (mitadAncho)
            {
                contadorFontSize.Value = Consts.FontSizeMitad;
                // Ya he encontrado la lgoica a q mas grande haga q se vea mas pequeño
                // Es todo culpa de gaster
                // Creo qie trabajar aqui esta haciendo q me vuelva loco
                // Seguro que las focas no me harian esto
            }
            else
            {
                contadorFontSize.Value = Consts.FontSizeNormal;
            }

            CargarVistaPrevia();
        }
    }
}
