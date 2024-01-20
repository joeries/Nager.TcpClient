using System.Security.Authentication;

namespace Nager.TcpClient
{
    /// <summary>
    /// TcpClient Config
    /// </summary>
    public class TcpClientConfig
    {
        /// <summary>
        /// ReceiveBufferSize
        /// </summary>
        public int ReceiveBufferSize { get; set; } = 1024;
        /// <summary>
        /// Absolute Path of Cert
        /// </summary>
        public string CertPath { get; set; }
        /// <summary>
        /// Password of Cert
        /// </summary>
        public string CertPassword { get; set; }
        public SslProtocols SSLProtocol { get; set; } = SslProtocols.None;
    }
}
