using System;
using SharedAPI;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerLog.New();

            try
            {
                Server.CreateTcpListener("127.0.0.1", 80);
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
                Main(args);
            }
        }
    }
}
