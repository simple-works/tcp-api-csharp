using System;
using SharedAPI;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
        start:

            string ip = "127.0.0.1";
            int port = 80;

            if (args.Length >= 1) ip = args[0];
            if (args.Length >= 2) int.TryParse(args[1], out port);

            ServerLog.New();

            try
            {
                Server.CreateTcpListener(ip, port);
                Server.Start();
                while (true) { Server.Connect(); break; }
                while (true) Server.ReceiveText();
            }
            catch (Exception exception)
            {
                Log.Exception(exception);

            }
            finally
            {
                Server.Stop();
            }

            if (args.Length > 0) return;
            goto start;
        }
    }
}
