using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using ScrollRevealXFSample.Models;
using Xamarin.Forms;

namespace ScrollRevealXFSample.ViewModels
{
    public class NewsFeedViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<News> NewsFeed
        {
            get => _newsFeed;
            set
            {
                _newsFeed = value;
                OnPropertyChanged(nameof(NewsFeed));
            }
        }

        private ObservableCollection<News> _newsFeed;

        public ICommand LoadMoreCommand { get; }

        public NewsFeedViewModel()
        {
            LoadMoreCommand = new Command(() =>
            {
                NewsFeed.Add(News.Empty);
                NewsFeed.Add(new News("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut ut arcu mattis", "https://bloximages.newyork1.vip.townnews.com/kdhnews.com/content/tncms/assets/v3/editorial/5/f0/5f0e1fa7-de15-5012-8b75-9f4328d5e79d/611e1e3da7000.image.jpg?resize=1200%2C795", DateTime.Now.AddMinutes(-2)));
                NewsFeed.Add(new News("pellentesque velit vitae, consequat felis. Suspendisse erat nibh", "https://www.westhawaiitoday.com/wp-content/uploads/2020/05/web1_Ironman_0314.jpg", DateTime.Now.AddMinutes(-2)));
                NewsFeed.Add(new News("ultricies vel nibh ac, elementum suscipit arcu", "https://ca-times.brightspotcdn.com/dims4/default/5260b16/2147483647/strip/true/crop/2048x1152+0+0/resize/1486x836!/quality/90/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2Fee%2F11%2F94d0e05536ede35c285975170ffc%2Fsd-1539142789-tll92codh5-snap-image", DateTime.Now.AddMinutes(-2)));
                NewsFeed.Add(new News("Vestibulum convallis eu urna vel fermentum", "https://www.westhawaiitoday.com/wp-content/uploads/2020/05/web1_Ironman_0015.jpg", DateTime.Now.AddMinutes(-2)));
                NewsFeed.Add(new News("faucibus magna sit amet justo varius", "https://images.thestar.com/9v8_AzqQfhzdCq5NeZmwVBqvslI=/850x680/smart/filters:cb(1629411504752)/https://www.thestar.com/content/dam/thestar/sports/2021/08/19/the-latest-covid-19-again-delays-ironman-championship/20210813190836-611702123edcf9245f296d26jpeg.jpg", DateTime.Now.AddMinutes(-2)));
                NewsFeed.Add(new News("Ut efficitur elit nec diam pharetra malesuada", "https://bloximages.newyork1.vip.townnews.com/timesdaily.com/content/tncms/assets/v3/editorial/a/4a/a4aa5ae1-a7a1-5551-94c2-353711ad7474/611e4fe137b35.image.jpg?resize=1200%2C725", DateTime.Now.AddMinutes(-2)));
                NewsFeed.Add(new News("Aenean eu nulla ex. Donec in sodales diam", "https://appremium.images.worldnow.com/images/21240684_G.jpg", DateTime.Now.AddMinutes(-2)));
                NewsFeed.Add(new News("ultricies vel nibh ac, elementum suscipit arcu", "https://ca-times.brightspotcdn.com/dims4/default/5260b16/2147483647/strip/true/crop/2048x1152+0+0/resize/1486x836!/quality/90/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2Fee%2F11%2F94d0e05536ede35c285975170ffc%2Fsd-1539142789-tll92codh5-snap-image", DateTime.Now.AddMinutes(-2)));
                NewsFeed.Add(new News("Vestibulum convallis eu urna vel fermentum", "https://www.westhawaiitoday.com/wp-content/uploads/2020/05/web1_Ironman_0015.jpg", DateTime.Now.AddMinutes(-2)));
                NewsFeed.Add(new News("faucibus magna sit amet justo varius", "https://images.thestar.com/9v8_AzqQfhzdCq5NeZmwVBqvslI=/850x680/smart/filters:cb(1629411504752)/https://www.thestar.com/content/dam/thestar/sports/2021/08/19/the-latest-covid-19-again-delays-ironman-championship/20210813190836-611702123edcf9245f296d26jpeg.jpg", DateTime.Now.AddMinutes(-2)));
            });

            NewsFeed = new ObservableCollection<News>()
            {
                {new News("TTC, City of Toronto making vaccines mandatory for employees", "https://images.thestar.com/79rGK6wc5m1rv7-6pnI9o41J_tw=/1086x724/smart/filters:cb(1629398163145)/https://www.thestar.com/content/dam/thestar/news/canada/2021/08/19/coronavirus-covid-19-updates-toronto-canada-august-19/bench.jpg", DateTime.Now.AddMinutes(-1))},
                {new News("Mumbai News Updates", "https://static.toiimg.com/thumb/imgsize-229432,msid-85445136,width-400,resizemode-4/85445136.jpg", DateTime.Now.AddHours(-1))},
                {new News("NFL roundup: Latest league news ", "https://static.www.nfl.com/image/private/t_editorial_landscape_12_desktop/league/qp1wzm1t6sgf9ikszi3s", DateTime.Now.AddMinutes(-40))},
                {new News("COVID news live: 94% believed to have antibodies in England", "https://www.cancer.org/content/dam/cancer-org/images/photographs/objetcs/medical/coronavirus-cdc-illustration.jpg/jcr:content/renditions/cq5dam.web.1280.1280.jpeg", DateTime.Now.AddMinutes(-2))},
                {new News("The Latest: COVID-19 Again Delays Ironman Championship", "https://s.abcnews.com/images/Health/WireAP_27d5ab2318ab4f12a23ae93fcc291afe_16x9_992.jpg", DateTime.Now.AddSeconds(-2))},
                {new News("Transfer news: Haaland to Liverpool; Ramsdale to Arsenal", "https://soccer.nbcsports.com/wp-content/uploads/sites/14/2021/08/GettyImages-1234658214.jpg?w=280&h=158&crop=1", DateTime.Now.AddHours(-10))},
                {new News("TTC, City of Toronto making vaccines mandatory for employees", "https://images.thestar.com/79rGK6wc5m1rv7-6pnI9o41J_tw=/1086x724/smart/filters:cb(1629398163145)/https://www.thestar.com/content/dam/thestar/news/canada/2021/08/19/coronavirus-covid-19-updates-toronto-canada-august-19/bench.jpg", DateTime.Now.AddDays(-1))},
                {new News("Mumbai News Updates", "https://static.toiimg.com/thumb/imgsize-229432,msid-85445136,width-400,resizemode-4/85445136.jpg", DateTime.Now.AddDays(-1))},
                {new News("NFL roundup: Latest league news ", "https://bloximages.chicago2.vip.townnews.com/goshennews.com/content/tncms/assets/v3/editorial/5/bc/5bcd8436-c063-5d1d-b095-96c80dec5280/611e4ff3177f1.image.jpg?resize=1200%2C800", DateTime.Now.AddDays(-2))},
                {new News("COVID news live: 94% believed to have antibodies in England", "https://bloximages.chicago2.vip.townnews.com/goskagit.com/content/tncms/assets/v3/editorial/b/0c/b0ce6936-847b-54f3-9657-c74c31277503/611e4f6176fa9.image.jpg?resize=1200%2C877", DateTime.Now.AddDays(-2))},
                {new News("The Latest: COVID-19 Again Delays Ironman Championship", "https://bloximages.chicago2.vip.townnews.com/normantranscript.com/content/tncms/assets/v3/editorial/9/21/921fab14-140b-5cb1-a8e4-32f844e08904/611e75d3766e6.image.jpg?resize=1200%2C800", DateTime.Now.AddDays(-3))},
                {new News("Transfer news: Haaland to Liverpool; Ramsdale to Arsenal", "https://bloximages.chicago2.vip.townnews.com/madison.com/content/tncms/assets/v3/editorial/e/90/e908ec9a-7eb8-56e2-bb83-dccdff7e5897/611e1d9992d62.image.jpg?resize=1200%2C800", DateTime.Now.AddDays(-3))},
            };
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
