using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dota2api.Helpers
{
    public static class Urls
    {
        public static string GetMatchHistory = "IDOTA2Match_570/GetMatchHistory/V001/?key=";
        public static string GetMatchDetails = "IDOTA2Match_570/GetMatchDetails/V001/?key=";
    }

    public static class Arguments{
        public static string MatchHistoryStartIndex = "&start_at_match_id=";
        public static string MatchId = "&match_id=";
    }
}
