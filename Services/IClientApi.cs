using Refit;

namespace StarWars.Services
{
    public  interface IClientApi
    {
        [Get("/")]
        Task<string> GetResult();
    }
}
