using System;
using System.ComponentModel.DataAnnotations;
using static System.Net.WebRequestMethods;

namespace DevPloyClasses.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public required string Username { get; set; }

        [Required]
        [MaxLength(256)]
        public required string Email { get; set; }

        [Required]
        [Phone]
        public required string PhoneNumber { get; set; }


        [Required]
        public required byte[] PasswordHash { get; set; }

        [Required]
        public required byte[] PasswordSalt { get; set; }

        public string? Otp { get; set; }

        public DateTime? OtpExpiry { get; set; }
        public string? BillingAdress { get; set; }
        public string? Status { get; set; }
       
    }
}
