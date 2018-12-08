using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EventManager2018.Models
{
    public class Guests
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(8)]
        public string Dni { get; set; }

        public int Companions { get; set; }

        public string Image { get; set; }

        //Navigation Properties
        [ForeignKey(typeof(Event))]
        public int EventId { get; set; }
    }
}
