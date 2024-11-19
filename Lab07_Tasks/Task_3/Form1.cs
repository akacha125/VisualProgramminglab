// 233514 
using System;
using System.Windows.Form
namespace vp_lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string calculate_squares()
        {
            string result = "";
            for (int i = 1; i <= 10; i++)
            {
                result += $"Square of {i}: {i * i}\t\n\n";
            }
            return result;
        }

        private void btn_calculate_click(object sender, EventArgs e)
        {
            txt_result.Text = calculate_squares();
        }
    }
}