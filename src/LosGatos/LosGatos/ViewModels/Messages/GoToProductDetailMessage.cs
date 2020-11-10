using LosGatos.Models;
using TinyMessenger;

namespace LosGatos.ViewModels.Messages
{
    public class GoToProductDetailMessage  : ITinyMessage
    {
        public GoToProductDetailMessage()
        {
        }

        public object Sender { get; private set; }

        public Gatos Gatos { get; set; }
    }
}