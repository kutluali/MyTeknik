using MyTeknik.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeknik.Model.Entities
{
    public class Vision : CoreEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string VisionImage { get; set; }

    }
}
