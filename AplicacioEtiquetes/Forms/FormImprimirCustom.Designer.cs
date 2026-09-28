namespace AplicacioEtiquetes.Forms
{
    partial class FormImprimirCustom
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
            this.tableTopButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableBottomButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tableMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableTopButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableBottomButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.panel1, 0, 0);
            this.tableMain.Controls.Add(this.lblSelected, 0, 1);
            this.tableMain.Controls.Add(this.dataGridView1, 0, 2);
            this.tableMain.Controls.Add(this.panel2, 0, 3);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.Padding = new System.Windows.Forms.Padding(20);
            this.tableMain.RowCount = 4;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableMain.Size = new System.Drawing.Size(1200, 850);
            this.tableMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableTopButtons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 70);
            this.panel1.TabIndex = 0;
            // 
            // tableTopButtons
            // 
            this.tableTopButtons.ColumnCount = 2;
            this.tableTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTopButtons.Controls.Add(this.btnSelectAll, 0, 0);
            this.tableTopButtons.Controls.Add(this.btnUnselectAll, 1, 0);
            this.tableTopButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTopButtons.Location = new System.Drawing.Point(0, 0);
            this.tableTopButtons.Name = "tableTopButtons";
            this.tableTopButtons.RowCount = 1;
            this.tableTopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTopButtons.Size = new System.Drawing.Size(1154, 70);
            this.tableTopButtons.TabIndex = 0;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelectAll.Location = new System.Drawing.Point(3, 3);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(571, 64);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.Text = "Selecciona Tot";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnselectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUnselectAll.Location = new System.Drawing.Point(580, 3);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(571, 64);
            this.btnUnselectAll.TabIndex = 1;
            this.btnUnselectAll.Text = "Deselecciona Tot";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            this.btnUnselectAll.Click += new System.EventHandler(this.btnUnselectAll_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblSelected.Location = new System.Drawing.Point(23, 96);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblSelected.Size = new System.Drawing.Size(1154, 44);
            this.lblSelected.TabIndex = 1;
            this.lblSelected.Text = "Seleccionat 0";
            this.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(23, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 614);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableBottomButtons);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(23, 763);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 64);
            this.panel2.TabIndex = 3;
            // 
            // tableBottomButtons
            // 
            this.tableBottomButtons.ColumnCount = 2;
            this.tableBottomButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBottomButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBottomButtons.Controls.Add(this.btnCancel, 0, 0);
            this.tableBottomButtons.Controls.Add(this.btnPrint, 1, 0);
            this.tableBottomButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBottomButtons.Location = new System.Drawing.Point(0, 0);
            this.tableBottomButtons.Name = "tableBottomButtons";
            this.tableBottomButtons.RowCount = 1;
            this.tableBottomButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBottomButtons.Size = new System.Drawing.Size(1154, 64);
            this.tableBottomButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(571, 58);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancela";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(580, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(571, 58);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "🖨 Imprimeix";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormImprimirCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.tableMain);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "FormImprimirCustom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormImprimirCustom";
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableTopButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableBottomButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableTopButtons;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableBottomButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
    }
}