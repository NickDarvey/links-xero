using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Xero.Api.Core;
using Xero.Api.Example.Applications.Private;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Serialization;
using Functional.Maybe;

namespace GD.Links.Xero.Services
{
    public interface IApiService
    {
        XeroCoreApi Api { get; }
    }
    public class ApiService : IApiService
    {
        private readonly XeroCoreApi _api;

        public ApiService(IAuthenticator authenticator)
        {
            var mapper = new DefaultMapper();
            var uri = ConfigurationManager.AppSettings.Get("xero:uri").ToMaybe().OrElse(() => new ArgumentException("No Xero URI in application settings"));
            var key = ConfigurationManager.AppSettings.Get("xero:clientId").ToMaybe().OrElse(() => new ArgumentException("No Xero Client ID in application settings"));
            var secret = ConfigurationManager.AppSettings.Get("xero:clientSecret").ToMaybe().OrElse(() => new ArgumentException("No Xero Client Secret in application settings"));

            _api = new XeroCoreApi(uri,
                authenticator,
                new Consumer(key, secret),
                null,
                mapper,
                mapper)
                {
                    UserAgent = "Connector"
                };
        }

        public XeroCoreApi Api { get { return _api; } }
    }
}