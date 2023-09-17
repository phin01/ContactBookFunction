using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace ContactCompiler
{
    public class ContactCompiler
    {
        private readonly ILogger _logger;

        public ContactCompiler(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<ContactCompiler>();
        }

        [Function("AddContacts")]
        public HttpResponseData AddContacts([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Function("ExportContacts")]
        public HttpResponseData ExportContacts([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
}
