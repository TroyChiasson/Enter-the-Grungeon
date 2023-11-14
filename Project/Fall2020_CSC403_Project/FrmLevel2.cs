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

        private Enemy enemyFlea0;
        private Enemy enemyFlea1;
        private Enemy enemyFlea2;
        private Character[] walls;

        private DateTime timeBegin;
        private FrmBattle frmBattle;

        private int currentSong = 0;
        private IWavePlayer waveOut;
        private AudioFileReader audio;
        private ResourceManager rm;
        private string[] songNames; // Array to store the resource names of your songs
        private bool changingSong = false;

        private bool pause = false;

        private Tuple<Key, Vector2>[] moveKeys;

        private int count = 0;
        private bool HaltMove { get; set; }


        public FrmLevel2()
        {
            player = Game.player;
            player.Teleport(new Vector2(125, 540));
            InitializeComponent();
            this.KeyPreview = true;
            HaltMove = false;

        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 4;

            enemyFlea0 = new Enemy(CreatePosition(picEnemyFlea0), CreateCollider(picEnemyFlea0, PADDING));
            enemyFlea1 = new Enemy(CreatePosition(picEnemyFlea1), CreateCollider(picEnemyFlea1, PADDING));
            enemyFlea2 = new Enemy(CreatePosition(picEnemyFlea2), CreateCollider(picEnemyFlea2, PADDING));


            enemyFlea0.Name = "enemyFlea0";
            enemyFlea1.Name = "enemyFlea1";
            enemyFlea2.Name = "enemyFlea2";

            enemyFlea0.Img = picEnemyFlea0.BackgroundImage;
            enemyFlea1.Img = picEnemyFlea1.BackgroundImage;
            enemyFlea2.Img = picEnemyFlea2.BackgroundImage;


            enemyFlea0.Color = Color.BurlyWood;
            enemyFlea1.Color = Color.BurlyWood;
            enemyFlea2.Color = Color.BurlyWood;

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

        public void displayPauseMenu()
        {
            if (Keyboard.IsKeyDown(Key.Escape))
            {
                this.PauseMenuBackground.BringToFront();
                this.ResumeGameButton.BringToFront();
                this.QuitToMainMenuButton.BringToFront();
                pause = true;
            }
        }
        public void removePauseMenu()
        {
            this.PauseMenuBackground.SendToBack();
            this.ResumeGameButton.SendToBack();
            this.QuitToMainMenuButton.SendToBack();
            pause = false;
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
            if (!HaltMove)
            {
                player.Move();
            }

            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }

            // check collision with enemies
            if (HitAChar(player, enemyFlea0))
            {
                Fight(enemyFlea0);
            }
            else if (HitAChar(player, enemyFlea1))
            {
                Fight(enemyFlea1);
            }
            else if (HitAChar(player, enemyFlea2))
            {
                Fight(enemyFlea2);
            }

            Random rand = new Random();

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

            // randomly move flea every 3 ticks
            if (count % 3 == 0)
            { 
                enemyFlea0.MoveRand(rand.Next(32));
                enemyFlea0.Move();

                // check collision with enemies and walls
                if (HitAWall(enemyFlea0))
                {
                    enemyFlea0.MoveBack();
                }
                if (HitAChar(enemyFlea0, enemyFlea1))
                {
                    enemyFlea0.MoveBack();
                }
                if (HitAChar(enemyFlea0, enemyFlea2))
                {
                    enemyFlea0.MoveBack();
                }

                // update flea's picture box
                picEnemyFlea0.Location = new Point((int)enemyFlea0.Position.x, (int)enemyFlea0.Position.y);
            }

            // randomly move flea every 3 ticks
            if (count % 3 == 1)
            {
                enemyFlea1.MoveRand(rand.Next(32));
                enemyFlea1.Move();

                // check collision with enemies and walls
                if (HitAWall(enemyFlea1))
                {
                    enemyFlea1.MoveBack();
                }
                if (HitAChar(enemyFlea1, enemyFlea0))
                {
                    enemyFlea1.MoveBack();
                }
                if (HitAChar(enemyFlea1, enemyFlea2))
                {
                    enemyFlea1.MoveBack();
                }

                // update flea's picture box
                picEnemyFlea1.Location = new Point((int)enemyFlea1.Position.x, (int)enemyFlea1.Position.y);
            }

            // randomly move flea every 3 ticks
            if (count % 3 == 2)
            {
                enemyFlea2.MoveRand(rand.Next(32));
                enemyFlea2.Move();

                // check collision with enemies and walls
                if (HitAWall(enemyFlea2))
                {
                    enemyFlea2.MoveBack();
                }
                if (HitAChar(enemyFlea2, enemyFlea0))
                {
                    enemyFlea2.MoveBack();
                }
                if (HitAChar(enemyFlea2, enemyFlea1))
                {
                    enemyFlea2.MoveBack();
                }

                // update flea's picture box
                picEnemyFlea2.Location = new Point((int)enemyFlea2.Position.x, (int)enemyFlea2.Position.y);
            }
            count++;
            if (count >= 1000) { count = 0; }
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
            frmBattle.SetupForLVL2(player);


            switch (enemy.Name)
            {
                case "enemyFlea0":
                    enemyFlea0 = new Enemy(RemovePosition(0, 0), RemoveCollider());
                    picEnemyFlea0.BackgroundImage = null;
                    break;
                case "enemyFlea1":
                    enemyFlea1 = new Enemy(RemovePosition(0, 0), RemoveCollider());
                    picEnemyFlea1.BackgroundImage = null;
                    break;
                case "enemyFlea2":
                    enemyFlea2 = new Enemy(RemovePosition(0, 0), RemoveCollider());
                    picEnemyFlea2.BackgroundImage = null;
                    break;  
            }
        }

        private void playerMove()
        {
            if (pause == false)
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
        }

        private void playerStatsUpdate()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString() + "/" + player.MaxHealth.ToString();

            lblPlayerStrength2.Text = "Attack Power: " + (player._strength*4).ToString();

            lblPlayerScore2.Text = "Score: " + player.Score.ToString();
        }



        private void FrmLevel_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            displayPauseMenu();
            playerMove();
        }

        private void FrmLevel_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            displayPauseMenu();
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
        private void QuitToMainMenuButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ResumeGameButton_Click(object sender, EventArgs e)
        {
            removePauseMenu();
        }
    }
}
