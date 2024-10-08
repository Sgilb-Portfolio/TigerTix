using TigerTix.Web.Models;

namespace TigerTix.Web.Services
{
    public interface ICartService
    {
        List<Cart> GetCart();
        void AddToCart(Event @event, int count);
        void RemoveFromCart(int index);
    }
}
