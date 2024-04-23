using DGT.Web.POC.SingleApp.Models;
using DGT.Web.POC.SingleApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DGT.Web.POC.SingleApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoardStateController : ControllerBase
    {
        private IBoardConnectorService BoardConnectorService { get; set; }
        public BoardStateController(IBoardConnectorService boardConnectorService)
        {
            this.BoardConnectorService = boardConnectorService;
        }

        [HttpGet]
        public BoardStateResponseModel Get()
        {
            return new BoardStateResponseModel() { CurrentState = BoardConnectorService.GetCurrentState() };
        }
    }
}
