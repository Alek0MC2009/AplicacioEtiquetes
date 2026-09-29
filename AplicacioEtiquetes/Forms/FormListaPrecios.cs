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
using Models;

namespace AplicacioEtiquetes.Forms
{
    public partial class FormListaPrecios : Form
    {
        private PrecioRepository repository = new PrecioRepository();
        public FormListaPrecios()
        {
            InitializeComponent();
            ConfigurarGrid();
            CargarPrecios();
        }

        private void ConfigurarGrid()
        {
            dgvPrecios.AutoGenerateColumns = false;
            dgvPrecios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrecios.MultiSelect = false;
            dgvPrecios.AllowUserToAddRows = false;

            dgvPrecios.Columns.Clear();
            dgvPrecios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50,
                Visible = false
            });
            dgvPrecios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Valor",
                HeaderText = "Preu",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void CargarPrecios()
        {
            dgvPrecios.DataSource = repository.ObtenerTodos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using(var formCrear = new FormCrearEtiqueta())
            {
                if(formCrear.ShowDialog() == DialogResult.OK)
                {
                    CargarPrecios(); // recargamos la grid
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvPrecios.SelectedRows.Count > 0)
            {
                var itemSeleccionado = (PrecioItem)dgvPrecios.SelectedRows[0].DataBoundItem;

                var confirmacion = MessageBox.Show(
                    $"Segur que vols eliminar el preu {itemSeleccionado.Valor}?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if(confirmacion == DialogResult.Yes)
                {
                    repository.Eliminar(itemSeleccionado.Id);
                    CargarPrecios(); // Recargamos tras imprimir
                }
                else
                {
                    MessageBox.Show("Selecciona un preu de la llista", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de impresión y mostrarlo
            using (FormImpresion formImp = new FormImpresion())
            {
                formImp.ShowDialog();
            }
        }

        private void btnImprimirSeleccio_Click(object sender, EventArgs e)
        {
            using (FormImprimirCustom formImp = new FormImprimirCustom())
            {
                formImp.ShowDialog();
            }
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            using (FormAcercaDe acercaDe = new FormAcercaDe())
            {
                acercaDe.ShowDialog();  
            }
        }
    }
}
