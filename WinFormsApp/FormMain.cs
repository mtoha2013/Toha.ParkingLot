using System;
using System.Windows.Forms;
using WinFormsApp.Common;
using WinFormsApp.Providers;

namespace WinFormsApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfig config = new FormConfig();
            config.Show();

        }

        private void newParkEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newId  = ParkingLotProvider.SaveData(ddlType.Text, txtPoliceNo.Text, ddlColour.Text);
            MessageBox.Show("Allocated Slot number : " + newId);
            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            var dataList = ParkingLotProvider.GetAllAsync();
            if (dataList.Item1)
            {

                dataGridViewSlot.DataSource = dataList.Item2;
                dataGridViewSlot.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            labelTotalSlot.Text = "Total Slot : " + CommonConstant.TotalParkSlot;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var dataList = ParkingLotProvider.GetAllAsync();
            if (dataList.Item1) {

                dataGridViewSlot.DataSource = dataList.Item2;
                dataGridViewSlot.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            labelTotalSlot.Text = "Total Slot : " + CommonConstant.TotalParkSlot;
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
            labelTotalSlot.Text = "Total Slot : " + CommonConstant.TotalParkSlot;
        }

        private void reportByEvenOddPlateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportEvenOdd newForm = new FormReportEvenOdd();
            newForm.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void reportByVehicleTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportVehicleType newForm = new FormReportVehicleType();
            newForm.Show();
        }

        private void reportByRegistrationNumberColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportPlateColour newForm = new FormReportPlateColour();
            newForm.Show();
        }

        private void searchDataByRegistrationNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportRegistrationNumber newForm = new FormReportRegistrationNumber();
            newForm.Show();
        }

        private void outParkEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeave newForm = new FormLeave();
            newForm.Show();
        }
    }
}
