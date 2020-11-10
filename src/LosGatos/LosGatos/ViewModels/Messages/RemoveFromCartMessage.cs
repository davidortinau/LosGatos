using LosGatos.Models;
using TinyMessenger;

namespace LosGatos.ViewModels.Messages
{
    public class RemoveFromCartMessage  : ITinyMessage
    {
        public RemoveFromCartMessage()
        {
        }

        public object Sender { get; private set; }

        public Gatos Gatos { get; set; }
    }
}