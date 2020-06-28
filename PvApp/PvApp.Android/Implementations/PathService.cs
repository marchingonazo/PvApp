using System;
using PvApp.Interfaces;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(PvApp.Droid.Implementations.PathService))]
namespace PvApp.Droid.Implementations
{
    public class PathService : IPathService
    {
        public string GetDataBasePath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(path, "PvAppDb.db3");
        }
    }
}