using System.Net.Http;

namespace biblefunctions.Services
{
    public class RandomVerseService
    {
        public string GetRandomNivVerse()
        {
            var client = new HttpClient();

            const string url = "http://www.ourmanna.com/verses/api/get/?format=text&order=random";

            var response = client.GetStringAsync(url).Result;

            return response;
        }
    }
}
