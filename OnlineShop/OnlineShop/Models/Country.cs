using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Country
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String code { get; set; }
        public List<Brand> Brands { get; set; }
    }
}
