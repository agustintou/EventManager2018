using EventManager2018.SQLite.LiteConnection;
using EventManager2018.SQLite.StandarDb;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SporTucMobile.Droid.LiteConnection.Connection))]
namespace SporTucMobile.Droid.LiteConnection
{
    public class Connection : IDataBase
    {
        public LocalDb GetDataBase()
        {
            var fileName = Keys.DataBaseName;
            //var internalpath = Android.OS.Environment.ExternalStorageDirectory.Path;
            //var path = Path.Combine(internalpath, fileName);
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);
            return new LocalDb(path);
        }
    }
}