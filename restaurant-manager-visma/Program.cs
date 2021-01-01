using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager_visma
{
    class Program
    {
        static void Main(string[] args)
        {
            string stockFile = "stock.csv";
            string menuFile = "menu.csv";
            string ordersFile = "orders.csv";

            var manager = new Manager(stockFile, menuFile, ordersFile);
            manager.mainPage();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
