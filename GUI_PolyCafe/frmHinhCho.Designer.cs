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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHinhCho));
            progressBarwelcome = new ProgressBar();
            SuspendLayout();
            // 
            // progressBarwelcome
            // 
            progressBarwelcome.Location = new Point(32, 419);
            progressBarwelcome.Name = "progressBarwelcome";
            progressBarwelcome.Size = new Size(870, 24);
            progressBarwelcome.TabIndex = 0;
            // 
            // frmHinhCho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(929, 455);
            Controls.Add(progressBarwelcome);
            MaximumSize = new Size(945, 494);
            MinimumSize = new Size(945, 494);
            Name = "frmHinhCho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcom to PolyCafe";
            FormClosing += frmHinhCho_FormClosing;
            Load += frmHinhCho_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBarwelcome;
    }
}
