using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueApiInterface.Models;
using LeagueApiInterface.enums;
using LeagueApiInterface.Interfaces;
using Newtonsoft.Json;

namespace LeagueApiInterface
{
    public class FeaturedGames : IFeaturedGames
    {
        IRequest request = new Request();
        public FeaturedGamesInfo GetFeaturedGames(String platform_ID)
        {
            try
            {
                String requestUrl = platform_ID + Endpoints.FEATURED_GAME + Endpoints.API_KEY;
                var requestResult = request.MakeRequest(requestUrl);
                FeaturedGamesInfo returnInfo = JsonConvert.DeserializeObject<FeaturedGamesInfo>(requestResult.Result);

                return returnInfo;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
