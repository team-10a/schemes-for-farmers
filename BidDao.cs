using Microsoft.EntityFrameworkCore;
using Schemasforfarmer.BusinessAccessLayer.Models;
using Schemasforfarmer.DataAccessLayer.Interfaces;
using Schemasforfarmer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schemasforfarmer.DataAccessLayer
{
    public class BidDao : IBidDao
    {

        public List<BidModel> GetBiddings()
        {
            List<BidModel> allBids = null;
            try
            {
                using (var db = new AgricultureContext())
                {
                    DbSet<Bidding> allEntityBids = db.Bidding;
                    allBids = allEntityBids
                      .Select(entityCrop =>
                  new BidModel
                  {
                      BiddingId=entityCrop.BiddingId,
                      BidAmt=entityCrop.BidAmt,
                      BidDate=entityCrop.BidDate,
                      IsBitStatus=entityCrop.IsBitStatus,
                      Sell=entityCrop.Sell,
                      SellId=entityCrop.SellId,
                      User=entityCrop.User,
                      UserId=entityCrop.UserId
                  })
                      .ToList();
                }
                return allBids;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
