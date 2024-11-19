
using System;
using System.Windows.Forms;
using System.Timers;

namespace vp_lab7
{
    public partial class Form1 : Form
    {
        private int countdown_seconds;
        private System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (countdown_seconds > 0)
            {
                countdown_seconds--;
                Invoke(new Action(() => lbl_timer.Text = $"Time Left: {countdown_seconds} seconds"));
            }
            else
            {
                timer.Stop();
                Invoke(new Action(() => MessageBox.Show("Time's up!", "Countdown Timer")));
            }
        }

        private void btn_start_click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_seconds.Text, out countdown_seconds) && countdown_seconds > 0)
            {
                lbl_timer.Text = $"Time Left: {countdown_seconds} seconds";
                timer.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid positive integer.", "Invalid Input");
            }
        }
    }
}