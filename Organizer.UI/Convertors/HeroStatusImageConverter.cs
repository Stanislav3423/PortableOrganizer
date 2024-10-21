using Organizer.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Organizer.UI.Convertors
{
    public class HeroStatusImageConverter : IValueConverter
    {
        private Dictionary<HeroStatus, BitmapImage> cache = new Dictionary<HeroStatus, BitmapImage>();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (HeroStatus)value;
            if (!cache.ContainsKey(status))
            {
                var uri = new Uri(string.Format(@"../Images/HeroStatus/{0}.png", status), UriKind.Relative);
                cache.Add(status, new BitmapImage(uri));
            }

            return cache[status];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
