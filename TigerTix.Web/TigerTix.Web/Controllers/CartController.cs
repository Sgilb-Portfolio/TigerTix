using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;
using TigerTix.Web.Services;

public class CartController : Controller
{
    private readonly ICartService _cartService;

    public CartController(ICartService cartService)
    {
        _cartService = cartService;
    }

    public IActionResult ViewCart()
    {
        var cartItems = _cartService.GetCart();

        // Extract events from cart items
        var eventsInCart = cartItems.Select(cartItem => cartItem.Event);

        return View(eventsInCart);
    }

    [HttpPost]
    public IActionResult AddToCart(Event @event, int count)
    {
        _cartService.AddToCart(@event, count);
        return RedirectToAction("ViewCart");
    }

    [HttpPost]
    public IActionResult RemoveFromCart(int index)
    {
        _cartService.RemoveFromCart(index);
        return RedirectToAction("ViewCart");
    }
}
