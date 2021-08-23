using ScrollRevealXFSample.Views;
using Xamarin.Forms;

namespace ScrollRevealXFSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NewsFeedPage());
        }
    }
}
