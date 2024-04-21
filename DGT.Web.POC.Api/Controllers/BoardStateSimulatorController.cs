using DGT.Web.POC.Api.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DGT.Web.POC.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoardStateSimulatorController : ControllerBase
    {
        public IBoardConnectorService BoardConnectorService { get; set; }
        public BoardStateSimulatorController(IBoardConnectorService boardConnectorService)
        {
            this.BoardConnectorService = boardConnectorService;
        }

        //[DisableCors]
        //[HttpPost]
        [HttpGet]
        public void Set(string currentState)
        {
            if (BoardConnectorService is IBoardConnectorSimulatorService)
            {
                ((IBoardConnectorSimulatorService)BoardConnectorService).SetCurrentState(currentState);
            }
        }
    }
}
