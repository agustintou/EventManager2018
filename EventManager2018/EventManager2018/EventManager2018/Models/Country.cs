using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace EventManager2018.Models
{
    public class Country
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public bool Removed { get; set; }

        //Navigation Properties
        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert)]
        public List<Province> Provinces { get; set; }
    }
}
