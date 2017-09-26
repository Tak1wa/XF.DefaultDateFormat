using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GlobalDateFormat.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(CultureController))]
namespace GlobalDateFormat.Droid
{
    public class CultureController : ICultureController
    {
        public void ChangeCulture(CultureInfo culture)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}