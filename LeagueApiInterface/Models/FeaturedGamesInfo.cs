using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueApiInterface.Models
{
    public class FeaturedGamesInfo
    {
        public List<GameList> gameList { get; set; }
        public int clientRefreshInterval { get; set; }
    }
}
