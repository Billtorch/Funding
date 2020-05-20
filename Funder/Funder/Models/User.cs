using System;
using System.Collections.Generic;
using System.Text;

namespace Funder.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public bool isActive { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}