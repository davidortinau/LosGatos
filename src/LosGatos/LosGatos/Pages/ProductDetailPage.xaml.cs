using System;
using Xamarin.Forms;

namespace LosGatos.Pages
{
    public partial class ProductDetailPage : ContentPage
    {
        public ProductDetailPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        async void OnBackButtonClicked(object sender, EventArgs e) => await Navigation.PopAsync();
    }
}