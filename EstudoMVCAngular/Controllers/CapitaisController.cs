using EstudoMVCAngular.Models;
using System.Collections.Generic;
using System.Web.Http;
using EstudoMVCAngular.Models;



namespace EstudoMVCAngular.Controllers
{
    public class CapitaisController : ApiController
    {
        // GET: Capitais
        public IEnumerable<Capital> Get()
        {
            return CapitalRepository.ListarCapitais(); 
        }
    }
}