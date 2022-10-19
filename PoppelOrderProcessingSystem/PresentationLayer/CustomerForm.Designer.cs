namespace PoppelOrderProcessingSystem.PresentationLayer
{
    partial class CustomerForm
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
            this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
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
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.customerListView = new System.Windows.Forms.ListView();
            this.custLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.CustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerGroupBox
            // 
            this.CustomerGroupBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CustomerGroupBox.Controls.Add(this.deleteButton);
            this.CustomerGroupBox.Controls.Add(this.submitButton);
            this.CustomerGroupBox.Controls.Add(this.editButton);
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
            this.CustomerGroupBox.Location = new System.Drawing.Point(630, 21);
            this.CustomerGroupBox.Name = "CustomerGroupBox";
            this.CustomerGroupBox.Size = new System.Drawing.Size(297, 416);
            this.CustomerGroupBox.TabIndex = 0;
            this.CustomerGroupBox.TabStop = false;
            this.CustomerGroupBox.Text = "Customer";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(103, 370);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(184, 370);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(22, 370);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 19;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // crdtStatLabel
            // 
            this.crdtStatLabel.AutoSize = true;
            this.crdtStatLabel.Location = new System.Drawing.Point(30, 321);
            this.crdtStatLabel.Name = "crdtStatLabel";
            this.crdtStatLabel.Size = new System.Drawing.Size(67, 13);
            this.crdtStatLabel.TabIndex = 16;
            this.crdtStatLabel.Text = "Credit Status";
            // 
            // crdtStatTextBox
            // 
            this.crdtStatTextBox.Location = new System.Drawing.Point(148, 318);
            this.crdtStatTextBox.Name = "crdtStatTextBox";
            this.crdtStatTextBox.Size = new System.Drawing.Size(100, 20);
            this.crdtStatTextBox.TabIndex = 15;
            // 
            // crdtAmntLabel
            // 
            this.crdtAmntLabel.AutoSize = true;
            this.crdtAmntLabel.Location = new System.Drawing.Point(30, 283);
            this.crdtAmntLabel.Name = "crdtAmntLabel";
            this.crdtAmntLabel.Size = new System.Drawing.Size(73, 13);
            this.crdtAmntLabel.TabIndex = 14;
            this.crdtAmntLabel.Text = "Credit Amount";
            // 
            // accBLabel
            // 
            this.accBLabel.AutoSize = true;
            this.accBLabel.Location = new System.Drawing.Point(30, 240);
            this.accBLabel.Name = "accBLabel";
            this.accBLabel.Size = new System.Drawing.Size(89, 13);
            this.accBLabel.TabIndex = 13;
            this.accBLabel.Text = "Account Balance";
            // 
            // adrLabel
            // 
            this.adrLabel.AutoSize = true;
            this.adrLabel.Location = new System.Drawing.Point(30, 195);
            this.adrLabel.Name = "adrLabel";
            this.adrLabel.Size = new System.Drawing.Size(45, 13);
            this.adrLabel.TabIndex = 12;
            this.adrLabel.Text = "Address";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(30, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(30, 156);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(30, 121);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(30, 48);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(148, 80);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(148, 118);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // crdtAmTextBox
            // 
            this.crdtAmTextBox.Location = new System.Drawing.Point(148, 280);
            this.crdtAmTextBox.Name = "crdtAmTextBox";
            this.crdtAmTextBox.Size = new System.Drawing.Size(100, 20);
            this.crdtAmTextBox.TabIndex = 4;
            // 
            // AccBalTextBox
            // 
            this.AccBalTextBox.Location = new System.Drawing.Point(148, 237);
            this.AccBalTextBox.Name = "AccBalTextBox";
            this.AccBalTextBox.Size = new System.Drawing.Size(100, 20);
            this.AccBalTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(148, 156);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(148, 195);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(148, 45);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(840, 450);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 18;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 450);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // customerListView
            // 
            this.customerListView.BackColor = System.Drawing.Color.HotPink;
            this.customerListView.HideSelection = false;
            this.customerListView.Location = new System.Drawing.Point(12, 30);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(600, 350);
            this.customerListView.TabIndex = 1;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.SelectedIndexChanged += new System.EventHandler(this.customerListView_SelectedIndexChanged);
            // 
            // custLabel
            // 
            this.custLabel.AutoSize = true;
            this.custLabel.BackColor = System.Drawing.Color.Peru;
            this.custLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.custLabel.Location = new System.Drawing.Point(25, 7);
            this.custLabel.Name = "custLabel";
            this.custLabel.Size = new System.Drawing.Size(86, 20);
            this.custLabel.TabIndex = 2;
            this.custLabel.Text = "Customers";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(510, 403);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PoppelOrderProcessingSystem.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(943, 478);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.custLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.customerListView);
            this.Controls.Add(this.CustomerGroupBox);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Activated += new System.EventHandler(this.CustomerForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.CustomerGroupBox.ResumeLayout(false);
            this.CustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomerGroupBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox crdtAmTextBox;
        private System.Windows.Forms.TextBox AccBalTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label crdtStatLabel;
        private System.Windows.Forms.TextBox crdtStatTextBox;
        private System.Windows.Forms.Label crdtAmntLabel;
        private System.Windows.Forms.Label accBLabel;
        private System.Windows.Forms.Label adrLabel;
        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.Label custLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
    }
}