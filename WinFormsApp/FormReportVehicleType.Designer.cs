
namespace WinFormsApp
{
    partial class FormReportVehicleType
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewSlot = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalSlot = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlot)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSlot
            // 
            this.dataGridViewSlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSlot.Location = new System.Drawing.Point(12, 195);
            this.dataGridViewSlot.Name = "dataGridViewSlot";
            this.dataGridViewSlot.RowHeadersWidth = 51;
            this.dataGridViewSlot.RowTemplate.Height = 29;
            this.dataGridViewSlot.Size = new System.Drawing.Size(1352, 274);
            this.dataGridViewSlot.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result Saved Slot : ";
            // 
            // labelTotalSlot
            // 
            this.labelTotalSlot.AutoSize = true;
            this.labelTotalSlot.Location = new System.Drawing.Point(1048, 158);
            this.labelTotalSlot.Name = "labelTotalSlot";
            this.labelTotalSlot.Size = new System.Drawing.Size(83, 20);
            this.labelTotalSlot.TabIndex = 3;
            this.labelTotalSlot.Text = "Total Slot : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.ddlType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 99);
            this.panel1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(431, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 52);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search Data";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ddlType
            // 
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Items.AddRange(new object[] {
            "Car",
            "Motorcycle"});
            this.ddlType.Location = new System.Drawing.Point(206, 55);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(151, 28);
            this.ddlType.TabIndex = 6;
            this.ddlType.Text = "Car";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vehicle Type : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Data By Vehicle Type";
            // 
            // FormReportVehicleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTotalSlot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSlot);
            this.Name = "FormReportVehicleType";
            this.Text = "Form Main - Park Slot (c)Toha - NTT";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlot)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewSlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalSlot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ddlType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
    }
}

