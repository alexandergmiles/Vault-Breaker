using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueApiInterface.Models;
using LeagueApiInterface.enums;

namespace LeagueApiInterface.Interfaces
{
    interface IChampions
    {
        ChampionList GetAllChampions(string Host, regions.Regions selectedRegion);
        Champion GetChampionById(string Host, regions.Regions selectedRegion, int id);
    }
}
