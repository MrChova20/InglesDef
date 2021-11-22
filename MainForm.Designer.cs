namespace FinalCountdown
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.modifyButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.itemList = new System.Windows.Forms.ListBox();
            this.aboutUsButton = new System.Windows.Forms.Button();
            this.discountText = new System.Windows.Forms.TextBox();
            this.ampersand1 = new System.Windows.Forms.Label();
            this.applyDiscountButton = new System.Windows.Forms.Button();
            this.raisePriceText = new System.Windows.Forms.TextBox();
            this.ampersand2 = new System.Windows.Forms.Label();
            this.raisePricesButton = new System.Windows.Forms.Button();
            this.dataViewerButton = new System.Windows.Forms.Button();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(426, 481);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(187, 36);
            this.modifyButton.TabIndex = 26;
            this.modifyButton.Text = "MODIFY INFORMATION";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(22, 481);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(187, 36);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(229, 481);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(189, 36);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.ItemHeight = 16;
            this.itemList.Location = new System.Drawing.Point(22, 91);
            this.itemList.Margin = new System.Windows.Forms.Padding(4);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(591, 324);
            this.itemList.TabIndex = 17;
            // 
            // aboutUsButton
            // 
            this.aboutUsButton.Location = new System.Drawing.Point(877, 525);
            this.aboutUsButton.Name = "aboutUsButton";
            this.aboutUsButton.Size = new System.Drawing.Size(120, 23);
            this.aboutUsButton.TabIndex = 28;
            this.aboutUsButton.Text = "ABOUT US";
            this.aboutUsButton.UseVisualStyleBackColor = true;
            this.aboutUsButton.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // discountText
            // 
            this.discountText.Location = new System.Drawing.Point(877, 91);
            this.discountText.Name = "discountText";
            this.discountText.Size = new System.Drawing.Size(70, 22);
            this.discountText.TabIndex = 29;
            // 
            // ampersand1
            // 
            this.ampersand1.AutoSize = true;
            this.ampersand1.Location = new System.Drawing.Point(954, 91);
            this.ampersand1.Name = "ampersand1";
            this.ampersand1.Size = new System.Drawing.Size(20, 17);
            this.ampersand1.TabIndex = 30;
            this.ampersand1.Text = "%";
            // 
            // applyDiscountButton
            // 
            this.applyDiscountButton.Location = new System.Drawing.Point(756, 86);
            this.applyDiscountButton.Name = "applyDiscountButton";
            this.applyDiscountButton.Size = new System.Drawing.Size(115, 27);
            this.applyDiscountButton.TabIndex = 31;
            this.applyDiscountButton.Text = "Apply Discount";
            this.applyDiscountButton.UseVisualStyleBackColor = true;
            this.applyDiscountButton.Click += new System.EventHandler(this.Button5_Click);
            // 
            // raisePriceText
            // 
            this.raisePriceText.Location = new System.Drawing.Point(877, 120);
            this.raisePriceText.Name = "raisePriceText";
            this.raisePriceText.Size = new System.Drawing.Size(70, 22);
            this.raisePriceText.TabIndex = 32;
            // 
            // ampersand2
            // 
            this.ampersand2.AutoSize = true;
            this.ampersand2.Location = new System.Drawing.Point(954, 120);
            this.ampersand2.Name = "ampersand2";
            this.ampersand2.Size = new System.Drawing.Size(20, 17);
            this.ampersand2.TabIndex = 33;
            this.ampersand2.Text = "%";
            // 
            // raisePricesButton
            // 
            this.raisePricesButton.Location = new System.Drawing.Point(756, 117);
            this.raisePricesButton.Name = "raisePricesButton";
            this.raisePricesButton.Size = new System.Drawing.Size(115, 25);
            this.raisePricesButton.TabIndex = 34;
            this.raisePricesButton.Text = "Raise prices";
            this.raisePricesButton.UseVisualStyleBackColor = true;
            this.raisePricesButton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // dataViewerButton
            // 
            this.dataViewerButton.Location = new System.Drawing.Point(756, 269);
            this.dataViewerButton.Name = "dataViewerButton";
            this.dataViewerButton.Size = new System.Drawing.Size(166, 36);
            this.dataViewerButton.TabIndex = 35;
            this.dataViewerButton.Text = "DATA VIEWER";
            this.dataViewerButton.UseVisualStyleBackColor = true;
            this.dataViewerButton.Click += new System.EventHandler(this.Button7_Click);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(22, 67);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(96, 17);
            this.inventoryLabel.TabIndex = 36;
            this.inventoryLabel.Text = "Inventory List:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 615);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.dataViewerButton);
            this.Controls.Add(this.raisePricesButton);
            this.Controls.Add(this.ampersand2);
            this.Controls.Add(this.raisePriceText);
            this.Controls.Add(this.applyDiscountButton);
            this.Controls.Add(this.ampersand1);
            this.Controls.Add(this.discountText);
            this.Controls.Add(this.aboutUsButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.itemList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mercadona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        public System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.Button aboutUsButton;
        private System.Windows.Forms.TextBox discountText;
        private System.Windows.Forms.Label ampersand1;
        private System.Windows.Forms.Button applyDiscountButton;
        private System.Windows.Forms.TextBox raisePriceText;
        private System.Windows.Forms.Label ampersand2;
        private System.Windows.Forms.Button raisePricesButton;
        private System.Windows.Forms.Button dataViewerButton;
        private System.Windows.Forms.Label inventoryLabel;
    }
}

