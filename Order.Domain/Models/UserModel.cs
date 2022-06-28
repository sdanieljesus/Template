using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Domain.Models
{
    public class UserModel : EntityBase
    {
        public string Name { get; set; }
        
        public string Login { get; set; }
        
        public string PasswordHash { get; set; }
        
        
    }
}