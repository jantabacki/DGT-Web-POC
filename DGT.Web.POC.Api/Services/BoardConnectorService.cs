using DGT.Web.POC.HardwareConnector;

namespace DGT.Web.POC.Api.Services
{
    public class BoardConnectorService : IBoardConnectorService
    {
        public static string CurrentState { get; set; } = string.Empty;
        public string GetCurrentState() { return CurrentState; }
        public BoardConnectorService()
        {
            IDgtLiveChess dgtLiveChess = new DgtLiveChess();
            dgtLiveChess.OnBoardDisconnected += DgtLiveChess_OnBoardDisconnected;
            dgtLiveChess.OnBoardConnected += DgtLiveChess_OnBoardConnected;
            dgtLiveChess.OnCantFindBoard += DgtLiveChess_OnCantFindBoard;
            dgtLiveChess.OnLiveChessDisconnected += DgtLiveChess_OnLiveChessDisconnected;
            dgtLiveChess.OnLiveChessConnected += DgtLiveChess_OnLiveChessConnected;
            dgtLiveChess.OnFenRecieved += DgtLiveChess_OnFenRecieved;
            dgtLiveChess.OnBatteryCritical += DgtLiveChess_OnBatteryCritical;
            dgtLiveChess.OnBatteryLow += DgtLiveChess_OnBatteryLow;
            dgtLiveChess.OnBatteryOk += DgtLiveChess_OnBatteryOk;
            dgtLiveChess.OnError += DgtLiveChess_OnError;
            dgtLiveChess.PollDgtBoard();
        }

        private void DgtLiveChess_OnError(object? sender, MessageRecievedEventArgs e)
        {
            CurrentState = e.ResponseOut;
        }

        private void DgtLiveChess_OnBatteryOk(object? sender, MessageRecievedEventArgs e)
        {
            CurrentState = e.ResponseOut;
        }

        private void DgtLiveChess_OnBatteryLow(object? sender, MessageRecievedEventArgs e)
        {
            CurrentState = e.ResponseOut;
        }

        private void DgtLiveChess_OnBatteryCritical(object? sender, MessageRecievedEventArgs e)
        {
            CurrentState = e.ResponseOut;
        }

        private void DgtLiveChess_OnFenRecieved(object? sender, MessageRecievedEventArgs e)
        {
            CurrentState = e.ResponseOut;
        }

        private void DgtLiveChess_OnLiveChessConnected(object? sender, MessageRecievedEventArgs e)
        {
            CurrentState = e.ResponseOut;
        }

        private void DgtLiveChess_OnLiveChessDisconnected(object? sender, MessageRecievedEventArgs e)
        {
            CurrentState = e.ResponseOut;
        }

        private void DgtLiveChess_OnCantFindBoard(object? sender, MessageRecievedEventArgs e)
        {
            CurrentState = e.ResponseOut;
        }

        private void DgtLiveChess_OnBoardConnected(object? sender, MessageRecievedEventArgs e)
        {
            CurrentState = e.ResponseOut;
        }

        private void DgtLiveChess_OnBoardDisconnected(object? sender, MessageRecievedEventArgs e)
        {
            CurrentState = e.ResponseOut;
        }
    }
}
