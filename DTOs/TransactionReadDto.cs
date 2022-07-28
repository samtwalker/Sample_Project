using System;
namespace Sample_Project.DTOs
{
    public class TransactionReadDto
    {
        public int TransactionID { get; set; }

        public string UserName { get; set; }

        public string AccountNumber { get; set; }

        public float TransactionAmount { get; set; }
    }
}

