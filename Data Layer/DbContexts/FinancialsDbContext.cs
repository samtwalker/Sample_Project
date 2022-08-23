using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sample_Project.Data_Layer.DbContexts
{
    public class FinancialsDbContext : DbContext
    {
        public FinancialsDbContext(DbContextOptions<FinancialsDbContext> options)
            :base(options)
        {

        }
    }
}
