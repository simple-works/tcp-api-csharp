# ![Icon](./icon.png) TCP API C#

[![Windows](https://img.shields.io/badge/Windows-blue?logo=windows)](https://github.com/topics/windows)
[![C# 4.0](https://img.shields.io/badge/C%23-4.0-blue?logo=c-sharp)](https://github.com/topics/csharp)
[![.NET Framework 4.0](https://img.shields.io/badge/.NET%20Framework-4.0-blue?logo=dot-net)](https://github.com/topics/dotnet)

Simple TCP Client and Server written in C# .NET for learning purposes.

The project consists of simple:
- **🎁 Wrapper** for the **TCP/IP Socket API** (_TcpClient_ and _TcpListener_ Classes).
- **✏ Console Logger** accompagning the wrapper.
- **💻 Client** and **💻 Server** console applications using the wrapper.

<details>
  <summary>:floppy_disk: Download Binaries</summary>

  - <img src="./Client/icon.ico" alt="" width="16"> [**Server.exe**](./Server/bin/Release/Server.exe?raw=true)
  - <img src="./Server/icon.ico" alt="" width="16"> [**Client.exe**](./Client/bin/Release/Client.exe?raw=true)
  - :package: [**SharedAPI.dll**](./SharedAPI/bin/Release/SharedAPI.dll?raw=true) :information_source: _Keep it alongside executables._
</details>

![Screenshot](./screenshot-client.gif?raw=true)
![Screenshot](./screenshot-server.gif?raw=true)

## :arrow_forward: Usage
Executables can run directly using defaults or by passing arguments as the following:
- `server [<local-ip-address> [<local-port>]]`
- `client [<local-ip-address> [<local-port>]] to [<remote-ip-address> [<remote-port>]]`

Example:
- Run Server:
```batch
cd server\executable\directory
server 127.0.0.1 8080
```
- Run Client:
```batch
cd client\executable\directory
server client 127.0.0.200 7070 to 127.0.0.1 8080
```

## :rocket: Development
- Language: **[C#](https://github.com/dotnet/csharplang) 4.0**
- Framework: **[.NET](https://github.com/dotnet) Framework 4.0**
- IDE: **[Visual Studio](https://github.com/microsoft) 2010**

## :page_facing_up: License
- Licensed under [MIT](./LICENSE).
- Using [Free FatCow Farm Fresh Icons 3.92](http://www.fatcow.com/free-icons) licensed under [CC BY 3.0](https://creativecommons.org/licenses/by/3.0/us).