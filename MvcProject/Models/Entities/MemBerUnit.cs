using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models.Entities{
    public class MemBerUnit{
        [Key]
        public int MemBerUnitId { get;set;}
        [Required]
        public string MemBerUnitName { get;set;}
        [Required]
        public string Address { get; set;}
        public string PhoneNumber { get; set;}
        public string WebsiteUrl { get; set;}
    }
}