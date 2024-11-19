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
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            this.btn_calculate.Location = new System.Drawing.Point(100, 20);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(100, 30);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Calculate Squares";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_click);
            this.txt_result.Location = new System.Drawing.Point(20, 70);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_result.Size = new System.Drawing.Size(260, 200);
            this.txt_result.TabIndex = 1;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_result);
            this.Name = "Form1";
            this.Text = "Square Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_result;
    }
}