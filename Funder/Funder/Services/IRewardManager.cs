using Funder.Models;
using Funder.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funder.Services
{
    public interface IRewardManager
    {
        Reward CreateReward(RewardOption rewdOption);
        Reward Update(RewardOption rewOption, int rewardId);
        bool DeleteRewardById(int id);


    }
}
