using SharedAPI;

namespace Client
{
    public static class ClientLog
    {
        public static void New()
        {
            Log.New("Client");
            Log.Header("♦ Client");
        }

        public static void ClientCreated(string ip, int port)
        {
            Log.Note("New client created as Client@{0}:{1}.", ip, port);
            Log.Warning("Connecting...");
        }

        public static void ClientConnected(string localIP, int localPort,
            string remoteIP, int remotePort)
        {
            Log.SetCursorToPreviousLine();
            Log.ClearLine();
            Log.Success("Client@{0}:{1} connected to Server@{2}:{3}.",
                localIP, localPort, remoteIP, remotePort);
        }

        public static void BytesSent(int size)
        {
            Log.Info("{0} bytes sent.", size);
        }

        public static void ClientClosed()
        {
            Log.Warning("Client closed.");
        }
    }
}
