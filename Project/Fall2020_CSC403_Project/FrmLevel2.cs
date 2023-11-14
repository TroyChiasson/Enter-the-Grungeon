using Fall2020_CSC403_Project.code;
using NAudio.Wave;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Input;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel2 : Form
    {
        private Player player;

        private Enemy enemyPoisonPacket;
        private Enemy enemyCheeto;
        private Enemy enemyFlea;
        private Character[] walls;

        private DateTime timeBegin;
        private FrmBattle frmBattle;

        private int currentSong = 0;
        private IWavePlayer waveOut;
        private AudioFileReader audio;
        private ResourceManager rm;
        private string[] songNames; // Array to store the resource names of your songs
        private bool changingSong = false;

        private bool fleaFlag = true;

        private Tuple<Key, Vector2>[] moveKeys;

        public FrmLevel2()
        {
            player = Game.player;
            InitializeComponent();
            this.KeyPreview = true;

        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 10;


            
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
            enemyFlea = new Enemy(CreatePosition(picEnemyFlea), CreateCollider(picEnemyFlea, PADDING), 1);

            enemyPoisonPacket.Name = "enemyPoisonPacket";
            enemyCheeto.Name = "enemyCheeto";
            enemyFlea.Name = "enemyFlea";

            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
            enemyFlea.Img = picEnemyFlea.BackgroundImage;

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

            songNames = new string[]
            {
                "JaredLeto_wav",
                "BeQuietAndDrive_wav",
                "ArmsWideOpen_wav",
                "_3_Doors_Down_wav",
                "HowYouRemindMe_wav",
                "MySacrifice_wav",
                "OneLatBreath_wav"
            };

            rm = new ResourceManager("Fall2020_CSC403_Project.Properties.Resources", Assembly.GetExecutingAssembly());

            // Initialize NAudio objects
            waveOut = new WaveOutEvent();
            LoadSong();

            // waveOut.PlaybackStopped += (sender, e) =>
            // {
            // if (e.Exception == null)
            // {
            //     NextButtonClick(this, EventArgs.Empty);
            //  }
            //};

            moveKeys = new Tuple<Key, Vector2>[]
            {
                Tuple.Create(Key.A,     new Vector2(-1, 0)),
                Tuple.Create(Key.D,     new Vector2(+1, 0)),
                Tuple.Create(Key.W,     new Vector2(0, -1)),
                Tuple.Create(Key.S,     new Vector2(0, +1)),
            };
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Vector2 RemovePosition(int x, int y)
        {
            return new Vector2(x, y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }
        private Collider RemoveCollider()
        {
            Rectangle rect = new Rectangle(0, 0, 0, 0);
            return new Collider(rect);
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();

            playerStatsUpdate();
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

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

            // randomly move flea
            if (fleaFlag == true)
            {
                enemyFlea.MoveRand();
                enemyFlea.Move();


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
            frmBattle = FrmBattle.GetInstance(enemy, picPlayer);
            frmBattle.Show();

            if (enemy == enemyFlea)
            {
                frmBattle.SetupForFlea();
            }

            switch (enemy.Name)
            {
                case "enemyPoisonPacket":
                    enemyPoisonPacket = new Enemy(RemovePosition(0, 0), RemoveCollider());
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

        private void playerMove()
        {
            Vector2 moveDir = new Vector2(0, 0);

            foreach (Tuple<Key, Vector2> keyBind in this.moveKeys)
            {
                if (Keyboard.IsKeyDown(keyBind.Item1))
                {
                    moveDir = new Vector2(moveDir.x + keyBind.Item2.x, moveDir.y + keyBind.Item2.y);
                }
            }

            if (moveDir.Equals(new Vector2(0, 0)))
                player.ResetMoveSpeed();
            else
                player.MoveVector(moveDir);
            
        }

        private void playerStatsUpdate()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString() + "/" + player.MaxHealth.ToString();

            lblPlayerStrength.Text = "Attack Power: " + (player._strength*4).ToString();

            lblPlayerScore.Text = "Score: " + player.Score.ToString();
        }



        private void FrmLevel_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            playerMove();
        }

        private void FrmLevel_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            playerMove();
        }

        private void LoadSong()
        {
            if (currentSong >= 0 && currentSong < songNames.Length)
            {

                StopAndDispose();

                string song = songNames[currentSong];



                try
                {

                    Stream stream = (Stream)rm.GetObject(song);

                    var waveStream = new RawSourceWaveStream(stream, new WaveFormat());
                    waveOut.Init(waveStream);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading the song" + ex.Message);
                    audio = null;
                }
            }
        }

        private void PlayButtonClick(object sender, EventArgs e)
        {


            if (waveOut.PlaybackState == PlaybackState.Stopped)
            {
                waveOut.Play();
            }
            else if (waveOut.PlaybackState == PlaybackState.Paused)
            {
                waveOut.Play();
            }

        }

        private void PauseButtonClick(object sender, EventArgs e)
        {

            if (waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Pause();
            }

        }

        private void NextButtonClick(object sender, EventArgs e)
        {
            if (!changingSong)
            {
                changingSong = true;
                // Stop the current song
                PauseButtonClick(sender, e);

                // Move to the next song
                currentSong++;
                if (currentSong >= songNames.Length)
                {
                    currentSong = 0; // Wrap around to the first song
                }

                // Load and play the next song
                LoadSong();
                PlayButtonClick(sender, e);

                changingSong = false;
            }

        }

        private void StopAndDispose()
        {
            if (waveOut.PlaybackState != PlaybackState.Stopped)
            {
                waveOut.Stop();
            }
            if (audio != null)
            {
                audio.Dispose();
                audio = null;
            }
        }

        private void VolumeUpInGame_Click(object sender, EventArgs e)
        {
            if (waveOut.Volume + .10f < 1)
            {
                waveOut.Volume += 0.10f;
            }
        }

        private void VolumeDownInGame_Click(object sender, EventArgs e)
        {
            if (waveOut.Volume - .10f > 0)
            {
                waveOut.Volume -= 0.10f;
            }
        }
    }
}
