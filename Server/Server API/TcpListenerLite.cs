using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public class TcpListenerLite
    {
        private TcpListener _tcpListener;
        private TcpClient _acceptedTcpClient;

        public string LocalIP { get; private set; }
        public int LocalPort { get; private set; }
        public string RemoteIP
        {
            get
            {
                if (_acceptedTcpClient == null) return null;
                return (_acceptedTcpClient.Client.RemoteEndPoint as IPEndPoint).Address.ToString();
            }
        }
        public int RemotePort
        {
            get
            {
                if (_acceptedTcpClient == null) return -1;
                return (_acceptedTcpClient.Client.RemoteEndPoint as IPEndPoint).Port;
            }
        }

        public TcpListenerLite(string localIP = "127.0.0.1", int localPort = 80)
        {
            this.LocalIP = localIP;
            this.LocalPort = localPort;
            _tcpListener = new TcpListener(new IPEndPoint(IPAddress.Parse(localIP), localPort));
        }

        public void Start()
        {
            _tcpListener.Start();
        }

        public void Accept()
        {
            _acceptedTcpClient = _tcpListener.AcceptTcpClient();
        }

        public int ReceiveText(out string text)
        {
            byte[] buffer = new byte[_acceptedTcpClient.Available];
            NetworkStream stream = _acceptedTcpClient.GetStream();
            int size = stream.Read(buffer, 0, buffer.Length);
            text = Encoding.UTF8.GetString(buffer);
            return size;
        }

        public void Stop()
        {
            if (_tcpListener != null) _tcpListener.Stop();
            if (_acceptedTcpClient != null) _acceptedTcpClient.Close();
        }
    }
}

