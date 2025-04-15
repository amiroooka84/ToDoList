using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models.Classes;


namespace ToDoList.Models
{
    public class db : IdentityDbContext<UserApp>
    {
        public db() : base() { }
        public db(DbContextOptions<db> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ToDoList;Integrated Security=True");
            //optionsBuilder.UseSqlServer("Server=.; Initial Catalog=stockss; User ID=stockss; Password=stockss.123; MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Todo> Todos { get; set; }
    }
}
