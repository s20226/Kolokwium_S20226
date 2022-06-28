using Kolokwium_S20226.Models;
using Kolokwium_S20226.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kolokwium_S20226.Services
{
    public interface IDbService
    {
        public Task<IEnumerable<TeamInfoDto>> GetTeam(int teamID);
        public Task<bool> CheckTeam(int teamID);

        public Task<bool> CheckOrganization(Member member, int teamID);
        public Task AddMember(int teamID, Member member);
    }
}