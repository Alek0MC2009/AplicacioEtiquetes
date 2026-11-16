namespace AplicacioEtiquetes.Forms
{
    partial class FormImpresion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.contadorFontSize = new System.Windows.Forms.NumericUpDown();
            this.btnImprimirAhora = new System.Windows.Forms.Button();
            this.vistaPrevia = new System.Windows.Forms.PrintPreviewControl();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkboxMitad = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contadorFontSize)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImprimirAhora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1200, 110);
            this.panel1.TabIndex = 0;
            // 
            // contadorFontSize
            // 
            this.contadorFontSize.Location = new System.Drawing.Point(135, 3);
            this.contadorFontSize.Name = "contadorFontSize";
            this.contadorFontSize.Size = new System.Drawing.Size(57, 22);
            this.contadorFontSize.TabIndex = 1;
            this.contadorFontSize.ValueChanged += new System.EventHandler(this.contadorFontSize_ValueChanged);
            // 
            // btnImprimirAhora
            // 
            this.btnImprimirAhora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImprimirAhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnImprimirAhora.Location = new System.Drawing.Point(20, 20);
            this.btnImprimirAhora.Name = "btnImprimirAhora";
            this.btnImprimirAhora.Size = new System.Drawing.Size(1160, 70);
            this.btnImprimirAhora.TabIndex = 0;
            this.btnImprimirAhora.Text = "🖨 Confirmar e Imprimir";
            this.btnImprimirAhora.UseVisualStyleBackColor = true;
            this.btnImprimirAhora.Click += new System.EventHandler(this.btnImprimirAhora_Click);
            // 
            // vistaPrevia
            // 
            this.vistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaPrevia.Location = new System.Drawing.Point(0, 110);
            this.vistaPrevia.Name = "vistaPrevia";
            this.vistaPrevia.Size = new System.Drawing.Size(1200, 740);
            this.vistaPrevia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamany de la Font";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkboxMitad
            // 
            this.checkboxMitad.AutoSize = true;
            this.checkboxMitad.Location = new System.Drawing.Point(3, 31);
            this.checkboxMitad.Name = "checkboxMitad";
            this.checkboxMitad.Size = new System.Drawing.Size(202, 21);
            this.checkboxMitad.TabIndex = 4;
            this.checkboxMitad.Text = "Reduir a la meitat l\'etiqueta";
            this.checkboxMitad.UseVisualStyleBackColor = true;
            this.checkboxMitad.CheckedChanged += new System.EventHandler(this.checkboxMitad_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.contadorFontSize);
            this.flowLayoutPanel1.Controls.Add(this.checkboxMitad);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1000, 110);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 740);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // FormImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.vistaPrevia);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "FormImpresion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormImpresion";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contadorFontSize)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImprimirAhora;
        private System.Windows.Forms.PrintPreviewControl vistaPrevia;
        private System.Windows.Forms.NumericUpDown contadorFontSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkboxMitad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}