using System.Collections.Generic;
using System.Web.Mvc;
using LinqToTwitter;
using TwitterTyper.Models;
using TweeterReader.ADL;
using NLog;
using System;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]//could it be authorized pages?No change
        public ActionResult About()
        {
            StackifyLib.ProfileTracer.SetReportingUrl("Twitter Page");
            //LogManager.GetLogger("Twitter Page"); -I think this messes something up Changing didn't affect whether the page was profiled by prefix.
            Logger logger = LogManager.GetCurrentClassLogger(); 

            //Declare Html Helper

            int tweetcount = 0;
            //TwitterClass someTweets = new TwitterClass();
            List<Status> tweetList = TwitterClass.GetTwitterFeeds("Stackify");
            foreach (var tweet in tweetList)
            {
                tweetcount += 1;
            }
            ViewData["tweetCount"] = tweetcount;
            logger.Debug("Tweets counted: " + tweetcount);

            Status[] tweetArray = tweetList.ToArray();
            //AnalyzeTweet tweet = new AnalyzeTweet("words");
            //ViewData["Distance"] = tweet.Distance;
            //ViewData["Finger"] = tweet.Finger;
            //ViewData["KeyRow"] = tweet.KeyRow;

            AnalyzeTweet[] tweetStats = new AnalyzeTweet[tweetcount];
            for (int i = 0; i < tweetcount; i++)
            {
                try
                {
                    tweetStats[i] = new AnalyzeTweet(tweetArray[i].Text.ToString());
                    ViewData["Tweet Stats" + i] = tweetStats[i].EasyResult();
                    ViewData["rpinkie" + i] = tweetStats[i].RPinkie;
                    ViewData["rring" + i] = tweetStats[i].RRing;
                    ViewData["rmiddle" + i] = tweetStats[i].RMiddle;
                    ViewData["rindex" + i] = tweetStats[i].RIndex;
                    ViewData["lpinkie" + i] = tweetStats[i].LPinkie;
                    ViewData["lring" + i] = tweetStats[i].LRing;
                    ViewData["lmiddle" + i] = tweetStats[i].LMiddle;
                    ViewData["lindex" + i] = tweetStats[i].LIndex;
                    ViewData["strokes" + i] = tweetStats[i].Strokes;
                    ViewData["keytravel" + i] = tweetStats[i].KeyTravel;
                    ViewData["efficiency" + i] = Math.Round(tweetStats[i].Efficiency, 2);

                }
                catch (Exception)
                {
                    StackifyLib.Logger.Queue("Error", "Failed to generate ViewData for #Stats");
                    throw;
                }

            }


            return View(tweetArray);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
