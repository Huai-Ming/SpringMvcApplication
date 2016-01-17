using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Console
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.Routes.MapHttpRoute(
            name: "Get",
            routeTemplate: "api/{controller}/Get/{folder}",
            defaults: new { folder = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "GetMailById",
                routeTemplate: "api/{controller}/GetMailById/{mailId}",
                defaults: new { mailId = RouteParameter.Optional }
            );
        }
    }
}
