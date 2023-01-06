using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp.Common;

namespace WinFormsApp
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParkSlot.Text.Trim()))
            {
                MessageBox.Show("Please Input number.");
                return;
            }
            try
            {
                Convert.ToInt32(txtParkSlot.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Input number.");
                return;
            }
            CommonConstant.UpdateParkAppSettings(txtParkSlot.Text.Trim());

            MessageBox.Show(string.Format("Value Saved.. Created a parking lot with {0} slots", CommonConstant.TotalParkSlot));
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            txtParkSlot.Text = CommonConstant.TotalParkSlot.ToString();
        }
    }
}
