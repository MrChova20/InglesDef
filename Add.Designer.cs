namespace FinalCountdown
{
    partial class Add
    {
        /// <summary>
        /// ojdnijdc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addNameText = new System.Windows.Forms.TextBox();
            this.addIdText = new System.Windows.Forms.TextBox();
            this.addDescriptionText = new System.Windows.Forms.TextBox();
            this.addQuantitytext = new System.Windows.Forms.TextBox();
            this.addPriceText = new System.Windows.Forms.TextBox();
            this.addIdLabel = new System.Windows.Forms.Label();
            this.addDescriptionLabel = new System.Windows.Forms.Label();
            this.addQuantityLabel = new System.Windows.Forms.Label();
            this.addPriceLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNameLabel
            // 
            this.addNameLabel.AutoSize = true;
            this.addNameLabel.Location = new System.Drawing.Point(45, 41);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(35, 13);
            this.addNameLabel.TabIndex = 0;
            this.addNameLabel.Text = "Name";
            // 
            // addNameText
            // 
            this.addNameText.Location = new System.Drawing.Point(209, 38);
            this.addNameText.Name = "addNameText";
            this.addNameText.Size = new System.Drawing.Size(253, 20);
            this.addNameText.TabIndex = 6;
            // 
            // addIdText
            // 
            this.addIdText.Location = new System.Drawing.Point(209, 92);
            this.addIdText.Name = "addIdText";
            this.addIdText.Size = new System.Drawing.Size(253, 20);
            this.addIdText.TabIndex = 7;
            // 
            // addDescriptionText
            // 
            this.addDescriptionText.Location = new System.Drawing.Point(209, 148);
            this.addDescriptionText.Name = "addDescriptionText";
            this.addDescriptionText.Size = new System.Drawing.Size(253, 20);
            this.addDescriptionText.TabIndex = 8;
            // 
            // addQuantitytext
            // 
            this.addQuantitytext.Location = new System.Drawing.Point(209, 203);
            this.addQuantitytext.Name = "addQuantitytext";
            this.addQuantitytext.Size = new System.Drawing.Size(253, 20);
            this.addQuantitytext.TabIndex = 9;
            // 
            // addPriceText
            // 
            this.addPriceText.Location = new System.Drawing.Point(209, 258);
            this.addPriceText.Name = "addPriceText";
            this.addPriceText.Size = new System.Drawing.Size(253, 20);
            this.addPriceText.TabIndex = 10;
            // 
            // addIdLabel
            // 
            this.addIdLabel.AutoSize = true;
            this.addIdLabel.Location = new System.Drawing.Point(45, 95);
            this.addIdLabel.Name = "addIdLabel";
            this.addIdLabel.Size = new System.Drawing.Size(18, 13);
            this.addIdLabel.TabIndex = 11;
            this.addIdLabel.Text = "ID";
            // 
            // addDescriptionLabel
            // 
            this.addDescriptionLabel.AutoSize = true;
            this.addDescriptionLabel.Location = new System.Drawing.Point(45, 151);
            this.addDescriptionLabel.Name = "addDescriptionLabel";
            this.addDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.addDescriptionLabel.TabIndex = 12;
            this.addDescriptionLabel.Text = "Description";
            // 
            // addQuantityLabel
            // 
            this.addQuantityLabel.AutoSize = true;
            this.addQuantityLabel.Location = new System.Drawing.Point(45, 206);
            this.addQuantityLabel.Name = "addQuantityLabel";
            this.addQuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.addQuantityLabel.TabIndex = 13;
            this.addQuantityLabel.Text = "Quantity";
            // 
            // addPriceLabel
            // 
            this.addPriceLabel.AutoSize = true;
            this.addPriceLabel.Location = new System.Drawing.Point(45, 261);
            this.addPriceLabel.Name = "addPriceLabel";
            this.addPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.addPriceLabel.TabIndex = 14;
            this.addPriceLabel.Text = "Price";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(48, 329);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(140, 29);
            this.addProductButton.TabIndex = 15;
            this.addProductButton.Text = "ADD PRODUCT";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.addPriceLabel);
            this.Controls.Add(this.addQuantityLabel);
            this.Controls.Add(this.addDescriptionLabel);
            this.Controls.Add(this.addIdLabel);
            this.Controls.Add(this.addPriceText);
            this.Controls.Add(this.addQuantitytext);
            this.Controls.Add(this.addDescriptionText);
            this.Controls.Add(this.addIdText);
            this.Controls.Add(this.addNameText);
            this.Controls.Add(this.addNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.TextBox addNameText;
        private System.Windows.Forms.TextBox addIdText;
        private System.Windows.Forms.TextBox addDescriptionText;
        private System.Windows.Forms.TextBox addQuantitytext;
        private System.Windows.Forms.TextBox addPriceText;
        private System.Windows.Forms.Label addIdLabel;
        private System.Windows.Forms.Label addDescriptionLabel;
        private System.Windows.Forms.Label addQuantityLabel;
        private System.Windows.Forms.Label addPriceLabel;
        private System.Windows.Forms.Button addProductButton;
    }
}