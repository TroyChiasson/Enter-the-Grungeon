using System;
using Stripe;
using Microsoft.AspNetCore.Mvc;

namespace Fall2020_CSC403_Project
{
    [Route("api/payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpGet("get-payment-link")]
        public ActionResult<string> GetPaymentLink()
        {
            try
            {
                // Replace with your actual Payment Link URL
                string paymentLink = "https://buy.stripe.com/test_28o9E9ffP9Z40rSdQQ";

                return Ok(paymentLink);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
