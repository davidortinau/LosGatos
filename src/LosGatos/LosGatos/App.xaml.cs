using System.Collections.Generic;
using LosGatos.Models;
using LosGatos.Pages;
using Plugin.SharedTransitions;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace LosGatos
{
    public partial class App : Xamarin.Forms.Application
    {
        public static AppModel Model { get; set; } = new AppModel();

        public App()
        {
            //Device.SetFlags(new string[] { "Brush_Experimental", "Shapes_Experimental" });

            InitializeComponent();

            var navigationPage = new SharedTransitionNavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.Transparent
            };

            navigationPage.On<iOS>().SetHideNavigationBarSeparator(true);

            MainPage = navigationPage;
            //MainPage = new ProductDetailPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        
    }
}