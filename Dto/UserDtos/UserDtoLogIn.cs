using System;
using System.ComponentModel.DataAnnotations;

namespace DevPloyClasses.Dto.UserDtos
{
    /// <summary>
    /// Dto Model For User retrivment
    /// </summary>
    public class UserDtoLogIn
    {
        public string? PhoneNumber { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string Pasword { get; set; } = string.Empty;
    }

}