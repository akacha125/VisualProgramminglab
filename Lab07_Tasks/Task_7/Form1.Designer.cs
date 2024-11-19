
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
            this.lbl_date_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lbl_date_time.AutoSize = true;
            this.lbl_date_time.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date_time.Location = new System.Drawing.Point(20, 20);
            this.lbl_date_time.Name = "lbl_date_time";
            this.lbl_date_time.Size = new System.Drawing.Size(180, 30);
            this.lbl_date_time.TabIndex = 0;
            this.lbl_date_time.Text = "Current Date Time";
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.lbl_date_time);
            this.Name = "Form1";
            this.Text = "Wall Clock";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_date_time;
    }
}