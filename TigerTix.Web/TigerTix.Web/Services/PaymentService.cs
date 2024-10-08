using TigerTix.Web.Models;

namespace TigerTix.Web.Services
{
    public class PaymentService : IPaymentService
    {
        public bool ProcessPayment(Payment payment)
        {
            bool isPaymentSuccessful = IsValidCardNumber(payment.CardNumber);

            return isPaymentSuccessful;
        }

        public bool IsValidCardNumber(string cardNumber)
        {
            return !string.IsNullOrEmpty(cardNumber);
        }
    }
}
