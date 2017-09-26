using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Foundation;
using GlobalDateFormat.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(CultureController))]
namespace GlobalDateFormat.iOS
{
    public class CultureController : ICultureController
    {
        public void ChangeCulture(CultureInfo culture)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
        }
    }
}