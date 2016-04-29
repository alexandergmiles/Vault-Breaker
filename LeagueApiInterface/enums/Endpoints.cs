using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueApiInterface.enums
{
    public class Endpoints
    {
        ///URL Example
        ///HOST + API_LOL + REGION + ENDPOINT + PARAMETERS + API_KEY
        ///https://euw.api.pvp.net/api/lol/euw/v1.2/champion?freeToPlay=1&api_key=44db7ff8-5f4e-4a1f-be49-ca5aecfd28c


        /// <summary>
        /// Have all dem endpoint host regions
        /// </summary>
        public static readonly String BR_HOST = "br.api.pvp.net";
        public static readonly String EUNE_HOST = "eune.api.pvp.net";
        public static readonly String EUW_HOST = "euw.api.pvp.net";
        public static readonly String KR_HOST = "kr.api.pvp.net";
        public static readonly String LAN_HOST = "lan.api.pvp.net";
        public static readonly String LAS_HOST = "las.api.pvp.net";
        public static readonly String NA_HOST = "na.api.pvp.net";
        public static readonly String OCE_HOST = "oce.api.pvp.net";
        public static readonly String TR_HOST = "tr.api.pvp.net";
        public static readonly String RU_HOST = "ru.api.pvp.net";
        public static readonly String PBE_HOST = "pbe.api.pvp.net";
        public static readonly String GLOBAL_HOST = "global.api.pvp.net";

        /// <summary>
        /// API Key to be used
        /// </summary>
        public static readonly String API_KEY = "api_key=44db7ff8-5f4e-4a1f-be49-ca5aecfd28c3";

        /// <summary>
        /// Section of url that must be used
        /// </summary>
        public static readonly String API_LOL = "/api/lol/";

        /// <summary>
        /// The endpoint to collection list of champions dependant on the region that is the prefix
        /// </summary>
        public static readonly String REGION_CHAMPIONS = "/v1.2/champion?freeToPlay=1&";

        /// <summary>
        /// Used to collect a specified champion by the ID of said champion
        /// </summary>
        public static readonly String CHAMPIONS_BY_ID = "/v1.2/champion/";

        /// <summary>
        /// Used to get the current game info for a live game. This only requires the region and the summoner ID after a forward slash.
        /// </summary>
        public static readonly String CURRENT_GAME = "/observer-mode/rest/consumer/getSpectatorGameInfo/";

        /// <summary>
        /// Used to collect the list of featured games for the region speicfied by the user
        /// </summary>
        public static readonly String FEATURED_GAME = "/observer-mode/rest/featured?";

        /// <summary>
        /// Used to collect the 10 most recent games of a summoner
        /// </summary>
        public static readonly String RECENT_GAME_DETAILS = "/v1.3/game/by-summoner/";
    }
}
