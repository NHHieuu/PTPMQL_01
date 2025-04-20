using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcProject.Models;

   
    public class student{
        [Key]
        public  string Id { get; set;}
        public string Name { get; set;}
        public int PersonId { get; set; }
    }

