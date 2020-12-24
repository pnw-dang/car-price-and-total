
namespace CarPriceAndTotal
{
    partial class CarPriceUpdate
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
            this.updateLabel = new System.Windows.Forms.Label();
            this.updateTxtBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.totalBtn = new System.Windows.Forms.Button();
            this.displayInfoLV = new System.Windows.Forms.ListView();
            this.Make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mileage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.Location = new System.Drawing.Point(588, 399);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(171, 26);
            this.updateLabel.TabIndex = 13;
            this.updateLabel.Text = "Update car price";
            // 
            // updateTxtBox
            // 
            this.updateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTxtBox.Location = new System.Drawing.Point(467, 449);
            this.updateTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateTxtBox.Name = "updateTxtBox";
            this.updateTxtBox.Size = new System.Drawing.Size(394, 32);
            this.updateTxtBox.TabIndex = 12;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(467, 495);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(395, 76);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // totalBtn
            // 
            this.totalBtn.Location = new System.Drawing.Point(66, 449);
            this.totalBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totalBtn.Name = "totalBtn";
            this.totalBtn.Size = new System.Drawing.Size(395, 122);
            this.totalBtn.TabIndex = 10;
            this.totalBtn.Text = "Total Value";
            this.totalBtn.UseVisualStyleBackColor = true;
            this.totalBtn.Click += new System.EventHandler(this.totalBtn_Click);
            // 
            // displayInfoLV
            // 
            this.displayInfoLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Make,
            this.Model,
            this.Mileage,
            this.Year,
            this.Price,
            this.CustomerID,
            this.VIN});
            this.displayInfoLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayInfoLV.FullRowSelect = true;
            this.displayInfoLV.GridLines = true;
            this.displayInfoLV.HideSelection = false;
            this.displayInfoLV.Location = new System.Drawing.Point(12, 13);
            this.displayInfoLV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.displayInfoLV.Name = "displayInfoLV";
            this.displayInfoLV.Size = new System.Drawing.Size(916, 364);
            this.displayInfoLV.TabIndex = 9;
            this.displayInfoLV.UseCompatibleStateImageBehavior = false;
            this.displayInfoLV.View = System.Windows.Forms.View.Details;
            // 
            // Make
            // 
            this.Make.Text = "Make";
            this.Make.Width = 120;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 120;
            // 
            // Mileage
            // 
            this.Mileage.Text = "Mileage";
            this.Mileage.Width = 120;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 120;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 140;
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "Customer ID";
            this.CustomerID.Width = 140;
            // 
            // VIN
            // 
            this.VIN.Text = "VIN";
            this.VIN.Width = 150;
            // 
            // CarPriceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 595);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.updateTxtBox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.totalBtn);
            this.Controls.Add(this.displayInfoLV);
            this.Name = "CarPriceUpdate";
            this.Text = "Car Price and Total Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.TextBox updateTxtBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button totalBtn;
        private System.Windows.Forms.ListView displayInfoLV;
        private System.Windows.Forms.ColumnHeader Make;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Mileage;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader VIN;
    }
}

