using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dota2api.Models
{
    public class Match
    {
        public int match_id { get; set; }
        public int match_seq_num { get; set; }
        public int start_time { get; set; }
        public int lobby_type { get; set; }
        public int radiant_team_id { get; set; }
        public int dire_team_id { get; set; }
        public List<Player> players { get; set; }
    }
}
