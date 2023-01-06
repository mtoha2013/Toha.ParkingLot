using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp.Common;
using WinFormsApp.Providers;

namespace WinFormsApp
{
    public partial class FormReportPlateColour : Form
    {
        public FormReportPlateColour()
        {
            InitializeComponent();
        }





        private void btnSearch_Click(object sender, EventArgs e)
        {

            var allData = ParkingLotProvider.GetByPlateColour(ddlType.Text);
            if (allData.Count > 0)
                MessageBox.Show("Slot No : " + new StringBuilder().AppendJoin(", ", allData.Select(x => x.Slot)).ToString());
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
        }
    }
}
