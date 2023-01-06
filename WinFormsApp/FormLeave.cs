using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp.Common;
using WinFormsApp.Providers;

namespace WinFormsApp
{
    public partial class FormLeave : Form
    {
        public FormLeave()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

            var dataList = ParkingLotProvider.GetAllAsync();
            if (dataList.Item1)
            {

                dataGridViewSlot.DataSource = dataList.Item2;
                dataGridViewSlot.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            labelTotalSlot.Text = "Total Slot : " + CommonConstant.TotalParkSlot;



            var dataListRegNo = ParkingLotProvider.GetAllDistinctSlot();
            ddlType.DataSource = dataListRegNo.Item2;

        }

        private void dataGridViewSlot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(string.Format("Are you sure, Park No {0} is about to Leave?", ddlType.Text), "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                var deletedData = ParkingLotProvider.LeaveByParkId(ddlType.Text);
                if (deletedData.Item1) {
                    TimeSpan diff =  DateTime.Now - deletedData.Item2.CheckInTime ?? DateTime.Now - DateTime.Now.AddHours(-8);
                    decimal hours = diff.Hours + Math.Ceiling((decimal)diff.Minutes / (decimal)60);
                    if (hours == 0)
                        hours = 1;
                    MessageBox.Show(string.Format("Slot Number {0} is free. Total Hours: {1}", deletedData.Item2.Slot, hours));
                }
                else
                    MessageBox.Show("No Data.");

                dataGridViewSlot.DataSource = deletedData;
                dataGridViewSlot.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                return;
            }
        }
    }
}
