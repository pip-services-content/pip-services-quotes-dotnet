# Deployment Guide <br/> Quotes Microservice

Quotes microservice can be used in different deployment scenarios.

* [Standalone Process](#process)

## <a name="process"></a> Standalone Process

The simplest way to deploy the microservice is to run it as a standalone process. 
This microservice is implemented in .NET Core and requires installation of .NET Core SDK. 
You can get it from the official site at https://www.microsoft.com/net/download/

**Step 1.** Download microservices by following [instructions](Download.md)

**Step 2.** Add **config.yml** file to the root of the microservice folder and set configuration parameters. 
See [Configuration Guide](Configuration.md) for details.

**Step 3.** Start the microservice using the command:

```bash
dotnet run
```

You can use the microservice by calling seneca commands directly as described in [Seneca Protocol](SenecaProtocolV1.md)
or by using [QuotesSenecaClient](https://github.com/pip-services-content/pip-clients-quotes-node/doc/NodeClientApiV1.md/#client_seneca)