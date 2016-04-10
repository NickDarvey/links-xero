using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Xero.Api.Infrastructure.Interfaces;
using GD.Links.Xero.Controllers;
using GD.Links.Xero.Services;

namespace GD.Links.Xero
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
