﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueApiInterface.Models;
using LeagueApiInterface.enums;

namespace LeagueApiInterface.Interfaces
{
    public interface IFeaturedGames
    {
        FeaturedGamesInfo GetFeaturedGames(String platform_ID);
    }
}
