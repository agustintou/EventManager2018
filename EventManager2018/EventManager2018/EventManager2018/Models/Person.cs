using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace EventManager2018.Models
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(25)]
        public string Name { get; set; }

        [MaxLength(25)]
        public string LastName { get; set; }

        [MaxLength(8)]
        public string Dni { get; set; }

        [MaxLength(100), Unique]
        public string Email { get; set; }

        //Navigation Properties
        [ForeignKey(typeof(User))]
        public int UserId { get; set; }

        [ForeignKey(typeof(Province))]
        public int ProvinceId { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert)]
        public List<Event> Events { get; set; }
    }
}
