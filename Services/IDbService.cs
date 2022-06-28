using Kolokwium_S20226.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kolokwium_S20226.Services
{
    public interface IDbService
    {
        Task<IEnumerable<TeamInfoDto>> GetTeam(int teamID);
        Task<bool> CheckTeam(int teamID);
    }
}
