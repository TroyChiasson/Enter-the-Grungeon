namespace Fall2020_CSC403_Project
{
    partial class FrmLevel2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picEnemyFlea0 = new System.Windows.Forms.PictureBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.VolumeUpInGame = new System.Windows.Forms.Button();
            this.VolumeDownInGame = new System.Windows.Forms.Button();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblPlayerStrength = new System.Windows.Forms.Label();
            this.picEnemyFlea2 = new System.Windows.Forms.PictureBox();
            this.picEnemyFlea1 = new System.Windows.Forms.PictureBox();
            this.lblPlayerScore2 = new System.Windows.Forms.Label();
            this.lblPlayerStrength2 = new System.Windows.Forms.Label();
            this.PauseMenuBackground = new System.Windows.Forms.PictureBox();
            this.ResumeGameButton = new System.Windows.Forms.Button();
            this.QuitToMainMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyFlea0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyFlea2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyFlea1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseMenuBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 34);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(41, 18);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "timer";
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.Location = new System.Drawing.Point(1093, 1);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(82, 722);
            this.picWall3.TabIndex = 15;
            this.picWall3.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.Location = new System.Drawing.Point(76, 1);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(1017, 67);
            this.picWall0.TabIndex = 13;
            this.picWall0.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.Location = new System.Drawing.Point(2, 1);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(82, 475);
            this.picWall1.TabIndex = 12;
            this.picWall1.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.Location = new System.Drawing.Point(222, 651);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(872, 72);
            this.picWall2.TabIndex = 6;
            this.picWall2.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(163, 504);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(54, 106);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picEnemyFlea0
            // 
            this.picEnemyFlea0.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyFlea0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_flea_1;
            this.picEnemyFlea0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picEnemyFlea0.Location = new System.Drawing.Point(171, 138);
            this.picEnemyFlea0.Name = "picEnemyFlea0";
            this.picEnemyFlea0.Size = new System.Drawing.Size(124, 104);
            this.picEnemyFlea0.TabIndex = 18;
            this.picEnemyFlea0.TabStop = false;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(1019, 4);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 18;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButtonClick);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(1100, 4);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(71, 23);
            this.PauseButton.TabIndex = 19;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButtonClick);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(1058, 33);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 20;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // VolumeUpInGame
            // 
            this.VolumeUpInGame.Location = new System.Drawing.Point(1019, 33);
            this.VolumeUpInGame.Name = "VolumeUpInGame";
            this.VolumeUpInGame.Size = new System.Drawing.Size(26, 23);
            this.VolumeUpInGame.TabIndex = 41;
            this.VolumeUpInGame.Text = "+";
            this.VolumeUpInGame.UseVisualStyleBackColor = true;
            this.VolumeUpInGame.Click += new System.EventHandler(this.VolumeUpInGame_Click);
            // 
            // VolumeDownInGame
            // 
            this.VolumeDownInGame.Location = new System.Drawing.Point(1145, 33);
            this.VolumeDownInGame.Name = "VolumeDownInGame";
            this.VolumeDownInGame.Size = new System.Drawing.Size(26, 23);
            this.VolumeDownInGame.TabIndex = 42;
            this.VolumeDownInGame.Text = "-";
            this.VolumeDownInGame.UseVisualStyleBackColor = true;
            this.VolumeDownInGame.Click += new System.EventHandler(this.VolumeDownInGame_Click);
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(12, 4);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(226, 23);
            this.lblPlayerHealthFull.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 36;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.Black;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.White;
            this.lblPlayerScore.Location = new System.Drawing.Point(249, 34);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(46, 18);
            this.lblPlayerScore.TabIndex = 37;
            this.lblPlayerScore.Text = "score";
            // 
            // lblPlayerStrength
            // 
            this.lblPlayerStrength.AutoSize = true;
            this.lblPlayerStrength.BackColor = System.Drawing.Color.Black;
            this.lblPlayerStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStrength.ForeColor = System.Drawing.Color.White;
            this.lblPlayerStrength.Location = new System.Drawing.Point(249, 9);
            this.lblPlayerStrength.Name = "lblPlayerStrength";
            this.lblPlayerStrength.Size = new System.Drawing.Size(61, 18);
            this.lblPlayerStrength.TabIndex = 38;
            this.lblPlayerStrength.Text = "strength";
            // 
            // picEnemyFlea2
            // 
            this.picEnemyFlea2.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyFlea2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_flea_1;
            this.picEnemyFlea2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picEnemyFlea2.Location = new System.Drawing.Point(891, 504);
            this.picEnemyFlea2.Name = "picEnemyFlea2";
            this.picEnemyFlea2.Size = new System.Drawing.Size(124, 104);
            this.picEnemyFlea2.TabIndex = 43;
            this.picEnemyFlea2.TabStop = false;
            // 
            // picEnemyFlea1
            // 
            this.picEnemyFlea1.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyFlea1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_flea_1;
            this.picEnemyFlea1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picEnemyFlea1.Location = new System.Drawing.Point(891, 138);
            this.picEnemyFlea1.Name = "picEnemyFlea1";
            this.picEnemyFlea1.Size = new System.Drawing.Size(124, 104);
            this.picEnemyFlea1.TabIndex = 45;
            this.picEnemyFlea1.TabStop = false;
            // 
            // lblPlayerScore2
            // 
            this.lblPlayerScore2.AutoSize = true;
            this.lblPlayerScore2.BackColor = System.Drawing.Color.Black;
            this.lblPlayerScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore2.ForeColor = System.Drawing.Color.White;
            this.lblPlayerScore2.Location = new System.Drawing.Point(249, 30);
            this.lblPlayerScore2.Name = "lblPlayerScore2";
            this.lblPlayerScore2.Size = new System.Drawing.Size(46, 18);
            this.lblPlayerScore2.TabIndex = 46;
            this.lblPlayerScore2.Text = "score";
            // 
            // lblPlayerStrength2
            // 
            this.lblPlayerStrength2.AutoSize = true;
            this.lblPlayerStrength2.BackColor = System.Drawing.Color.Black;
            this.lblPlayerStrength2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStrength2.ForeColor = System.Drawing.Color.White;
            this.lblPlayerStrength2.Location = new System.Drawing.Point(249, 5);
            this.lblPlayerStrength2.Name = "lblPlayerStrength2";
            this.lblPlayerStrength2.Size = new System.Drawing.Size(61, 18);
            this.lblPlayerStrength2.TabIndex = 47;
            this.lblPlayerStrength2.Text = "strength";
            // 
            // PauseMenuBackground
            // 
            this.PauseMenuBackground.Location = new System.Drawing.Point(0, 0);
            this.PauseMenuBackground.Name = "PauseMenuBackground";
            this.PauseMenuBackground.Size = new System.Drawing.Size(1187, 742);
            this.PauseMenuBackground.TabIndex = 49;
            this.PauseMenuBackground.TabStop = false;
            // 
            // ResumeGameButton
            // 
            this.ResumeGameButton.Location = new System.Drawing.Point(485, 270);
            this.ResumeGameButton.Name = "ResumeGameButton";
            this.ResumeGameButton.Size = new System.Drawing.Size(206, 100);
            this.ResumeGameButton.TabIndex = 50;
            this.ResumeGameButton.Text = "Resume Game";
            this.ResumeGameButton.UseVisualStyleBackColor = true;
            this.ResumeGameButton.Click += new System.EventHandler(this.ResumeGameButton_Click);

            // 
            // QuitToMainMenuButton
            // 
            this.QuitToMainMenuButton.Location = new System.Drawing.Point(485, 376);
            this.QuitToMainMenuButton.Name = "QuitToMainMenuButton";
            this.QuitToMainMenuButton.Size = new System.Drawing.Size(206, 100);
            this.QuitToMainMenuButton.TabIndex = 51;
            this.QuitToMainMenuButton.Text = "Quit to Main Menu";
            this.QuitToMainMenuButton.UseVisualStyleBackColor = true;
            this.QuitToMainMenuButton.Click += new System.EventHandler(this.QuitToMainMenuButton_Click);

            // 
            // FrmLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 726);
            this.Controls.Add(this.lblPlayerScore2);
            this.Controls.Add(this.lblPlayerStrength2);
            this.Controls.Add(this.VolumeDownInGame);
            this.Controls.Add(this.VolumeUpInGame);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblPlayerStrength);
            this.Controls.Add(this.picEnemyFlea0);
            this.Controls.Add(this.picEnemyFlea1);
            this.Controls.Add(this.picEnemyFlea2);
            this.Controls.Add(this.PauseMenuBackground);
            this.Controls.Add(this.ResumeGameButton);
            this.Controls.Add(this.QuitToMainMenuButton);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "dwawd";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyFlea0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyFlea2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyFlea1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseMenuBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picWall0;
        private System.Windows.Forms.PictureBox picEnemyFlea0;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button VolumeUpInGame;
        private System.Windows.Forms.Button VolumeDownInGame;
        private System.Windows.Forms.Label lblPlayerHealthFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblPlayerStrength;
        public System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picEnemyFlea2;
        private System.Windows.Forms.PictureBox picEnemyFlea1;
        private System.Windows.Forms.Label lblPlayerScore2;
        private System.Windows.Forms.Label lblPlayerStrength2;
        private System.Windows.Forms.PictureBox PauseMenuBackground;
        private System.Windows.Forms.Button ResumeGameButton;
        private System.Windows.Forms.Button QuitToMainMenuButton;
    }
}