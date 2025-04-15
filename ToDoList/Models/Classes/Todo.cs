using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models.Classes
{
    public class Todo
    {
        public int id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public bool visible { get; set; }
    }
}
