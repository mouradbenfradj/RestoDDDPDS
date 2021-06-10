using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestoDDD.infra.Repositories;
using System.Net.Http.Formatting;


namespace WebService.Controllers
{
    public class RestoController : ApiController
    {

        // Post Data Json using Asp.net WebApi
        public HttpResponseMessage Get()
        {
            NoteRepository nott = new NoteRepository();

            var formatter = new JsonMediaTypeFormatter();
            var json = formatter.SerializerSettings;
            json.Formatting = Newtonsoft.Json.Formatting.Indented;
            return Request.CreateResponse(HttpStatusCode.OK, new { result = nott.GetAll() }, formatter);
        }

        public HttpResponseMessage commentaire()
        {

            CommentaireRepository comment = new CommentaireRepository();

            var formatter = new JsonMediaTypeFormatter();
            var json = formatter.SerializerSettings;
            json.Formatting = Newtonsoft.Json.Formatting.Indented;
            return Request.CreateResponse(HttpStatusCode.OK, new { result = comment.GetAll() }, formatter);
        }

    }
}
