using Microsoft.AspNetCore.Mvc;

[Route("api/payment")]
[ApiController]
public class PaymentController : ControllerBase
{
    [HttpGet("get-payment-link")]
    public ActionResult<string> GetPaymentLink()
    {
        // Controller logic to generate a payment link
        string paymentLink = "https://buy.stripe.com/test_28o9E9ffP9Z40rSdQQ";

        return Ok(paymentLink);
    }


}