using System;
using System.Collections.Generic;
using System.Text;

namespace Funder.Models
{
   public class ProjectCategories
    {
        public int ProjectCategoriesId { get; set; }
        public string Art { get; set; }
        public string Games { get; set; }
        public string Technology { get; set; }
        public string Trending { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
