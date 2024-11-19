
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

        private long calculate_factorial(int number)
        {
            if (number == 0 || number == 1) return 1;
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        private void btn_calculate_click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_number.Text, out int number) && number >= 0)
            {
                long factorial = calculate_factorial(number);
                lbl_result.Text = $"Factorial: {factorial}";
            }
            else
            {
                lbl_result.Text = "Enter a valid non-negative integer.";
            }
        }
    }
}