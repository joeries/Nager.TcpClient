﻿namespace Nager.TcpClient
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
        /// Absolute Path of Root CA Cert
        /// </summary>
        public string RootCACertPath { get; set; }
    }
}
