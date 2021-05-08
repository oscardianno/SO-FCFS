using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO_FCFS
{
    class Horse
    {
        public const string horsetag = "Nosense";
        public Horse(int position)
        {
            this.Id = Guid.NewGuid().ToString();
            CreatePictureBox();
            this.Position = position;
            CreateLabel();
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public PictureBox PictureBox { get; private set; }
        public Label Label { get; set; }
        public bool IsRunning { get; set; } = false;
        private int position;
        public int Position { get { return this.position; } set
            {
                this.position = value;
                PictureBox.Location = new System.Drawing.Point(value * 50 + 30, 350);

            }
        }
        private void CreateLabel()
        {
            Label = new Label();
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(PictureBox.Location.X, PictureBox.Location.Y - 13);
            Label.Name = Id;
            Label.Size = new System.Drawing.Size(93, 13);
            Label.TabIndex = 3;
            Label.Text = new string((char) (position + 65), 1);
        }
        private void CreatePictureBox()
        {
            PictureBox = new PictureBox();
            PictureBox.Image = global::SO_FCFS.Properties.Resources.running_horse;
            PictureBox.Name = Id;
            PictureBox.Size = new System.Drawing.Size(50, 50);
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.Tag = this;
        }
    }
}
