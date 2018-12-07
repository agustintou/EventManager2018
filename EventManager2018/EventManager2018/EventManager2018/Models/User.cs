using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EventManager2018.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(15), Unique]
        public string UserName { get; set; }

        [MaxLength(15)]
        public string Password { get; set; }

        public bool Blocked { get; set; }

        //Navigation Properties
        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert)]
        public int PersonId { get; set; }

    }
}
