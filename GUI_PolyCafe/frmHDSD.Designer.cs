namespace GUI_PolyCafe
{
    partial class frmHDSD
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
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtHuongDan = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.Anchor = AnchorStyles.None;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.Highlight;
            guna2HtmlLabel1.Location = new Point(434, 21);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(303, 39);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "HƯỚNG DẪN SỬ DỤNG";
            // 
            // txtHuongDan
            // 
            txtHuongDan.Location = new Point(12, 92);
            txtHuongDan.Name = "txtHuongDan";
            txtHuongDan.Size = new Size(1172, 457);
            txtHuongDan.TabIndex = 1;
            txtHuongDan.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(guna2HtmlLabel1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1172, 82);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // frmHDSD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1196, 554);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtHuongDan);
            Name = "frmHDSD";
            Text = "frmHDSD";
            Load += frmHDSD_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private RichTextBox txtHuongDan;
        private TableLayoutPanel tableLayoutPanel1;
    }
}