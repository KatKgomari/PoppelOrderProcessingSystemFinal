namespace PoppelOrderProcessingSystem.PresentationLayer
{
    partial class PickingListForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pickingList_ListView = new System.Windows.Forms.ListView();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.BackColor = System.Drawing.Color.Peru;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OrderItemsLabel.Location = new System.Drawing.Point(443, 39);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(88, 20);
            this.OrderItemsLabel.TabIndex = 27;
            this.OrderItemsLabel.Text = "Picking List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Controls.Add(this.totalLabel);
            this.groupBox1.Controls.Add(this.pickingList_ListView);
            this.groupBox1.Location = new System.Drawing.Point(80, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 427);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picking List";
            // 
            // pickingList_ListView
            // 
            this.pickingList_ListView.BackColor = System.Drawing.Color.HotPink;
            this.pickingList_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pickingList_ListView.HideSelection = false;
            this.pickingList_ListView.Location = new System.Drawing.Point(62, 93);
            this.pickingList_ListView.Name = "pickingList_ListView";
            this.pickingList_ListView.Size = new System.Drawing.Size(733, 265);
            this.pickingList_ListView.TabIndex = 27;
            this.pickingList_ListView.UseCompatibleStateImageBehavior = false;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalLabel.Location = new System.Drawing.Point(588, 377);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(59, 20);
            this.totalLabel.TabIndex = 28;
            this.totalLabel.Text = "TOTAL";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalTextBox.Location = new System.Drawing.Point(676, 374);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 26);
            this.totalTextBox.TabIndex = 29;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(869, 537);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 29;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PickingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PoppelOrderProcessingSystem.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(999, 572);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OrderItemsLabel);
            this.Name = "PickingListForm";
            this.Text = "PickingList";
            this.Activated += new System.EventHandler(this.PickingListForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PickingListForm_FormClosed);
            this.Load += new System.EventHandler(this.PickingListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ListView pickingList_ListView;
        private System.Windows.Forms.Button doneButton;
    }
}