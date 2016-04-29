using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueApiInterface.Interfaces;
using LeagueApiInterface.Models;
using LeagueApiInterface.enums;
using Newtonsoft.Json;

namespace LeagueApiInterface
{
    class RecentGames : IRecentGames
    {
        IRequest request = new Request();

        public RecentGameStats GetRecentGames(string host, regions.Regions region, int id)
        {
            try
            {
                var requestUrl = host + Endpoints.API_LOL + region + Endpoints.RECENT_GAME_DETAILS + id + "/recent?" + Endpoints.API_KEY;
                var requestResult = request.MakeRequest(requestUrl).Result;
                RecentGameStats recentResults = JsonConvert.DeserializeObject<RecentGameStats>(requestResult);

                return recentResults;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
