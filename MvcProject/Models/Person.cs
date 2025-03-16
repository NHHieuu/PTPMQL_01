using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcProject.Models;
[Table("Person")]
public class Person
{
    [Key]
    public  string PersonId { get; set; }
    public string? FullName { get; set; }
    [DataType(DataType.Date)]
    public  string Address { get; set; }
}