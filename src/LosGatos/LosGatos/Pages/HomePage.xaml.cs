using System;
using System.Collections.Generic;
using LosGatos.Models;
using Xamarin.Forms;

namespace LosGatos.Pages
{
    public partial class HomePage : ContentView
    {
        public HomePage()
        {
            BindingContext = this;

            InitializeComponent();
        }

        public async void TapGestureRecognizer_Tapped(object s, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProductDetailPage(), false);
        }

        public void AddToCardBtn_Clicked(object s, EventArgs e)
        {
            App.Model.Cart.Add(App.Model.Gatos[0]);
        }


        public List<Gatos> Gatos { get; set; } = App.Model.Gatos;
    }
}