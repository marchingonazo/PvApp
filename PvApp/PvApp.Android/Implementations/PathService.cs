//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
using System.IO;
using PvApp.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(GasApp.Droid.Implementations.PathService))]
namespace PvApp.Droid.Implementations
{
    public class PathService : IpathServices
    {
        public string GetDataBasePath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(path, "PvAppDb.db3");
        }
    }
}