using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sweet
{
    public class SearchPageViewModel
    {
        public Page Page { get; }
        public Command SearchCommand { get; }
        public string SearchTerm { get; set; }
        public ObservableCollection<Tweet> Tweets { get; set; }

        public SearchPageViewModel (Page page)
        {
            Page = page;
            Tweets = new ObservableCollection<Tweet> ();
            SearchCommand = new Command (LoadTweets);
        }

        private void LoadTweets ()
        {
            var url = Global.EndPointUrl + SearchTerm;
            var fetchedTweets = EndPointParser.Parse<ObservableCollection<Tweet>> (url);

            Tweets.Clear ();
            foreach (var tweet in fetchedTweets) {
                Tweets.Add (tweet);
            }

        }
    }
}
