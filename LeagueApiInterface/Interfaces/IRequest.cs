using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueApiInterface.Interfaces
{
    interface IRequest
    {
        Task<string> MakeRequest(String url);
    }
}
