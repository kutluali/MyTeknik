using MyTeknik.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeknik.Model.Entities
{
    public class Brand : CoreEntity
    {
        public string BrandName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
