namespace JogoPalavras.WinApp
{
    partial class PalavraUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            teladaColunas = new TableLayoutPanel();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            teladaColunas.SuspendLayout();
            SuspendLayout();
            // 
            // teladaColunas
            // 
            teladaColunas.BackColor = SystemColors.Menu;
            teladaColunas.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            teladaColunas.ColumnCount = 5;
            teladaColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            teladaColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            teladaColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            teladaColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            teladaColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            teladaColunas.Controls.Add(lbl5, 4, 0);
            teladaColunas.Controls.Add(lbl4, 3, 0);
            teladaColunas.Controls.Add(lbl3, 2, 0);
            teladaColunas.Controls.Add(lbl2, 1, 0);
            teladaColunas.Controls.Add(lbl1, 0, 0);
            teladaColunas.Dock = DockStyle.Fill;
            teladaColunas.Location = new Point(0, 0);
            teladaColunas.Name = "teladaColunas";
            teladaColunas.RowCount = 1;
            teladaColunas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            teladaColunas.Size = new Size(333, 47);
            teladaColunas.TabIndex = 0;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Dock = DockStyle.Fill;
            lbl5.Location = new Point(269, 2);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(59, 43);
            lbl5.TabIndex = 4;
            lbl5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Dock = DockStyle.Fill;
            lbl4.Location = new Point(203, 2);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(58, 43);
            lbl4.TabIndex = 3;
            lbl4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Location = new Point(137, 2);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(58, 43);
            lbl3.TabIndex = 2;
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Location = new Point(71, 2);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(58, 43);
            lbl2.TabIndex = 1;
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Location = new Point(5, 2);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(58, 43);
            lbl1.TabIndex = 0;
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PalavraUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(teladaColunas);
            MinimumSize = new Size(333, 47);
            Name = "PalavraUserControl";
            Size = new Size(333, 47);
            teladaColunas.ResumeLayout(false);
            teladaColunas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public TableLayoutPanel teladaColunas;
        private Label lbl5;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
    }
}
