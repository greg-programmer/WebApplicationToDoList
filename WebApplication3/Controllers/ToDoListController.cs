using Microsoft.AspNetCore.Mvc;
using WebApplication3.Interfaces;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    public class ToDoListController : Controller
    {
       private readonly IRepository<ToDoList> _repositoryToDoList;

        public ToDoListController(IRepository<ToDoList> repositoryToDoList)
        {
            _repositoryToDoList = repositoryToDoList;
        }

        public IActionResult Index()
        {
            return View(_repositoryToDoList.GetAll());
        }
        public IActionResult Change(int id)
        {
            _repositoryToDoList.Change(id);
            return RedirectToAction("Index");
        }
        public IActionResult FormulaireGet()
        {
            return View();
        }
        public IActionResult FormulairePost(ToDoList toDoList)
        {
            _repositoryToDoList.Create(toDoList);
            return RedirectToAction("Index");
        }
        public IActionResult FormulaireGetUpdate()
        {
            return View();
        }
        public IActionResult Update(ToDoList toDoList)
        {
           _repositoryToDoList.Update(toDoList);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _repositoryToDoList.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
