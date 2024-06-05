using System.ComponentModel.DataAnnotations;

namespace Maqaoplus.Entities.Auth
{
    public class StaffForgotPassword
    {
        [Required(ErrorMessage = "Email Address Is Required!")]
        public string? EmailAddress { get; set; }
    }
}
