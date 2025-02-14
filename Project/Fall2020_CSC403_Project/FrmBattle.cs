﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBattle : Form
    {
        public static FrmBattle instance = null;
        private Enemy enemy;
        public Player player;
        public FrmLevel level { get; private set; }
        public float resetStrength = Game.player._strength;

        private FrmBattle()
        {
            InitializeComponent();
            
            player = Game.player;
        }

        public void Setup(PictureBox picPlayer)
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;

            this.picPlayer.BackgroundImage = picPlayer.BackgroundImage;
            picPlayer.Refresh();    

            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;

            // show health
            UpdateStats();
        }

        public void SetupForBossBattle(FrmLevel lvl)
        {
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
            level = lvl;
        }

        public void SetupForFlea(FrmLevel level)
        {
            this.level = level;
        }
        public void SetupForLVL2(Player player)
        {
            this.player = player;
        }

        public static FrmBattle GetInstance(Enemy enemy, PictureBox picPlayer)
        {
            if (instance == null)
            {
                instance = new FrmBattle();
                instance.enemy = enemy;
                instance.Setup(picPlayer);
            }
            return instance;
        }

        private void UpdateStats()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString() + "/" + player.MaxHealth.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString() + "/" + enemy.MaxHealth.ToString();

            lblPlayerStrength.Text = "Attack Power: " + (player._strength * 4).ToString();

            lblPlayerScore.Text = "Score: " + player.Score.ToString();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            switch (enemy.Name)
            {
                case "enemyBossKoolAid":
                    player.OnAttack(-4);
                    break;

                case "enemyPoisonPacket":
                    // Weak to Piercing damage
                    player.OnAttack(-5);
                    break;

                case "enemyCheeto":
                    // resistant to bludgeoning damage
                    player.OnAttack(-3);
                    break;

                case "enemyFlea":
                    player.OnAttack(-4);
                    break;
                case "enemyFlea0":
                    player.OnAttack(-4);
                    break;
                case "enemyFlea1":
                    player.OnAttack(-4);
                    break;
                case "enemyFlea2":
                    player.OnAttack(-4);
                    break;
            }

            if (enemy.Health > 0)
            {
                enemy.OnAttack(-3);
            }

            if (enemy.Health <= 0 && enemy.Name == "enemyFlea")
            {
                FrmPaymentChoice frmPaymentChoice = new FrmPaymentChoice(this);
                frmPaymentChoice.Show();
                /*
                Random rand = new Random();
                int buffEffect = rand.Next(2);
                switch (buffEffect)
                {
                    case 0:
                        player.buffHealth();
                        break;
                    case 1:
                        player.buffAttack();
                        level.displayAttackBoost();
                        break;
                    case 2:
                        player.buffHealth();
                        player.buffAttack();
                        level.displayAttackBoost();
                        break;
                }
                */               
            }

            UpdateStats();
            
            if (enemy.Health <= 0 && enemy.Name == "enemyBossKoolAid")
            {
                player.Score += 10;
                NextLevel();
            }
            if (player.Health <= 0)
            {
                FrmGameOver frmGameOver = new FrmGameOver();
                frmGameOver.Show();

                instance = null;
                Close();
            }
            else if (enemy.Health <= 0)
            {
                player._strength = resetStrength;
                player.Score += 20;
                instance = null;
                Close();
            }
        }


        private void HeavyAttackButton_Click(object sender, EventArgs e)
        {
            switch (enemy.Name)
            {
                case "enemyBossKoolAid":
                    player.OnAttack(-6);
                    break;

                case "enemyPoisonPacket":
                    // resistant to piercing damage
                    player.OnAttack(-5);
                    break;

                case "enemyCheeto":
                    // weak to bludgeoning damage
                    player.OnAttack(-7);
                    break;

                case "enemyFlea":
                    player.OnAttack(-6);
                    break;
                case "enemyFlea0":
                    player.OnAttack(-6);
                    break;
                case "enemyFlea1":
                    player.OnAttack(-6);
                    break;
                case "enemyFlea2":
                    player.OnAttack(-6);
                    break;

            }

            if (enemy.Health > 0)
            {
                enemy.OnAttack(-4);
            }

            if (enemy.Health <= 0 && enemy.Name == "enemyFlea")
            {
                FrmPaymentChoice frmPaymentChoice = new FrmPaymentChoice(this);
                frmPaymentChoice.Show();
                /*
                Random rand = new Random();
                int buffEffect = rand.Next(2);
                switch (buffEffect)
                {
                    case 0:
                        player.buffHealth();
                        break;
                    case 1:
                        player.buffAttack();
                        level.displayAttackBoost();
                        break;
                    case 2:
                        player.buffHealth();
                        player.buffAttack();
                        level.displayAttackBoost();
                        break;
                }
                */
            }

            UpdateStats();
            if (enemy.Health <= 0 && enemy.Name == "enemyBossKoolAid")
            {
                player.Score += 10;
                NextLevel();
            }
            if (player.Health <= 0)
            {
                FrmGameOver frmGameOver = new FrmGameOver();
                frmGameOver.Show();

                instance = null;
                this.Close();
            }
            else if (enemy.Health <= 0)
            {
                player.Score += 20;
                instance = null;
                this.Close();
            }
        }
        private void EnemyDamage(int amount)
        {
            enemy.AlterHealth(amount);
        }

        private void PlayerDamage(int amount)
        {
            player.AlterHealth(amount);
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e)
        {
            picBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
        }

        private void FrmBattle_Load(object sender, EventArgs e)
        {

        }

        private void buttonTaunt_Click(object sender, EventArgs e)
        {        
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-3);
            }

            if (player.Health <= 0)
            {
                FrmGameOver frmGameOver = new FrmGameOver();
                frmGameOver.Show();

                instance = null;
                Close();
            }
            else if (enemy.Health <= 0)
            {
                player.Score += 20;
                instance = null;
                Close();
            }

            player.buffAttack();
            UpdateStats();
        }

        private void NextLevel()
        {
            FrmLevel2 level2 = new FrmLevel2();
            //level2.FormClosed += GameExit;
            level2.picPlayer.BackgroundImage = picPlayer.BackgroundImage;
            level2.Show();

            level.HaltAll();
            level.Hide();
        }

        private void GameExit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
