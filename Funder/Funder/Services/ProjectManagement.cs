using Funder.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Funder.Models;
using Funder.Options;
using System.Linq;

namespace Funder.Services
{
    public class ProjectManagement : IProjectManager
    {
        private FunderDbContext db;

        public ProjectManagement(FunderDbContext _db)
        {
            db = _db;
        }


        //CRUD
        // create read update delete

        public Project CreateProject(ProjectOption projOption)
        {
            Project project = new Project
            {
                ProjectName = projOption.ProjectName,
                Description = projOption.Description,
                Goal = projOption.Goal,
                Start = projOption.Start,
                End = projOption.End,
                Progress = projOption.Progress,
                isActive = true,
                Category = projOption.Category

            };

            db.Projects.Add(project);
            db.SaveChanges();

            return project;
        }

        public Project FindProjectById(int projectId)
        {

            return db.Projects.Find(projectId);
        }  


        public Project Update(ProjectOption projOption, int projectId)
        {

            Project project = db.Projects.Find(projectId);

            if (projOption.ProjectName != null)
                project.ProjectName = projOption.ProjectName;
            if (projOption.Description != null)
                project.Description = projOption.Description;
            if (projOption.Progress != null)
                project.Progress = projOption.Progress;
            if (projOption.Category != null)
                project.Category = projOption.Category;
            if (projOption.Start != new DateTime())
                project.Start = projOption.Start;
            if (projOption.End != new DateTime())
                project.End = projOption.End;

            db.SaveChanges();
            return project;
        }

        public bool DeleteProjectById(int id)
        {
            Project project = db.Projects.Find(id);
            if (project != null)
            {
                db.Projects.Remove(project);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Project> GetAllProjects()
        {
            return db.Projects.ToList();
        }
    }
}