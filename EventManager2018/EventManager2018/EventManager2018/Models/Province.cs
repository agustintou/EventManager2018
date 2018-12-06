using System.Collections.Generic;

namespace EventManager2018.Models
{
    public class Province
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool Removed { get; set; }

        //Navigation Properties
        public Country Country { get; set; }

        public List<Event> Events { get; set; }

        public List<Person> Persons { get; set; }

    }
}
