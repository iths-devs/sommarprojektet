# Build and run the backend

## Install .NET 6
If you already have VisualStudio 2022 or .NET 6 runtime installed you can skip step 1. If you already have VS Code extensions setup for C# or use Rider/VS2022 instead you can skip step 1 and 2.
1. Go to [this page](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks), download and install **.NET 6 Runtime**.
2. In Visual Studio Code, click extension and search for C# and install:
   * Name: C#
   * Id: ms-dotnettools.csharp
   * Description: C# for Visual Studio Code (powered by OmniSharp).
   * Version: 1.25.0
   * Publisher: Microsoft
   * VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp

## Build and run the backend

1. Open a terminal and navigate to `/backend`, run `dotnet build`.
2. step into `/API` and run `dotnet run`
3. Server is now running