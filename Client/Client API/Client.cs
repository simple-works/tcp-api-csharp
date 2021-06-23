
namespace Client
{
    public static class Client
    {
        private static TcpClientLite _client;

        public static void CreateTcpClient(string ip, int port)
        {
            _client = new TcpClientLite(ip, port);
            ClientLog.ClientCreated(ip, port);
        }

        public static void Connect(string ip, int port)
        {
            _client.Connect(ip, port);
            ClientLog.ClientConnected(_client.LocalIP, _client.LocalPort,
                _client.RemoteIP, _client.RemotePort);
        }

        public static void SendText(string text)
        {
            int size = _client.SendText(text);
            ClientLog.BytesSent(size);
        }

        public static void Close()
        {
            _client.Close();
            ClientLog.ClientClosed();
        }
    }
}
