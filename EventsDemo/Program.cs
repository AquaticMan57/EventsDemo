using System;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisc = new Product(50);
            harddisc.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;
            for (int i = 0; i < 6; i++)
            {
                gsm.Sell(10);
                harddisc.Sell(9);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            
            
            Console.WriteLine("GSM is about to finish");
        }
    }
    
}
