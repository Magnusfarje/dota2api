using dota2api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using unirest_net.http;
using System.Reflection;
using dota2api.Helpers;

namespace dota2api
{
    public class Dota2Api
    {
        public string baseUrl = "https://api.steampowered.com/";
        private string _apiKey;
        
        public Dota2Api(string apiKey)
        {
            _apiKey = apiKey;
        }

        private async Task<T> GetApiData<T>(string url) where T : new()
        {
            try
            {
                var responseTask = Unirest.get(url).header("Accept", "application/json").asJsonAsync<T>();
                var response = await responseTask;
                return response.Body;
            }
            catch(Exception e)
            {
                return default(T);
            }
        }

        private string ConstructQueryUrl<T>(string queryUrl, T queryModel)
        {
            var arguments = "";
            if (queryModel != null)
                    foreach (PropertyInfo prop in typeof(T).GetProperties())
                    {
                        var myPropInfo = queryModel.GetType().GetProperty(prop.Name);
                        var propValue = myPropInfo.GetValue(queryModel, null);
                        propValue = propValue == null ? "0" : propValue;

                        int result;
                        Int32.TryParse(propValue.ToString(), out result);

                        if (propValue.GetType() == typeof(string))
                            result = 1;
                        if (result != 0)
                            arguments += "&" + prop.Name + "=" + propValue;
                    }
            return baseUrl + queryUrl + _apiKey + arguments;

        }


        public async Task<Result> GetMatchHistory(MatchHistoryQuery matchHistoryQuery = null)
        {
            Task<RootObject> matchHistoryTask = null;
            var queryUrl = ConstructQueryUrl(Urls.GetMatchHistory, matchHistoryQuery);
            matchHistoryTask = GetApiData<RootObject>(queryUrl);


            var matchHistory = await matchHistoryTask;
            if (matchHistory == null)
                return null;
            
            matchHistory.result.next_id = matchHistory.result.matches != null && matchHistory.result.matches.Count > 2 ? matchHistory.result.matches[matchHistory.result.matches.Count() - 2].match_id : 0;
            matchHistory.result.query_url = queryUrl;
            return matchHistory.result;
        }

        public async Task<Result> GetMatchDetails(int matchId)
        {
            var matchDetailsTask = GetApiData<RootObject>(baseUrl + Urls.GetMatchDetails + _apiKey + Arguments.MatchId + matchId);
            var matchDetails = await matchDetailsTask;

            return matchDetails == null ? null : matchDetails.result;
        }
    }
}

