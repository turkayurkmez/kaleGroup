using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class ShoppingCard
    {
        private List<CartItem> cartItems = new();
        public void AddToCart(CartItem item)
        {
            cartItems.Add(item);
        }

        public decimal GetTotalPrice()
        {
            decimal result = 0;
            foreach (var item in cartItems)
            {
                result += item;
            }

            return result;
        }
    }
}
