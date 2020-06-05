using Funder.Models;
using Funder.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funder.Services
{
   public interface IProjectManager
    {

        Project CreateProject(CreateProjectOption createProjectOption);
        Project FindProjectById(int id);
        Project Update(ProjectOption projOption, int projId);
        bool DeleteProjectById(int id);
        List<Project> GetAllProjects();
    }
}
