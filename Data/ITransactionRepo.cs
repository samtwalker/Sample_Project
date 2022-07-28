using System;
using System.Collections.Generic;
using Sample_Project.Models;

namespace Sample_Project.Data
{
    public interface ITransactionRepo
    {

        IEnumerable<TransactionModel> GetApprovedTransactions();

        void CreateTransaction(TransactionModel newTrans);

    }
}

