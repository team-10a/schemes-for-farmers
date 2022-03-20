using Schemasforfarmer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Schemasforfarmer.BusinessAccessLayer.Models
{
    public class Seller
    {
        [Key]
        [Column("SellId")]
        
        public int SellId { get; set; }
        public string CropName { get; set; }
        public string FertilizerType { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? BasePrice { get; set; }
        public int? CropTypeId { get; set; }
        public int? UserId { get; set; }

        

      
      
    }
}

