using System.ComponentModel.DataAnnotations;

namespace DxBlazorApplicationScheduler.Login
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Bitte Benutzername eingeben.")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Bitte Passwort eingeben.")]
        public string Password { get; set; }
    }
}
