namespace EscribanoChova
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showDataButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataViewerText
            // 
            this.dataViewerText.Location = new System.Drawing.Point(40, 47);
            this.dataViewerText.Margin = new System.Windows.Forms.Padding(2);
            this.dataViewerText.Multiline = true;
            this.dataViewerText.Name = "dataViewerText";
            this.dataViewerText.Size = new System.Drawing.Size(263, 253);
            this.dataViewerText.TabIndex = 0;
            // 
            // TXTradioButton
            // 
            this.TXTradioButton.AutoSize = true;
            this.TXTradioButton.Location = new System.Drawing.Point(4, 20);
            this.TXTradioButton.Margin = new System.Windows.Forms.Padding(2);
            this.TXTradioButton.Name = "TXTradioButton";
            this.TXTradioButton.Size = new System.Drawing.Size(39, 17);
            this.TXTradioButton.TabIndex = 1;
            this.TXTradioButton.TabStop = true;
            this.TXTradioButton.Text = ".txt";
            this.TXTradioButton.UseVisualStyleBackColor = true;
            this.TXTradioButton.CheckedChanged += new System.EventHandler(this.TXTradioButton_CheckedChanged);
            // 
            // JSONradioButton
            // 
            this.JSONradioButton.AutoSize = true;
            this.JSONradioButton.Location = new System.Drawing.Point(4, 41);
            this.JSONradioButton.Margin = new System.Windows.Forms.Padding(2);
            this.JSONradioButton.Name = "JSONradioButton";
            this.JSONradioButton.Size = new System.Drawing.Size(44, 17);
            this.JSONradioButton.TabIndex = 2;
            this.JSONradioButton.TabStop = true;
            this.JSONradioButton.Text = "json";
            this.JSONradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTradioButton);
            this.groupBox1.Controls.Add(this.JSONradioButton);
            this.groupBox1.Location = new System.Drawing.Point(363, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(106, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // showDataButton
            // 
            this.showDataButton.Location = new System.Drawing.Point(363, 160);
            this.showDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(56, 19);
            this.showDataButton.TabIndex = 6;
            this.showDataButton.Text = "Show";
            this.showDataButton.UseVisualStyleBackColor = true;
            this.showDataButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.showDataButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataViewerText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button showDataButton;
    }
}