using System;
using System.Collections.Generic;
using System.Text;

namespace Funder.Models
{
  public class Reward
    {
        public int RewardId { get; set; }
        public string Description { get; set; }
        public string Low_Tier { get; set; }
        public string Mid_Tier { get; set; }
        public string High_Tier { get; set; }

        public Project Project { get; set; }
    }
}
