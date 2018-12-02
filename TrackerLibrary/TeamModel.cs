using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// The unique id of a team
        /// </summary>
        public int Id { get; set; }

        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public String TeamName { get; set; }
    }
}
