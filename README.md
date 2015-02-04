Async C# implementation of the dota 2 match history api

</br>

[Get api key for steam here](http://steamcommunity.com/dev/apikey)

[Api doc](http://dev.dota2.com/showthread.php?t=47115)


<h3>GetMatchHistory(dota2api.Models.MatchHistoryQuery?)</h3>
Returns match history.
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
<tr>
<td>
hero_id
</td>
<td>
Search for matches with a specific hero being played, hero id's are in dota/scripts/npc/npc_heroes.txt in your Dota install directory
</td>
</tr>
<tr>
<td>
skill
</td>
<td>
0 for any, 1 for normal, 2 for high, 3 for very high skill
</td>
</tr>
<tr>
<td>
date_min
</td>
<td>
date in UTC seconds since Jan 1, 1970 (unix time format)
</td>
</tr>
<tr>
<td>
account_id
</td>
<td>
Steam account id (this is not SteamID, its only the account number portion)
</td>
</tr>
<tr>
<td>
league_id
</td>
<td>
matches for a particular league
</td>
</tr>
<tr>
<td>
start_at_match_id
</td>
<td>
Start the search at the indicated match id, descending
</td>
</tr>
<tr>
<td>
matches_requested
</td>
<td>
Defaults is 100? matches, this can limit to less
</td>
</tr>


</table>

<strong>Usage:</strong>
```
using dota2api;
...

public async void CallApi(){
var dota2api = new Dota2Api("<key>");

// returns last 100 matches played.
var resultModel = await dota2api.GetMatchHistory();  

// return last match where given accountid played.
var resultModel = await dota2api.GetMatchHistory(new MatchHistoryQuery(){ 
      account_id = 1233322,
      matches_requested = 1,
      });                                             
}
```

<h3>GetMatchDetails(int)</h3>
Returns match details.

<strong>Usage:</strong>
```
using dota2api;
...

public async void CallApi(){
var dota2api = new Dota2Api("<key>");

// returns match details.
var resultModel = await dota2api.GetMatchDetails(1233322);  

```





