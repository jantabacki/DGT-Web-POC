using DGT.Web.POC.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DGT.Web.POC.Api.Controllers
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
        public string Get()
        {
            return BoardConnectorService.GetCurrentState();
        }
    }
}
