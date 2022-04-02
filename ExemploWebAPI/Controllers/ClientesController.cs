using ExemploWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWebAPI.Controllers
{
    public class ClientesController : ApiController
    {
        public List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> Get() 
        {
            return clientes;
        }

        public void Post(string nome)
        {
            if(!string.IsNullOrEmpty(nome))
                clientes.Add(new Cliente(nome));
        }
    }
}
