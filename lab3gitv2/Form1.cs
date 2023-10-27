using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3gitv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double containerSize = Convert.ToDouble(textBoxSize.Text);
            double alcoholPercentage = Convert.ToDouble(textBoxPercentage.Text);
            int numberOfContainers = Convert.ToInt32(textBoxNumber.Text);

            double beverageVolume = containerSize * numberOfContainers;

            double pureAlcoholVolume = (beverageVolume * alcoholPercentage) / 100;

            MessageBox.Show("Beverage volume: " + beverageVolume.ToString("0.00") + " ml", "Result", MessageBoxButtons.OK);
            MessageBox.Show("Pure alcohol volume: " + pureAlcoholVolume.ToString("0.00") + " ml", "Result", MessageBoxButtons.OK);

        }
    }
}
