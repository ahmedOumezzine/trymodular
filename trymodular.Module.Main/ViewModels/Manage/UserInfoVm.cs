using System.ComponentModel.DataAnnotations;

namespace trymodular.Module.Main.ViewModels.Manage
{
    public class UserInfoVm
    {
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
