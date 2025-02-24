using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcProject.Models

{
    [Table("student")]
    public class student{
        [Key]
        public  string Id { get; set;}
        public string Name { get; set;}
    }
}
