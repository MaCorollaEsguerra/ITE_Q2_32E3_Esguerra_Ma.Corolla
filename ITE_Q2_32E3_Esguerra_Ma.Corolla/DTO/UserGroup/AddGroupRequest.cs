using System.ComponentModel.DataAnnotations;

namespace ITE_Q2_32E3_Esguerra_Ma.Corolla.DTO.UserGroup
{
    public class AddGroupRequest
    {
        [Required]
        public string? Name { get; set; }
        [EmailAddress]
        public string? Email { get; set; } = null;
    }
}
