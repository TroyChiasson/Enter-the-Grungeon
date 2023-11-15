using Fall2020_CSC403_Project.code;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmPaymentChoice : Form
    {

        private FrmBattle frmBattle;
        public Player player;

        public FrmPaymentChoice(FrmBattle frmBattle)
        {
            InitializeComponent();
            this.frmBattle = frmBattle;
            player = Game.player;
            textBox1.Text = "If you do not care about the hard working developers then Click exit to continue with no stat boost";
            textBox2.Text = "If you wish to buy an in-game boost to health and attack click the Pay button!";
        }

        private void PayTheMan(object sender, EventArgs e)
        {
           
        }

        private async void linkToPay(object sender, EventArgs e)
        {
            try
            {
                string backendUrl = "http://localhost:5148/api/payment/get-payment-link";

                using (HttpClient client = new HttpClient())
                {
                    //Get the Payment Link
                    HttpResponseMessage response = await client.GetAsync(backendUrl);

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        string paymentLink = await response.Content.ReadAsStringAsync();
                        OpenStripeCheckout(paymentLink);

                        //Get the Payment Intent ID
                        HttpResponseMessage paymentIntentIdResponse = await client.GetAsync("http://localhost:5148/api/payment/get-payment-intent-id");
                        
                        if (paymentIntentIdResponse.IsSuccessStatusCode)
                        {
                            string paymentIntentIdResponseContent = await paymentIntentIdResponse.Content.ReadAsStringAsync();

                            // Extract the payment ID
                            int startIndex = paymentIntentIdResponseContent.IndexOf("pi_");
                            if (startIndex != -1)
                            {
                                startIndex += "pi_".Length;
                                string paymentIntentId = "pi_" + paymentIntentIdResponseContent.Substring(startIndex);
                                paymentIntentId = paymentIntentId.Substring(0, paymentIntentId.Length - 2);

                                await Task.Delay(TimeSpan.FromSeconds(10));

                                // Step 3: Check Payment Status
                                HttpResponseMessage paymentStatusResponse = await client.GetAsync($"http://localhost:5148/api/payment/check-payment-status?paymentId={paymentIntentId}");
                                
                                if (paymentStatusResponse.IsSuccessStatusCode)
                                {

                                    string paymentStatusJson = await paymentStatusResponse.Content.ReadAsStringAsync();

                                    MessageBox.Show($"Response Content: {paymentStatusJson}");

                                    // Deserialize the JSON response into PaymentStatus object
                                    var paymentStatus = JsonConvert.DeserializeObject<PaymentStatus>(paymentStatusJson);

                                    // Check the payment status
                                    if (paymentStatus.Status == "succeeded")
                                    {
                                        //  existing code for applying buffs
                                        Random rand = new Random();
                                        int buffEffect = rand.Next(2);
                                        switch (buffEffect)
                                        {
                                            case 0:
                                                frmBattle.player.buffHealth(20);
                                                break;
                                            case 1:
                                                frmBattle.player.buffAttack(10);
                                                break;
                                            case 2:
                                                frmBattle.player.buffHealth(10);
                                                frmBattle.player.buffAttack(5);
                                                break;
                                        }
                                    }
                                    else
                                    {
                                      

                                        //  existing code for applying buffs
                                        Random rand = new Random();
                                        int buffEffect = rand.Next(2);
                                        switch (buffEffect)
                                        {
                                            case 0:
                                                frmBattle.player.buffHealth(20);
                                                break;
                                            case 1:
                                                frmBattle.player.buffAttack(10);
                                                break;
                                            case 2:
                                                frmBattle.player.buffHealth(10);
                                                frmBattle.player.buffAttack(5);
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    // error checking
                                    MessageBox.Show($"HTTP Status Code: {paymentStatusResponse.StatusCode}");
                                    paymentStatusResponse.EnsureSuccessStatusCode();
                                }
                            }
                            else
                            {
                                // Handle the case where "pi_" is not found in the response content
                                Console.WriteLine("Error: Unable to extract paymentIntentId from the response content.");
                            }
                        }
                        else
                        {
                            // successful intent response
                            MessageBox.Show($"HTTP Status Code: {paymentIntentIdResponse.StatusCode}");
                            paymentIntentIdResponse.EnsureSuccessStatusCode();
                        }
                    }
                    else
                    {
                        // got the right link
                        response.EnsureSuccessStatusCode();
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP request exceptions
                MessageBox.Show($"HTTP Request Exception: {ex.Message}");
                
            }
        }

        public class PaymentStatus
        {
            public string Status { get; set; }
        }

        // open link
        private void OpenStripeCheckout(string checkoutUrl)
        {
            string callbackUrl = "http://localhost:5171/api/payment/callback";

            Process.Start(new ProcessStartInfo
            {
                FileName = $"{checkoutUrl}?callback={callbackUrl}",
                UseShellExecute = true
            });

        }

        private void DontPayTheMan(object sender, EventArgs e)
        {   
           
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
