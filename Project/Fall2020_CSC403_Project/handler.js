



const stripe = require('stripe')('sk_test_51OBMJOJX9jBfJ4Lfxj5ppJ0wTfXmdpswWEpjmpAf6EwIK1Bxy92BhZpvuQV3q0TXKSnnrT6V6xALSJXri4TBdAJG00S1C1Lvzb');

exports.handler = async (event) => {
    try {
        // Extract payment details from the request body
        const { amount, currency } = JSON.parse(event.body);

        // Use the Stripe API to confirm the payment

     
        payment_method = stripe.PaymentMethod.create(
            type = "card",
            card = {
                "number": "4000009990000005",
                "exp_month": 10,
                "exp_year": 2026,
                "cvc": "123"
            }
        )
        const paymentIntent = await stripe.paymentIntents.create({
            amount,
            currency,
            payment_method,  // Replace with a valid test payment method
            confirmation_method: 'manual',
            confirm: true,
        });

        return {
            statusCode: 200,
            body: JSON.stringify({ message: 'Payment confirmed', paymentIntent }),
        };
    } catch (error) {
        console.error('Error:', error.message);

        return {
            statusCode: 500,
            body: JSON.stringify({ error: 'Payment confirmation failed' }),
        };
    }
};
