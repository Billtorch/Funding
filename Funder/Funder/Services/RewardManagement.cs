using Funder.Models;
using Funder.Options;
using Funder.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funder.Services
{
    public class RewardManagement : IRewardManager
    {
        private FunderDbContext db;

        public RewardManagement(FunderDbContext _db)
        {
            db = _db;
        }


        //CRUD
        // create read update delete
        public Reward CreateReward(RewardOption rewOption)
        {
            Reward reward = new Reward
            {
                Description = rewOption.Description,
                Low_Tier = rewOption.Low_Tier,
                Mid_Tier = rewOption.Mid_Tier,
                High_Tier = rewOption.High_Tier
               

            };


            db.Rewards.Add(reward);
            db.SaveChanges();

            return reward;
        }


        public Reward Update(RewardOption rewOption, int rewardId)
        {

            Reward reward = db.Rewards.Find(rewardId);

            if (rewOption.Description != null)
                reward.Description = rewOption.Description;
            if (rewOption.Low_Tier != null)
                reward.Low_Tier = rewOption.Low_Tier;
            if (rewOption.Mid_Tier!= null)
                reward.Mid_Tier = rewOption.Mid_Tier;
            if (rewOption.High_Tier != null)
                reward.High_Tier = rewOption.High_Tier;

            db.SaveChanges();
            return reward;
        }

        public bool DeleteRewardById(int id)
        {
            Reward reward = db.Rewards.Find(id);
            if (reward != null)
            {
                db.Rewards.Remove(reward);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
