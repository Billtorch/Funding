﻿using Funder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunderMVC.Models
{
    public class ProjectDetailsViewModel
    {
        public Project Project { get; set; }

        public Fund Fund { get; set; }
    }
}
