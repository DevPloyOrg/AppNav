using System.ComponentModel.DataAnnotations;

namespace DevPloyClasses.Dto.UserDtos
{
    /// <summary>
    /// Data Transfert Model for User Post
    /// </summary>
    public class UserDtoRegister
    {
        public required string Username { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public string? BillingAdress { get; set; }

        public required string PhoneNumber { get; set; }
    }
}
