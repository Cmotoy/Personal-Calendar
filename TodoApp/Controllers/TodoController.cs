using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using TodoApp.Services;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoListService _todoListService;

        public TodoController(ITodoListService todoListService)
            {
                _todoListService = todoListService;
            }

        [HttpGet]
        public IActionResult TodoList()
        {
            return View ();
        }

        [HttpPost]
        public IActionResult TodoList (TodoListModel models)
        {
            return View ();
        }
    }
}