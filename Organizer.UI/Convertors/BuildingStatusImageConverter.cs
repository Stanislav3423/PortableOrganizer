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
    public class BuildingStatusImageConverter : IValueConverter
    {
        private Dictionary<BuildingStatus, BitmapImage> cache = new Dictionary<BuildingStatus, BitmapImage>();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (BuildingStatus)value;
            if (!cache.ContainsKey(status))
            {
                var uri = new Uri(string.Format(@"../Images/BuildingStatus/{0}.png", status), UriKind.Relative);
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
