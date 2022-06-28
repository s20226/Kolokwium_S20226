﻿using Kolokwium_S20226.Models;
using Kolokwium_S20226.Models.DTO;
using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> CheckTeam(int teamID)
        {
            var team = await _dbContext.Teams.Where(e => e.TeamID == teamID).FirstOrDefaultAsync();
            if (team is null) return false;
            return true;
        }

        public async Task<IEnumerable<TeamInfoDto>> GetTeam(int teamID)
        {
            var results = await _dbContext.Teams.Where(e => e.TeamID == teamID)
                .Include(o => o.Organization)
                .Include(m => m.Memberships)
                  .Select(e => new TeamInfoDto
                  {
                      TeamName = e.TeamName,
                      TeamDescription = e.TeamDescription,
                      OrganizationName = e.Organization.OrganizationName

                  }).ToListAsync();

          

            return results;
        }
    }
}
