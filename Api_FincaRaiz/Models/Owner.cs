using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_FincaRaiz.Models
{
    public class Owner
    {
        public int IdOwner { get; set; }
        public string NameOwner { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public string Birthday { get; set; }

    }
}