namespace PoppelOrderProcessingSystem.PresentationLayer
{
    partial class InventoryReport
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
            this.inventoryReportGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.inventoryReportListView = new System.Windows.Forms.ListView();
            this.InventoryReportLabel = new System.Windows.Forms.Label();
            this.inventoryReportGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryReportGroupBox
            // 
            this.inventoryReportGroupBox.Controls.Add(this.dateTextBox);
            this.inventoryReportGroupBox.Controls.Add(this.dateLabel);
            this.inventoryReportGroupBox.Controls.Add(this.inventoryReportListView);
            this.inventoryReportGroupBox.Location = new System.Drawing.Point(122, 72);
            this.inventoryReportGroupBox.Name = "inventoryReportGroupBox";
            this.inventoryReportGroupBox.Size = new System.Drawing.Size(864, 427);
            this.inventoryReportGroupBox.TabIndex = 31;
            this.inventoryReportGroupBox.TabStop = false;
            this.inventoryReportGroupBox.Text = "Inventory Report";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(215, 34);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(151, 20);
            this.dateTextBox.TabIndex = 32;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(87, 34);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 30;
            this.dateLabel.Text = "Date";
            // 
            // inventoryReportListView
            // 
            this.inventoryReportListView.BackColor = System.Drawing.Color.HotPink;
            this.inventoryReportListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inventoryReportListView.HideSelection = false;
            this.inventoryReportListView.Location = new System.Drawing.Point(62, 93);
            this.inventoryReportListView.Name = "inventoryReportListView";
            this.inventoryReportListView.Size = new System.Drawing.Size(733, 265);
            this.inventoryReportListView.TabIndex = 27;
            this.inventoryReportListView.UseCompatibleStateImageBehavior = false;
            // 
            // InventoryReportLabel
            // 
            this.InventoryReportLabel.AutoSize = true;
            this.InventoryReportLabel.BackColor = System.Drawing.Color.Peru;
            this.InventoryReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InventoryReportLabel.Location = new System.Drawing.Point(444, 35);
            this.InventoryReportLabel.Name = "InventoryReportLabel";
            this.InventoryReportLabel.Size = new System.Drawing.Size(236, 20);
            this.InventoryReportLabel.TabIndex = 30;
            this.InventoryReportLabel.Text = "Inventory Report : Expired Items";
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PoppelOrderProcessingSystem.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1109, 591);
            this.Controls.Add(this.inventoryReportGroupBox);
            this.Controls.Add(this.InventoryReportLabel);
            this.Name = "InventoryReport";
            this.Text = "InventoryReport";
            this.Activated += new System.EventHandler(this.InventoryReport_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryReport_FormClosed);
            this.Load += new System.EventHandler(this.InventoryReport_Load);
            this.inventoryReportGroupBox.ResumeLayout(false);
            this.inventoryReportGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inventoryReportGroupBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ListView inventoryReportListView;
        private System.Windows.Forms.Label InventoryReportLabel;
    }
}