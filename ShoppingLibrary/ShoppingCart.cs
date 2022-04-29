using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppinglibrary
{
    public class ShoppingCart
    {
        private List<ShoppingCartItem> _shoppingcartitems = new List<ShoppingCartItem>();
        //protected string _shoppingcartitems;
        private double _vat = 1.15;
        public ShoppingCart()
        {
        }
        public void Addshoppingcartitem(ShoppingCartItem item)
        {
            _shoppingcartitems.Add(item);
        }
        public double GetsubTotal()
        {
            double subTotal = 0;
            foreach (ShoppingCartItem item in _shoppingcartitems)
            {
                subTotal = subTotal + item.Price;
            }
            return subTotal;
        }
        public double Getwithvattotal()
        {
            double subTotal = Getwithvattotal();
            return Math.Round(subTotal * _vat, 2);
        }
        public List<ShoppingCartItem> ShoppingCartItems()
        {
            return _shoppingcartitems;
        }

    }
}