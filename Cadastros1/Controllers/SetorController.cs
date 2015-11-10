using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cadastros1.Controllers
{
    public class SetorController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage CreateNewSector(ViewModel.CreateNewSector Setor)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new ViewModel.RetCreateNewSector {
            
                IdSetor = new BLL.Setor().CreateNewSetcor(Setor)

            });
        }
    }
}