using System;
using LosGatos.Models;
using MvvmHelpers;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

namespace LosGatos.ViewModels
{
    public class ProductDetailViewModel : BaseViewModel
    {
        public Gatos Gatos
        {
            get
            {
                return App.Model.SelectedGatos;

            }
        }

        public PointCollection HorizonPoints { get; set; }

        public ProductDetailViewModel()
        {
            var screenWidth = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density;
            HorizonPoints = new PointCollection();
            HorizonPoints.Add(new Xamarin.Forms.Point(0, 60));
            HorizonPoints.Add(new Xamarin.Forms.Point(screenWidth, 0));
            HorizonPoints.Add(new Xamarin.Forms.Point(screenWidth, 100));
            HorizonPoints.Add(new Xamarin.Forms.Point(0, 100));
        }
    }
}
