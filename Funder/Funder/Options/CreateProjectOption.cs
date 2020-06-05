using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Funder.Options
{
   public class CreateProjectOption
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount2 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount3 { get; set; }
        public DateTime FundDate { get; set; }
        public string Reward { get; set; }

        public string ProjectName { get; set; }
        public string Description { get; set; }

        public decimal Goal { get; set; }

        public decimal Progress { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Category { get; set; }
    }
}
