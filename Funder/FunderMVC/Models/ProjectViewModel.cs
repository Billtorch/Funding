using Funder.Models;
using System.Collections.Generic;

namespace FunderMVC.Models
{
    public class ProjectViewModel
    {
        public List<Project> Projects { get; set; }
        public List<Fund> Funds { get; set; }

        public ProjectViewModel()

        {
            Projects = new List<Project>();
            Funds = new List<Fund>();
        }

    }


}
