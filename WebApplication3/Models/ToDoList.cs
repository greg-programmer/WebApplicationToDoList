using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class ToDoList
    {
        public int Id { get; set; }
        [Display(Name ="Titre")]
        public string Title { get; set; }
        [Display(Name ="Description")]
        public string Description { get; set; }
        [Display(Name ="Statut")]
        public bool Finished { get; set; } = false;
    }
}
