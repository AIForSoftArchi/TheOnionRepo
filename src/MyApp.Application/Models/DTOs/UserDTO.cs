namespace MyApp.Application.Models.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public int Status { get; set; }
        public string StatusText { get; set; }

        public UserDTO() { }
    }
}
