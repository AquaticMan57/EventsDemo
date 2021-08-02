using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDemo
{
    public delegate void StockControl();
    class Product
    {
        private int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public int Stock { 
            get 
            {
                return _stock; 
            } 
            set 
            {
                _stock = value; 
                if (value <=15 && StockControlEvent != null) 
                { 
                    StockControlEvent(); 
                } 

            } 
        }
        public string ProductName { get; set; }

        public void Sell(int amount)
        {
            Stock -= amount;
            if (Stock <0)
            {
                Stock = 0;

            }
            Console.WriteLine("Stock Amount :{0}", Stock);
        }

    }
}
