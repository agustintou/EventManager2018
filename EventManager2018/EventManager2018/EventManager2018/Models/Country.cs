using System.Collections.Generic;

namespace EventManager2018.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool Removed { get; set; }

        //Navigation Properties
        public List<Province> Provinces { get; set; }
    }
}
