using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(20,ErrorMessage ="can't be more than 20 words")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "can't be more than 20 words")]
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "can't be more than 20 words")]
        public string LastName { get; set; }
    }
}
