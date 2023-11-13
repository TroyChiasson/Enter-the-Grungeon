using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using System.Reflection;
using System.IO;
using System.Resources;
using PayPal.Api;
using Stripe;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net;

namespace Fall2020_CSC403_Project {
    public partial class FrmLevel : Form
    {
        private Player player;
        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Character[] walls;

        private DateTime timeBegin;
        private FrmBattle frmBattle;


        private int currentSong = 0;
        private IWavePlayer waveOut;
        private AudioFileReader audio;
        private ResourceManager rm;
        private string[] songNames; // Array to store the resource names of your songs
        private bool changingSong = false;

        public FrmLevel()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }



        private void FrmLevel_Load(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            const int PADDING = 7;
            const int NUM_WALLS = 13;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);

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
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
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
            if (HitAChar(player, bossKoolaid))
            {
                Fight(bossKoolaid);
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
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
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    player.GoLeft();
                    break;

                case Keys.D:
                    player.GoRight();
                    break;

                case Keys.W:
                    player.GoUp();
                    break;

                case Keys.S:
                    player.GoDown();
                    break;

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

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

        private async void button1_Click(object sender, EventArgs e)
        {
            //OpenStripeCheckout("https://buy.stripe.com/test_28o9E9ffP9Z40rSdQQ");
            try
            {
                string backendUrl = "http://localhost:5171/api/payment/get-payment-link";
                MessageBox.Show(backendUrl);

                using (HttpClient client = new HttpClient())
                {
                    
                    HttpResponseMessage response = await client.GetAsync(backendUrl);
                    

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        
                        string paymentLink = await response.Content.ReadAsStringAsync();
                        OpenStripeCheckout("https://buy.stripe.com/test_28o9E9ffP9Z40rSdQQ");


                        // Now, let's make a request to your backend to check the payment status
                        HttpResponseMessage paymentStatusResponse = await client.GetAsync("http://localhost:5171/api/payment/check-payment-status");

                        if (paymentStatusResponse.IsSuccessStatusCode)
                        {
                            // Process the content of the response to determine payment success
                            string paymentStatusJson = await paymentStatusResponse.Content.ReadAsStringAsync();

                            // Log or display the response content for debugging purposes
                            Console.WriteLine($"Response Content: {paymentStatusJson}");
                            MessageBox.Show($"Response Content: {paymentStatusJson}");

                            var paymentStatus = JsonConvert.DeserializeObject<PaymentStatus>(paymentStatusJson);

                            // Check the payment status
                            if (paymentStatus.Success)
                            {
                                // Payment is successful
                                MessageBox.Show("Payment successful!");
                                // Perform actions for a successful payment
                            }
                            else
                            {
                                // Payment failed
                                MessageBox.Show("Payment failed. Please try again.");
                                // Perform actions for a failed payment
                            }
                        }
                        else
                        {
                            // Handle unsuccessful response
                            MessageBox.Show($"HTTP Status Code: {paymentStatusResponse.StatusCode}");
                            paymentStatusResponse.EnsureSuccessStatusCode();
                        }
                    }
                    else
                    {
                        // Handle unsuccessful response
                        response.EnsureSuccessStatusCode(); // This will throw an exception for non-success status codes
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP request exceptions
                MessageBox.Show($"HTTP Request Exception: {ex.Message}");
                // You may want to provide a user-friendly message or take appropriate action based on the exception type
            }
            catch (Exception ex)
            {
                // Handle unexpected exceptions
                Console.WriteLine($"An unexpected error occurred: {ex}");
            }
        }

        public class PaymentStatus
        {
            public bool Success { get; set; }
            // Add other properties as needed based on your API response
        }
        private void OpenStripeCheckout(string checkoutUrl)
        {
            string callbackUrl = "http://localhost:5171/api/payment/callback";

            Process.Start(new ProcessStartInfo
            {
                FileName = $"{checkoutUrl}?callback={callbackUrl}",
                UseShellExecute = true
            });
        }
    }
}