using Fall2020_CSC403_Project.code;
using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    internal class FrmMainMenu : Form
    {
        private PictureBox pictureBox1;
        private Button button1;

        public FrmMainMenu()
        {
            InitializeComponent();

        }
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(-15, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1399, 779);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 141);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMainMenu
            // 
            this.ClientSize = new System.Drawing.Size(1256, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmMainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (this.button1.Enabled)
            {
                this.Hide();
                FrmLevel openLevel = new FrmLevel();
                openLevel.ShowDialog();
            }
        }


    }
}