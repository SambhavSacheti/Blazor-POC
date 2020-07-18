
using System;
using System.ComponentModel.DataAnnotations;

namespace HelloBlazor.Apps.Models
{
    public class ValidationExampleModel
    {
        [ValidateComplexType]   // Complex Type Validation
        public Name Name { get; set; }

        [RegularExpression(@"[R]\d{3}[a-zA-Z]{2}\d{2}"), Required]
        public string Model { get; set; }
        public DateTime Year { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        [Required,]
        public string SerialNumber { get; set; }

        public string AdditionalDetails { get; set; }
        public ValidationExampleModel()
        {
            Name = new Name{FirstName=string.Empty, LastName = string.Empty};
        }

    }

    public class Name{
        
        [Required, Range(3,15, ErrorMessage = "First Name should be betweeen 3 and 15 characters long")]
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}