using System.Threading.Tasks;

namespace trymodular.Module.Main.Services {
    public interface ISmsSender {
        Task SendSmsAsync(string number, string message);
    }
}
