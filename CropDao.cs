using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Schemasforfarmer.BusinessAccessLayer.Models;
using Schemasforfarmer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Schemasforfarmer.DataAccessLayer
{
    public class CropDao : ICropDao
    {





        public bool InsertCrop(CropDetail crop)
        {
            int result = 0;
            try
            {
                using (var db = new AgricultureContext())
                {
                    DbSet<CropType> allcrop = db.CropType;
                    CropType cropType = new CropType
                    {
                        CropTypeId = crop.CropTypeId,
                        CropType1 = crop.CropType1


                    };
                    allcrop.Add(cropType);
                    result = db.SaveChanges();
                }
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CropDetail> GetAllCrops()
        {
            List<CropDetail> allCrops = null;
            try
            {
                using (var db = new AgricultureContext())
                {
                    DbSet<CropType> allEntityCrops = db.CropType;
                    allCrops = allEntityCrops
                      .Select(entityCrop =>
                  new CropDetail
                  {
                      CropType1 = entityCrop.CropType1,
                      CropTypeId = entityCrop.CropTypeId
                  })
                      .ToList();
                }
                return allCrops;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CropDetail GetCropById(int id)

        {

            CropDetail cropDetail = null;
            try
            {
                using (var db = new AgricultureContext())
                {
                    DbSet<CropType> allEntityCrops = db.CropType;
                    var matchingAccount = allEntityCrops.Where(p => p.CropTypeId == id);
                    if (matchingAccount != null && matchingAccount.Count() > 0)
                    {
                        CropType p = matchingAccount.First<CropType>();
                        cropDetail = new CropDetail
                        {
                            CropType1 = p.CropType1,
                            CropTypeId = p.CropTypeId
                        };
                    }
                }
                return cropDetail;
            }
            catch (Exception ex)

            {
                throw ex;
            }

        }
    }
}







