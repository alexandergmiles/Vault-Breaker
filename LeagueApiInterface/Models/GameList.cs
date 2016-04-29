using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueApiInterface.Models
{
    public class GameList
    {
        public int gameId { get; set; }
        public int mapId { get; set; }
        public string gameMode { get; set; }
        public string gameType { get; set; }
        public int gameQueueConfigId { get; set; }
        public List<Participant> participants { get; set; }
        public Observers observers { get; set; }
        public string platformId { get; set; }
        public List<BannedChampion> bannedChampions { get; set; }
        public object gameStartTime { get; set; }
        public int gameLength { get; set; }
    }
}
