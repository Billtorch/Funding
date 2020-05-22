using System;
using System.Collections.Generic;
using System.Text;

namespace Funder.Models
{
   public class Fund
    {
        public int FundId { get; set; }
        public string Amount { get; set; }
        public string FundDate { get; set; }
        public string ProjectId { get; set; }

        public string Reward { get; set; }
    }
}
