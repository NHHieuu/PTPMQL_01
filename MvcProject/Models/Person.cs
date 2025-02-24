using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models;

public class Person
{
    public required string PersonId { get; set; }
    public string? FullName { get; set; }
    [DataType(DataType.Date)]
    public string? Address { get; set; }
}