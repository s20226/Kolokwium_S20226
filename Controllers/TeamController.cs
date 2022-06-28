using Kolokwium_S20226.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kolokwium_S20226.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IDbService _dbService;
        public TeamController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{teamID}")]
        public async Task<IActionResult> GetTeam(int teamID)
        {
            if (!await _dbService.CheckTeam(teamID))
                return NotFound("Brak teamu o tym id");
            return Ok(await _dbService.GetTeam(teamID));
            

        }

    }
}
