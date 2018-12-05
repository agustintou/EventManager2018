using EventManager2018.Models;
using System.Collections.ObjectModel;

namespace EventManager2018.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItem> Menu { get; set; }
        #endregion

        #region Builders
        public MainViewModel()
        {
            CargarMenu();
        }
        #endregion

        #region Methods
        void CargarMenu()
        {
            Menu = new ObservableCollection<MenuItem>
            {
                new MenuItem
                {
                    Icono = @"pedido.png",
                    Navegacion = @"Event",
                    Titulo = @"Pedidos"
                }
            };
        }
        #endregion
    }
}
