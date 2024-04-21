namespace DGT.Web.POC.Api.Services
{
    public class BoardConnectorSimulatorService : IBoardConnectorService, IBoardConnectorSimulatorService
    {
        public string CurrentState { get; set; } = string.Empty;
        public string GetCurrentState()
        {
            return CurrentState;
        }

        public void SetCurrentState(string currentState)
        {
            this.CurrentState = currentState;
        }
    }
}
