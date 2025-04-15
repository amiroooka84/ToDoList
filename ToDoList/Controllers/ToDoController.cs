using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;
using ToDoList.Models.Classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {

        // GET: api/<ApiController>
        [HttpGet("/GetTodos")]
        public List<Todo> todos()
        {
            db db = new db();
            return db.Todos.ToList();
        }

        // GET api/<ApiController>/5
        [HttpPost("/CreateTodo")]
        public bool Create(string title,DateTime Deadline,string Description)
        {
            Todo todo = new Todo() {
                Title = title,
                Deadline = Deadline,
                Description = Description,
                Done = false,
                visible = true
            };
            db db = new db();
            db.Todos.Add(todo);
            db.SaveChanges();
            return true;
        }

        // POST api/<ApiController>
        [HttpPost("/UpdateTodo")]
        public bool Update(int id,string title, DateTime Deadline, string Description)
        {
            Todo todo = new Todo()
            {
                Title = title,
                Deadline = Deadline,
                Description = Description
            };
            db db = new db();
            foreach (var item in db.Todos)
            {
                if (id == item.id)
                {
                    item.Title = title;
                    item.Deadline = Deadline;
                    item.Description = Description;
                }
            }
            db.SaveChanges();
            return true;
        }

        // PUT api/<ApiController>/5
        [HttpPost("/DoneTodo")]
        public bool Done(int id)
        {
            db db = new db();
            foreach (var item in db.Todos)
            {
                if (id == item.id)
                {
                    item.Done = true;
                }
            }
            db.SaveChanges();
            return true;
        }

        // DELETE api/<ApiController>/5
        [HttpPost("/DelTodos")]
        public bool Delete(List<int> ids)
        {
            db db = new db();
            foreach (var todo in db.Todos)
            {
                foreach (var id in ids)
                {
                    if (id == todo.id)
                    {
                        todo.visible = false;
                    }
                }
            }
            db.SaveChanges();
            return true;
        }
    }
}
