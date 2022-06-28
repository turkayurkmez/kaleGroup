using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }


        public static decimal operator + (decimal value, CartItem cartItem)
        {
            return value + (cartItem.Price * cartItem.Quantity);
        }

        public static decimal operator +(CartItem item1, CartItem item2)
        {
            return (item1.Price * item1.Quantity) + (item2.Price * item2.Quantity);
        }
    }
}
