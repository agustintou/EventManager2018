using EventManager2018.Models;
using EventManager2018.SQLite.LiteConnection;

namespace EventManager2018.SQLite.StandarDb
{
    public class LocalDb : DataBase
    {
        public Table<Person> Person { get; set; }
        public Table<User> User { get; set; }

        public LocalDb(string databasePath, bool storeDateTimeAsTicks = true)
            : base(databasePath, storeDateTimeAsTicks)
        {
            Person = DBSet<Person>();
            User = DBSet<User>();
        }

        public static LocalDb Intance
        {
            get
            {
                var service = Xamarin.Forms.DependencyService.Get<IDataBase>();

                if (service != null)
                {
                    return service.GetDataBase();
                }
                throw new System.Exception("No es posible obtener el servicio.");
            }
        }
    }
}
}
