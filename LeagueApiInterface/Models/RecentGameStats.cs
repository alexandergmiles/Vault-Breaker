using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueApiInterface.Models
{
    public class RecentGameStats
    {
        public int summonerId { get; set; }
        public List<Game> games { get; set; }
    }
}
