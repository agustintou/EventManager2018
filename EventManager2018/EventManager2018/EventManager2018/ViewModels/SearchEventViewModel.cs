using EventManager2018.Models;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EventManager2018.ViewModels
{
    public class SearchEventViewModel : BaseViewModel
    {
        #region Attributes
        private string _searchText { get; set; }
        public string SearchText
        {
            get
            {
                return this._searchText;
            }
            set
            {
                if(value != _searchText)
                {
                    _searchText = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _informationIsVisible { get; set; }
        public bool InformationIsVisible
        {
            get
            {
                return this._informationIsVisible;
            }
            set
            {
                if (value != _informationIsVisible)
                {
                    _informationIsVisible = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _informationText { get; set; }
        public string InformationText
        {
            get
            {
                return this._informationText;
            }
            set
            {
                if (value != _informationText)
                {
                    _informationText = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isRefresing { get; set; }
        public bool IsRefresing
        {
            get
            {
                return this._informationIsVisible;
            }
            set
            {
                if (value != _informationIsVisible)
                {
                    _informationIsVisible = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Properties
        public ICommand CommandSearch { get { return new RelayCommand(SearchC); } }

        public ICommand CommandRefresh { get { return new RelayCommand(RefreshC); } }

        public ObservableCollection<Event> Events { get; set; }
        #endregion

        #region Builders
        public SearchEventViewModel()
        {
            InitialData();
        }
        #endregion

        #region Commands
        void SearchC()
        {
            Refresh();
        }

        void RefreshC()
        {
            Refresh();
        }
        #endregion

        #region Methods
        async void Refresh()
        {

        }

        void InitialData()
        {
            Events = new ObservableCollection<Event>();
        }
        #endregion
    }
}
