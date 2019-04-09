using System.Threading.Tasks;

namespace trymodular.Module.Main.Services {
    public interface IEmailSender {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
