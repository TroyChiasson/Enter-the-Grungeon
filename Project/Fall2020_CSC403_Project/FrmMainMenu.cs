using Fall2020_CSC403_Project.code;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    internal class FrmMainMenu : Form
    {
        private Button button1;

        public FrmMainMenu()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 129);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMainMenu
            // 
            this.ClientSize = new System.Drawing.Size(1088, 838);
            this.Controls.Add(this.button1);
            this.Name = "FrmMainMenu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.ResumeLayout(false);

        }

        private void FrmMainMenu_Load(object sender, System.EventArgs e)
        {

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