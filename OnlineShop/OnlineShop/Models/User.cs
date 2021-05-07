using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class User
    {
        public int Id { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public String fullName { get; set; }
        public List<User_Role> User_Roles { get; set; }

    }
}
