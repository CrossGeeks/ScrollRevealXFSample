using ScrollRevealXFSample.ViewModels;
using Xamarin.Forms;

namespace ScrollRevealXFSample.Views
{
    public partial class NewsFeedPage : ContentPage
    {
        public NewsFeedPage()
        {
            InitializeComponent();
            BindingContext = new NewsFeedViewModel();
        }
    }
}
