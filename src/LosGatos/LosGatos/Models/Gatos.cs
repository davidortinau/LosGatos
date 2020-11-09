using System;
using MvvmHelpers;
using Xamarin.Forms;

namespace LosGatos.Models
{
    public class Gatos : BaseViewModel
    {
        private int _quantity = 0;
        public string Name { get; set; }
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
        public Gatos()
        {
        }
    }
}
