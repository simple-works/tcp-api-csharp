using SharedAPI;

namespace Server
{
    public static class ServerLog
    {
        public static void New()
        {
            Log.New("Server");
            Log.Header("♦ Server");
        }

        public static void ServerCreated(string ip, int port)
        {
            Log.Note("New server created as Server@{0}:{1}.", ip, port);
            Log.Warning("Starting...");
        }

        public static void ServerStarted(string ip, int port)
        {
            Log.SetCursorToPreviousLine();
            Log.ClearLine();
            Log.Warning("Server@{0}:{1} started.", ip, port);
            Log.Warning("♫ Listening...");
        }

        public static void ServerConnected(string localIP, int localPort,
            string remoteIP, int remotePort)
        {
            Log.SetCursorToPreviousLine();
            Log.ClearLine();
            Log.Success("Server@{0}:{1} connected to Client@{2}:{3}.",
                localIP, localPort, remoteIP, remotePort);
        }

        public static void BytesReceived(int size, string text)
        {
            Log.Info("{0} bytes received as \"{1}\".", size, text);
        }

        public static void ServerStopped()
        {
            Log.Warning("Server stopped.");
        }
    }
}
