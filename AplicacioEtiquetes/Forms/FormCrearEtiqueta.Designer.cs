namespace AplicacioEtiquetes.Forms
{
    partial class FormCrearEtiqueta
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableCenter = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableMain.SuspendLayout();
            this.tableCenter.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.label1, 0, 0);
            this.tableMain.Controls.Add(this.tableCenter, 0, 1);
            this.tableMain.Controls.Add(this.tableButtons, 0, 2);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.Padding = new System.Windows.Forms.Padding(40);
            this.tableMain.RowCount = 3;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableMain.Size = new System.Drawing.Size(1100, 700);
            this.tableMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1014, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crea una etiqueta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableCenter
            // 
            this.tableCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableCenter.AutoSize = true;
            this.tableCenter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableCenter.ColumnCount = 2;
            this.tableCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableCenter.Controls.Add(this.lblPrecio, 0, 0);
            this.tableCenter.Controls.Add(this.txtPrecio, 1, 0);
            this.tableCenter.Location = new System.Drawing.Point(250, 290);
            this.tableCenter.Name = "tableCenter";
            this.tableCenter.RowCount = 1;
            this.tableCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableCenter.Size = new System.Drawing.Size(600, 55);
            this.tableCenter.TabIndex = 1;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblPrecio.Location = new System.Drawing.Point(3, 12);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(76, 36);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Preu:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtPrecio.Location = new System.Drawing.Point(97, 3);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(500, 41);
            this.txtPrecio.TabIndex = 1;
            // 
            // tableButtons
            // 
            this.tableButtons.ColumnCount = 2;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtons.Controls.Add(this.btnAceptar, 0, 0);
            this.tableButtons.Controls.Add(this.btnCancelar, 1, 0);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableButtons.Location = new System.Drawing.Point(43, 590);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableButtons.Size = new System.Drawing.Size(1014, 70);
            this.tableButtons.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(3, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(501, 64);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Crear Etiqueta";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCancelar.Location = new System.Drawing.Point(510, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(501, 64);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Tornar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCrearEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tableMain);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormCrearEtiqueta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCrearEtiqueta";
            this.Load += new System.EventHandler(this.FormCrearEtiqueta_Load);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.tableCenter.ResumeLayout(false);
            this.tableCenter.PerformLayout();
            this.tableButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableCenter;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}