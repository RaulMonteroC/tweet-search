using Xamarin.Forms;

namespace Sweet
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage ()
        {
            InitializeComponent ();
            var model = new SearchPageViewModel (this);
            BindingContext = model;
        }
    }
}
