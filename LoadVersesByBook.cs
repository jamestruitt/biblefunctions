using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace biblefunctions
{
    public static class LoadVersesByBook
    {
        [FunctionName("LoadVersesByBook")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("LoadVersesByBook processed a request.");
           
            // Get request body
            dynamic data = await req.Content.ReadAsAsync<object>();

            // Set name to query string or body data
            var name = data?.name.ToString();
            var chapter = (int?)data?.chapter;
   
            log.Info(string.Format("Book Recieved:{0} Chapter Passed in:{1}",name,chapter));

            var commonData = new BibleInfo();

            var book = (BibleChapterInfo) commonData.FindBibleChapterInfo(name);

            string notFoundMessage = string.Format("{0} was not found",name).ToString();

            return book == null
                ? req.CreateResponse(HttpStatusCode.BadRequest,  notFoundMessage)
                : req.CreateResponse(HttpStatusCode.OK, string.Format("Book {0} was found and has {1} chapters",book.Name,book.NumberofChapter));
        }
    }
}
