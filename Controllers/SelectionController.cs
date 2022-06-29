using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASGExchangeAPI.Models;

namespace ASGExchangeAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SelectionController : ControllerBase
    {
        [Route("add")]
        [HttpPost]
        public long Add(Currency[] model)
        {            
            //SelectionRepository selectionRepository = new SelectionRepository(_context);
            
            //Selection selection = new Selection();

            //ong selectionId = selectionRepository.Add(selection);

            long selectionId = 1;
            return selectionId;
        }


    }
}
