
# PrintfulClient

- **Docs**: Visit https://developers.printful.com/docs/ to see the Printful API Docs.
- 
PrintfulClient is a .NET library designed to interact with the Printful API, providing access to various Printful services such as catalogs, orders, mockups, and more. It includes built-in retry policies and timeout handling, making it reliable for integrating with Printful's API.

## Table of Contents

1. [Introduction](#introduction)
2. [Features](#features)
3. [Tech Stack](#tech-stack)
4. [Usage](#usage)
5. [Configuration](#configuration)

## Introduction

PrintfulClient simplifies communication with the Printful API by providing dedicated clients for various services. It includes support for retry policies via Polly, configurable timeouts, and dependency injection for easy integration into .NET applications.

## Features

- **Retry Policies:** Automatically retries failed requests using Polly for handling transient failures.
- **Timeout Handling:** Configurable timeouts for API requests.
- **Multiple Service Clients:** Access various Printful services such as product catalogs, mockups, orders, and more.

## Tech Stack

- **Backend:** .NET 8
- **API Integration:** Printful API
- **Resilience:** Polly for retry policies
- **Dependency Injection:** Used for service registrations and configurations

## Usage

1. **Register the PrintfulClient:** Use the provided extension methods such as `AddPrintfulCatalogClient`, `AddPrintfulOrdersClient`, or `AddAllPrintfulClients` to register the desired Printful clients in the dependency injection container.
2. **Configure Authentication:** Use the `ConfigurePrintfulAuth` method to set up authentication with the Printful API.
3. **Invoke Services:** Use the respective service clients (e.g., `IPrintfulCatalogClient`, `IPrintfulOrdersClient`) to interact with the Printful API.

## Configuration

### PrintfulAuth

- **AccessToken:** The API token for authenticating requests to Printful.

```csharp
public class PrintfulAuth
{
    public string AccessToken { get; set; }
}
```

### PrintfulHttp

- **BaseAddress:** The base URL for the Printful API.
- **Timeout:** The timeout value for HTTP requests.

```csharp
public class PrintfulHttp
{
    public string BaseAddress { get; set; }
    public int Timeout { get; set; }
}
```

### Dependency Injection Example

Registering Printful clients and configuring authentication in the `Startup.cs` or `Program.cs`:

```csharp
services.ConfigurePrintfulAuth(options => 
{
    options.AccessToken = "your-api-token";
});

services.AddPrintfulHttpClient(new PrintfulHttp
{
    BaseAddress = "https://api.printful.com/",
    Timeout = 5 // in minutes
});

services.AddAllPrintfulClients();
```
