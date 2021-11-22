namespace FinalCountdown
{
    partial class DataViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewer));
            this.dataViewerText = new System.Windows.Forms.TextBox();
            this.TXTradioButton = new System.Windows.Forms.RadioButton();
            this.JSONradioButton = new System.Windows.Forms.RadioButton();
            this.XMLradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showDataButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataViewerText
            // 
            this.dataViewerText.Location = new System.Drawing.Point(53, 58);
            this.dataViewerText.Multiline = true;
            this.dataViewerText.Name = "dataViewerText";
            this.dataViewerText.Size = new System.Drawing.Size(349, 311);
            this.dataViewerText.TabIndex = 0;
            // 
            // TXTradioButton
            // 
            this.TXTradioButton.AutoSize = true;
            this.TXTradioButton.Location = new System.Drawing.Point(6, 24);
            this.TXTradioButton.Name = "TXTradioButton";
            this.TXTradioButton.Size = new System.Drawing.Size(47, 21);
            this.TXTradioButton.TabIndex = 1;
            this.TXTradioButton.TabStop = true;
            this.TXTradioButton.Text = ".txt";
            this.TXTradioButton.UseVisualStyleBackColor = true;
            // 
            // JSONradioButton
            // 
            this.JSONradioButton.AutoSize = true;
            this.JSONradioButton.Location = new System.Drawing.Point(6, 51);
            this.JSONradioButton.Name = "JSONradioButton";
            this.JSONradioButton.Size = new System.Drawing.Size(55, 21);
            this.JSONradioButton.TabIndex = 2;
            this.JSONradioButton.TabStop = true;
            this.JSONradioButton.Text = "json";
            this.JSONradioButton.UseVisualStyleBackColor = true;
            // 
            // XMLradioButton
            // 
            this.XMLradioButton.AutoSize = true;
            this.XMLradioButton.Location = new System.Drawing.Point(6, 78);
            this.XMLradioButton.Name = "XMLradioButton";
            this.XMLradioButton.Size = new System.Drawing.Size(49, 21);
            this.XMLradioButton.TabIndex = 3;
            this.XMLradioButton.TabStop = true;
            this.XMLradioButton.Text = "xml";
            this.XMLradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTradioButton);
            this.groupBox1.Controls.Add(this.XMLradioButton);
            this.groupBox1.Controls.Add(this.JSONradioButton);
            this.groupBox1.Location = new System.Drawing.Point(484, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // showDataButton
            // 
            this.showDataButton.Location = new System.Drawing.Point(484, 197);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(75, 23);
            this.showDataButton.TabIndex = 6;
            this.showDataButton.Text = "Show";
            this.showDataButton.UseVisualStyleBackColor = true;
            this.showDataButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showDataButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataViewerText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataViewer";
            this.Text = "Data Viewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dataViewerText;
        private System.Windows.Forms.RadioButton TXTradioButton;
        private System.Windows.Forms.RadioButton JSONradioButton;
        private System.Windows.Forms.RadioButton XMLradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button showDataButton;
    }
}