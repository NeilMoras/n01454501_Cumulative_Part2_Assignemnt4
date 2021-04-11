using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace n01454501_Cumulative_Part3_Assignment3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes

            config.MapHttpAttributeRoutes();

            config.EnableCors(); 

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
