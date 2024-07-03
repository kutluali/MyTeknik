using MyTeknik.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeknik.Model.Entities
{
    public class Category : CoreEntity
    {
        public string CategoryName { get; set; }

        public string? Image { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
