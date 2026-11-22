using System.ComponentModel.DataAnnotations;

namespace ITE_Q2_32E3_Esguerra_Ma.Corolla.DTO.UserGroup
{
    public class EditGroupRequestcs
    {
        public string? Name { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? ID { get; set; }
    }
}
