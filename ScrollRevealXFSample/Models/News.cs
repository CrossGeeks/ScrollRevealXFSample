using System;

namespace ScrollRevealXFSample.Models
{
    public class News
    {
        public News(string title, string photo, DateTime date)
        {
            Title = title;
            Photo = photo;
            Date = date;
        }
        public string Title { get; }
        public string Photo { get; }
        public DateTime Date { get; }

        public static News Empty = _empty ??= new News(string.Empty, string.Empty, DateTime.MinValue);

        private static News _empty;
    }
}

