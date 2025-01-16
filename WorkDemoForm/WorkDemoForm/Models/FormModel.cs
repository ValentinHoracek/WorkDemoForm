using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using WorkDemoForm.Models.Data;

namespace WorkDemoForm.Models
{
    public class FormModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname {  get; set; }

        [Required]
        [RegularExpression(@"[0-9]{6}\/?[0-9]{3,4}")]
        public string PersonalNumber {  get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public Gender Gender { get; set; } = Gender.Undefined;

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]  
        public bool IsGDPRConfirmed { get; set; }

    }
}
