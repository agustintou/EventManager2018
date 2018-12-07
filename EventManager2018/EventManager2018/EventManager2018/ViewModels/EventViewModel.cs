using EventManager2018.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;

namespace EventManager2018.ViewModels
{
    public class EventViewModel : BaseViewModel
    {
        #region Attributes
        private Event _event { get; set; }
        public Event Event
        {
            get
            {
                return this._event;
            }
            set
            {
                if(value != _event)
                {
                    _event = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime MinimumDate { get; set; }

        public DateTime MaximumDate { get; set; }

        public string _information { get; set; }
        public string Information
        {
            get
            {
                return this._information;
            }
            set
            {
                if(value != _information)
                {
                    _information = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Properties
        public ICommand CommandAccept { get { return new RelayCommand(Accept); } }
        #endregion

        #region Builders
        public EventViewModel()
        {
            InitialData();
        }
        #endregion

        #region Commands
        void Accept()
        {
            try
            {
                CheckData();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Methods
        void CheckData()
        {

        }

        void InitialData()
        {
            Event = new Event();
            MinimumDate = DateTime.Now;
            MaximumDate = new DateTime(2020, 1, 1);
        }
        #endregion
    }
}
