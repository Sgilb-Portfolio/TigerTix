using TigerTix.Web.Models;

namespace TigerTix.Web.Services
{
    public interface IPaymentService
    {
        bool ProcessPayment(Payment payment);
        bool IsValidCardNumber(string cardNumber);

    }
}
