using System.Linq;
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
        public static BibleConfigService bibleConfigService = new BibleConfigService();

        [FunctionName("LoadVersesByBook")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("LoadVersesByBook processed a request.");
           
            // Get request body
            var data = await req.Content.ReadAsAsync<BibleRequest>();

            // Set name to query string or body data
            var name = data.Name;
            var chapter = data.Chapter;
   
            log.Info(string.Format("Book Recieved:{0} Chapter Passed in:{1}",name,chapter));

            var book = bibleConfigService.FindBibleConfigInfo(name);

            if (book != null)
                log.Info(string.Format("Book {0} was found and has {1} chapters", book.Name, book.NumberofChapters));
            
            return book == null
                ? req.CreateResponse(HttpStatusCode.BadRequest, string.Format("{0} was not found", name).ToString())
                : req.CreateResponse(HttpStatusCode.OK, string.Format("Book {0} was found and has {1} chapters",book.Name,book.NumberofChapters));
        }
    }
}
