using System;
using System.Collections.Generic;
using shoppinglibrary;

namespace shoppinglibrary

{
    internal class program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            var item = new ShoppingCartItem("Headphones",200);
            cart.Addshoppingcartitem(item);

            item = new ShoppingCartItem("GamingChair",300);
            cart.Addshoppingcartitem(item);

            item = new ShoppingCartItem("laptop", 400);
            cart.Addshoppingcartitem(item);

            item = new ShoppingCartItem("ipad", 1300);
            cart.Addshoppingcartitem(item);

            item = new ShoppingCartItem("xbox", 2900);
            cart.Addshoppingcartitem(item);

            List<ShoppingCartItem> shoppingCartItems = cart.ShoppingCartItems();
            foreach (ShoppingCartItem shoppingCartItem in shoppingCartItems) 
            {
                Console.WriteLine(shoppingCartItem.Name + "\t\t\t" + shoppingCartItem.Price);
            }
            Console.WriteLine("subTotal" + "\t" + cart.GetsubTotal());
            Console.WriteLine("With Vat" + "\t" + cart.Getwithvattotal());
        }
    }

}
