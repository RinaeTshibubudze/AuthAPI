
namespace AuthAPI.Models.Dto
{
    public class UserDto
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
    }
}