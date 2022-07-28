using System;
using System.Collections.Generic;
using Sample_Project.Models;

namespace Sample_Project.Data
{
    public class TestTransactionRepo : ITransactionRepo
    {
        public void CreateTransaction(TransactionModel newTrans)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransactionModel> GetApprovedTransactions()
        {
            var transactions = new List<TransactionModel>
            {
                new TransactionModel {
                    TransactionID=1,
                    TransactionAmount=34.56f,
                    AccountNumber="123456789123456",
                    UserName="Test Name" },
                new TransactionModel {
                    UserName = "Sam", AccountNumber = "1234", TransactionAmount = 32.4f },
                new TransactionModel {
                    UserName = "mas", AccountNumber = "2435553", TransactionAmount = 5.76f }

            };

            return transactions;
        }
    }
}

