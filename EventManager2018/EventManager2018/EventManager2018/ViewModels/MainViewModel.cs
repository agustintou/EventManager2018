namespace EventManager2018.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public MenuViewModel MenuVM { get; set; }

        public EventViewModel EventVM { get; set; }
        #endregion

        #region Builders
        public MainViewModel()
        {
            MenuVM = new MenuViewModel();
            EventVM = new EventViewModel();
        }
        #endregion

        #region Methods

        #endregion
    }
}
