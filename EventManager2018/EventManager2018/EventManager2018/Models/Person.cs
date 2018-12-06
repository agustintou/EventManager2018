using System.Collections.Generic;

namespace EventManager2018.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Dni { get; set; }

        public string Email { get; set; }

        //Navigation Properties
        public User User { get; set; }

        public Province Province { get; set; }

        public List<Event> Events { get; set; }
    }
}
