using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_Project.Data_Layer.Entity_Models
{
    public class PaymentEntityModel
    {
        public int Id { get; set; }
        public int CreditCardNumber { get; set; }
        public int AccountNumber { get; set; }
        public double Amount { get; set; }
    }
}
