using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework1.Entities
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set;}
        public int StudentAge { get; set;}
    }
}
