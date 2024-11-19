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
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.gb_operations = new System.Windows.Forms.GroupBox();
            this.rb_add = new System.Windows.Forms.RadioButton();
            this.rb_subtract = new System.Windows.Forms.RadioButton();
            this.rb_multiply = new System.Windows.Forms.RadioButton();
            this.rb_divide = new System.Windows.Forms.RadioButton();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.gb_operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(120, 20);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 20);
            this.txt_num1.TabIndex = 0;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(120, 60);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 20);
            this.txt_num2.TabIndex = 1;
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Location = new System.Drawing.Point(20, 23);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(84, 13);
            this.lbl_num1.TabIndex = 2;
            this.lbl_num1.Text = "Enter Number 1:";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Location = new System.Drawing.Point(20, 63);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(84, 13);
            this.lbl_num2.TabIndex = 3;
            this.lbl_num2.Text = "Enter Number 2:";
            // 
            // gb_operations
            // 
            this.gb_operations.Controls.Add(this.rb_add);
            this.gb_operations.Controls.Add(this.rb_subtract);
            this.gb_operations.Controls.Add(this.rb_multiply);
            this.gb_operations.Controls.Add(this.rb_divide);
            this.gb_operations.Location = new System.Drawing.Point(20, 100);
            this.gb_operations.Name = "gb_operations";
            this.gb_operations.Size = new System.Drawing.Size(200, 120);
            this.gb_operations.TabIndex = 4;
            this.gb_operations.TabStop = false;
            this.gb_operations.Text = "Operations";
            // 
            // rb_add
            // 
            this.rb_add.AutoSize = true;
            this.rb_add.Location = new System.Drawing.Point(10, 20);
            this.rb_add.Name = "rb_add";
            this.rb_add.Size = new System.Drawing.Size(44, 17);
            this.rb_add.TabIndex = 0;
            this.rb_add.TabStop = true;
            this.rb_add.Text = "Add";
            this.rb_add.UseVisualStyleBackColor = true;
            // 
            // rb_subtract
            // 
            this.rb_subtract.AutoSize = true;
            this.rb_subtract.Location = new System.Drawing.Point(10, 50);
            this.rb_subtract.Name = "rb_subtract";
            this.rb_subtract.Size = new System.Drawing.Size(65, 17);
            this.rb_subtract.TabIndex = 1;
            this.rb_subtract.TabStop = true;
            this.rb_subtract.Text = "Subtract";
            this.rb_subtract.UseVisualStyleBackColor = true;
            // 
            // rb_multiply
            // 
            this.rb_multiply.AutoSize = true;
            this.rb_multiply.Location = new System.Drawing.Point(10, 80);
            this.rb_multiply.Name = "rb_multiply";
            this.rb_multiply.Size = new System.Drawing.Size(60, 17);
            this.rb_multiply.TabIndex = 2;
            this.rb_multiply.TabStop = true;
            this.rb_multiply.Text = "Multiply";
            this.rb_multiply.UseVisualStyleBackColor = true;
            // 
            // rb_divide
            // 
            this.rb_divide.AutoSize = true;
            this.rb_divide.Location = new System.Drawing.Point(100, 20);
            this.rb_divide.Name = "rb_divide";
            this.rb_divide.Size = new System.Drawing.Size(55, 17);
            this.rb_divide.TabIndex = 3;
            this.rb_divide.TabStop = true;
            this.rb_divide.Text = "Divide";
            this.rb_divide.UseVisualStyleBackColor = true;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(70, 240);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 5;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(20, 280);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(40, 13);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.Text = "Result:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.gb_operations);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Name = "Form1";
            this.Text = "Improved Calculator";
            this.gb_operations.ResumeLayout(false);
            this.gb_operations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.GroupBox gb_operations;
        private System.Windows.Forms.RadioButton rb_add;
        private System.Windows.Forms.RadioButton rb_subtract;
        private System.Windows.Forms.RadioButton rb_multiply;
        private System.Windows.Forms.RadioButton rb_divide;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_result;
    }
}
