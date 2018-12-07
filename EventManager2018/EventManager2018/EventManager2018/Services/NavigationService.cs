using EventManager2018.Views;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EventManager2018.Services
{
    public class NavigationService
    {
        public static async Task MenuNavigation(string pageName)
        {
            switch (pageName)
            {
                case "EventPage":
                    await Application.Current.MainPage.Navigation.PushAsync(new EventPage());
                    break;
                case "SearchEventPage":
                    await Application.Current.MainPage.Navigation.PushAsync(new SearchEventPage());
                    break;
                default:
                    break;
            }
        }
    }
}
