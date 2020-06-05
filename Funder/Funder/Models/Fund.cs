using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Funder.Models
{
    public class Fund
    {
        public int FundId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount2 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount3 { get; set; }

        public DateTime FundDate { get; set; }
        public string Reward { get; set; }
        public virtual ICollection<Reward> Rewards { get; set; }

        public Fund()
        {
            FundDate = DateTime.Now;
        }
    }
}
