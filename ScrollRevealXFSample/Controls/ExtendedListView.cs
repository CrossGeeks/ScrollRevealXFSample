using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace ScrollRevealXFSample.Controls
{
    public class ExtendedListView : ListView
    {
        public static readonly BindableProperty LoadMoreCommandProperty =
                    BindableProperty.Create(nameof(LoadMoreCommand), typeof(ICommand), typeof(ExtendedListView), default(ICommand));

        public ICommand LoadMoreCommand
        {
            get { return (ICommand)GetValue(LoadMoreCommandProperty); }
            set { SetValue(LoadMoreCommandProperty, value); }
        }

        public ExtendedListView() : this(ListViewCachingStrategy.RetainElement)
        {
        }

        public ExtendedListView(ListViewCachingStrategy cachingStrategy) : base(cachingStrategy)
        {
            ItemAppearing += OnItemAppearing;
        }

        private void OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            if (LoadMoreCommand != null)
            {
                if (e.Item == ItemsSource.Cast<object>().Last())
                {
                    LoadMoreCommand?.Execute(null);
                }
            }
        }
    }
}
