using Fall2020_CSC403_Project.code;
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
        private Player player;
        private FrmLevel level;
        private bool fightingFlea = false;


        private FrmBattle()
        {
            InitializeComponent();
            player = Game.player;
        }

        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;

            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;

            // show health
            UpdateStats();
        }

        public void SetupForBossBattle()
        {
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
        }

        public void SetupForFlea(FrmLevel level)
        {
            fightingFlea = true;
            this.level = level;
        }

        public static FrmBattle GetInstance(Enemy enemy)
        {
            if (instance == null)
            {
                instance = new FrmBattle();
                instance.enemy = enemy;
                instance.Setup();
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

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();

            lblPlayerStrength.Text = "Attack Power: " + (player._strength * 4).ToString();

            lblPlayerScore.Text = "Score: " + player.Score.ToString();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            player.OnAttack(-4);
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2);
            }

            UpdateStats();

            if (enemy.Health <= 0 && fightingFlea)
            {
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

                fightingFlea = false;
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
                enemy.OnAttack(-2);
            }

            UpdateStats();

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
        }

        private void HeavyAttackButton_Click(object sender, EventArgs e)
        {
            player.OnAttack(-6);
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2);
                enemy.OnAttack(-2);
            }

            UpdateStats();

            if (enemy.Health <= 0 && fightingFlea)
            {
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

                fightingFlea = false;
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
        }
    }
}
