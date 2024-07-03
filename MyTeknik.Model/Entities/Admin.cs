using MyTeknik.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeknik.Model.Entities
{
    public class Admin : CoreEntity
    {
        public string Administrator { get; set; }

        public string Password { get; set; }
    }
}
