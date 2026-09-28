using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data;
using Models;

namespace AplicacioEtiquetes.Forms
{
    public partial class FormImprimirCustom : Form
    {
        private PrecioRepository repository = new PrecioRepository();
        public List<string> PreciosSeleccionados { get; private set; }

        public FormImprimirCustom()
        {
            InitializeComponent();
            PreciosSeleccionados = new List<string>();

            // Ejecutamos la carga directamente en el constructor
            CargarTablaDirecta();
        }

        private void CargarTablaDirecta()
        {
            try
            {
                // 1. Configuramos el DataGridView
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.AllowUserToAddRows = false;

                // 2. Columnas
                dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn { Name = "colCheck", HeaderText = "Sel.", Width = 40 });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "ID", Width = 50 });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colValor", HeaderText = "Preu", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colFecha", HeaderText = "Data", Width = 120 });

                // 3. Cargar datos de la BBDD
                List<PrecioItem> lista = repository.ObtenerTodos();

                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("La consulta devolvió 0 registros desde la BBDD.", "Aviso");
                    return;
                }

                // 4. Agregar filas
                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(false, item.Id, item.Valor, item.FechaCreacion.ToString("dd/MM/yyyy"));
                }

                ActualizarContador();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en CargarTablaDirecta: " + ex.Message);
            }
        }

        private void ActualizarContador()
        {
            int contador = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colCheck"].Value) == true)
                {
                    contador++;
                }
            }

            if (lblSelected != null)
            {
                lblSelected.Text = $"Seleccionat {contador}";
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["colCheck"].Index)
            {
                ActualizarContador();
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["colCheck"].Value = true;
            }
            dataGridView1.EndEdit();
            ActualizarContador();
        }

        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["colCheck"].Value = false;
            }
            dataGridView1.EndEdit();
            ActualizarContador();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            PreciosSeleccionados.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool marcado = Convert.ToBoolean(row.Cells["colCheck"].Value);
                if (marcado)
                {
                    string valor = row.Cells["colValor"].Value?.ToString();
                    if (!string.IsNullOrEmpty(valor))
                    {
                        PreciosSeleccionados.Add(valor);
                    }
                }
            }

            if (PreciosSeleccionados.Count == 0)
            {
                MessageBox.Show("Selecciona almenys un preu per imprimir.", "Avís", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormVistaPreviaCustom formVista = new FormVistaPreviaCustom(PreciosSeleccionados))
            {
                formVista.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}