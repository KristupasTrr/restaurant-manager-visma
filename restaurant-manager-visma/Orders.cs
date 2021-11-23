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
    public class Orders
    {
        private List<OrderItem> orders { get; set; }
        public Orders()
        {
            this.orders = new List<OrderItem>();
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
        public void deleteOrder(OrderItem order)
        {
            this.orders.Remove(order);
        }
        public OrderItem returnOrder(int id)
        {
            var index = this.orders.FindIndex(x => x.id == id);
            if (index != -1)
            {
                return this.orders[index];
            }
            return null;
        }
        public void editOrder(int id, List<int> menuItems)
        {
            var index = this.orders.FindIndex(x => x.id == id);
            if(index != -1)
            {
                this.orders[index].menuItems = menuItems;
            }
        }
        public List<int> returnMenuItems(int id)
        {
            var index = this.orders.FindIndex(x => x.id == id);
            if (index != -1)
            {
                return this.orders[index].menuItems;
            }
            return null;
        }

        public int getOrderCount()
        {
            return this.orders.Count;
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

        public void getDataFromFile(string orderFile)
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

        public void updateDataFile(string orderFile)
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
