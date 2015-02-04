using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dota2api.Models
{
    public class Result
    {
        public int status { get; set; }
        public string statusDetail { get; set; }
        public int num_results { get; set; }
        public int total_results { get; set; }
        public int results_remaining { get; set; }
        public List<Match> matches { get; set; }
        public int next_id { get; set; }
        public string query_url { get; set; }
        public List<Player> players { get; set; }
        public bool radiant_win { get; set; }
        public int duration { get; set; }
        public int start_time { get; set; }
        public int match_id { get; set; }
        public int match_seq_num { get; set; }
        public int tower_status_radiant { get; set; }
        public int tower_status_dire { get; set; }
        public int barracks_status_radiant { get; set; }
        public int barracks_status_dire { get; set; }
        public int cluster { get; set; }
        public int first_blood_time { get; set; }
        public int lobby_type { get; set; }
        public int human_players { get; set; }
        public int leagueid { get; set; }
        public int positive_votes { get; set; }
        public int negative_votes { get; set; }
        public int game_mode { get; set; }
    }
}
