
namespace Server
{
    public static class Server
    {
        private static TcpListenerLite _listener;

        public static void CreateTcpListener(string ip, int port)
        {
            _listener = new TcpListenerLite(ip, port);
            ServerLog.ServerCreated(ip, port);
        }

        public static void Start()
        {
            _listener.Start();
            ServerLog.ServerStarted(_listener.LocalIP, _listener.LocalPort);
        }

        public static void Connect()
        {
            _listener.Accept();
            ServerLog.ServerConnected(_listener.LocalIP, _listener.LocalPort,
                _listener.RemoteIP, _listener.RemotePort);
        }

        public static void ReceiveText()
        {
            string text = string.Empty;
            int size = _listener.ReceiveText(out text);
            if (size > 0) ServerLog.BytesReceived(size, text);
        }

        public static void Stop()
        {
            _listener.Stop();
            ServerLog.ServerStopped();
        }
    }
}
