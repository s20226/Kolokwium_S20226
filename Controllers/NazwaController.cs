using Kolokwium_S20226.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_S20226.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NazwaController : ControllerBase
    {
        private readonly IDbService _dbService;
        public NazwaController (IDbService dbService)
        {
            _dbService = dbService;
        }



    }
}
