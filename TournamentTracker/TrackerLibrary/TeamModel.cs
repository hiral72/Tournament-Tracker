using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; }
        public string TeamName { get; set; }
        public TeamModel ()
	    {
            TeamMembers=new List<PersonModel>();
	    }
    }
}
