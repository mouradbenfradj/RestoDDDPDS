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
    public class CompteController : ApiController
    {
        // GET: api/Compte
        public HttpResponseMessage Get()
        {
            CompteRepository compt = new CompteRepository();
            var formatter = new JsonMediaTypeFormatter();
            var json = formatter.SerializerSettings;
            json.Formatting = Newtonsoft.Json.Formatting.Indented;
            return Request.CreateResponse(HttpStatusCode.OK, new { result = compt.GetAll() }, formatter);
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody]string login, string mdp, string nom, string prenom, string numtele)
        {
            try
            {
                CompteRepository compt = new CompteRepository();
                var cll = new Compte();
                cll.Login = login;
                cll.Password = mdp;
                cll.Nom = nom;
                cll.Prenom = prenom;
                cll.NumTel = numtele;
                compt.Add(cll);
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

        // PUT: api/Compte/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Compte/5
        public void Delete(int id)
        {
        }
    }
}
