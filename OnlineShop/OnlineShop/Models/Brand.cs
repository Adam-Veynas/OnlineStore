using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public String name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<Item> Items { get; set; }
    }
}
