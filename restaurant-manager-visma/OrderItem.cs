using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager_visma
{
    public class OrderItem
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public List<int> menuItems { get; set; }

        public OrderItem() { }
        public OrderItem(int id, DateTime date, List<int> menuItems)
        {
            this.id = id;
            this.date = date;
            this.menuItems = menuItems;
        }
    }
    public class OrderItemMap : ClassMap<OrderItem>
    {
        public OrderItemMap()
        {
            Map(m => m.id);
            Map(m => m.date);
            Map(m => m.menuItems).TypeConverter<ToIntArrayConverter>();
        }
    }
}
