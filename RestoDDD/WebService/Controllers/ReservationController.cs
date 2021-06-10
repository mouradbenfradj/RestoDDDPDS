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
    public class ReservationController : ApiController
    {
        // GET: api/Reservation
        public HttpResponseMessage Get()
        {
            ReservationRepository resrev = new ReservationRepository();
            var formatter = new JsonMediaTypeFormatter();
            var json = formatter.SerializerSettings;
            json.Formatting = Newtonsoft.Json.Formatting.Indented;
            return Request.CreateResponse(HttpStatusCode.OK, new { result = resrev.GetAll() }, formatter);
        }


        [HttpPost]
        public HttpResponseMessage Post([FromBody]string dte, int nbre, DateTime datee)
        {
            try
            {
                ReservationRepository resrev = new ReservationRepository();
                var cll = new Reservation();
                cll.NombrePres = nbre;
                cll.ResvDate = datee;

                resrev.Add(cll);
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

        // PUT: api/Reservation/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Reservation/5
        public void Delete(int id)
        {
        }
    }
}
