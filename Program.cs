// See https://aka.ms/new-console-template for more information
using StarWars.Model;
using StarWars.Services;
using System.Collections.Generic;


int Totalcount = 0;

var nextCall = "https://swapi.dev/api/people";

var listFilm = new List<Result>(); 

IStarwarsService starwarsService = new StarWarsService();

var result = await starwarsService.GetResults(nextCall);

Totalcount = result.Count;


while (result.Next != null)
{

    listFilm.AddRange(result.Results);

    result = await starwarsService.GetResults(result.Next);

}


listFilm.Where(x => x.Films.All(x => x.Equals));
	




