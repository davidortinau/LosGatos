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
            DisplayAlert("Yay!", "If this were a real app, we might do something. It's not.", "Okay!");
        }

        void OnRemoveButtonClicked(object sender, EventArgs e)
        {
            // Remove from cart
            DisplayAlert("Yay!", "If this were a real app, we might do something. It's not.", "Okay!");
        }
    }
}