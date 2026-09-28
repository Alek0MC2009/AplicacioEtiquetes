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
            this.btnImprimirAhora = new System.Windows.Forms.Button();
            this.vistaPrevia = new System.Windows.Forms.PrintPreviewControl();
            this.panel1.SuspendLayout();
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
            this.vistaPrevia.AutoZoom = true;
            this.vistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaPrevia.Location = new System.Drawing.Point(0, 110);
            this.vistaPrevia.Name = "vistaPrevia";
            this.vistaPrevia.Size = new System.Drawing.Size(1200, 740);
            this.vistaPrevia.TabIndex = 1;
            // 
            // FormImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.vistaPrevia);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "FormImpresion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormImpresion";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImprimirAhora;
        private System.Windows.Forms.PrintPreviewControl vistaPrevia;
    }
}