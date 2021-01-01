using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager_visma
{
    class Orders
    {
        private List<OrderItem> orders { get; set; }
        private string orderFile { get; set; }
        public Orders(string orderFile)
        {
            this.orderFile = orderFile;
            getDataFromFile();
        }
        public int newID()
        {
            if (orders.Count > 0)
                return orders.Max(x => x.id) + 1;
            else
                return 1;
        }

        public void createOrder(OrderItem order)
        {
            this.orders.Add(order);
        }

        public void printOrders()
        {
            var header = String.Format("{0,-3} | {1,-25} | {2, -13} ", "ID", "Date", "Menu Items");
            Console.WriteLine(header);
            foreach (var item in this.orders)
            {
                var line = String.Format("{0,-3} | {1,-25} | {2, -13} ", item.id, item.date, string.Join(" ", item.menuItems));
                Console.WriteLine(line);
            }
        }

        public void getDataFromFile()
        {
            // find data file 
            string thisFile = new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName();
            string path = Path.GetDirectoryName(thisFile);
            path += "\\data\\" + orderFile;

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                using (var csvWriter = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csvWriter.Configuration.Delimiter = ";";

                    csvWriter.Configuration.RegisterClassMap<OrderItemMap>();

                    this.orders = csvWriter.GetRecords<OrderItem>().ToList();
                }
            }
            else
            {
                this.orders = new List<OrderItem>();
            }
        }

        public void updateDataFile()
        {
            string thisFile = new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName();
            string path = Path.GetDirectoryName(thisFile);
            path += "\\data\\" + orderFile;

            using (var writer = new StreamWriter(path))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.Configuration.Delimiter = ";";

                csvWriter.Configuration.RegisterClassMap<OrderItemMap>();

                csvWriter.WriteRecords(this.orders);
            }
        }
    }
}
