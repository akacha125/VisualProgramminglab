
using System;
using System.Windows.Forms;

namespace vp_lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double convert_to_celsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        private void btn_convert_click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_fahrenheit.Text, out double fahrenheit))
            {
                double celsius = convert_to_celsius(fahrenheit);
                lbl_result.Text = $"Celsius: {celsius:F2}";
            }
            else
            {
                lbl_result.Text = "Enter a valid number.";
            }
        }
    }
}