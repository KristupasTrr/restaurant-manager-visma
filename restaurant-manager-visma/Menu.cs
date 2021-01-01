using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager_visma
{
    public class Menu
    {
        private List<MenuItem> menuItems { get; set; }

        public Menu()
        {
            this.menuItems = new List<MenuItem>();
        }
        public int newID()
        {
            if (menuItems.Count > 0)
                return menuItems.Max(x => x.id) + 1;
            else
                return 1;
        }
        public bool isAvailable(int id)
        {
            return menuItems.Any(x => x.id == id);
        }
        public void addMenuItem(MenuItem item)
        {
            this.menuItems.Add(item);
        }
        public void removeMenuItem(int id)
        {
            var delete = this.menuItems.Find(x => x.id == id);
            this.menuItems.Remove(delete);
        }
        public void updateName(int id, string name)
        {
            this.menuItems.Find(x => x.id == id).name = name;
        }
        public void updateProducts(int id, List<int> products)
        {
            this.menuItems.Find(x => x.id == id).products = products;
        }

        public MenuItem getMenuListItem(int id)
        {
            return this.menuItems.Find(x => x.id == id);
        }
        public void printMenu()
        {
            var header = String.Format("{0,-3} | {1,-20} | {2, -13} ", "ID", "Name", "Products");
            Console.WriteLine(header);
            foreach (var item in this.menuItems)
            {
                var line = String.Format("{0,-3} | {1,-20} | {2, -13} ", item.id, item.name, string.Join(" ", item.products));
                Console.WriteLine(line);
            }
        }

        public void getDataFromFile(string menuFile)
        {
            // find data file 
            string thisFile = new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName();
            string path = Path.GetDirectoryName(thisFile);
            path += "\\data\\" + menuFile;

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                using (var csvWriter = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csvWriter.Configuration.Delimiter = ";";

                    csvWriter.Configuration.RegisterClassMap<MenuItemMap>();

                    this.menuItems = csvWriter.GetRecords<MenuItem>().ToList();
                }
            }
            else
            {
                this.menuItems = new List<MenuItem>();
            }
        }

        public void updateDataFile(string menuFile)
        {
            string thisFile = new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName();
            string path = Path.GetDirectoryName(thisFile);
            path += "\\data\\" + menuFile;

            using (var writer = new StreamWriter(path))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.Configuration.Delimiter = ";";

                csvWriter.Configuration.RegisterClassMap<MenuItemMap>();

                csvWriter.WriteRecords(this.menuItems);
            }
        }

    }
}
