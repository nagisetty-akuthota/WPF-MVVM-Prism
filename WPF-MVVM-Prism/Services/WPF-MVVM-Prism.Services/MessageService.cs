using WPF_MVVM_Prism.Services.Interfaces;

namespace WPF_MVVM_Prism.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
