using EM.Domain.Enums;
using GalaSoft.MvvmLight.Command;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace EventManager2018.Models
{
    public class Event
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        [MaxLength(25)]
        public string Day { get; set; }

        public bool Tickets { get; set; }

        public EventType EventType { get; set; }

        public byte[] Image { get; set; }

        [Unique, MaxLength(12)]
        public string Code { get; set; }

        //Navigation Properties
        [ForeignKey(typeof(Province))]
        public int ProvinceId { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert)]
        public List<Person> Persons { get; set; }


        //Command
        public ICommand CommandDetail { get { return new RelayCommand(DetailC); } }
        void DetailC()
        {
            //Aqui se abre la pagina con el evento pasando el id
        }
    }
}
