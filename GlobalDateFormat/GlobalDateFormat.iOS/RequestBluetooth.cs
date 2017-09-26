using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreBluetooth;
using Foundation;
using GlobalDateFormat.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(RequestBluetooth))]
namespace GlobalDateFormat.iOS
{
    public class RequestBluetooth : IRequestBluetooth
    {
        public void Request()
        {
            var manager = new CBCentralManager();
        }
    }
}