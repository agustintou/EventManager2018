using EventManager2018.Models;
using EventManager2018.SQLite.LiteConnection;

namespace EventManager2018.SQLite.StandarDb
{
    public class LocalDb : DataBase
    {
        public Table<Person> Person { get; set; }
        public Table<User> User { get; set; }
        public Table<Country> Country { get; set; }
        public Table<Province> Province { get; set; }
        public Table<Event> Event { get; set; }

        public LocalDb(string databasePath, bool storeDateTimeAsTicks = true)
            : base(databasePath, storeDateTimeAsTicks)
        {
            Person = DBSet<Person>();
            User = DBSet<User>();
            Country = DBSet<Country>();
            Province = DBSet<Province>();
            Event = DBSet<Event>();
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
