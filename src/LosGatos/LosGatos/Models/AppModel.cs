using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MvvmHelpers;

namespace LosGatos.Models
{
    /// <summary>
    /// Simple model for hosting sample content and storing app state
    /// </summary>
    public class AppModel : BaseViewModel
    {
        private ObservableCollection<Gatos> cart = new ObservableCollection<Gatos>();

        public AppModel()
        {
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

        public ObservableCollection<Gatos> Cart
        {
            get { return cart; }
            set
            {
                SetProperty(ref cart, value);
            }
        }
        public ObservableCollection<Gatos> Favorites { get; set; } = new ObservableCollection<Gatos>();

        public ObservableCollection<Gatos> SaveForLater { get; set; } = new ObservableCollection<Gatos>();

        public void AddToCartByName(string catName)
        {
            Cart.Add(
            Gatos.FirstOrDefault(x => x.Name == catName)
                );
        }
    }
}
