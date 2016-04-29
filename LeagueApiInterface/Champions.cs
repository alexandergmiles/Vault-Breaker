using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using LeagueApiInterface.Interfaces;
using LeagueApiInterface.Models;
using LeagueApiInterface.enums;

namespace LeagueApiInterface
{
    public class Champions : IChampions
    {
        IRequest request = new Request();
        public ChampionList GetAllChampions(String Host, regions.Regions selectedRegion)
        {
            try
            {
                String requestUrl = Host + Endpoints.API_LOL + selectedRegion + Endpoints.REGION_CHAMPIONS + Endpoints.API_KEY;
                var requestResult = request.MakeRequest(requestUrl).Result;
                ChampionList returnChampions = JsonConvert.DeserializeObject<ChampionList>(requestResult);

                return returnChampions;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public Champion GetChampionById(string Host, regions.Regions selectedRegion, int id)
        {
            try
            {
                String requestUrl = Host + Endpoints.API_LOL + selectedRegion + Endpoints.CHAMPIONS_BY_ID + id + "?" + Endpoints.API_KEY;
                var requestResult = request.MakeRequest(requestUrl).Result;
                Champion returnChampion = JsonConvert.DeserializeObject<Champion>(requestResult);

                return returnChampion;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}