using System.ComponentModel.DataAnnotations;

namespace Application.UI.ViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}