# Nager.TcpClient

<img src="https://raw.githubusercontent.com/nager/Nager.TcpClient/main/doc/icon.png" width="150" title="Nager TcpClient" alt="Nager TcpClient" align="left">

A simple **TcpClient** with asynchronous connect logic and SSL/TLS supported. Received data packets are available via a `DataReceived` event. There are also events for `Connected` and `Disconnected`. Additionally there is the possibility to enable `TcpKeepAlive`. The library offers the possibility to pass an `ILogger` for logging. There are extensive tests for all major operating systems (ubuntu, windows, macos).

<br>
<br>

## How can I use it?

The package is available via [NuGet](https://www.nuget.org/packages/Joeries.Nager.TcpClient)
```
PM> install-package Joeries.Nager.TcpClient
```

## Examples of use

For the examples, an online service `tcpbin.com` is used that returns all sent packages. 

### Simple example send and receive data

```cs
void OnDataReceived(byte[] receivedData)
{
}

using var cancellationTokenSource = new CancellationTokenSource(1000);

using var tcpClient = new TcpClient();
tcpClient.DataReceived += OnDataReceived;
await tcpClient.ConnectAsync("tcpbin.com", 4242, cancellationTokenSource.Token);
await tcpClient.SendAsync(new byte[] { 0x01, 0x0A });
await Task.Delay(400);
tcpClient.Disconnect();
tcpClient.DataReceived -= OnDataReceived;
```

## Other projects in the .NET enviorment

| Project | Description |
| ------------- | ------------- |
| [SuperSimpleTcp](https://github.com/jchristn/SuperSimpleTcp) | TcpServer and TcpClient (with SSL support) |
| [DotNetty](https://github.com/Azure/DotNetty) | TcpServer and TcpClient |
| [SpanNetty](https://github.com/cuteant/SpanNetty) | TcpServer and TcpClient (Modern implementation of DotNetty) |
