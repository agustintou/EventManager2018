using EM.Domain.Enums;
using System;
using System.Collections.Generic;

namespace EventManager2018.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public bool Tickets { get; set; }

        public EventType EventType { get; set; }

        public byte[] Image { get; set; }

        public string Cod { get; set; }

        //Navigation Properties
        public Province Province { get; set; }

        public List<Person> Persons { get; set; }

    }
}
