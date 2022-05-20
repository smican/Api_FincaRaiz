using System.Web.Http;
using System.Web.Http.Cors;

namespace Api_FincaRaiz
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Configuración y servicios de API web
            var cors = new EnableCorsAttribute("*", "*", "*"); //Permite que nuestro servicio web pueda ser utilizado por cualquier cliente
            config.EnableCors(cors);


            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
