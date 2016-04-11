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
            _certificate = ConfigurationManager.AppSettings.Get("xero:pkcs12Content").ToMaybe()
                    .Select(c =>
                    {
                        return ConfigurationManager.AppSettings.Get("xero:pkcs12Password").ToMaybe()
                           .Select(p => new X509Certificate2(Convert.FromBase64String(c), p))
                           .OrElse(() => new CryptographicException("There was no PKCS12 password in app settings"));
                    })
                    .OrElse(() => new CryptographicException("There was no PKCS12 content in app settings"));
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