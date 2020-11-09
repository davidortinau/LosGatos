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



        public List<Gatos> Gatos { get; set; } = new List<Gatos>()
        {
            new Gatos{
                Name = "First",
                Description = "The One",
                Price = "$22.95",
                ProductImage = "shutterstock_553119223.png",
                Stars = "3.5"
            },
            new Gatos{
                Name = "Second",
                Description = "The Two",
                Price = "$32.95",
                ProductImage = "shutterstock_208551202.png",
                Stars = "3"
            },
            new Gatos{
                Name = "Third",
                Description = "The Three",
                Price = "$12.95",
                ProductImage = "shutterstock_188816654.png",
                Stars = "4"
            },
        };
    }
}