using System.ComponentModel.DataAnnotations;

namespace ITE_Q2_32E3_Esguerra_Ma.Corolla.DTO.User
{
    public class AddUserRequest
    {
        public string? Name { get; set; }
        [EmailAddress]
        public string? Email { get; set; } = null;
        
    }
}
