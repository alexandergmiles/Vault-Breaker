using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueApiInterface.Interfaces;
using LeagueApiInterface.Models;
using LeagueApiInterface.enums;
namespace LeagueApiInterface
{
    public class LeagueOfLegends
    {
        //IRequest request = new Request();
        IChampions championBackend = new Champions();
        ICurrentGame currentGame = new CurrentGame();
        IFeaturedGames featuredGames = new FeaturedGames();
        IRecentGames recentGames = new RecentGames();
        public ChampionList GetAllChampions(String host, regions.Regions region)
        {
            return championBackend.GetAllChampions(host, region);
        }

        public Champion GetChampionById(String host, regions.Regions region, int id)
        {
            return championBackend.GetChampionById(host, region, id);
        }

        public CurrentGameInfo GetCurrentGameInfo(String host, regions.Platform_ID platform_ID, int summonerId)
        {
            return currentGame.GetCurrentGameInfo(host, platform_ID, summonerId);
        }

        public FeaturedGamesInfo GetFeaturedGames(String platform_ID)
        {
            return featuredGames.GetFeaturedGames(platform_ID);
        }

        public RecentGameStats GetRecentStats(String host, regions.Regions region, int id)
        {
            return recentGames.GetRecentGames(host, region, id);
        }
    }
}
