using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace PaymentServer.Controllers
{
    [Route("webhook")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        // Replace with your actual Stripe webhook secret
        const string endpointSecret = "whsec_4c61bc719992ba31eb3583ef9a66f251f2e8440d8d77dd38b26fdea373f13a5b";

        [HttpPost]
        public async Task<IActionResult> Index()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();

            try
            {
                var stripeEvent = EventUtility.ConstructEvent(json,
                    Request.Headers["Stripe-Signature"], endpointSecret);

                // Handle the event
                if (stripeEvent.Type == Events.PaymentIntentSucceeded)
                {
                    var paymentIntent = (PaymentIntent)stripeEvent.Data.Object;

                    // Payment succeeded
                    Console.WriteLine($"PaymentIntent succeeded: {paymentIntent.Id}");
                    // Perform any necessary actions (e.g., update order status, send confirmation email)
                }
                else if (stripeEvent.Type == Events.PaymentIntentPaymentFailed)
                {
                    var paymentIntent = (PaymentIntent)stripeEvent.Data.Object;

                    // Payment failed
                    Console.WriteLine($"PaymentIntent failed: {paymentIntent.Id}");
                    // Perform any necessary actions (e.g., notify the user, log the failure)
                }
                else
                {
                    Console.WriteLine("Unhandled event type: {0}", stripeEvent.Type);
                }

                return Ok();
            }
            catch (StripeException e)
            {
                Console.WriteLine($"StripeException: {e}");
                return BadRequest();
            }
        }
    }
}
