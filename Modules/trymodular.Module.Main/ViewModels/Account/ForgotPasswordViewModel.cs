using System.ComponentModel.DataAnnotations;

namespace trymodular.Module.Main.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
