using EventManager2018.Resources;
using EventManager2018.SQLite.LiteConnection;
using EventManager2018.SQLite.StandarDb;
using EventManager2018.Views;
using Plugin.Multilingual;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EventManager2018
{
    public partial class App : Application
    {
        public static LocalDb DB { get; private set; }

        public App()
        {
            InitializeComponent();

            Keys.DataBaseName = "EventManager2018.db3";
            App.DB = LocalDb.Intance;

            AppResources.Culture = CrossMultilingual.Current.DeviceCultureInfo;

            MainPage = new NavigationPage(new MasterPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
