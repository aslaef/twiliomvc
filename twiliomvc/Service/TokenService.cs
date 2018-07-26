using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.Jwt.AccessToken;
using twiliomvc.ServiceInterfaces;

namespace twiliomvc.Controllers
{
    public class TokenService: ITokenService
    {
        
        public string GenerateRandomToken()
        {
            // Substitute your Twilio AccountSid and ApiKey details
            var accountSid = "";
            var apiKey = "";
            var apiSecret = "";

            var identity = "example-user";

            // Create a random identity for the client


            // Create a video grant for the token
            var grant = new VideoGrant();
            grant.Room = "cool room";
            var grants = new HashSet<IGrant> { grant };

            // Create an Access Token generator
            var token = new Token(accountSid, apiKey, apiSecret, identity: identity, grants: grants);
            return token.ToJwt();
        }



    }
}