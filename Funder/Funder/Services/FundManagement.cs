using Funder.Models;
using Funder.Options;
using Funder.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funder.Services
{
    public class FundManagement : IFundManager
    {
        private FunderDbContext db;

        public FundManagement(FunderDbContext _db)
        {
            db = _db;
        }


        //CRUD
        // create read update delete
        public Fund CreateFund(FundOption fndOption)
        {
            Fund fund = new Fund
            {
                Amount = fndOption.Amount,
                FundDate = fndOption.FundDate,
            };


            db.Funds.Add(fund);
            db.SaveChanges();

            return fund;
        }


        public Fund Update(FundOption fndOption, int fundId)
        {

            Fund fund = db.Funds.Find(fundId);

            if (fndOption.Amount != null)
                fund.Amount = fndOption.Amount;
            if (fndOption.FundDate != new DateTime())
                fund.FundDate = fndOption.FundDate;

            db.SaveChanges();
            return fund;
        }

        public bool DeleteFundById(int id)
        {
            Fund fund = db.Funds.Find(id);
            if (fund != null)
            {
                db.Funds.Remove(fund);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
