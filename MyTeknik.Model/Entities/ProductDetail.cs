using MyTeknik.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyTeknik.Model.Entities
{
    public class ProductDetail : CoreEntity
    {
        public string ProductDescription { get; set; }

        public string ProductInfo { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
