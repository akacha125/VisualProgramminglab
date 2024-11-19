
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
            this.lbl_enter_time = new System.Windows.Forms.Label();
            this.txt_seconds = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lbl_enter_time.AutoSize = true;
            this.lbl_enter_time.Location = new System.Drawing.Point(20, 20);
            this.lbl_enter_time.Name = "lbl_enter_time";
            this.lbl_enter_time.Size = new System.Drawing.Size(93, 15);
            this.lbl_enter_time.TabIndex = 0;
            this.lbl_enter_time.Text = "Time (seconds):";
            this.txt_seconds.Location = new System.Drawing.Point(130, 20);
            this.txt_seconds.Name = "txt_seconds";
            this.txt_seconds.Size = new System.Drawing.Size(100, 23);
            this.txt_seconds.TabIndex = 1;
            this.btn_start.Location = new System.Drawing.Point(80, 60);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 25);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_click);
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(20, 110);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(70, 15);
            this.lbl_timer.TabIndex = 3;
            this.lbl_timer.Text = "Time Left: ";
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.lbl_enter_time);
            this.Controls.Add(this.txt_seconds);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_timer);
            this.Name = "Form1";
            this.Text = "Countdown Timer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_enter_time;
        private System.Windows.Forms.TextBox txt_seconds;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_timer;
    }
}