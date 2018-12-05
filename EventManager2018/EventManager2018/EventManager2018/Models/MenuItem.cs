using EventManager2018.Services;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace EventManager2018.Models
{
    public class MenuItem
    {
        public string Icon { get; set; }

        public string Title { get; set; }

        public string Navigate { get; set; }

        public ICommand NavigateCommand { get { return new RelayCommand(NavigateC); } }

        async void NavigateC()
        {
            await NavigationService.MenuNavigation(Navigate);
        }
    }
}
