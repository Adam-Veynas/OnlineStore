using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Item
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public int price { get; set; }
        public DateTime added_date { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<Item_Category> Item_Categories { get; set; }

    }
}
