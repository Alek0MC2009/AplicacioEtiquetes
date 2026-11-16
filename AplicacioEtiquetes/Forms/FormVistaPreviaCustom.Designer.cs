namespace AplicacioEtiquetes.Forms
{
    partial class FormVistaPreviaCustom
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
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnImprimirAhora = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.panelOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.contadorFontSize = new System.Windows.Forms.NumericUpDown();
            this.checkboxMitad = new System.Windows.Forms.CheckBox();
            this.vistaPrevia = new System.Windows.Forms.PrintPreviewControl();
            this.tableMain.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contadorFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.tableButtons, 0, 0);
            this.tableMain.Controls.Add(this.vistaPrevia, 0, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.Padding = new System.Windows.Forms.Padding(10);
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(1200, 850);
            this.tableMain.TabIndex = 0;
            // 
            // tableButtons
            // 
            this.tableButtons.ColumnCount = 3;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableButtons.Controls.Add(this.btnImprimirAhora, 0, 0);
            this.tableButtons.Controls.Add(this.btnCancela, 1, 0);
            this.tableButtons.Controls.Add(this.panelOpciones, 2, 0);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableButtons.Location = new System.Drawing.Point(13, 13);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.Size = new System.Drawing.Size(1174, 54);
            this.tableButtons.TabIndex = 0;
            // 
            // btnImprimirAhora
            // 
            this.btnImprimirAhora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImprimirAhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnImprimirAhora.Location = new System.Drawing.Point(3, 3);
            this.btnImprimirAhora.Name = "btnImprimirAhora";
            this.btnImprimirAhora.Size = new System.Drawing.Size(385, 48);
            this.btnImprimirAhora.TabIndex = 0;
            this.btnImprimirAhora.Text = "🖨 Imprimeix";
            this.btnImprimirAhora.UseVisualStyleBackColor = true;
            this.btnImprimirAhora.Click += new System.EventHandler(this.btnImprimirAhora_Click_1);
            // 
            // btnCancela
            // 
            this.btnCancela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancela.Location = new System.Drawing.Point(394, 3);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(385, 48);
            this.btnCancela.TabIndex = 1;
            this.btnCancela.Text = "Cancela";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.lblFontSize);
            this.panelOpciones.Controls.Add(this.contadorFontSize);
            this.panelOpciones.Controls.Add(this.checkboxMitad);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(785, 3);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Padding = new System.Windows.Forms.Padding(5);
            this.panelOpciones.Size = new System.Drawing.Size(386, 48);
            this.panelOpciones.TabIndex = 2;
            this.panelOpciones.WrapContents = false;
            // 
            // lblFontSize
            // 
            this.lblFontSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(8, 10);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(126, 17);
            this.lblFontSize.TabIndex = 0;
            this.lblFontSize.Text = "Tamany de la Font";
            // 
            // contadorFontSize
            // 
            this.contadorFontSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.contadorFontSize.Location = new System.Drawing.Point(140, 8);
            this.contadorFontSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.contadorFontSize.Name = "contadorFontSize";
            this.contadorFontSize.Size = new System.Drawing.Size(60, 22);
            this.contadorFontSize.TabIndex = 1;
            this.contadorFontSize.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.contadorFontSize.ValueChanged += new System.EventHandler(this.contadorFontSize_ValueChanged);
            // 
            // checkboxMitad
            // 
            this.checkboxMitad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkboxMitad.AutoSize = true;
            this.checkboxMitad.Location = new System.Drawing.Point(206, 8);
            this.checkboxMitad.Name = "checkboxMitad";
            this.checkboxMitad.Size = new System.Drawing.Size(165, 21);
            this.checkboxMitad.TabIndex = 2;
            this.checkboxMitad.Text = "Reduir 1 / 2 l\'etiqueta";
            this.checkboxMitad.UseVisualStyleBackColor = true;
            this.checkboxMitad.CheckedChanged += new System.EventHandler(this.checkboxMitad_CheckedChanged);
            // 
            // vistaPrevia
            // 
            this.vistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaPrevia.Location = new System.Drawing.Point(13, 73);
            this.vistaPrevia.Name = "vistaPrevia";
            this.vistaPrevia.Size = new System.Drawing.Size(1174, 764);
            this.vistaPrevia.TabIndex = 1;
            // 
            // FormVistaPreviaCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.tableMain);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "FormVistaPreviaCustom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVistaPreviaCustom";
            this.tableMain.ResumeLayout(false);
            this.tableButtons.ResumeLayout(false);
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contadorFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.Button btnImprimirAhora;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.PrintPreviewControl vistaPrevia;

        // Nuevos controles
        private System.Windows.Forms.FlowLayoutPanel panelOpciones;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.NumericUpDown contadorFontSize;
        private System.Windows.Forms.CheckBox checkboxMitad;
    }
}