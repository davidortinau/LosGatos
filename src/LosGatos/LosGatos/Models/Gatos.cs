using System;
using LosGatos.ViewModels.Messages;
using MvvmHelpers;
using TinyMessenger;
using Xamarin.Forms;

namespace LosGatos.Models
{
    public class Gatos : BaseViewModel
    {
        private int _quantity = 0;
        public string Name { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public string Stars { get; set; }
        public string Price { get; set; }
        public string ProductImage { get; set; }
        public LinearGradientBrush Gradient { get; set; }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                SetProperty(ref _quantity, value);
            }
        }

        public Command SelectedCommand { get; set; }

        public Command AddToCartCommand { get; set; }

        public Gatos()
        {
            SelectedCommand = new Command(OnSelected);
            AddToCartCommand = new Command(OnAddToCart);
        }

        private void OnAddToCart()
        {
            DependencyService.Get<TinyMessengerHub>().Publish(new AddToCartMessage() { Gatos = this });
        }

        private void OnSelected()
        {
            DependencyService.Get<TinyMessengerHub>().Publish(new GoToProductDetailMessage() { Gatos = this });
        }
    }
}
