namespace EventManager2018.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public MenuViewModel MenuVM { get; set; }
        #endregion

        #region Builders
        public MainViewModel()
        {
            MenuVM = new MenuViewModel();
        }
        #endregion

        #region Methods

        #endregion
    }
}
