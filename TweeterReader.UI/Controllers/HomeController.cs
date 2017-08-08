using System.Collections.Generic;
using System.Web.Mvc;
using LinqToTwitter;
using TweeterReader.Data;
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

        //[Authorize]//could it be authorized pages?No change
        public ActionResult About()
        {
            return View();
        }

        public ActionResult ThrowErrors()
        {
            Logger logger = NLog.LogManager.GetCurrentClassLogger();

            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                logger.Error(ex,"An Exception was thrown");
            }
            return View();
        }
        public ActionResult Tweets() {
            Logger logger = NLog.LogManager.GetCurrentClassLogger();
            #region Old Stuff
            //Taking out the viewdata also did nothing to help
            //var tracer = StackifyLib.ProfileTracer.CreateAsTrackedFunction("Tweets Controller"); tracer.Exec(() => { did not help

            //StackifyLib.ProfileTracer.SetReportingUrl("About Page");
            //LogManager.GetLogger("Twitter Page"); -I think this messes something up Changing didn't affect whether the page was profiled by prefix.
            //Logger logger = LogManager.GetCurrentClassLogger();
            //int tweetcount = 0;
            //TwitterClass someTweets = new TwitterClass();
            //List<Status> tweetList = TwitterClass.GetTwitterFeeds("Stackify");
            //foreach (var tweet in tweetList)
            //{
            //    tweetcount += 1;
            //}
            ////ViewData["tweetCount"] = tweetcount;
            //logger.Debug("Tweets counted: " + tweetcount);


            //Status[] tweetArray2 = tweetList.ToArray();
            ////AnalyzeTweet tweet = new AnalyzeTweet("words");
            ////ViewData["Distance"] = tweet.Distance;
            ////ViewData["Finger"] = tweet.Finger;
            ////ViewData["KeyRow"] = tweet.KeyRow;


            //    //AnalyzeTweet[] tweetStats = new AnalyzeTweet[tweetcount]; This seemed to be the issue!
            //for (int i = 0; i < tweetcount; i++)
            //{
            //    try
            //    {
            //        //tweetStats[i] = new AnalyzeTweet(tweetArray2[i].Text.ToString());
            //        //ViewData["Tweet Stats" + i] = tweetStats[i].EasyResult();
            //        //ViewData["rpinkie" + i] = tweetStats[i].RPinkie;
            //        //ViewData["rring" + i] = tweetStats[i].RRing;
            //        //ViewData["rmiddle" + i] = tweetStats[i].RMiddle;
            //        //ViewData["rindex" + i] = tweetStats[i].RIndex;
            //        //ViewData["lpinkie" + i] = tweetStats[i].LPinkie;
            //        //ViewData["lring" + i] = tweetStats[i].LRing;
            //        //ViewData["lmiddle" + i] = tweetStats[i].LMiddle;
            //        //ViewData["lindex" + i] = tweetStats[i].LIndex;
            //        //ViewData["strokes" + i] = tweetStats[i].Strokes;
            //        //ViewData["keytravel" + i] = tweetStats[i].KeyTravel;
            //        //ViewData["efficiency" + i] = Math.Round(tweetStats[i].Efficiency, 2);
            //        ViewData["efficiency" + i] = "0.75";

            //    }
            //        catch (Exception)
            //    {
            //        StackifyLib.Logger.Queue("Error", "Failed to generate ViewData for #Stats");
            //        throw;
            //    }

            //}
            ////Removing the model did not change anything
            //try
            //{
            //    throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex, "An Exception was thrown");
            //}
            #endregion
            try
            {
            TwitterClass Stackify = new TwitterClass("Stackify", 500);
                return View(Stackify);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Unable to Create Twitter Class");
                return View("Error", new HandleErrorInfo(ex, "Home", "Index"));
                throw;
            }


            //tweetArray2
        }


        public ActionResult Contact()
        {
            return View();
        }
    }
}
