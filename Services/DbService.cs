using Kolokwium_S20226.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_S20226.Services
{
    public class DbService : IDbService
    {
        private readonly MainDbContext _dbContext;

        public DbService(MainDbContext mainDbContext)
        {
            _dbContext = mainDbContext;
        }


    }
}
