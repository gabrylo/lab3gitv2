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
            double containerSize, alcoholPercentage;
            int numberOfContainers;
            if (double.TryParse(textBoxSize.Text, out containerSize) && double.TryParse(textBoxPercentage.Text, out alcoholPercentage) && int.TryParse(textBoxNumber.Text, out numberOfContainers))
            {
                //double containerSize = Convert.ToDouble(textBoxSize.Text);
                //double alcoholPercentage = Convert.ToDouble(textBoxPercentage.Text);
                //int numberOfContainers = Convert.ToInt32(textBoxNumber.Text);

                double beverageVolume = containerSize * numberOfContainers;

                double pureAlcoholVolume = (beverageVolume * alcoholPercentage) / 100;


                labelBeverageVolume.Text = "Beverage volume: " + beverageVolume.ToString("0.00") + " ml";
                labelPureAlcoholVolume.Text = "Pure alcohol volume: " + pureAlcoholVolume.ToString("0.00") + " ml";
            }
            else
            {
                MessageBox.Show("źle wprowadzony. Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
