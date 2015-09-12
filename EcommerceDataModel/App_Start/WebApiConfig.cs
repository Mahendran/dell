using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EcommerceDataModel
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            
            config.Routes.MapHttpRoute(
                name: "customerquery",
                routeTemplate: "api/{controller}/{action}/{query}",
                defaults: new { query = RouteParameter.Optional }
            );
            
            config.Routes.MapHttpRoute(
               name: "byfilter",
               routeTemplate: "api/{controller}/{action}/{id}/{filter}",
               defaults: new { id = RouteParameter.Optional, filter = RouteParameter.Optional }
           );

            
        }
    }
}
