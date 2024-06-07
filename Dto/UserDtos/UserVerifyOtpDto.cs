using System;

namespace DevPloyClasses.Dto.UserDtos
{
    public class UserVerifyOtpDto
    {
        public required string UserId { get; set; }
        public required string Otp { get; set; }
    }

}