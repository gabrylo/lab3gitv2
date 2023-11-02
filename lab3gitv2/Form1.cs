using System;
using System.Windows.Forms;

namespace lab3gitv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Alcohol";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double containerSize, alcoholPercentage;
            int numberOfContainers;
            if (double.TryParse(textBoxSize.Text, out containerSize) && double.TryParse(textBoxPercentage.Text, out alcoholPercentage) && int.TryParse(textBoxNumber.Text, out numberOfContainers))
            {

                double beverageVolume = containerSize * numberOfContainers;

                double pureAlcoholVolume = (beverageVolume * alcoholPercentage) / 100;


                labelBeverageVolume.Text = "Beverage volume: " + beverageVolume.ToString("0.00") + " ml";
                labelPureAlcoholVolume.Text = "Pure alcohol volume: " + pureAlcoholVolume.ToString("0.00") + " ml";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
