[![Publish NuGet Package](https://github.com/mtconnect/MtconnectTranspiler/actions/workflows/gh-package.yml/badge.svg)](https://github.com/mtconnect/MtconnectTranspiler/actions/workflows/gh-package.yml)

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

NuGet package: [MtconnectTranspiler](https://www.nuget.org/packages/MtconnectTranspiler)

## Package Usage

For the full NuGet package usage guide, including dispatcher setup, model source options, and `ITranspilerSink` examples, see [MtconnectTranspiler/README.md](MtconnectTranspiler/README.md).

## Repository Layout

- `MtconnectTranspiler/` - Core NuGet package source.
- `MtconnectTranspiler.Console/` - Console utility and examples for loading/deserializing the model.
- `MtconnectTranspiler/Xmi/` - Strongly typed XMI and SysML model types.
- `MtconnectTranspiler/Sinks/` - Sink abstractions used by the dispatcher.
- `MtconnectTranspiler/XmiOptions/` - Built-in model source options.

## Resources

- [NuGet package](https://www.nuget.org/packages/MtconnectTranspiler)
- [MTConnect Model Browser](https://model.mtconnect.org/)
- [MTConnect User Portal](https://mtcup.org/)
- [MTConnect SysML model releases](https://github.com/mtconnect/mtconnect_sysml_model/releases)

## License

MtconnectTranspiler is licensed under the Apache License 2.0. See [LICENSE.txt](LICENSE.txt).
