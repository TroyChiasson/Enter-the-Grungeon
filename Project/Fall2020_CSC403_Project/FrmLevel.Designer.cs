namespace Fall2020_CSC403_Project {
  partial class FrmLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.ChooseClassLabel = new System.Windows.Forms.Label();
            this.ClassAssassinButton = new System.Windows.Forms.Button();
            this.ClassFighterButton = new System.Windows.Forms.Button();
            this.ClassTankButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.mainMenuPlay = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.VolumeUp = new System.Windows.Forms.Button();
            this.VolumeDown = new System.Windows.Forms.Button();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.VolumeUpInGame = new System.Windows.Forms.Button();
            this.VolumeDownInGame = new System.Windows.Forms.Button();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblPlayerStrength = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.SetNameButton = new System.Windows.Forms.Button();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picEnemyFlea = new System.Windows.Forms.PictureBox();
            this.DisplayClassFighter = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClassMenuBackground = new System.Windows.Forms.PictureBox();
            this.picAssassin = new System.Windows.Forms.PictureBox();
            this.picTank = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyFlea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayClassFighter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassMenuBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAssassin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).BeginInit();
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
            // ChooseClassLabel
            // 
            this.ChooseClassLabel.AutoSize = true;
            this.ChooseClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseClassLabel.Location = new System.Drawing.Point(412, 168);
            this.ChooseClassLabel.Name = "ChooseClassLabel";
            this.ChooseClassLabel.Size = new System.Drawing.Size(295, 46);
            this.ChooseClassLabel.TabIndex = 31;
            this.ChooseClassLabel.Text = "Choose a class";
            // 
            // ClassAssassinButton
            // 
            this.ClassAssassinButton.Location = new System.Drawing.Point(867, 322);
            this.ClassAssassinButton.Name = "ClassAssassinButton";
            this.ClassAssassinButton.Size = new System.Drawing.Size(219, 99);
            this.ClassAssassinButton.TabIndex = 30;
            this.ClassAssassinButton.Text = "Assassin";
            this.ClassAssassinButton.UseVisualStyleBackColor = true;
            this.ClassAssassinButton.Click += new System.EventHandler(this.ClassAssassinButton_Click);
            // 
            // ClassFighterButton
            // 
            this.ClassFighterButton.Location = new System.Drawing.Point(471, 322);
            this.ClassFighterButton.Name = "ClassFighterButton";
            this.ClassFighterButton.Size = new System.Drawing.Size(219, 99);
            this.ClassFighterButton.TabIndex = 29;
            this.ClassFighterButton.Text = "Fighter";
            this.ClassFighterButton.UseVisualStyleBackColor = true;
            this.ClassFighterButton.Click += new System.EventHandler(this.ClassFighterButton_Click);
            // 
            // ClassTankButton
            // 
            this.ClassTankButton.Location = new System.Drawing.Point(91, 326);
            this.ClassTankButton.Name = "ClassTankButton";
            this.ClassTankButton.Size = new System.Drawing.Size(219, 99);
            this.ClassTankButton.TabIndex = 28;
            this.ClassTankButton.Text = "Tank";
            this.ClassTankButton.UseVisualStyleBackColor = true;
            this.ClassTankButton.Click += new System.EventHandler(this.ClassTankButton_Click);
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
            // mainMenuPlay
            // 
            this.mainMenuPlay.Location = new System.Drawing.Point(357, 175);
            this.mainMenuPlay.Name = "mainMenuPlay";
            this.mainMenuPlay.Size = new System.Drawing.Size(334, 141);
            this.mainMenuPlay.TabIndex = 35;
            this.mainMenuPlay.Text = "Play";
            this.mainMenuPlay.UseVisualStyleBackColor = true;
            this.mainMenuPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(356, 425);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(334, 141);
            this.SettingsButton.TabIndex = 37;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // VolumeUp
            // 
            this.VolumeUp.Location = new System.Drawing.Point(741, 322);
            this.VolumeUp.Name = "VolumeUp";
            this.VolumeUp.Size = new System.Drawing.Size(140, 65);
            this.VolumeUp.TabIndex = 38;
            this.VolumeUp.Text = "Volume+";
            this.VolumeUp.UseVisualStyleBackColor = true;
            this.VolumeUp.Click += new System.EventHandler(this.VolumeUp_Click);
            // 
            // VolumeDown
            // 
            this.VolumeDown.Location = new System.Drawing.Point(254, 324);
            this.VolumeDown.Name = "VolumeDown";
            this.VolumeDown.Size = new System.Drawing.Size(140, 65);
            this.VolumeDown.TabIndex = 39;
            this.VolumeDown.Text = "Volume-";
            this.VolumeDown.UseVisualStyleBackColor = true;
            this.VolumeDown.Click += new System.EventHandler(this.VolumeDown_Click);
            // 
            // BackToMenu
            // 
            this.BackToMenu.Location = new System.Drawing.Point(481, 528);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(140, 65);
            this.BackToMenu.TabIndex = 40;
            this.BackToMenu.Text = "Back To Main Menu";
            this.BackToMenu.UseVisualStyleBackColor = true;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
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
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(400, 89);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(315, 20);
            this.playerNameTextBox.TabIndex = 43;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.BackColor = System.Drawing.Color.DimGray;
            this.playerNameLabel.Location = new System.Drawing.Point(327, 92);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(67, 13);
            this.playerNameLabel.TabIndex = 44;
            this.playerNameLabel.Text = "Player Name";
            // 
            // SetNameButton
            // 
            this.SetNameButton.Location = new System.Drawing.Point(741, 78);
            this.SetNameButton.Name = "SetNameButton";
            this.SetNameButton.Size = new System.Drawing.Size(130, 40);
            this.SetNameButton.TabIndex = 45;
            this.SetNameButton.Text = "Set Name";
            this.SetNameButton.UseVisualStyleBackColor = true;
            this.SetNameButton.Click += new System.EventHandler(this.SetNameButton_Click);
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.Location = new System.Drawing.Point(551, 425);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(164, 232);
            this.picWall7.TabIndex = 17;
            this.picWall7.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.Location = new System.Drawing.Point(1093, 274);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(82, 449);
            this.picWall5.TabIndex = 15;
            this.picWall5.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.Location = new System.Drawing.Point(653, 89);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(228, 162);
            this.picWall9.TabIndex = 11;
            this.picWall9.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.Location = new System.Drawing.Point(266, 154);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(197, 118);
            this.picWall8.TabIndex = 10;
            this.picWall8.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.Location = new System.Drawing.Point(890, 397);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(203, 113);
            this.picWall6.TabIndex = 8;
            this.picWall6.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.Location = new System.Drawing.Point(2, 454);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(82, 203);
            this.picWall3.TabIndex = 7;
            this.picWall3.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.Location = new System.Drawing.Point(2, 656);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(1092, 67);
            this.picWall4.TabIndex = 6;
            this.picWall4.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.Location = new System.Drawing.Point(2, 388);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(358, 67);
            this.picWall2.TabIndex = 3;
            this.picWall2.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(110, 98);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(63, 96);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(838, 540);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(64, 107);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(971, 74);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(193, 194);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.Location = new System.Drawing.Point(2, 1);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(82, 388);
            this.picWall1.TabIndex = 12;
            this.picWall1.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(119, 510);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(54, 106);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.Location = new System.Drawing.Point(83, 1);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(937, 67);
            this.picWall0.TabIndex = 13;
            this.picWall0.TabStop = false;
            // 
            // picEnemyFlea
            // 
            this.picEnemyFlea.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyFlea.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_flea_0;
            this.picEnemyFlea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picEnemyFlea.Location = new System.Drawing.Point(433, 324);
            this.picEnemyFlea.Name = "picEnemyFlea";
            this.picEnemyFlea.Size = new System.Drawing.Size(54, 102);
            this.picEnemyFlea.TabIndex = 18;
            this.picEnemyFlea.TabStop = false;
            // 
            // DisplayClassFighter
            // 
            this.DisplayClassFighter.BackColor = System.Drawing.Color.Transparent;
            this.DisplayClassFighter.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.DisplayClassFighter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DisplayClassFighter.Location = new System.Drawing.Point(557, 452);
            this.DisplayClassFighter.Name = "DisplayClassFighter";
            this.DisplayClassFighter.Size = new System.Drawing.Size(54, 106);
            this.DisplayClassFighter.TabIndex = 34;
            this.DisplayClassFighter.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(-58, -35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1399, 779);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // ClassMenuBackground
            // 
            this.ClassMenuBackground.Location = new System.Drawing.Point(-12, 1);
            this.ClassMenuBackground.Name = "ClassMenuBackground";
            this.ClassMenuBackground.Size = new System.Drawing.Size(1187, 742);
            this.ClassMenuBackground.TabIndex = 19;
            this.ClassMenuBackground.TabStop = false;
            // 
            // picAssassin
            // 
            this.picAssassin.BackColor = System.Drawing.Color.Transparent;
            this.picAssassin.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.assassin;
            this.picAssassin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAssassin.Location = new System.Drawing.Point(972, 445);
            this.picAssassin.Name = "picAssassin";
            this.picAssassin.Size = new System.Drawing.Size(54, 106);
            this.picAssassin.TabIndex = 33;
            this.picAssassin.TabStop = false;
            // 
            // picTank
            // 
            this.picTank.BackColor = System.Drawing.Color.Transparent;
            this.picTank.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Tank;
            this.picTank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTank.Location = new System.Drawing.Point(179, 454);
            this.picTank.Name = "picTank";
            this.picTank.Size = new System.Drawing.Size(58, 113);
            this.picTank.TabIndex = 32;
            this.picTank.TabStop = false;
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 726);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.SetNameButton);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.VolumeDownInGame);
            this.Controls.Add(this.VolumeUpInGame);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblPlayerStrength);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picEnemyFlea);
            this.Controls.Add(this.DisplayClassFighter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ClassMenuBackground);
            this.Controls.Add(this.VolumeDown);
            this.Controls.Add(this.VolumeUp);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.mainMenuPlay);
            this.Controls.Add(this.ClassFighterButton);
            this.Controls.Add(this.ChooseClassLabel);
            this.Controls.Add(this.ClassAssassinButton);
            this.Controls.Add(this.picAssassin);
            this.Controls.Add(this.picTank);
            this.Controls.Add(this.ClassTankButton);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyFlea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayClassFighter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassMenuBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAssassin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picBossKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
    private System.Windows.Forms.PictureBox picEnemyCheeto;
    private System.Windows.Forms.PictureBox picWall4;
    private System.Windows.Forms.PictureBox picWall3;
    private System.Windows.Forms.PictureBox picWall6;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall9;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall5;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picEnemyFlea;
        private System.Windows.Forms.PictureBox ClassMenuBackground;
        private System.Windows.Forms.PictureBox DisplayClassFighter;
        private System.Windows.Forms.PictureBox picTank;
        private System.Windows.Forms.PictureBox picAssassin;
        private System.Windows.Forms.Label ChooseClassLabel;
        private System.Windows.Forms.Button ClassAssassinButton;
        private System.Windows.Forms.Button ClassFighterButton;
        private System.Windows.Forms.Button ClassTankButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button mainMenuPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button VolumeUp;
        private System.Windows.Forms.Button VolumeDown;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.Button VolumeUpInGame;
        private System.Windows.Forms.Button VolumeDownInGame;
        private System.Windows.Forms.Label lblPlayerHealthFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblPlayerStrength;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Button SetNameButton;
    }
}