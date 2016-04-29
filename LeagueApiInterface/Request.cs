using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueApiInterface.Interfaces;
using System.Net.Http;

namespace LeagueApiInterface
{
    class Request : IRequest
    {
        public async Task<string> MakeRequest(string url)
        {
            var client = new HttpClient();
            try
            {
                return await client.GetStringAsync("https://" + url);
            }
            catch(Exception e)
            {
                return "";
            }
        }
    }
}
