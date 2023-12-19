using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace BankSimulation.Models
{

    public class MinimumAgeAttribute : ValidationAttribute { 
        private readonly int _minimumAge;

        public MinimumAgeAttribute(int minimumAge)        {
            _minimumAge = minimumAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validation) {
            if (value != null) { 
                int age = (int)value;

                if (age < _minimumAge)
                {
                    return new ValidationResult($"Age should be atleast {_minimumAge} years.");
                }
            }
            return ValidationResult.Success;
        }

    }
    public class User
    {
        [Key]
        public int AccountNumber { get; set; }

        [Required]
        [DisplayName("Account Holder Name")]
        public string Name{ get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [MinimumAge(16, ErrorMessage ="Age should be atleast 16 years.")]
        public int Age { get; set; }

        [Required]
        public string Password { get; set; }
        
        public decimal CurrentBalance { get; set; }

    }
}
