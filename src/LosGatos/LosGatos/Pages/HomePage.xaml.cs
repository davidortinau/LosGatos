using System;
using System.Collections.Generic;
using System.Linq;
using LosGatos.Models;
using LosGatos.ViewModels.Messages;
using Plugin.SharedTransitions;
using TinyMessenger;
using Xamarin.Forms;

namespace LosGatos.Pages
{
    public partial class HomePage : ContentView
    {
        public HomePage()
        {
            BindingContext = this;

            DependencyService.Get<TinyMessengerHub>().Subscribe<GoToProductDetailMessage>(OnGoToProductDetail);

            InitializeComponent();
        }

        async void OnGoToProductDetail(GoToProductDetailMessage obj)
        {
            App.Model.SelectedGatos = obj.Gatos;
            Page p = ((NavigationPage)App.Current.MainPage).CurrentPage;
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(p, obj.Gatos.Name);
            await Navigation.PushAsync(new ProductDetailPage());
        }

        public void AddToCardBtn_Clicked(object s, EventArgs e)
        {
            App.Model.Cart.Add(App.Model.Gatos[0]);
        }

        public List<Gatos> Gatos { get; set; } = App.Model.Gatos.Take(3).ToList();

        public List<Gatos> PopularGatos
        {
            get
            {
                var rand = new Random();
                var randomList = App.Model.Gatos.OrderBy(x => rand.Next()).ToList();
                return randomList.Take(5).ToList();
            }
        }    

        void OnDragStarting(object sender, DragStartingEventArgs e)
        {

        }

        void OnDropCompleted(object sender, DropCompletedEventArgs e)
        {
            DependencyService.Get<TinyMessengerHub>().Publish(new DragEndedMessage());
        }
    }
}