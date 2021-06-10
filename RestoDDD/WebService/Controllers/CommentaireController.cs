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
    public class CommentaireController : ApiController
    {
        // GET: api/Commentaire
        public HttpResponseMessage Get()
        {
            CommentaireRepository comm = new CommentaireRepository();
            var formatter = new JsonMediaTypeFormatter();
            var json = formatter.SerializerSettings;
            json.Formatting = Newtonsoft.Json.Formatting.Indented;
            return Request.CreateResponse(HttpStatusCode.OK, new { result = comm.GetAll() }, formatter);
        }


        [HttpPost]
        public HttpResponseMessage Post([FromBody]string contenue)
        {
            try
            {
                CommentaireRepository comm = new CommentaireRepository();
                var cll = new Commentaire();
                cll.Content = contenue;
                comm.Add(cll);
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

        // PUT: api/Commentaire/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Commentaire/5
        public void Delete(int id)
        {
        }
    }
}
