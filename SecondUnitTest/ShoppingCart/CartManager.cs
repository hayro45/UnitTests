﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    //Gereksinimler
    //1. Sepete Ürün Eklenebilmelidir. 
    //2. Sepette Olan Ürün Sepetten Çıkarılabilmelidir.
    //3. Sepet temizlenebilmelidir. 
    public class CartManager
    {
        private readonly List<CartItem> _cartItems;

        public CartManager()
        {
            _cartItems = new List<CartItem>();
        }

        public void Add(CartItem item)
        {
            _cartItems.Add(item);
        }

        public void Remove(int productId)
        {
            var product = _cartItems.FirstOrDefault(t => t.Product.ProductId == productId);
            _cartItems.Remove(product);

        }

        public List<CartItem> CartItems
        {
            get
            {
                return _cartItems;
            }
        }

        public void Clear()
        {
            _cartItems.Clear();
        }

        public decimal TotalPrice
        {
            get { return _cartItems.Sum(t => t.Quantity * t.Product.UnitPrice); }
        }

        public decimal TotalQuantity
        {
            get { return _cartItems.Sum(t => t.Quantity); }
        }

        public int TotalItems
        {
            get { return _cartItems.Count; }
        }
    }
}
