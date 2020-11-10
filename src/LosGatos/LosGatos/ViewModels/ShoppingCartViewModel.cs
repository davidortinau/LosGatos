using System.Collections.ObjectModel;
using LosGatos.Models;
using MvvmHelpers;

namespace LosGatos.ViewModels
{
    public class ShoppingCartViewModel : BaseViewModel
    {
        public ObservableCollection<Gatos> Cart { get; set; }

        public ShoppingCartViewModel()
        {
            Cart = App.Model.Cart;
        }       
    }
}