using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Role
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public List<User_Role> User_Roles { get; set; }
    }
}
