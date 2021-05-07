using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String picture_url { get; set; }
        public List<Item_Category> Item_Categories { get; set; }
    }
}
