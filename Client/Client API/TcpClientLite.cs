using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public class TcpClientLite
    {
        private TcpClient _tcpClient;

        public string LocalIP { get; private set; }
        public int LocalPort { get; private set; }
        public string RemoteIP { get; private set; }
        public int RemotePort { get; private set; }

        public TcpClientLite(string localIP = "127.0.0.1 ", int localPort = 80)
        {
            this.LocalIP = localIP;
            this.LocalPort = localPort;
            _tcpClient = new TcpClient(new IPEndPoint(IPAddress.Parse(localIP), localPort));
        }

        public void Connect(string remoteIP = "127.0.0.2 ", int remotePort = 81)
        {
            this.RemoteIP = remoteIP;
            this.RemotePort = remotePort;
            _tcpClient.Connect(remoteIP, remotePort);
        }

        public int SendText(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            NetworkStream stream = _tcpClient.GetStream();
            stream.Write(buffer, 0, buffer.Length);
            return buffer.Length;
        }

        public void Close()
        {
            if (_tcpClient != null) _tcpClient.Close();
        }
    }
}
