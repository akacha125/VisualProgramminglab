
using System;
using System.IO;
using System.Windows.Forms;

namespace vp_lab7
{
    public partial class Form1 : Form
    {
        private int current_index = 0;
        private string[] image_files;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            var folder_dialog = new FolderBrowserDialog();
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                image_files = Directory.GetFiles(folder_dialog.SelectedPath, "*.jpg;*.jpeg;*.png", SearchOption.TopDirectoryOnly);
                current_index = 0;
                ShowImage();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (image_files != null && image_files.Length > 0)
            {
                current_index = (current_index + 1) % image_files.Length;
                ShowImage();
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (image_files != null && image_files.Length > 0)
            {
                current_index = (current_index - 1 + image_files.Length) % image_files.Length;
                ShowImage();
            }
        }

        private void ShowImage()
        {
            if (image_files != null && image_files.Length > 0)
            {
                picture_box.ImageLocation = image_files[current_index];
            }
        }
    }
}