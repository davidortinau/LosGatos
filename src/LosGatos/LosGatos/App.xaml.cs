using LosGatos.Models;
using LosGatos.Pages;
using LosGatos.ViewModels.Messages;
using Plugin.SharedTransitions;
using TinyMessenger;
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
            InitializeComponent();
            
            DependencyService.Register<TinyMessengerHub>();
            Subscribe();
            
            var navigationPage = new SharedTransitionNavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.Transparent
            };

            navigationPage.On<iOS>().SetHideNavigationBarSeparator(true);

            MainPage = navigationPage;
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

        void Subscribe()
        {
            var hub = DependencyService.Get<TinyMessengerHub>();
            hub.Subscribe<AddToCartMessage>(OnAddToCart);
            hub.Subscribe<RemoveFromCartMessage>(OnRemoveFromCart);
        }

        void OnRemoveFromCart(RemoveFromCartMessage obj)
        {
            Model.Cart.Remove(obj.Gatos);
        }

        void OnAddToCart(AddToCartMessage obj)
        {
            Model.Cart.Add(obj.Gatos);
        }
    }
}