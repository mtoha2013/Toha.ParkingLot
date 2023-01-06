
namespace WinFormsApp
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newParkEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outParkEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportByVehicleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportByEvenOddPlateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportByRegistrationNumberColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDataByRegistrationNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewSlot = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalSlot = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.ddlColour = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPoliceNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlot)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.newParkEntryToolStripMenuItem,
            this.outParkEntryToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1418, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // newParkEntryToolStripMenuItem
            // 
            this.newParkEntryToolStripMenuItem.Name = "newParkEntryToolStripMenuItem";
            this.newParkEntryToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.newParkEntryToolStripMenuItem.Text = "New Park Entry";
            this.newParkEntryToolStripMenuItem.Click += new System.EventHandler(this.newParkEntryToolStripMenuItem_Click);
            // 
            // outParkEntryToolStripMenuItem
            // 
            this.outParkEntryToolStripMenuItem.Name = "outParkEntryToolStripMenuItem";
            this.outParkEntryToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.outParkEntryToolStripMenuItem.Text = "Leave/Out Park Entry";
            this.outParkEntryToolStripMenuItem.Click += new System.EventHandler(this.outParkEntryToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportByVehicleTypeToolStripMenuItem,
            this.reportByEvenOddPlateToolStripMenuItem,
            this.reportByRegistrationNumberColourToolStripMenuItem,
            this.searchDataByRegistrationNumberToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // reportByVehicleTypeToolStripMenuItem
            // 
            this.reportByVehicleTypeToolStripMenuItem.Name = "reportByVehicleTypeToolStripMenuItem";
            this.reportByVehicleTypeToolStripMenuItem.Size = new System.Drawing.Size(347, 26);
            this.reportByVehicleTypeToolStripMenuItem.Text = "Report By Vehicle Type";
            this.reportByVehicleTypeToolStripMenuItem.Click += new System.EventHandler(this.reportByVehicleTypeToolStripMenuItem_Click);
            // 
            // reportByEvenOddPlateToolStripMenuItem
            // 
            this.reportByEvenOddPlateToolStripMenuItem.Name = "reportByEvenOddPlateToolStripMenuItem";
            this.reportByEvenOddPlateToolStripMenuItem.Size = new System.Drawing.Size(347, 26);
            this.reportByEvenOddPlateToolStripMenuItem.Text = "Report By  Even/Odd Plate";
            this.reportByEvenOddPlateToolStripMenuItem.Click += new System.EventHandler(this.reportByEvenOddPlateToolStripMenuItem_Click);
            // 
            // reportByRegistrationNumberColourToolStripMenuItem
            // 
            this.reportByRegistrationNumberColourToolStripMenuItem.Name = "reportByRegistrationNumberColourToolStripMenuItem";
            this.reportByRegistrationNumberColourToolStripMenuItem.Size = new System.Drawing.Size(347, 26);
            this.reportByRegistrationNumberColourToolStripMenuItem.Text = "Report By Registration Number Colour";
            this.reportByRegistrationNumberColourToolStripMenuItem.Click += new System.EventHandler(this.reportByRegistrationNumberColourToolStripMenuItem_Click);
            // 
            // searchDataByRegistrationNumberToolStripMenuItem
            // 
            this.searchDataByRegistrationNumberToolStripMenuItem.Name = "searchDataByRegistrationNumberToolStripMenuItem";
            this.searchDataByRegistrationNumberToolStripMenuItem.Size = new System.Drawing.Size(347, 26);
            this.searchDataByRegistrationNumberToolStripMenuItem.Text = "Search Data By Registration Number";
            this.searchDataByRegistrationNumberToolStripMenuItem.Click += new System.EventHandler(this.searchDataByRegistrationNumberToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // dataGridViewSlot
            // 
            this.dataGridViewSlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSlot.Location = new System.Drawing.Point(21, 82);
            this.dataGridViewSlot.Name = "dataGridViewSlot";
            this.dataGridViewSlot.RowHeadersWidth = 51;
            this.dataGridViewSlot.RowTemplate.Height = 29;
            this.dataGridViewSlot.Size = new System.Drawing.Size(1352, 274);
            this.dataGridViewSlot.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saved Slot : ";
            // 
            // labelTotalSlot
            // 
            this.labelTotalSlot.AutoSize = true;
            this.labelTotalSlot.Location = new System.Drawing.Point(1057, 45);
            this.labelTotalSlot.Name = "labelTotalSlot";
            this.labelTotalSlot.Size = new System.Drawing.Size(83, 20);
            this.labelTotalSlot.TabIndex = 3;
            this.labelTotalSlot.Text = "Total Slot : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.ddlColour);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ddlType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPoliceNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSlot);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(21, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 269);
            this.panel1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(482, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 100);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save New Entry";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ddlColour
            // 
            this.ddlColour.FormattingEnabled = true;
            this.ddlColour.Items.AddRange(new object[] {
            "White",
            "Black",
            "Biru"});
            this.ddlColour.Location = new System.Drawing.Point(239, 194);
            this.ddlColour.Name = "ddlColour";
            this.ddlColour.Size = new System.Drawing.Size(151, 28);
            this.ddlColour.TabIndex = 8;
            this.ddlColour.Text = "White";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Registration No Colour : ";
            // 
            // ddlType
            // 
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Items.AddRange(new object[] {
            "Car",
            "Motorcycle"});
            this.ddlType.Location = new System.Drawing.Point(239, 149);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(151, 28);
            this.ddlType.TabIndex = 6;
            this.ddlType.Text = "Car";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type : ";
            // 
            // txtPoliceNo
            // 
            this.txtPoliceNo.Location = new System.Drawing.Point(239, 103);
            this.txtPoliceNo.Name = "txtPoliceNo";
            this.txtPoliceNo.Size = new System.Drawing.Size(125, 27);
            this.txtPoliceNo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Police No : ";
            // 
            // txtSlot
            // 
            this.txtSlot.Enabled = false;
            this.txtSlot.Location = new System.Drawing.Point(239, 55);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(125, 27);
            this.txtSlot.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Slot : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Entry";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(151, 41);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(167, 28);
            this.btnStatus.TabIndex = 10;
            this.btnStatus.Text = "Refresh Status Slot";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 719);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTotalSlot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSlot);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form Main - Park Slot (c)Toha - NTT";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlot)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newParkEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outParkEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewSlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalSlot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ddlColour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPoliceNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.ToolStripMenuItem reportByVehicleTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportByEvenOddPlateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportByRegistrationNumberColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDataByRegistrationNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
    }
}

