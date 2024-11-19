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

        private void text_box_input_TextChanged(object sender, EventArgs e)
        {
            if (text_box_input.Text.Length > 160)
            {
                text_box_input.Text = text_box_input.Text.Substring(0, 160);
                text_box_input.SelectionStart = text_box_input.Text.Length; // Move the cursor to the end
            }
            lbl_char_count.Text = $"Characters: {text_box_input.Text.Length}/160";
        }
    }
}