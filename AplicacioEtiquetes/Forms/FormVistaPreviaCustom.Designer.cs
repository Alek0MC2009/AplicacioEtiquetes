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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnImprimirAhora = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.vistaPrevia = new System.Windows.Forms.PrintPreviewControl();
            this.tableMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.panel1, 0, 0);
            this.tableMain.Controls.Add(this.vistaPrevia, 0, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.Padding = new System.Windows.Forms.Padding(20);
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(1200, 850);
            this.tableMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableButtons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 70);
            this.panel1.TabIndex = 0;
            // 
            // tableButtons
            // 
            this.tableButtons.ColumnCount = 2;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtons.Controls.Add(this.btnImprimirAhora, 0, 0);
            this.tableButtons.Controls.Add(this.btnCancela, 1, 0);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableButtons.Location = new System.Drawing.Point(0, 0);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.Size = new System.Drawing.Size(1154, 70);
            this.tableButtons.TabIndex = 0;
            // 
            // btnImprimirAhora
            // 
            this.btnImprimirAhora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImprimirAhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnImprimirAhora.Location = new System.Drawing.Point(3, 3);
            this.btnImprimirAhora.Name = "btnImprimirAhora";
            this.btnImprimirAhora.Size = new System.Drawing.Size(571, 64);
            this.btnImprimirAhora.TabIndex = 0;
            this.btnImprimirAhora.Text = "🖨 Imprimeix";
            this.btnImprimirAhora.UseVisualStyleBackColor = true;
            this.btnImprimirAhora.Click += new System.EventHandler(this.btnImprimirAhora_Click_1);
            // 
            // btnCancela
            // 
            this.btnCancela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCancela.Location = new System.Drawing.Point(580, 3);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(571, 64);
            this.btnCancela.TabIndex = 1;
            this.btnCancela.Text = "Cancela";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // vistaPrevia
            // 
            this.vistaPrevia.AutoZoom = true;
            this.vistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaPrevia.Location = new System.Drawing.Point(23, 99);
            this.vistaPrevia.Name = "vistaPrevia";
            this.vistaPrevia.Size = new System.Drawing.Size(1154, 728);
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
            this.panel1.ResumeLayout(false);
            this.tableButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.Button btnImprimirAhora;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.PrintPreviewControl vistaPrevia;
    }
}