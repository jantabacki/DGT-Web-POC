using DGT.Web.POC.SingleApp.Models;
using DGT.Web.POC.SingleApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DGT.Web.POC.SingleApp.Controllers
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

        [HttpPost]
        public int Set(SimulatorSetRequestModel simulatorSetRequestModel)
        {
            if (BoardConnectorService is IBoardConnectorSimulatorService)
            {
                ((IBoardConnectorSimulatorService)BoardConnectorService).SetCurrentState(simulatorSetRequestModel.CurrentState);
            }
            return 0;
        }
    }
}
