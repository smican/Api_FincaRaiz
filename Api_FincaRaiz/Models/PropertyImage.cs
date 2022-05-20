using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_FincaRaiz.Models
{
    public class PropertyImage
    {
        public string IdPropertyImage { get; set; }
        public string IdProperty { get; set; }
        public string File { get; set; }
        public string Enabled { get; set; }
    }
}