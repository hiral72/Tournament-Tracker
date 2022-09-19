﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public int MatchupId{get; set;}
        public List<MatchupEntryModel> Entries { get; set; }
        public TeamModel Winner { get; set; }
        public int WinnerId { get; set; }
        public int MatchupRound { get; set; }

        public MatchupModel()
        {
            Entries= new List<MatchupEntryModel>();
        }

    }
}
