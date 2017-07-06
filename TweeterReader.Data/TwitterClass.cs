using LinqToTwitter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TwitterTyper.Models
{
    public class TwitterClass
    {
        public string tweets;

        //CTOR
        public TwitterClass()
        {
            tweets = "";
        }

        public async void GetTweets() {
            var auth = new ApplicationOnlyAuthorizer
            {
                CredentialStore = new InMemoryCredentialStore()
                {
                    ConsumerKey = "8FBg1Nfxwjv1vzzycbwzBqkFe",
                    ConsumerSecret = "eBT3Cqu4V3ukmNQrvxudAXbzLHKm2KIJYAp1pFfugU9mdCnWgD"
                }
            };

            await auth.AuthorizeAsync();
            var twitterCtx = new TwitterContext(auth);
            
            var searchResponse =
                 await
                 (from search in twitterCtx.Search
                  where search.Type == SearchType.Search &&
                        search.Query == "\"LINQ to Twitter\""
                  select search)
                 .SingleOrDefaultAsync();

            tweets = searchResponse.ToString();

            if (searchResponse != null && searchResponse.Statuses != null)
                searchResponse.Statuses.ForEach(tweet =>
                    Console.WriteLine(
                        "User: {0}, Tweet: {1}",
                        tweet.User.ScreenNameResponse,
                        tweet.Text));            

        }//End GetTweet

        public static List<Status> GetTwitterFeeds(string user)
        {
            string screenname = user;

            var auth = new SingleUserAuthorizer
            {
                CredentialStore = new SingleUserInMemoryCredentialStore
                {
                    ConsumerKey = ConfigurationManager.AppSettings["consumerKey"],
                    ConsumerSecret = ConfigurationManager.AppSettings["consumerSecret"],
                    AccessToken = ConfigurationManager.AppSettings["accessToken"],
                    AccessTokenSecret = ConfigurationManager.AppSettings["accessTokenSecret"]
                }
            };
            
            var twitterCtx = new TwitterContext(auth);
            var ownTweets = new List<Status>();

            ulong maxId = 0;
            bool flag = true;
            var statusResponse = new List<Status>();
            statusResponse = (from tweet in twitterCtx.Status
                              where tweet.Type == StatusType.User
                              && tweet.ScreenName == screenname
                              && tweet.Count == 200
                              select tweet).ToList();

            if (statusResponse.Count > 0)
            {
                maxId = ulong.Parse(statusResponse.Last().StatusID.ToString()) - 1;
                ownTweets.AddRange(statusResponse);

            }
            do
            {
                int rateLimitStatus = twitterCtx.RateLimitRemaining;
                if (rateLimitStatus != 0)
                {

                    statusResponse = (from tweet in twitterCtx.Status
                                      where tweet.Type == StatusType.User
                                      && tweet.ScreenName == screenname
                                      && tweet.MaxID == maxId
                                      && tweet.Count == 200
                                      select tweet).ToList();

                    if (statusResponse.Count != 0)
                    {
                        maxId = ulong.Parse(statusResponse.Last().StatusID.ToString()) - 1;
                        ownTweets.AddRange(statusResponse);
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else
                {
                    flag = false;
                }
            } while (flag);

            return ownTweets;
        }

        public string Tweets
        {
            get { return tweets; }
            set { tweets = value; }
        }
    }
}