using StarWars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Services
{
    public interface IStarwarsService
    {
        Task<ResponseData> GetResults(string nextCall);
    }
}
