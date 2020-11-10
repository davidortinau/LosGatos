using System;
using Xamarin.Forms;

namespace LosGatos.Pages
{
    public partial class ShoppingCartPage : ContentPage
    {
        public ShoppingCartPage()
        {
            InitializeComponent();
        }

        async void OnBackButtonClicked(object sender, EventArgs e) => await Navigation.PopAsync();

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Remove from cart
            // Add to saved for later
        }

        void OnRemoveButtonClicked(object sender, EventArgs e)
        {
            // Remove from cart
        }
    }
}