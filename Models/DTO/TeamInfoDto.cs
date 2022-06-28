using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_S20226.Models.DTO
{
    public class TeamInfoDto
    {
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }

        public string OrganizationName { get; set; }


        public IEnumerable<MemberDto> Members { get; set; }

}
}
