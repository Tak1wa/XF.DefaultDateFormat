using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GlobalDateFormat.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(RequestBluetooth))]
namespace GlobalDateFormat.Droid
{
    public class RequestBluetooth : IRequestBluetooth
    {
        public void Request()
        {
            //[Requires] Manifest.Permission : BLUETOOTH
            var intent = new Intent(BluetoothAdapter.ActionRequestEnable);
            var activity = (MainActivity)Forms.Context;
            activity.StartActivityForResult(intent, 1);
        }
    }
}