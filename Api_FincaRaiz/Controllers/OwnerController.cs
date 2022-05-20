using Api_FincaRaiz.Data;
using Api_FincaRaiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_FincaRaiz.Controllers
{
    public class OwnerController : ApiController
    {
        [HttpGet]
        [ActionName("ListarPropietarios")]
        public List<Owner> Get()
        {
            return OwnerData.ListarOwner();
        }
    }
}