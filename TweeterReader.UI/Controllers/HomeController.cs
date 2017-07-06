using System.Collections.Generic;
using System.Web.Mvc;
using LinqToTwitter;
using TwitterTyper.Models;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            //TwitterClass someTweets = new TwitterClass();
            List<Status> tweetList = TwitterClass.GetTwitterFeeds("realDonaldTrump");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
