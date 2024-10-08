using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TigerTix.Web.Models;
using TigerTix.Web.Services;


namespace TigerTix.Web.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        // GET: /Payment/AddMethod
        public IActionResult AddMethod()
        {
            return View();
        }

        // POST: /Payment/AddMethod
        [HttpPost]
        public IActionResult AddMethod(Payment payment)
        {
            bool isPaymentSuccessful = _paymentService.ProcessPayment(payment);

            if (isPaymentSuccessful)
            {
                ViewBag.Message = "Payment successful!";
            }
            else
            {
                ViewBag.Message = "Payment failed. Please check your card details.";
            }

            return View(payment);
        }

   
    }

}
