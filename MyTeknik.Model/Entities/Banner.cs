﻿using MyTeknik.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeknik.Model.Entities
{
    public class Banner : CoreEntity
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string Image { get; set; }


    }
}
