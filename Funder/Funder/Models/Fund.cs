using System;
using System.Collections.Generic;
using System.Text;

namespace Funder.Models
{
    public class Fund
    {
        public int FundId { get; set; }
        public string Amount { get; set; }
        public DateTime FundDate { get; set; }
        public string Reward { get; set; }
        public virtual ICollection<Reward> Rewards { get; set; }

    }
}
