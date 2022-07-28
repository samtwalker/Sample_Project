using System;
using System.ComponentModel.DataAnnotations;

namespace Sample_Project.Models
{
    public class TransactionModel
    {
        // transaction object Key
        public int TransactionID { get; set; }

        // transaction user name
        [Display(Name = "User Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "You must enter the name found on your Credit Card")]
        public string UserName { get; set; }

        // valid CC number
        [Display(Name = "Credit Card Number")]
        [DataType(DataType.CreditCard)]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Credit Card is not 16 digits")]
        [Required(ErrorMessage = "You must provide your Credit Card 16 digit number")]
        public string AccountNumber { get; set; }


        // amount of transaction
        [Display(Name = "Transaction Amount")]
        [Range(0, 10000, ErrorMessage = "Transaction Must be less than $10,000")]
        [Required(ErrorMessage = "You must provide an amount to be charged")]
        public float TransactionAmount { get; set; }

    }
}

