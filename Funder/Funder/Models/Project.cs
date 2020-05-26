﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Funder.Models
{



   public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
       
        [Column(TypeName = "decimal(18,4)")]
        public decimal Goal { get; set; }
        public string Progress { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }  
        public bool IsActive { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Fund> Funds { get; set; }
        public virtual ICollection<Media> Medias { get; set; }
        public virtual ICollection<ProjectCategory> ProjectCategories{ get; set; }
        public virtual ICollection<Reward> Rewards { get; set; }

    }
}
