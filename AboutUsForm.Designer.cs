namespace FinalCountdown
{
    partial class AboutUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsForm));
            this.infoLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.companyLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(245, 470);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(435, 20);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "This proyect was made by Alvaro escribano and Pablo Chova";
            this.infoLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(14, 15);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(84, 29);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "< Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // companyLogo
            // 
            this.companyLogo.Image = global::FinalCountdown.Properties.Resources.DEPORTE_LOGOS_03;
            this.companyLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("companyLogo.InitialImage")));
            this.companyLogo.Location = new System.Drawing.Point(230, 15);
            this.companyLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.companyLogo.Name = "companyLogo";
            this.companyLogo.Size = new System.Drawing.Size(501, 501);
            this.companyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.companyLogo.TabIndex = 0;
            this.companyLogo.TabStop = false;
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.companyLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AboutUsForm";
            this.Text = "About us";
            this.Load += new System.EventHandler(this.AboutUsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox companyLogo;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button backButton;
    }
}