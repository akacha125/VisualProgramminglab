using System;
using System.Windows.Forms;

namespace vp_lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_date_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
