using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.OAuth.Signing;
using Functional.Maybe;

namespace GD.Links.Xero.Services
{

    public class AuthorizationService : IAuthenticator
    {
        private readonly X509Certificate2 _certificate;

        public AuthorizationService()
        {
            var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            _certificate = ConfigurationManager.AppSettings.Get("xero:thumbprint").ToMaybe()
                .Select(t =>
                {
                    return store.Certificates.Find(X509FindType.FindByThumbprint, t, false);
                })
                .Select(c => c[0])
                .OrElse(() => new CryptographicException($"There were no certificates matching the thumbprint found in '{store.Name}'"));
            store.Close();
        }

        public string GetSignature(IConsumer consumer, IUser user, Uri uri, string verb, IConsumer consumer1)
        {
            var token = new Token
            {
                ConsumerKey = consumer.ConsumerKey,
                ConsumerSecret = consumer.ConsumerSecret,
                TokenKey = consumer.ConsumerKey
            };

            return new RsaSha1Signer().CreateSignature(_certificate, token, uri, verb);
        }

        public X509Certificate Certificate { get { return _certificate; } }

        public IToken GetToken(IConsumer consumer, IUser user)
        {
            return null;
        }

        public IUser User { get; set; }
    }
}