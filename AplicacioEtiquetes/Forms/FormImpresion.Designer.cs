
namespace AplicacioEtiquetes.Forms
{
    partial class FormImpresion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnImprimirAhora
            // 
            this.btnImprimirAhora.Location = new System.Drawing.Point(0, 0);
            this.btnImprimirAhora.Name = "btnImprimirAhora";
            this.btnImprimirAhora.Size = new System.Drawing.Size(797, 57);
            this.btnImprimirAhora.TabIndex = 0;
            this.btnImprimirAhora.Text = "🖨 Confirmar e Imprimir";
            this.btnImprimirAhora.UseVisualStyleBackColor = true;
            this.btnImprimirAhora.Click += new System.EventHandler(this.btnImprimirAhora_Click);
            // 
            // vistaPrevia
            // 
            this.vistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaPrevia.Location = new System.Drawing.Point(0, 60);
            this.vistaPrevia.Name = "vistaPrevia";
            this.vistaPrevia.Size = new System.Drawing.Size(800, 390);
            this.vistaPrevia.TabIndex = 1;
            // 
            // FormImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vistaPrevia);
            this.Controls.Add(this.panel1);
            this.Name = "FormImpresion";
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