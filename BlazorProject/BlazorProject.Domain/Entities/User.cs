﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Domain.Entities
{
     public class User
     {
          [Key]
          public int Id { get; set; }
          public string FirstName { get; set; }
          public string LastName { get; set; }
          public int Age { get; set; }
     }
}
