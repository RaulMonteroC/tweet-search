using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Sweet
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage ()
        {
            InitializeComponent ();

            var tweets = new List<Tweet> ();
            tweets.Add (new Tweet { Text = "Tweet 1" });
            tweets.Add (new Tweet { Text = "Tweet 2" });
            tweets.Add (new Tweet { Text = "Tweet 3" });
            tweets.Add (new Tweet { Text = "Tweet 4" });

            TweetList.ItemsSource = tweets;
        }
    }
}
