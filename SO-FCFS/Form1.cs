using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO_FCFS
{
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        void timer_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            pictureBox1.Location = new Point(x + 3, y);

            if (x > (this.pictureBox_finishLine.Location.X - pictureBox1.Width))
                timer1.Stop();
        }

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 10;
            timer1.Tick += new EventHandler(timer_Tick);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            timer1.Start();
        }

        private void pictureBox_finishLine_Click(object sender, EventArgs e)
        {

        }
    }
}
