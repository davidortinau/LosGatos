using System;
using Xamarin.Forms;

namespace LosGatos.Models
{
    public class Gatos
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Stars { get; set; }
        public string Price { get; set; }
        public string ProductImage { get; set; }
        public LinearGradientBrush Gradient { get; set; }

        public Gatos()
        {
        }
    }
}
