using Kentucky.Helper;
using Kentucky.iOS.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(CloseApplication))]
namespace Kentucky.iOS.Helper
{
    public class CloseApplication : ICloseApplication
    {
        public void closeApplication()
        {
            Process.GetCurrentProcess().CloseMainWindow();
            Process.GetCurrentProcess().Close();
        }
    }   
}
