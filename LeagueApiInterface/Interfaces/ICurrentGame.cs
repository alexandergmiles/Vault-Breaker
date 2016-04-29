using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueApiInterface.enums;
using LeagueApiInterface.Interfaces;
using LeagueApiInterface.Models;

namespace LeagueApiInterface.Interfaces
{
    interface ICurrentGame
    {
        CurrentGameInfo GetCurrentGameInfo(String host, regions.Platform_ID platform_ID,  int summonerId);
    }
}
