using Sample_Project.Data_Layer.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_Project.Data_Layer.Repositories
{
    public class FinanciesDbRepository
    {
        private readonly FinancialsDbContext _financesDbContext;
        public FinanciesDbRepository(FinancialsDbContext financesDbContext)
        {
            _financesDbContext = financesDbContext;
        }
    }
}