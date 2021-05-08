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

        bool noMore = false;
        static System.Windows.Forms.Timer enqueueTimer = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer runHorseTimer = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer horsePicker = new System.Windows.Forms.Timer();
        Queue<Horse> horseQueue = new Queue<Horse>();
        Horse currenthorse;
        public Form1()
        {
            InitializeComponent();
            enqueueTimer.Interval = 200;
            enqueueTimer.Tick += new EventHandler(AddToQueue);
            runHorseTimer.Interval = 10;
            runHorseTimer.Tick += new EventHandler(TimerTick);
            horsePicker.Interval = 1500;
            horsePicker.Tick += new EventHandler(PickHorse);

        }

        void TimerTick(object sender, EventArgs e)
        {
            if (currenthorse == null)
            {
                return;
            }
            int x = currenthorse.PictureBox.Location.X;
            int y = currenthorse.PictureBox.Location.Y;

            currenthorse.PictureBox.Location = new Point(x + 8, y);
            currenthorse.Label.Location = new Point(x + 8, y - 13);

            if (x > (this.pictureBox_finishLine.Location.X - currenthorse.PictureBox.Width))
            {
                currenthorse.IsRunning = true;
                this.Controls.Remove(currenthorse.PictureBox);
                this.Controls.Remove(currenthorse.Label);
                currenthorse = null;
            }
        }
        void PickHorse(object sender, EventArgs e)
        {
            if (currenthorse != null)
            {
                return;
            }
            if (horseQueue.Count == 0)
            {
                enqueueTimer.Stop();
                horsePicker.Stop();
                runHorseTimer.Stop();
                MessageBox.Show("Finalizado");
                return;
            }
            currenthorse = horseQueue.Dequeue();
            currenthorse.IsRunning = true;
            RerenderHorseQueue();
            currenthorse.PictureBox.Location = new System.Drawing.Point(102, 12);
            currenthorse.PictureBox.Size = new System.Drawing.Size(125, 85);
            currenthorse.Label.Location = new System.Drawing.Point(102, 12 - 13);
        }
        void AddToQueue(object sender, EventArgs e)
        {
            if (noMore)
            {
                return;
            }
            int count = horseQueue.Count;
            horseQueue.Enqueue(new Horse(count++));
            RerenderHorseQueue();
            if (count > 6 && !noMore)
            {
                noMore = true;
            }
        }

        void RerenderHorseQueue()
        {
            foreach (var item in Controls)
            {
                if (item is PictureBox itemCasted)
                {
                    if (itemCasted.Tag is Horse horse && !horse.IsRunning)
                    {
                        if (!this.horseQueue.Any(hq => hq.PictureBox == item))
                        {
                            this.Controls.Remove(horse.Label);
                            this.Controls.Remove(itemCasted);
                        }
                    }
                    
                }
            }
            foreach (var horse in horseQueue)
            {
                this.Controls.Add(horse.PictureBox);
                this.Controls.Add(horse.Label);
            }
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            runHorseTimer.Start();
            enqueueTimer.Start();
            horsePicker.Start();
        }

        private void pictureBox_finishLine_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
