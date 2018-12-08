using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventManager2018.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventPage : TabbedPage
    {
		public EventPage ()
		{
			InitializeComponent ();
            Children.Add(new PublicEventPage());
            Children.Add(new PrivateEventPage());
        }
	}
}