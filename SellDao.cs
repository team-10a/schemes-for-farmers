using Microsoft.EntityFrameworkCore;
using Schemasforfarmer.BusinessAccessLayer.Models;
using Schemasforfarmer.DataAccessLayer;
using Schemasforfarmer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schemasforfarmer.DataAccessLayer
{
    public class SellDao :ISellDao
    {

        public List<Seller> GetSellers()
        {
            List<Seller> allseller = null;
            try
            {
                using (var db = new AgricultureContext())
                {
                    DbSet<Sell> allEntityCrops = db.Sell;
                    allseller = allEntityCrops
                      .Select(seller =>
                  new Seller
                  {
                      SellId = seller.SellId,
                      BasePrice = seller.BasePrice,
                     
                      CropType = seller.CropType,
                      CropTypeId = seller.CropTypeId,
                      CropName = seller.CropName,
                      UserId = seller.UserId,
                      Quantity = seller.Quantity,
                      FertilizerType = seller.FertilizerType,
                      User = seller.User
                  })
                      .ToList();
                }
                return allseller;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public bool InsertSeller(Seller seller)
        {
            int result = 0;
            try
            {
                using var db = new AgricultureContext();
                {
                    DbSet<Sell> allcrop = db.Sell;
                    Sell entityobj = new Sell
                    {
                        SellId = seller.SellId,
                        BasePrice=seller.BasePrice,
                        
                        CropType=seller.CropType,
                        CropTypeId=seller.CropTypeId,
                        CropName=seller.CropName,
                        UserId=seller.UserId,
                        Quantity=seller.Quantity,
                        FertilizerType=seller.FertilizerType,
                        User=seller.User



                    };
                    allcrop.Add(entityobj);
                    result = db.SaveChanges();
                }
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
