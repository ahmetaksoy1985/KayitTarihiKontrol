using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace KayıtTarihiKontrolü
{
    public class RedConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime date;
            if (DateTime.TryParse(values[0].ToString(), out date) && values[1] is SortDescriptionCollection && ((SortDescriptionCollection)values[1]).Select(x => x.PropertyName).Contains("ÜyelikYenileme_Tarih"))
            {
                if (DateTime.Now - date > new TimeSpan(30, 0, 0, 0))
                    return new SolidColorBrush(Colors.Red);
                else
                    return null;
            }
            else
                return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
