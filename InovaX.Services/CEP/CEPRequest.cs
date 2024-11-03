using System.ComponentModel.DataAnnotations;

namespace InovaX.Services.CEP
{
    public class CEPRequest
    {
        [Required]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O CEP deve estar no formato 12345-678.")]
        public string CEP { get; set; }
    }
}
