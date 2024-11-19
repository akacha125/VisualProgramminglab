namespace vp_lab7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox text_box_input;
        private Label lbl_char_count;

        private void InitializeComponent()
        {
            this.text_box_input = new System.Windows.Forms.TextBox();
            this.lbl_char_count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_box_input
            // 
            this.text_box_input.Location = new System.Drawing.Point(20, 20);
            this.text_box_input.Multiline = true;
            this.text_box_input.Name = "text_box_input";
            this.text_box_input.Size = new System.Drawing.Size(300, 100);
            this.text_box_input.TabIndex = 0;
            this.text_box_input.TextChanged += new System.EventHandler(this.text_box_input_TextChanged);
            // 
            // lbl_char_count
            // 
            this.lbl_char_count.AutoSize = true;
            this.lbl_char_count.Location = new System.Drawing.Point(20, 130);
            this.lbl_char_count.Name = "lbl_char_count";
            this.lbl_char_count.Size = new System.Drawing.Size(119, 15);
            this.lbl_char_count.TabIndex = 1;
            this.lbl_char_count.Text = "Characters: 0/160";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.lbl_char_count);
            this.Controls.Add(this.text_box_input);
            this.Name = "Form1";
            this.Text = "Text Limit Example";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}