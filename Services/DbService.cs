using Kolokwium_S20226.Models;

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
