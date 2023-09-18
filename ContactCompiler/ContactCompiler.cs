using System;
using System.Net;
using System.Text.Json;
using ContactBook.Models;
using DataAccessLibrary.Data;
using DataAccessLibrary.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace ContactCompiler
{
    public class ContactCompiler
    {
        private readonly ILogger _logger;
        private readonly IDatabase _db;

        public ContactCompiler(ILoggerFactory loggerFactory, IDatabase db)
        {
            _logger = loggerFactory.CreateLogger<ContactCompiler>();
            _db = db;
        }

        [Function("AddContacts")]
        public async Task<HttpResponseData> AddContacts([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
        {
            HttpResponseData response;
            List<ContactInputViewModel> contacts;

            try
            {
                contacts = await JsonSerializer.DeserializeAsync<List<ContactInputViewModel>>(req.Body);
                _db.AddContacts(contacts);
            }
            catch (Exception)
            {
                response = req.CreateResponse(HttpStatusCode.BadRequest);
                response.WriteString("Incorrect input format");
                return response;
            }

            response = req.CreateResponse(HttpStatusCode.OK);
            response.WriteString($"{contacts.Count} contacts Added to Contact Book");
            return response;
        }

        [Function("ListContacts")]
        public async Task<HttpResponseData> ListContactsAsync([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            var contacts = _db.GetAllContacts().ToList();

            var response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteAsJsonAsync(contacts);
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
