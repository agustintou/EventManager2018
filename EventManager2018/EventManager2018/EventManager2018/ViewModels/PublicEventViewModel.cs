using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using EventManager2018.Implementation;
using EventManager2018.Models;
using GalaSoft.MvvmLight.Command;

namespace EventManager2018.ViewModels
{
    public class PublicEventViewModel : BaseViewModel
    {
        #region Attributtes
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

        private DateTime MaximumDate { get; set; }

        private DateTime MiniumDate { get; set; }

        private ObservableCollection<Guests> _specialGuests { get; set; }
        public ObservableCollection<Guests> SpecialGuests
        {
            get
            {
                return this._specialGuests;
            }
            set
            {
                if (value != _specialGuests)
                {
                    _specialGuests = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isRefresing { get; set; }
        public bool IsRefresing
        {
            get
            {
                return this._isRefresing;
            }
            set
            {
                if (value != _isRefresing)
                {
                    _isRefresing = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Properties
        public ICommand CommandNowGuests { get { return new RelayCommand(NowGuests); } }

        public ICommand CommandRefresh { get { return new RelayCommand(Refresh); } }

        public ICommand CommandNowEvent { get { return new RelayCommand(NowEvent); } }
        #endregion

        #region Builders
        public PublicEventViewModel()
        {
            InitialData();
        }
        #endregion

        #region Commands
        void NowGuests()
        {
            throw new NotImplementedException();
        }

        void Refresh()
        {
            throw new NotImplementedException();
        }

        void NowEvent()
        {
            try
            {
                CheckData();

                Event.Code = GetCode();


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

        #region Methods
        void InitialData()
        {
            Event = new Event();
            SpecialGuests = new ObservableCollection<Guests>();
            MaximumDate = new DateTime(2022, 1, 1);
            MiniumDate = DateTime.Now;
        }

        void CheckData()
        {
            if (string.IsNullOrWhiteSpace(_event.Name))
                throw new Exception("El nombre no puede estar vacio.");

            if (string.IsNullOrWhiteSpace(_event.Description))
                throw new Exception("La descripcion no puede estar vacia.");
        }

        string GetCode()
        {
            return GenerateCode.Generate();
        }
        #endregion
    }
}
