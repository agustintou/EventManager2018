using EventManager2018.Models;
using System.Collections.ObjectModel;

namespace EventManager2018.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        #region Attributes

        #endregion

        #region Properties
        public ObservableCollection<MenuItem> Menu { get; set; }
        #endregion

        #region Builders
        public MenuViewModel()
        {
            CargarMenu();
        }
        #endregion

        #region Commands

        #endregion

        #region Methods
        void CargarMenu()
        {
            Menu = new ObservableCollection<MenuItem>
            {
                new MenuItem
                {
                    Icon = @"ic_event_note.png",
                    Navigate = @"EventPage",
                    Title = @"Nuevo evento"
                },

                new MenuItem
                {
                    Icon = @"ic_search.png",
                    Navigate = @"EventsPage",
                    Title = @"Eventos publicos"
                },

                new MenuItem
                {
                    Icon = @"ic_manage.png",
                    Navigate = @"ManageEventPage",
                    Title = @"Administrar eventos"
                }
            };
        }
        #endregion
    }
}
