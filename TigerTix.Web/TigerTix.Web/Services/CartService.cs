using System.Collections.Generic;
using TigerTix.Web.Models;

namespace TigerTix.Web.Services
{
    public class CartService : ICartService
    {
        private List<Cart> _cart;

        public CartService()
        {
            _cart = new List<Cart>();
        }

        public List<Cart> GetCart()
        {
            return _cart;
        }

        public void AddToCart(Event @event, int count)
        {
            _cart.Add(new Cart { Event = @event, Count = count });
        }

        public void RemoveFromCart(int index)
        {
            if (index >= 0 && index < _cart.Count)
            {
                _cart.RemoveAt(index);
            }
        }
    }
}
