using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
namespace AplicacioEtiquetes.Forms
{
    public partial class FormCrearEtiqueta : Form
    {
        private PrecioRepository precioRepository = new PrecioRepository();
        public FormCrearEtiqueta()
        {
            InitializeComponent();
        }

        private void FormCrearEtiqueta_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string precioTexto = txtPrecio.Text.Trim(); 

            if(string.IsNullOrEmpty(precioTexto))
            {
                MessageBox.Show("Perfavor, Ingreseu un preu vàlid", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!precioTexto.EndsWith("€"))
            {
                precioTexto += "€";
            }

            precioRepository.Guardar(precioTexto);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
