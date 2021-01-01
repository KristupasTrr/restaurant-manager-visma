using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using CsvHelper.Expressions;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager_visma
{
    public class MenuItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<int> products { get; set; }

        // class for csvhelper
        public MenuItem() { }
        public MenuItem(int id, string name, List<int> products)
        {
            this.id = id;
            this.name = name;
            this.products = products;
        }
    }

    // helper class for id parsing from csv file
    public class MenuItemMap : ClassMap<MenuItem>
    {
        public MenuItemMap()
        {
            Map(m => m.id);
            Map(m => m.name);
            Map(m => m.products).TypeConverter<ToIntArrayConverter>();
        }
    }
}
