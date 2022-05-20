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
    public class PropertyController : ApiController
    {


        [HttpGet]
        [ActionName("ListarPropiedades")]
        public List<Property> Get(int idOwner)
        {
            return PropertyData.ListarPropiedadesPorDueno(idOwner);
        }


        [HttpPost]
        [ActionName("InsertarPropiedad")]
        public string InsertarPropiedad(Property Pro)
        {

            bool Inserto = PropertyData.RegistrarPropiedad(Pro);
            string Respuesta;

            if (Inserto == true)
            {
                Respuesta = "Se ha insertado el registro con exito.";
            }
            else
            {
                Respuesta = "Ha ocurrido un error al insertar.";
            }

            return Respuesta;
        }


        [HttpPut]
        [ActionName("ActualizarPrecio")]
        public string ActualizarPrecio(Property Prop)
        {

            bool Inserto = PropertyData.ActualizarPrecioPropiedad(Prop);
            string Respuesta;

            if (Inserto == true)
            {
                Respuesta = "Se ha actualizado el precion de la propiedad con exito.";
            }
            else
            {
                Respuesta = "Ha ocurrido un error al actualizar el precio.";
            }

            return Respuesta;
        }

    }
}