
using System.ComponentModel.DataAnnotations;

namespace Sample_Project.DTOs
{
    public class TransactionCreateDto
    { 
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public float TransactionAmount { get; set; }

    }
}

