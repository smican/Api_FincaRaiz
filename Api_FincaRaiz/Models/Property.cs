﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_FincaRaiz.Models
{
    public class Property
    {
        public int ?IdProperty { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Price { get; set; }
        public string CodeInternal { get; set; }
        public int Year { get; set; }
        public int IdOwner { get; set; }

    }
}