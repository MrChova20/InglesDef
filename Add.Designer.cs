namespace EscribanoChova
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
            this.addManufacturerText = new System.Windows.Forms.TextBox();
            this.addManufacturerLabel = new System.Windows.Forms.Label();
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
            this.addNameText.TextChanged += new System.EventHandler(this.addNameText_TextChanged);
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
            this.addDescriptionText.TextChanged += new System.EventHandler(this.addDescriptionText_TextChanged);
            // 
            // addQuantitytext
            // 
            this.addQuantitytext.Location = new System.Drawing.Point(209, 254);
            this.addQuantitytext.Name = "addQuantitytext";
            this.addQuantitytext.Size = new System.Drawing.Size(253, 20);
            this.addQuantitytext.TabIndex = 9;
            // 
            // addPriceText
            // 
            this.addPriceText.Location = new System.Drawing.Point(209, 320);
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
            this.addQuantityLabel.Location = new System.Drawing.Point(45, 261);
            this.addQuantityLabel.Name = "addQuantityLabel";
            this.addQuantityLabel.Size = new System.Drawing.Size(86, 13);
            this.addQuantityLabel.TabIndex = 13;
            this.addQuantityLabel.Text = "Quantity in stock";
            // 
            // addPriceLabel
            // 
            this.addPriceLabel.AutoSize = true;
            this.addPriceLabel.Location = new System.Drawing.Point(45, 323);
            this.addPriceLabel.Name = "addPriceLabel";
            this.addPriceLabel.Size = new System.Drawing.Size(52, 13);
            this.addPriceLabel.TabIndex = 14;
            this.addPriceLabel.Text = "Price ( € )";
            this.addPriceLabel.Click += new System.EventHandler(this.addPriceLabel_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(48, 382);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(140, 29);
            this.addProductButton.TabIndex = 15;
            this.addProductButton.Text = "ADD PRODUCT";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // addManufacturerText
            // 
            this.addManufacturerText.Location = new System.Drawing.Point(209, 202);
            this.addManufacturerText.Name = "addManufacturerText";
            this.addManufacturerText.Size = new System.Drawing.Size(253, 20);
            this.addManufacturerText.TabIndex = 16;
            this.addManufacturerText.TextChanged += new System.EventHandler(this.addManufacturerText_TextChanged);
            // 
            // addManufacturerLabel
            // 
            this.addManufacturerLabel.AutoSize = true;
            this.addManufacturerLabel.Location = new System.Drawing.Point(45, 202);
            this.addManufacturerLabel.Name = "addManufacturerLabel";
            this.addManufacturerLabel.Size = new System.Drawing.Size(70, 13);
            this.addManufacturerLabel.TabIndex = 17;
            this.addManufacturerLabel.Text = "Manufacturer";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addManufacturerLabel);
            this.Controls.Add(this.addManufacturerText);
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
        private System.Windows.Forms.TextBox addManufacturerText;
        private System.Windows.Forms.Label addManufacturerLabel;
    }
}