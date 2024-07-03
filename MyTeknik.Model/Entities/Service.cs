using MyTeknik.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeknik.Model.Entities
{
    public class Service : CoreEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Phone { get; set; }
    }
}
