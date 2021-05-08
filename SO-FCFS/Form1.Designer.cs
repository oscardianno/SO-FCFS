
namespace SO_FCFS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_finishLine = new System.Windows.Forms.PictureBox();
            this.lbl_waiting = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_finishLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_finishLine
            // 
            this.pictureBox_finishLine.Image = global::SO_FCFS.Properties.Resources.finishLine;
            this.pictureBox_finishLine.Location = new System.Drawing.Point(928, 12);
            this.pictureBox_finishLine.Name = "pictureBox_finishLine";
            this.pictureBox_finishLine.Size = new System.Drawing.Size(24, 324);
            this.pictureBox_finishLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_finishLine.TabIndex = 2;
            this.pictureBox_finishLine.TabStop = false;
            this.pictureBox_finishLine.Click += new System.EventHandler(this.pictureBox_finishLine_Click);
            // 
            // lbl_waiting
            // 
            this.lbl_waiting.AutoSize = true;
            this.lbl_waiting.Location = new System.Drawing.Point(31, 323);
            this.lbl_waiting.Name = "lbl_waiting";
            this.lbl_waiting.Size = new System.Drawing.Size(93, 13);
            this.lbl_waiting.TabIndex = 3;
            this.lbl_waiting.Text = "En cola de espera";
            this.lbl_waiting.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SO_FCFS.Properties.Resources.running_horse;
            this.pictureBox1.Location = new System.Drawing.Point(102, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.lbl_waiting);
            this.Controls.Add(this.pictureBox_finishLine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_finishLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox_finishLine;
        private System.Windows.Forms.Label lbl_waiting;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

