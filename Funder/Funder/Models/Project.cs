using System;
using System.Collections.Generic;
using System.Text;

namespace Funder.Models
{



   public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string Goal { get; set; }
        public string Progress { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }  
        public bool isActive { get; set; }
        public string Category { get; set; }


    }
}
