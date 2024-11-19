
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
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            this.picture_box.Location = new System.Drawing.Point(20, 20);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(500, 300);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box.TabIndex = 0;
            this.picture_box.TabStop = false;
            this.btn_browse.Location = new System.Drawing.Point(20, 330);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 25);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            this.btn_previous.Location = new System.Drawing.Point(120, 330);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 25);
            this.btn_previous.TabIndex = 2;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            this.btn_next.Location = new System.Drawing.Point(220, 330);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 25);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.picture_box);
            this.Name = "Form1";
            this.Text = "Photo Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
    }
}