﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace restaurant_manager_visma
{
    public class ProductStock
    {
        private List<Product> itemsInStock { get; set; }

        public ProductStock()
        {
            itemsInStock = new List<Product>();
        }
        public int newID()
        {
            if (itemsInStock.Count > 0)
                return itemsInStock.Max(x => x.id) + 1;
            else
                return 1;
        }
        public bool isAvailable(int id)
        {
            return itemsInStock.Any(x => x.id == id);
        }

        public int getStock(int id)
        {
            return itemsInStock.Find(x => x.id == id).portionCount;
        }

        public int updateStock(int id, int newStock)
        {
            var product = itemsInStock.FirstOrDefault(x => x.id == id);

            if (product is null || newStock < 0)
            {
                return -1;
            }

            product.portionCount = newStock;

            return product.portionCount;
        }

        public void removeStock(int id)
        {
            var item = itemsInStock.Find(x => x.id == id);
            itemsInStock.Remove(item);
        }

        public void deductStock(int id)
        {
            var item = this.itemsInStock.Find(x => x.id == id);
            item.portionCount--;
        }

        public void addToStock(Product product)
        {
            this.itemsInStock.Add(product);
        }

        public void printStock()
        {
            var header = String.Format("{0,-3} | {1,-20} | {2, -13} | {3, 5} | {4, -12}", "ID", "Name", "Portion Count", "Unit", "Portion Size");
            Console.WriteLine(header);
            foreach (var item in itemsInStock)
            {
                var line = String.Format("{0,-3} | {1,-20} | {2, -13} | {3, 5} | {4, -12}", item.id, item.name, item.portionCount, item.unit, item.portionSize);
                Console.WriteLine(line);
            }
        }

        public void updateDataFile(string stockFile)
        {
            string thisFile = new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName();
            string path = Path.GetDirectoryName(thisFile);
            path += "\\data\\" + stockFile;


            using (var writer = new StreamWriter(path))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.Configuration.Delimiter = ";";

                csvWriter.WriteRecords(itemsInStock);

            }

        }
        public void getDataFromFile(string stockFile)
        {
            // find data file 
            string thisFile = new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName();
            string path = Path.GetDirectoryName(thisFile);
            path += "\\data\\" + stockFile;

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Configuration.Delimiter = ";";
                    itemsInStock = csv.GetRecords<Product>().ToList();
                }
            }
            else
            {
                this.itemsInStock = new List<Product>();
            }
        }

        public Product getProduct(int id)
        {
            return itemsInStock.FirstOrDefault(x => x.id == id);
        }
    }
}
