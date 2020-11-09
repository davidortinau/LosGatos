using TinyMessenger;

namespace LosGatos.ViewModels.Messages
{
    public class DragStartedMessage : ITinyMessage
    {
        public DragStartedMessage()
        {
        }

        public object Sender { get; private set; }
    }
}