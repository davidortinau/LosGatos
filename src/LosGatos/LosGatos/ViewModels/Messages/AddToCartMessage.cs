using LosGatos.Models;
using TinyMessenger;

namespace LosGatos.ViewModels.Messages
{
    public class AddToCartMessage  : ITinyMessage
    {
        public AddToCartMessage()
        {
        }

        public object Sender { get; private set; }

        public Gatos Gatos { get; set; }
    }
}