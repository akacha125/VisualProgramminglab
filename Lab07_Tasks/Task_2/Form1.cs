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

        private double Add(double a, double b) => a + b;
        private double Subtract(double a, double b) => a - b;
        private double Multiply(double a, double b) => a * b;
        private double Divide(double a, double b) => b != 0 ? a / b : 0;

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt_num1.Text, out double num1) || !double.TryParse(txt_num2.Text, out double num2))
            {
                lbl_result.Text = "Invalid input. Please enter numbers.";
                return;
            }

            if (rb_add.Checked)
                lbl_result.Text = $"Result: {Add(num1, num2)}";
            else if (rb_subtract.Checked)
                lbl_result.Text = $"Result: {Subtract(num1, num2)}";
            else if (rb_multiply.Checked)
                lbl_result.Text = $"Result: {Multiply(num1, num2)}";
            else if (rb_divide.Checked)
                lbl_result.Text = num2 != 0 ? $"Result: {Divide(num1, num2)}" : "Cannot divide by zero.";
            else
                lbl_result.Text = "Please select an operation.";
        }
    }
}
