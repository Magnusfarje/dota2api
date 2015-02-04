Async C# implementation of the dota 2 match history api

<strong>Get api key for steam here:</strong>
http://steamcommunity.com/dev/apikey


<h1>GetMatchHistory(MatchHistoryQuery?)</h1>
<strong>MatchHistoryQuery properties:</strong>
<table>
<tr>
<td>
player_name
</td>
<td>
Search matches with a player name, exact match only
</td>
</tr>
</table>
player_name         Search matches with a player name, exact match only
hero_id             Search for matches with a specific hero being played, hero id's are in dota/scripts/npc/npc_heroes.txt in your Dota install directory
skill               0 for any, 1 for normal, 2 for high, 3 for very high skill
date_min            date in UTC seconds since Jan 1, 1970 (unix time format)
date_max            date in UTC seconds since Jan 1, 1970 (unix time format)
account_id          Steam account id (this is not SteamID, its only the account number portion)
league_id           matches for a particular league
start_at_match_id   Start the search at the indicated match id, descending
matches_requested   Defaults is 100? matches, this can limit to less

```
using dota2api;
...

public async void CallApi(){
var dota2api = new Dota2Api("<key>");
var resultModel = await dota2api.GetMatchHistory();  // returns last 100 matches played.



}
```


Usage:
var dota2api = new Dota2Api("<key>");





