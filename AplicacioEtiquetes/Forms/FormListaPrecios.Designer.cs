namespace AplicacioEtiquetes.Forms
{
    partial class FormListaPrecios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnImprimirSeleccio = new System.Windows.Forms.Button();
            this.tableMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            this.tableButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.dgvPrecios, 0, 0);
            this.tableMain.Controls.Add(this.tableButtons, 0, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.Padding = new System.Windows.Forms.Padding(20);
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableMain.Size = new System.Drawing.Size(1200, 850);
            this.tableMain.TabIndex = 0;
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrecios.Location = new System.Drawing.Point(23, 23);
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.RowHeadersWidth = 51;
            this.dgvPrecios.RowTemplate.Height = 40;
            this.dgvPrecios.Size = new System.Drawing.Size(1154, 734);
            this.dgvPrecios.TabIndex = 0;
            // 
            // tableButtons
            // 
            this.tableButtons.ColumnCount = 4;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableButtons.Controls.Add(this.btnNuevo, 0, 0);
            this.tableButtons.Controls.Add(this.btnEliminar, 1, 0);
            this.tableButtons.Controls.Add(this.btnImprimir, 2, 0);
            this.tableButtons.Controls.Add(this.btnImprimirSeleccio, 3, 0);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableButtons.Location = new System.Drawing.Point(23, 763);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableButtons.Size = new System.Drawing.Size(1154, 70);
            this.tableButtons.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(282, 64);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "➕ Afegir Preu";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminar.Location = new System.Drawing.Point(291, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(282, 64);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "🗑 Eliminar Seleccionat";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImprimir.Location = new System.Drawing.Point(579, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(282, 64);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "🖨 Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnImprimirSeleccio
            // 
            this.btnImprimirSeleccio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImprimirSeleccio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImprimirSeleccio.Location = new System.Drawing.Point(867, 3);
            this.btnImprimirSeleccio.Name = "btnImprimirSeleccio";
            this.btnImprimirSeleccio.Size = new System.Drawing.Size(284, 64);
            this.btnImprimirSeleccio.TabIndex = 3;
            this.btnImprimirSeleccio.Text = "🖨 Imprimir Selecció";
            this.btnImprimirSeleccio.UseVisualStyleBackColor = true;
            this.btnImprimirSeleccio.Click += new System.EventHandler(this.btnImprimirSeleccio_Click);
            // 
            // FormListaPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.tableMain);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FormListaPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListaPrecios";
            this.tableMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            this.tableButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.DataGridView dgvPrecios;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnImprimirSeleccio;
    }
}