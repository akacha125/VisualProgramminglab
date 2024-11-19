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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            string operation = cboOperation.Text;

            double result = operation switch
            {
                "Add" => Add(num1, num2),
                "Subtract" => Subtract(num1, num2),
                "Multiply" => Multiply(num1, num2),
                "Divide" => Divide(num1, num2),
                _ => 0
            };

            lblResult.Text = $"Result: {result}";
        }
    }
}
