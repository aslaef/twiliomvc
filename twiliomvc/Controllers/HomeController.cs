using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.Jwt.AccessToken;
using twiliomvc.ServiceInterfaces;
using twiliomvc.Models;

namespace twiliomvc.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ITokenService tokenService;

        //public HomeController(ITokenService tokenService)
        //{
        //    this.tokenService = tokenService;
        //}

        public ActionResult Index()
        {
            // var token = tokenService.GenerateRandomToken();
            // Substitute your Twilio AccountSid and ApiKey details
            var accountSid = "ACe60fd0aea5789edf56167aeed10e79ae";
            var apiKey = "SK88d8d89c9d57c43fc8677f1053169513";
            var apiSecret = "asMg80rqKGWjy4Bo1PPVA9K53tceJT5b";

            Random rand = new Random();
            
            var identity = rand.Next().ToString();

            // Create a random identity for the client


            // Create a video grant for the token
            var grant = new VideoGrant();
            
            var grants = new HashSet<IGrant> { grant };

            // Create an Access Token generator
            var token = new Token(accountSid, apiKey, apiSecret, identity: identity, grants: grants);
            var tokenstring = token.ToJwt();
            System.Diagnostics.Debug.WriteLine("asdasdasd");

            var model = new TokenProfile { Token = tokenstring };


            return View("Index", model);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}