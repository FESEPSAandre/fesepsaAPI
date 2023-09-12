using ApiSQL.DATA;
using ApiSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiSQL.Controllers
{
    public class ArtVendXClienteController : ApiController
    {
       
        // GET api/<controller>/5
        public List<ArtVendXCliente> Get(String docident)
        {
            return ArtVendXClienteDATA.listar(docident);
        }
    }
}