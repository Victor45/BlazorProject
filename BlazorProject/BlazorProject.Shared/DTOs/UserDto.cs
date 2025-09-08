using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Shared.DTOs
{
     public class UserDto
     {
          public int Id { get; set; }
          [Required(ErrorMessage = "First Name is required")]
          public string FirstName { get; set; } = string.Empty;
          [Required(ErrorMessage = "Last Name is required")]
          public string LastName { get; set; } = string.Empty;
          [Range(1, 100, ErrorMessage = "Age is required to be between 1 and 100")]
          public int Age { get; set; }
     }
}
