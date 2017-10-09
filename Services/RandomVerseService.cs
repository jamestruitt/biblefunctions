using System.Net.Http;

namespace biblefunctions.Services
{
    class RandomVerseService
    {
        public string GetRandomVerse()
        {
            var client = new HttpClient();

            const string url = "http://www.ourmanna.com/verses/api/get/?format=text&order=random";

            var response = client.GetStringAsync(url).Result;

            return response;
        }
    }
}
