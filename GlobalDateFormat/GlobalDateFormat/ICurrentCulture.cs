using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalDateFormat
{
    public interface ICultureController
    {
        void ChangeCulture(CultureInfo culture);
    }
}
