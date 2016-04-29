using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueApiInterface;
using LeagueApiInterface.enums;
using LeagueApiInterface.Models;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            LeagueOfLegends lol = new LeagueOfLegends();
            Console.WriteLine("Starting");

            //Get a list of the current champions
            ChampionList championList = lol.GetAllChampions(Endpoints.EUW_HOST, regions.Regions.EUW);
            Console.WriteLine("There are currently: " + championList.Champions.Count);

            //Get a champion of the selected index
            Console.WriteLine("Input character ID.");
            int id = Convert.ToInt32(Console.ReadLine());
            Champion selectedChampion = lol.GetChampionById(Endpoints.EUW_HOST, regions.Regions.EUW, id);
            
            Console.WriteLine(selectedChampion.rankedPlayEnabled);

            //Get live game
            //int summonerId = Convert.ToInt32(Console.ReadLine());
            //CurrentGameInfo currGameInfo = lol.GetCurrentGameInfo(Endpoints.NA_HOST, regions.Platform_ID.NA1, summonerId);

            //Console.WriteLine(currGameInfo.participants.Count);

            //FeaturedGamesInfo liveFeaturedGames = lol.GetFeaturedGames(Endpoints.EUW_HOST);

            //foreach (var game in liveFeaturedGames.gameList)
            //{
            //    Console.WriteLine(game.gameLength);
            //}

            //RecentGameStats recentGamesStats = lol.GetRecentStats(Endpoints.EUW_HOST, regions.Regions.EUW, 123);
            //if(recentGamesStats != null)
            //{
            //    Console.WriteLine(recentGamesStats.games[0].stats.win);
            //}
            //else
            //{
            //    Console.WriteLine("Error when collecting the recent games");
            //}

            Console.ReadLine();
        }
    }
}