namespace GUI_PolyCafe
{
    partial class frmHinhCho
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHinhCho));
            progressBarwelcome = new Guna.UI2.WinForms.Guna2ProgressBar();
            SuspendLayout();
            // 
            // progressBarwelcome
            // 
            progressBarwelcome.BackColor = Color.Transparent;
            progressBarwelcome.CustomizableEdges = customizableEdges1;
            progressBarwelcome.Location = new Point(12, 440);
            progressBarwelcome.Name = "progressBarwelcome";
            progressBarwelcome.ShadowDecoration.CustomizableEdges = customizableEdges2;
            progressBarwelcome.Size = new Size(936, 21);
            progressBarwelcome.TabIndex = 0;
            progressBarwelcome.Text = "guna2ProgressBar1";
            progressBarwelcome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            progressBarwelcome.UseTransparentBackground = true;
            // 
            // frmHinhCho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 473);
            ControlBox = false;
            Controls.Add(progressBarwelcome);
            Name = "frmHinhCho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcom to PolyCafe";
            FormClosing += frmHinhCho_FormClosing;
            Load += frmHinhCho_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar progressBarwelcome;
    }
}
