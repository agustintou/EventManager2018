namespace EventManager2018.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public MenuViewModel MenuVM { get; set; }

        public EventViewModel EventVM { get; set; }

        public SearchEventViewModel SeachEventVM { get; set; }

        #endregion

        #region Builders
        public MainViewModel()
        {
            MenuVM = new MenuViewModel();
            EventVM = new EventViewModel();
            SeachEventVM = new SearchEventViewModel();
        }
        #endregion

        #region Methods

        #endregion
    }
}
