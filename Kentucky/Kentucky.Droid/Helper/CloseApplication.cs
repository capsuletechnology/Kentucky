using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Kentucky.Helper;
using Kentucky.Droid.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(CloseApplication))]
namespace Kentucky.Droid.Helper
{
    public class CloseApplication : ICloseApplication
    {
        public void closeApplication()
        {
            Process.KillProcess(Process.MyPid());
        }
    }
}