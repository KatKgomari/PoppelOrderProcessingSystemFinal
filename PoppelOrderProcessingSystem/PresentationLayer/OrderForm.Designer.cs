namespace PoppelOrderProcessingSystem.PresentationLayer
{
    partial class OrderForm
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
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.orderItemsListView = new System.Windows.Forms.ListView();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.productDescriptionLabel = new System.Windows.Forms.Label();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.accBLabel = new System.Windows.Forms.Label();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.OrderItemGroupBox = new System.Windows.Forms.GroupBox();
            this.undoButton = new System.Windows.Forms.Button();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.generatePickingListButton = new System.Windows.Forms.Button();
            this.customerCreditAmountTextBox = new System.Windows.Forms.TextBox();
            this.customerCreditAmountLabel = new System.Windows.Forms.Label();
            this.totalSoFarLabel = new System.Windows.Forms.Label();
            this.totalSoFarTextBox = new System.Windows.Forms.TextBox();
            this.OrderItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.BackColor = System.Drawing.Color.Peru;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OrderItemsLabel.Location = new System.Drawing.Point(25, 14);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(142, 20);
            this.OrderItemsLabel.TabIndex = 25;
            this.OrderItemsLabel.Text = "Select Order Items";
            // 
            // orderItemsListView
            // 
            this.orderItemsListView.BackColor = System.Drawing.Color.HotPink;
            this.orderItemsListView.HideSelection = false;
            this.orderItemsListView.Location = new System.Drawing.Point(12, 37);
            this.orderItemsListView.Name = "orderItemsListView";
            this.orderItemsListView.Size = new System.Drawing.Size(600, 350);
            this.orderItemsListView.TabIndex = 24;
            this.orderItemsListView.UseCompatibleStateImageBehavior = false;
            this.orderItemsListView.SelectedIndexChanged += new System.EventHandler(this.orderItemsListView_SelectedIndexChanged);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(148, 45);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.productIDTextBox.TabIndex = 0;
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Location = new System.Drawing.Point(148, 192);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.productQuantityTextBox.TabIndex = 2;
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(148, 118);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.productDescriptionTextBox.TabIndex = 5;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(148, 80);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.productNameTextBox.TabIndex = 6;
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(30, 48);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(58, 13);
            this.ProductIDLabel.TabIndex = 7;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // productDescriptionLabel
            // 
            this.productDescriptionLabel.AutoSize = true;
            this.productDescriptionLabel.Location = new System.Drawing.Point(30, 121);
            this.productDescriptionLabel.Name = "productDescriptionLabel";
            this.productDescriptionLabel.Size = new System.Drawing.Size(100, 13);
            this.productDescriptionLabel.TabIndex = 9;
            this.productDescriptionLabel.Text = "Product Description";
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Location = new System.Drawing.Point(30, 195);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(43, 13);
            this.productQuantityLabel.TabIndex = 10;
            this.productQuantityLabel.Text = "Quanity";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.CausesValidation = false;
            this.productNameLabel.Location = new System.Drawing.Point(30, 80);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(75, 13);
            this.productNameLabel.TabIndex = 11;
            this.productNameLabel.Text = "Product Name";
            // 
            // accBLabel
            // 
            this.accBLabel.AutoSize = true;
            this.accBLabel.Location = new System.Drawing.Point(30, 240);
            this.accBLabel.Name = "accBLabel";
            this.accBLabel.Size = new System.Drawing.Size(0, 13);
            this.accBLabel.TabIndex = 13;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(143, 235);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(105, 23);
            this.addToOrderButton.TabIndex = 19;
            this.addToOrderButton.Text = "Add To Order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // OrderItemGroupBox
            // 
            this.OrderItemGroupBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OrderItemGroupBox.Controls.Add(this.undoButton);
            this.OrderItemGroupBox.Controls.Add(this.productPriceLabel);
            this.OrderItemGroupBox.Controls.Add(this.productPriceTextBox);
            this.OrderItemGroupBox.Controls.Add(this.addToOrderButton);
            this.OrderItemGroupBox.Controls.Add(this.accBLabel);
            this.OrderItemGroupBox.Controls.Add(this.productNameLabel);
            this.OrderItemGroupBox.Controls.Add(this.productQuantityLabel);
            this.OrderItemGroupBox.Controls.Add(this.productDescriptionLabel);
            this.OrderItemGroupBox.Controls.Add(this.ProductIDLabel);
            this.OrderItemGroupBox.Controls.Add(this.productNameTextBox);
            this.OrderItemGroupBox.Controls.Add(this.productDescriptionTextBox);
            this.OrderItemGroupBox.Controls.Add(this.productQuantityTextBox);
            this.OrderItemGroupBox.Controls.Add(this.productIDTextBox);
            this.OrderItemGroupBox.Location = new System.Drawing.Point(630, 28);
            this.OrderItemGroupBox.Name = "OrderItemGroupBox";
            this.OrderItemGroupBox.Size = new System.Drawing.Size(289, 278);
            this.OrderItemGroupBox.TabIndex = 23;
            this.OrderItemGroupBox.TabStop = false;
            this.OrderItemGroupBox.Text = "Order Item";
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(25, 235);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(105, 23);
            this.undoButton.TabIndex = 22;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(30, 162);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.productPriceLabel.TabIndex = 21;
            this.productPriceLabel.Text = "Price";
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(148, 155);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.productPriceTextBox.TabIndex = 20;
            // 
            // generatePickingListButton
            // 
            this.generatePickingListButton.Location = new System.Drawing.Point(965, 450);
            this.generatePickingListButton.Name = "generatePickingListButton";
            this.generatePickingListButton.Size = new System.Drawing.Size(127, 23);
            this.generatePickingListButton.TabIndex = 26;
            this.generatePickingListButton.Text = "Generate Picking List";
            this.generatePickingListButton.UseVisualStyleBackColor = true;
            this.generatePickingListButton.Click += new System.EventHandler(this.generatePickingListButton_Click);
            // 
            // customerCreditAmountTextBox
            // 
            this.customerCreditAmountTextBox.Location = new System.Drawing.Point(271, 412);
            this.customerCreditAmountTextBox.Name = "customerCreditAmountTextBox";
            this.customerCreditAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerCreditAmountTextBox.TabIndex = 20;
            // 
            // customerCreditAmountLabel
            // 
            this.customerCreditAmountLabel.AutoSize = true;
            this.customerCreditAmountLabel.BackColor = System.Drawing.Color.Peru;
            this.customerCreditAmountLabel.CausesValidation = false;
            this.customerCreditAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerCreditAmountLabel.Location = new System.Drawing.Point(25, 413);
            this.customerCreditAmountLabel.Name = "customerCreditAmountLabel";
            this.customerCreditAmountLabel.Size = new System.Drawing.Size(240, 17);
            this.customerCreditAmountLabel.TabIndex = 20;
            this.customerCreditAmountLabel.Text = " Remaining Customer Credit Amount:";
            // 
            // totalSoFarLabel
            // 
            this.totalSoFarLabel.AutoSize = true;
            this.totalSoFarLabel.BackColor = System.Drawing.Color.HotPink;
            this.totalSoFarLabel.CausesValidation = false;
            this.totalSoFarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalSoFarLabel.Location = new System.Drawing.Point(25, 453);
            this.totalSoFarLabel.Name = "totalSoFarLabel";
            this.totalSoFarLabel.Size = new System.Drawing.Size(113, 17);
            this.totalSoFarLabel.TabIndex = 27;
            this.totalSoFarLabel.Text = "TOTAL SO FAR:";
            // 
            // totalSoFarTextBox
            // 
            this.totalSoFarTextBox.Location = new System.Drawing.Point(211, 450);
            this.totalSoFarTextBox.Name = "totalSoFarTextBox";
            this.totalSoFarTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalSoFarTextBox.TabIndex = 28;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PoppelOrderProcessingSystem.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1113, 485);
            this.Controls.Add(this.totalSoFarTextBox);
            this.Controls.Add(this.totalSoFarLabel);
            this.Controls.Add(this.customerCreditAmountLabel);
            this.Controls.Add(this.customerCreditAmountTextBox);
            this.Controls.Add(this.generatePickingListButton);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.orderItemsListView);
            this.Controls.Add(this.OrderItemGroupBox);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderItemGroupBox.ResumeLayout(false);
            this.OrderItemGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.ListView orderItemsListView;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label productDescriptionLabel;
        private System.Windows.Forms.Label productQuantityLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label accBLabel;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.GroupBox OrderItemGroupBox;
        private System.Windows.Forms.Button generatePickingListButton;
        private System.Windows.Forms.TextBox customerCreditAmountTextBox;
        private System.Windows.Forms.Label customerCreditAmountLabel;
        private System.Windows.Forms.Label totalSoFarLabel;
        private System.Windows.Forms.TextBox totalSoFarTextBox;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Button undoButton;
    }
}