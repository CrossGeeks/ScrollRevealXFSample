using ScrollRevealXFSample.Models;
using Xamarin.Forms;

namespace ScrollRevealXFSample.Views.Cells
{
    public class NewsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate NewsTemplate = new DataTemplate(typeof(NewsCell));
        public DataTemplate EmptyTemplate = new DataTemplate(typeof(EmptyCell));

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((News)item) == News.Empty ? EmptyTemplate : NewsTemplate;
        }
    }
}