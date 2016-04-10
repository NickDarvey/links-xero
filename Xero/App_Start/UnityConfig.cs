using GD.Links.Xero.Services;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using Xero.Api.Infrastructure.Interfaces;

namespace GD.Links.Xero
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IAuthenticator, AuthorizationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IApiService, ApiService>(new HierarchicalLifetimeManager());

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}