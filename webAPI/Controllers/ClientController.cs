using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using webAPI.Models;

namespace webAPI.Controllers
{
    public class ClientController : ApiController
    {

        List<Client> clients = new List<Client>();
        public ClientController()
        {
            clients.Add(new Client { id = 1, name = "John", surname = "Doe" });
            clients.Add(new Client { id = 2, name = "Dana", surname = "Troy" });
            clients.Add(new Client { id = 3, name = "Jo", surname = "Man" });
        }

        [Route("api/names")]
        public List<string> GetNames()
        {
            List<string> names = new List<string>();
            foreach (var i in clients)
            {
                names.Add(i.name);
            }
            return names;
        }

        // GET: api/Client
        [Route("clients")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public List<Client> Get()
        {
            return  clients;
        }


        // GET: api/Client/5
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public Client Get(int id)
        {
            return clients.Where(cl => cl.id == id).FirstOrDefault();
        }


        // POST: api/Client
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Client/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
        }
    }
}
