using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppinglibrary
{
    public class ShoppingCartItem
    {
        public string _name;
        public double _price;
        public ShoppingCartItem(string name, double price)
        {
            _name = name;
            _price = price;
        }
        public string Name
        {
            get { return _name; }
        }
        public double Price
        {
            get { return _price; }
        }
    }
}
