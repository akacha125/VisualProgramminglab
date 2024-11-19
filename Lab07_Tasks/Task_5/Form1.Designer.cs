
namespace vp_lab7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lbl_number = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(20, 20);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(55, 15);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "Number:";
            this.txt_number.Location = new System.Drawing.Point(100, 20);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 23);
            this.txt_number.TabIndex = 1;
            this.btn_calculate.Location = new System.Drawing.Point(60, 60);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(100, 30);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_click);
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(20, 110);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(60, 15);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "Factorial: ";
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_result);
            this.Name = "Form1";
            this.Text = "Factorial Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_result;
    }
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