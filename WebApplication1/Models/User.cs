using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using MessagePack;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Cognome { get; set; }
        public string Email { get; set; }
        [Required]
        public Sex Sex { get; set; }
        [Range(0,150)]
        public int Age { get; set; }
    }
}
