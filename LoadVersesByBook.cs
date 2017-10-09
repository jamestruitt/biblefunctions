using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using biblefunctions.Models;
using biblefunctions.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace biblefunctions
{
    public static class LoadVersesByBook
    {
        public static BibleConfigService BibleConfigService = new BibleConfigService();
        public static RandomVerseService RandomVerseService = new RandomVerseService();

        [FunctionName("LoadVersesByBook")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("LoadVersesByBook processed a request.");
           
            // Get request body
            var data = await req.Content.ReadAsAsync<BibleRequest>();

            // Set name to query string or body data
            var name = data.Name;
            var chapter = data.Chapter;
   
            log.Info($"Book Recieved:{name} Chapter Passed in:{chapter}");

            var book = BibleConfigService.FindBibleConfigInfo(name);

            if (book != null)
            {
                log.Info($"Book {book.Name} was found and has {book.NumberofChapters} chapters");
                
                for (var i = 0; i < book.NumberofChapters-1; i++)
                {
                    log.Info(RandomVerseService.GetRandomNivVerse());
                }
            }

            return book == null
                ? req.CreateResponse(HttpStatusCode.BadRequest, $"{name} was not found")
                : req.CreateResponse(HttpStatusCode.OK,
                    $"Book {book.Name} was found and has {book.NumberofChapters} chapters");
        }
    }
}
