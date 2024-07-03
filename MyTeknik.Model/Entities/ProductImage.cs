using MyTeknik.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeknik.Model.Entities
{
    public class ProductImage : CoreEntity
    {

        public string Image1 { get; set; }

        public string Image2 { get; set; }

        public string Image3 { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}
