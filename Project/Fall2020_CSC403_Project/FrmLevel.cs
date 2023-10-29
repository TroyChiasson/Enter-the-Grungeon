using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private Player player;

        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Enemy enemyFlea;
        private Character[] walls;

        private DateTime timeBegin;
        private FrmBattle frmBattle;

        private bool fleaFlag = true;

        public FrmLevel()
        {
            InitializeComponent();
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 13;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
            enemyFlea = new Enemy(CreatePosition(picEnemyFlea), CreateCollider(picEnemyFlea, PADDING), 1);

            bossKoolaid.Name = "enemyBossKoolAid";
            enemyPoisonPacket.Name = "enemyPoisonPacket";
            enemyCheeto.Name = "enemyCheeto";
            enemyFlea.Name = "enemyFlea";
            
            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
            enemyFlea.Img = picEnemyFlea.BackgroundImage;

            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);
            enemyFlea.Color = Color.BurlyWood;

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            Game.player = player;
            timeBegin = DateTime.Now;
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Vector2 RemovePosition(int x, int y) {
            return new Vector2(x, y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }
        private Collider RemoveCollider()
        {
            Rectangle rect = new Rectangle(0,0,0,0);
            return new Collider(rect);
        }

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player
            player.Move();

            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }

            // check collision with enemies
            if (HitAChar(player, enemyPoisonPacket))
            {
                Fight(enemyPoisonPacket);
            }
            else if (HitAChar(player, enemyCheeto))
            {
                Fight(enemyCheeto);
            }
            else if (HitAChar(player, enemyFlea))
            {
                Fight(enemyFlea);
            }

            if (HitAChar(player, bossKoolaid))
            {
                Fight(bossKoolaid);
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

            // randomly move flea
            if (fleaFlag == true)
            {
                enemyFlea.Move();
                enemyFlea.MoveRand();


                // check collision with enemies and walls
                if (HitAWall(enemyFlea))
                {
                    enemyFlea.MoveBack();
                }
                if (HitAChar(enemyFlea, enemyPoisonPacket))
                {
                    enemyFlea.MoveBack();
                }
                if (HitAChar(enemyFlea, enemyCheeto))
                {
                    enemyFlea.MoveBack();
                }
                if (HitAChar(enemyFlea, bossKoolaid))
                {
                    enemyFlea.MoveBack();
                }

                // update flea's picture box
                picEnemyFlea.Location = new Point((int)enemyFlea.Position.x, (int)enemyFlea.Position.y);
            }
        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();

            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }

            if (enemy == enemyFlea)
            {
                frmBattle.SetupForFlea();
            }

            switch (enemy.Name) {
                case "bossKoolaid":
                    bossKoolaid = new Enemy(RemovePosition(0,0), RemoveCollider());
                    bossKoolaid.Img = null;
                    picBossKoolAid.BackgroundImage = null;
                    break;
                case "enemyPoisonPacket":
                    enemyPoisonPacket = new Enemy(RemovePosition(0,0), RemoveCollider());
                    enemyPoisonPacket.Img = null;
                    picEnemyPoisonPacket.BackgroundImage = null;

                    break;
                case "enemyCheeto":
                    enemyCheeto = new Enemy(RemovePosition(0, 0), RemoveCollider());
                    enemyCheeto.Img = null;
                    picEnemyCheeto.BackgroundImage = null;
                    break;
                case "enemyFlea":
                    enemyFlea = new Enemy(RemovePosition(0, 0), RemoveCollider());
                    picEnemyFlea.BackgroundImage = null;
                    fleaFlag = false;
                    break;
            }

        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.GoLeft();
                    break;

                case Keys.Right:
                    player.GoRight();
                    break;

                case Keys.Up:
                    player.GoUp();
                    break;

                case Keys.Down:
                    player.GoDown();
                    break;

                /*
                case (Keys.Left & Keys.Up):
                    player.GoNW();
                    break;

                case (Keys.Right & Keys.Up):
                    player.GoNE();
                    break;

                case (Keys.Left & Keys.Down):
                    player.GoSW();
                    break;

                case (Keys.Right & Keys.Down):
                    player.GoSW();
                    break;
                */

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }

        public void GameOver()
        {
            Close();
        }
    }
}
