using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestoDDD.infra.Repositories;
using System.Net.Http.Formatting;
using RestoDDD.Domaine.Entities;

namespace WebService.Controllers
{
    public class NoteController : ApiController
    {
        // GET: api/Note
        public HttpResponseMessage Get()
        {
            NoteRepository notee = new NoteRepository();
            var formatter = new JsonMediaTypeFormatter();
            var json = formatter.SerializerSettings;
            json.Formatting = Newtonsoft.Json.Formatting.Indented;
            return Request.CreateResponse(HttpStatusCode.OK, new { result = notee.GetAll() }, formatter);
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody]int note)
        {
            try
            {
                NoteRepository notee = new NoteRepository();
                var cll = new Note();
                cll.NoteR = note;
                notee.Add(cll);
                var formatter = new JsonMediaTypeFormatter();
                var json = formatter.SerializerSettings;
                json.Formatting = Newtonsoft.Json.Formatting.Indented;
                return Request.CreateResponse(HttpStatusCode.Created, new { result = "true" }, formatter);
            }
            catch (Exception)
            {
                var formatter = new JsonMediaTypeFormatter();
                var json = formatter.SerializerSettings;
                json.Formatting = Newtonsoft.Json.Formatting.Indented;
                return Request.CreateResponse(HttpStatusCode.OK, new { result = "false" }, formatter);
            }
        }

        // PUT: api/Note/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Note/5
        public void Delete(int id)
        {
        }
    }
}
