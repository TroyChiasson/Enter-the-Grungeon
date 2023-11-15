using Microsoft.AspNetCore.Mvc;
using Stripe;


[Route("api/payment")]
[ApiController]
public class PaymentController : ControllerBase
{

    private static string stripeSecretKey = "sk_test_51OBMJOJX9jBfJ4Lfxj5ppJ0wTfXmdpswWEpjmpAf6EwIK1Bxy92BhZpvuQV3q0TXKSnnrT6V6xALSJXri4TBdAJG00S1C1Lvzb";

    [HttpGet("get-payment-link")]
    public ActionResult<string> GetPaymentLink()
    {
        // Controller logic to generate a payment link
        string paymentLink = "https://buy.stripe.com/test_28o9E9ffP9Z40rSdQQ";

        return Ok(paymentLink);
    }
    [HttpGet("get-payment-intent-id")]
    public IActionResult GetPaymentIntentId()
    {
        // gets payment id to check payment status
        try
        {
            StripeConfiguration.ApiKey = stripeSecretKey;

            var options = new PaymentIntentCreateOptions
            {
                Amount = 500,
                Currency = "usd",
                PaymentMethodTypes = new List<string> { "card" },
            };

            var service = new PaymentIntentService();
            var paymentIntent = service.Create(options);

            return Ok(new { PaymentIntentId = paymentIntent.Id });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex}");
            return StatusCode(500, $"An error occurred: {ex.Message}");
        }
    }

    [HttpGet("check-payment-status")]
    public IActionResult CheckPaymentStatus([FromQuery(Name = "paymentId")] string paymentIntentId)
    {
        // unsuccessfully checks for success or failure
        try
        {
            StripeConfiguration.ApiKey = stripeSecretKey;

            var service = new PaymentIntentService();
            var paymentIntent = service.Get(paymentIntentId);

            bool paymentSuccessful = paymentIntent.Status == "succeeded";

            return Ok(new { Success = paymentSuccessful });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex}");

            return StatusCode(500, $"An error occurred: {ex.Message}");
        }
    }
}