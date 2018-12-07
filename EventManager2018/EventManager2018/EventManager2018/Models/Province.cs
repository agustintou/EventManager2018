using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace EventManager2018.Models
{
    public class Province
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public bool Removed { get; set; }

        //Navigation Properties
        [ForeignKey(typeof(Country))]
        public int CountryId { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert)]
        public List<Event> Events { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert)]
        public List<Person> Persons { get; set; }

    }
}
