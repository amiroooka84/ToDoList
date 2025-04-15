using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models.Classes
{
    public class UserApp: IdentityUser
    {
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
