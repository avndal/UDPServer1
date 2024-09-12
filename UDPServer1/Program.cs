using System.Net;
using System.Net.Sockets;
using System.Text;


Console.WriteLine("UDP Server");

using (UdpClient socket = new UdpClient())
{
    socket.Client.Bind(new IPEndPoint(IPAddress.Any,5005));
    
    IPEndPoint clientEndpoint = null;
    byte[] received = socket.Receive(ref clientEndpoint);
    
    string stringResult = Encoding.UTF8.GetString(received);

    Console.WriteLine(stringResult);
}



