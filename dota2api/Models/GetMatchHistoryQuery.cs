using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dota2api.Models
{
    public class MatchHistoryQuery
    {
        public string player_name { get; set; }     // Search matches with a player name, exact match only
        public int hero_id {get;set;}               //# Search for matches with a specific hero being played, hero id's are in dota/scripts/npc/npc_heroes.txt in your Dota install directory
        public int skill {get;set;}                 //# 0 for any, 1 for normal, 2 for high, 3 for very high skill
        public long date_min {get;set;}             //# date in UTC seconds since Jan 1, 1970 (unix time format)
        public long date_max { get; set; }          //# date in UTC seconds since Jan 1, 1970 (unix time format)
        public long account_id {get;set;}           //# Steam account id (this is not SteamID, its only the account number portion)
        public long league_id { get; set; }         //# matches for a particular league
        public long start_at_match_id {get;set;}    //# Start the search at the indicated match id, descending
        public int matches_requested {get;set;}     //# Defaults is 100? matches, this can limit to less
    }
}
