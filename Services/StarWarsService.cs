using Newtonsoft.Json;
using Refit;
using StarWars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StarWars.Services
{
    public class StarWarsService : IStarwarsService
    {
        public async Task<ResponseData> GetResults(string nextCall)
        {
            var client = RestService.For<IClientApi>(nextCall);

            var result = await client.GetResult();

            var results = JsonConvert.DeserializeObject<ResponseData>(result);

            return results;
        }
    }
}
