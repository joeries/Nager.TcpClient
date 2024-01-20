using Microsoft.Extensions.Logging;
using Nager.TcpClient;

using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.SetMinimumLevel(LogLevel.Trace);
    builder.AddConsole();
});

var logger = loggerFactory.CreateLogger<TcpClient>();


var tcpClient = new TcpClient(logger: logger, keepAliveConfig: new TcpClientKeepAliveConfig(), clientConfig: new TcpClientConfig { CertPath = "", CertPassword = "", SSLProtocol = System.Security.Authentication.SslProtocols.Tls12 });
tcpClient.Disconnected += () => Console.WriteLine("Disconnected");
if (!await tcpClient.ConnectAsync("10.0.100.108", 22001))
{
    Console.WriteLine("Cannot connect");
    return;
}
Console.WriteLine("Connected");

Console.WriteLine("Press any key for quit");
Console.ReadLine();

tcpClient.Disconnect();
tcpClient.Dispose();