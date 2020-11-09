using TinyMessenger;

namespace LosGatos.ViewModels.Messages
{
    public class DragEndedMessage  : ITinyMessage
    {
        public DragEndedMessage()
        {
        }

        public object Sender { get; private set; }
    }
}