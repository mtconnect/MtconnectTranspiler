# MtconnectTranspiler

MtconnectTranspiler is a .NET library for reading the MTConnect standard's SysML/XMI information model and dispatching the deserialized model to one or more transpiler sinks.

Use this package when you want to generate code, schemas, documentation, validation assets, or other artifacts from the MTConnect model instead of hand-maintaining those artifacts as the standard evolves.

The package provides:

- An XMI deserializer that produces a strongly typed `XmiDocument`.
- A `TranspilerDispatcher` that loads the MTConnect model and sends it to registered sinks.
- The `ITranspilerSink` contract for implementing your own output generator.
- Options for loading the model from a local file, GitHub release, or the MTConnect model browser.

## Installation

Install the package from NuGet:

```powershell
dotnet add package MtconnectTranspiler
```

Or add a package reference to your project file:

```xml
<ItemGroup>
  <PackageReference Include="MtconnectTranspiler" Version="2.8.0" />
</ItemGroup>
```

`MtconnectTranspiler` targets `.NET Standard 2.0`, so it can be consumed by modern .NET applications and libraries that support that target.

## Basic Usage

The library follows a dispatcher/sink pattern:

1. Choose where the MTConnect SysML/XMI model should be loaded from.
2. Implement or reuse an `ITranspilerSink`.
3. Add the sink to `TranspilerDispatcher`.
4. Call `TranspileAsync()`.

```csharp
using System;
using System.Threading;
using System.Threading.Tasks;
using MtconnectTranspiler;
using MtconnectTranspiler.Sinks;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.XmiOptions;

internal static class Program
{
    private static async Task Main()
    {
        using var dispatcher = new TranspilerDispatcher(
            new FromFileOptions { Filepath = @"C:\models\Model.xml" });

        dispatcher.AddSink(new SummarySink());

        await dispatcher.TranspileAsync();
    }
}

internal sealed class SummarySink : ITranspilerSink
{
    public void Transpile(XmiDocument model, CancellationToken cancellationToken = default)
    {
        var packageCount = model.Model?.Packages?.Count ?? 0;
        Console.WriteLine($"Loaded {packageCount} top-level MTConnect package(s).");
    }
}
```

In a real sink, the `Transpile` method is where you inspect the `XmiDocument` and write your generated output, such as C# source files, JSON schemas, markdown documentation, or other model-derived artifacts.

## Model Sources

Use one of the built-in options when creating a `TranspilerDispatcher`.

Load a local model file:

```csharp
var dispatcher = new TranspilerDispatcher(
    new FromFileOptions { Filepath = @"C:\models\Model.xml" });
```

Load the current model from the MTConnect model browser:

```csharp
var dispatcher = new TranspilerDispatcher(
    new MtconnectTranspiler.XmiOptions.FromMtconnectOrg());
```

Load a model from the `mtconnect/mtconnect_sysml_model` GitHub releases:

```csharp
var dispatcher = new TranspilerDispatcher(
    new FromGitHubOptions { GitHubRelease = "v2.8" });
```

Use `"latest"` for `GitHubRelease` to request the latest GitHub release.

## Implementing a Sink

A sink is responsible for turning the parsed MTConnect model into whatever output your project needs.

```csharp
public sealed class MySink : ITranspilerSink
{
    public void Transpile(XmiDocument model, CancellationToken cancellationToken = default)
    {
        // Traverse model.Model, model.Model.Packages, stereotypes, comments,
        // properties, constraints, and other XMI elements here.
    }
}
```

The dispatcher can run multiple sinks from the same deserialized model:

```csharp
dispatcher.AddSink(new MyFirstSink());
dispatcher.AddSink(new MySecondSink());
await dispatcher.TranspileAsync();
```

## Resources

- [Source repository](https://github.com/mtconnect/MtconnectTranspiler)
- [NuGet package](https://www.nuget.org/packages/MtconnectTranspiler)
- [MTConnect Model Browser](https://model.mtconnect.org/)
- [MTConnect User Portal](https://mtcup.org/)
- [MTConnect SysML model releases](https://github.com/mtconnect/mtconnect_sysml_model/releases)

## License

MtconnectTranspiler is licensed under the Apache License 2.0.
