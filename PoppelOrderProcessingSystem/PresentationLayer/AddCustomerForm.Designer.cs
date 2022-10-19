namespace PoppelOrderProcessingSystem.PresentationLayer
{
    partial class AddCustomerForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.crdtStatLabel = new System.Windows.Forms.Label();
            this.crdtStatTextBox = new System.Windows.Forms.TextBox();
            this.crdtAmntLabel = new System.Windows.Forms.Label();
            this.accBLabel = new System.Windows.Forms.Label();
            this.adrLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.crdtAmTextBox = new System.Windows.Forms.TextBox();
            this.AccBalTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.CustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(22, 459);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 23);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // CustomerGroupBox
            // 
            this.CustomerGroupBox.BackColor = System.Drawing.Color.HotPink;
            this.CustomerGroupBox.Controls.Add(this.cancelButton);
            this.CustomerGroupBox.Controls.Add(this.submitButton);
            this.CustomerGroupBox.Controls.Add(this.exitButton);
            this.CustomerGroupBox.Controls.Add(this.crdtStatLabel);
            this.CustomerGroupBox.Controls.Add(this.crdtStatTextBox);
            this.CustomerGroupBox.Controls.Add(this.crdtAmntLabel);
            this.CustomerGroupBox.Controls.Add(this.accBLabel);
            this.CustomerGroupBox.Controls.Add(this.adrLabel);
            this.CustomerGroupBox.Controls.Add(this.nameLabel);
            this.CustomerGroupBox.Controls.Add(this.phoneLabel);
            this.CustomerGroupBox.Controls.Add(this.emailLabel);
            this.CustomerGroupBox.Controls.Add(this.idLabel);
            this.CustomerGroupBox.Controls.Add(this.nameTextBox);
            this.CustomerGroupBox.Controls.Add(this.emailTextBox);
            this.CustomerGroupBox.Controls.Add(this.crdtAmTextBox);
            this.CustomerGroupBox.Controls.Add(this.AccBalTextBox);
            this.CustomerGroupBox.Controls.Add(this.phoneTextBox);
            this.CustomerGroupBox.Controls.Add(this.addressTextBox);
            this.CustomerGroupBox.Controls.Add(this.idTextBox);
            this.CustomerGroupBox.Location = new System.Drawing.Point(191, 21);
            this.CustomerGroupBox.Name = "CustomerGroupBox";
            this.CustomerGroupBox.Size = new System.Drawing.Size(506, 416);
            this.CustomerGroupBox.TabIndex = 19;
            this.CustomerGroupBox.TabStop = false;
            this.CustomerGroupBox.Text = "Customer";
            this.CustomerGroupBox.Enter += new System.EventHandler(this.CustomerGroupBox_Enter);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(211, 365);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(130, 365);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(292, 365);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // crdtStatLabel
            // 
            this.crdtStatLabel.AutoSize = true;
            this.crdtStatLabel.Location = new System.Drawing.Point(138, 316);
            this.crdtStatLabel.Name = "crdtStatLabel";
            this.crdtStatLabel.Size = new System.Drawing.Size(67, 13);
            this.crdtStatLabel.TabIndex = 16;
            this.crdtStatLabel.Text = "Credit Status";
            // 
            // crdtStatTextBox
            // 
            this.crdtStatTextBox.Location = new System.Drawing.Point(256, 313);
            this.crdtStatTextBox.Name = "crdtStatTextBox";
            this.crdtStatTextBox.Size = new System.Drawing.Size(100, 20);
            this.crdtStatTextBox.TabIndex = 15;
            // 
            // crdtAmntLabel
            // 
            this.crdtAmntLabel.AutoSize = true;
            this.crdtAmntLabel.Location = new System.Drawing.Point(138, 278);
            this.crdtAmntLabel.Name = "crdtAmntLabel";
            this.crdtAmntLabel.Size = new System.Drawing.Size(73, 13);
            this.crdtAmntLabel.TabIndex = 14;
            this.crdtAmntLabel.Text = "Credit Amount";
            // 
            // accBLabel
            // 
            this.accBLabel.AutoSize = true;
            this.accBLabel.Location = new System.Drawing.Point(138, 235);
            this.accBLabel.Name = "accBLabel";
            this.accBLabel.Size = new System.Drawing.Size(89, 13);
            this.accBLabel.TabIndex = 13;
            this.accBLabel.Text = "Account Balance";
            // 
            // adrLabel
            // 
            this.adrLabel.AutoSize = true;
            this.adrLabel.Location = new System.Drawing.Point(138, 190);
            this.adrLabel.Name = "adrLabel";
            this.adrLabel.Size = new System.Drawing.Size(45, 13);
            this.adrLabel.TabIndex = 12;
            this.adrLabel.Text = "Address";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(138, 75);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(138, 151);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(138, 116);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(138, 43);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(256, 75);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(256, 113);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // crdtAmTextBox
            // 
            this.crdtAmTextBox.Location = new System.Drawing.Point(256, 275);
            this.crdtAmTextBox.Name = "crdtAmTextBox";
            this.crdtAmTextBox.Size = new System.Drawing.Size(100, 20);
            this.crdtAmTextBox.TabIndex = 4;
            // 
            // AccBalTextBox
            // 
            this.AccBalTextBox.Location = new System.Drawing.Point(256, 232);
            this.AccBalTextBox.Name = "AccBalTextBox";
            this.AccBalTextBox.Size = new System.Drawing.Size(100, 20);
            this.AccBalTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(256, 151);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(256, 190);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(256, 40);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PoppelOrderProcessingSystem.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(850, 494);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.CustomerGroupBox);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.Activated += new System.EventHandler(this.AddCustomerForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.CustomerGroupBox.ResumeLayout(false);
            this.CustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox CustomerGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label crdtStatLabel;
        private System.Windows.Forms.TextBox crdtStatTextBox;
        private System.Windows.Forms.Label crdtAmntLabel;
        private System.Windows.Forms.Label accBLabel;
        private System.Windows.Forms.Label adrLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox crdtAmTextBox;
        private System.Windows.Forms.TextBox AccBalTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}