using WebApplication3.Data;
using WebApplication3.Interfaces;
using WebApplication3.Models;

namespace WebApplication3.Repositories
{
    public class RepositoryToDoList : IRepository<ToDoList>
    {
        private readonly ApplicationDbContext _db;

        public RepositoryToDoList(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Change(int id)
        {
            var a = _db.ToDoLists.Find(id);
            if(a == null)
            {
                return false;
            }
            if (a.Finished)
            {
                a.Finished = false;
                _db.SaveChanges();  
            }
            else
            {
                a.Finished = true;
                _db.SaveChanges();
            }            
            return true;
        }

        public bool Create(ToDoList entity)
        {
            _db.ToDoLists.Add(entity);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var a = _db.ToDoLists.Find(id);
            _db.ToDoLists.Remove(a);
            _db.SaveChanges();
            return true;    
        }

        public List<ToDoList> GetAll()
        {
            return _db.ToDoLists.ToList();  
        }

        public ToDoList GetById(int id)
        {
            return _db.ToDoLists.Find(id);            
        }

        public bool Update(ToDoList toDoList)
        {
            _db.Update(toDoList);
            _db.SaveChanges();
            return true;
            //var result = _db.ToDoLists.Find(toDoList.Id);
           
            //  toDoList.Id = result.Id;
            //  result.Title = toDoList.Title;
            // result.Description = toDoList.Description;          
           
        }
    }
}
