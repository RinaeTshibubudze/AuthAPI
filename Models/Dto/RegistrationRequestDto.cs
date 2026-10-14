
namespace AuthAPI.Models.Dto
{
    public class RegistrationRequestDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public required string Password { get; set; }
        public required string? Role { get; set; }
    }
}