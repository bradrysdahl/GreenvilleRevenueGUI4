using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void revenueButton_Click(object sender, EventArgs e)
        {
           int FEE = 25;

            int contestantsThisYear = Convert.ToInt32(thisYearTextBox.Text);
            int contestantsLastYear = Convert.ToInt32(lastYearTextBox.Text);
            int expectedRevenue = contestantsThisYear * FEE;
            revenueOutputLabel.Text = expectedRevenue.ToString("C");
            if (contestantsThisYear > contestantsLastYear)
            {
                contestantsOutputLabel.Text = "Yes";
            }
            else
            {
                contestantsOutputLabel.Text = "No";
            }
        }
    }
}
