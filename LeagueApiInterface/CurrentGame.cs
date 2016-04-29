using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using LeagueApiInterface.Models;
using LeagueApiInterface.Interfaces;
using LeagueApiInterface.enums;

namespace LeagueApiInterface
{
    public class CurrentGame : ICurrentGame
    {
        IRequest request = new Request();
        public CurrentGameInfo GetCurrentGameInfo(String host, regions.Platform_ID region, int summonerId)
        {
            try
            {
                String requestUrl = host + Endpoints.CURRENT_GAME + region + "/" + summonerId + "?" + Endpoints.API_KEY;
                var requestResult = request.MakeRequest(requestUrl);
                CurrentGameInfo returnInfo = JsonConvert.DeserializeObject<CurrentGameInfo>(requestResult.Result);

                return returnInfo;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
