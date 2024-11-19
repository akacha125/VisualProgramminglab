
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
            this.lbl_fahrenheit = new System.Windows.Forms.Label();
            this.txt_fahrenheit = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lbl_fahrenheit.AutoSize = true;
            this.lbl_fahrenheit.Location = new System.Drawing.Point(20, 20);
            this.lbl_fahrenheit.Name = "lbl_fahrenheit";
            this.lbl_fahrenheit.Size = new System.Drawing.Size(95, 15);
            this.lbl_fahrenheit.TabIndex = 0;
            this.lbl_fahrenheit.Text = "Fahrenheit:";
            this.txt_fahrenheit.Location = new System.Drawing.Point(120, 20);
            this.txt_fahrenheit.Name = "txt_fahrenheit";
            this.txt_fahrenheit.Size = new System.Drawing.Size(100, 23);
            this.txt_fahrenheit.TabIndex = 1;
            this.btn_convert.Location = new System.Drawing.Point(80, 60);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(100, 30);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_click);
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(20, 110);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(80, 15);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "Celsius: ";
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.lbl_fahrenheit);
            this.Controls.Add(this.txt_fahrenheit);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lbl_result);
            this.Name = "Form1";
            this.Text = "Fahrenheit to Celsius";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_fahrenheit;
        private System.Windows.Forms.TextBox txt_fahrenheit;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label lbl_result;
    }
}