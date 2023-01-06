using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp.Common;
using WinFormsApp.Providers;

namespace WinFormsApp
{
    public partial class FormReportRegistrationNumber : Form
    {
        public FormReportRegistrationNumber()
        {
            InitializeComponent();
        }




        private void btnSearch_Click(object sender, EventArgs e)
        {

            var allData = ParkingLotProvider.GetByRegNo(ddlType.Text);
            if (allData.Count > 0)
                MessageBox.Show(string.Format("Park slot of {0} : {1}",ddlType.Text, allData[0].Slot));
            else
                MessageBox.Show("No Data.");

            dataGridViewSlot.DataSource = allData;
            dataGridViewSlot.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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



            var dataListRegNo = ParkingLotProvider.GetAllRegNoAsync();
            ddlType.DataSource = dataListRegNo.Item2;

        }
    }
}
