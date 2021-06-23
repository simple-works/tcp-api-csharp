using System;
using SharedAPI;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientLog.New();

            try
            {
                Client.CreateTcpClient("127.177.177.177", 1717);
                Client.Connect("127.0.0.1", 80);
                while (true) Client.SendText(Log.Prompt("Send Text"));
            }
            catch (Exception exception)
            {
                Log.Exception(exception);
            }
            finally
            {
                Client.Close();
                Main(args);
            }
        }
    }
}
