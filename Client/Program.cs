using System;
using SharedAPI;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
        start:

            string localIp = "127.177.177.177";
            int localPort = 1717;

            string remoteIP = "127.0.0.1";
            int remotePort = 80;

            if (args.Length >= 1) localIp = args[0];
            if (args.Length >= 2) int.TryParse(args[1], out localPort);
            if (args.Length >= 3 && args[2] == "to")
            {
                if (args.Length >= 4) remoteIP = args[3];
                if (args.Length >= 5) int.TryParse(args[4], out remotePort);
            }

            ClientLog.New();

            try
            {
                Client.CreateTcpClient(localIp, localPort);
                Client.Connect(remoteIP, remotePort);
                while (true) Client.SendText(Log.Prompt("Send Text"));
            }
            catch (Exception exception)
            {
                Log.Exception(exception);
            }
            finally
            {
                Client.Close();
            }

            if (args.Length > 0) return;
            goto start;
        }
    }
}
