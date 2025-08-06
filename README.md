[![Publish NuGet Package](https://github.com/mtconnect/MtconnectTranspiler/actions/workflows/gh-package.yml/badge.svg)](https://github.com/mtconnect/MtconnectTranspiler/actions/workflows/gh-package.yml)

# MtconnectTranspiler
MtconnectTranspiler is an open-source C# library that deserializes the MTConnect standard’s SysML information model (provided as an XMI file) into a strongly-typed C# object model <sup>[1][1]</sup>. It leverages the normative XMI structure of the MTConnect standard <sup>[1][1]</sup> to automate development of related tools. In simpler terms, MtconnectTranspiler reads the MTConnect standard’s *digital model* (SysML XMI) and gives developers an in-memory C# model they can navigate or convert into other formats (code, documentation, etc.) using *sinks*. This helps maintain parity with updates to the MTConnect standard by regenerating code or artifacts whenever the standard’s model changes <sup>[2][2]</sup>.

## Installation
The library is available as a NuGet package. You can install it via the .NET CLI:
```
dotnet add package MtconnectTranspiler
```
This will download the **MtconnectTranspiler** library (targeting .NET Standard 2.0) <sup>[3][3]</sup>. The package enables parsing an MTConnect XMI file and passing the resulting model to your transpiler logic.

> *Note:* The package is published on NuGet.org, and may also be available on GitHub Packages. If using GitHub Packages, ensure your NuGet configuration includes the Mtconnect GitHub package feed (and authentication if required).

## Usage Example
Once installed, you can use MtconnectTranspiler to load an MTConnect model from an XMI file and then transpile it. At a high level, you will:

1. **Obtain the MTConnect XMI** - Download the normative MTConenct XMI for the version of the standard you need. (Since MTConnect v2.0, the official information model is provided as an XMI file <sup>[5][5]</sup> developed in SysML.) For example, you might obtain `MTConnect_v2.5.SysML.xmi` from the MTConnect Institute's website.
2. **Initialize the Transpiler Dispatcher** - In your code, create a `TranspilerDispatcher` with options pointing to the XMI file. This will load and parse the XMI into a C# model.
3. **Add a Sink and Run** - Attache one or more *sink* implementations to the dispatcher, then execute the transpilation. A *sink* is a component that receieves the parsed model and generates output (such as code files. JSON schemas, documentation, etc.).

Below is a simplified example in C# demonstrating these steps.
``` C#
using MtconnectTranspiler;
using MtconnectTranspiler.Contracts: // for ITranspilerSink
// ... other sing statements

// 1. Define the path to the MTConnect XMI file
string xmiPath = "path/to/MTConnectSysML.xmi";

// 2. Create a dispatcher to load the XMI
var dispatcher = new TranspilerDispatcher(new FromFileOptions { Filepath = xmiPath });

// 3. Add a sink implementation to handle the transpilation output
dispatcher.AddSink(new MyCustomSinkTranspiler());

// 4. Run the transpiler (asynchronous execution)
await dispatcher.TranspilerAsync();
```
In the above example, `MyCustomSinkTranspiler` would be your implementation of the
`ITranspilerSink` interface, which defines a `Transpile(XmiDocument model,
CancellationToken token)` method to process the model. The `TranspilerDispatcher` will
invoke your sink’s `Transpile` method, providing the deserialized `XmiDocument` (the in-memory
representation of the MTConnect model). This design cleanly separates the parsing of the standard
from the **generation of outputs**.
If you prefer not to write a sink from scratch, you can use or extend existing sinks. For instance, the
**MtconnectTranspiler.Sinks.CSharp** package provides an `ITranspilerSink` implementation that
generates C# code from the model <sup>[6][6]</sup>. You could add `MtconnectTranspiler.Sinks.CSharp` via
NuGet and then do: `dispatcher.AddSink(new CSharpSink(/*options*/));` to generate .NET
classes and enums representing the MTConnect standard. There are also other sink implementations
(for example, for JSON Schema generation) that you can leverage or study (see Related Projects below).

## Documentation and Resources
For more in-depth guidance, please refer to the project's Wiki (for documation site). The Wiki includes:
*   **Architecure Overvew** - Explains how the XMI is sourced and parsed, the transpiler's design (dispatcher and sinks), and how the deserialized model is used in code.
*   **Getting Started Guide** - A tutorial-style walkthrough for setting up a project with MtconnectTranspiler, writing or using a sink, and  running the transpilation (with code examples).
*   **MTConnect Model (API Reference)** - Describes the structure of the C# object model that MtconnectTranspiler produces, and how it correlates tot he MTConnect standard's SysML model. This section also covers versioning (using the transpiler with different versions of the MTConnect standard that have a SysML XMI).

Additional technical documentation on MTConnect's modeling can be found on the MTConnect User Portal (MTCUP) and the MTConnect Model Browser, which may help in understanding the standard's structure.

## Related Projects and Examples
One of the strengths of MtconnectTranspiler is that it’s been used to generate code for real-world
MTConnect libraries and tools. Here are a few examples and related projects:
* **MtconnectTranspiler.Sinks.CSharp** – An abstract sink implementation (built on Scriban
templating) that generates .cs files. It serves as a foundation for creating C# code output
from the MTConnect model . Developers can use this to produce their own class libraries
representing MTConnect devices, data items, etc., without writing a sink from scratch.
* **MtconnectCore** (GitHub: TrueAnalyticsSolutions/MtconnectCore) – An open-source .NET library
that mirrors the MTConnect standard. It uses the MtconnectTranspiler Sinks.CSharp to autogenerate
its classes and enums from the standard’s model . This is a great example of using
the transpiler to maintain a library in sync with the standard.
* **Mtconnect.Adapter** (GitHub: TrueAnalyticsSolutions/Mtconnect.Adapter) – An adapter SDK that
also utilizes the CSharp sink to generate MTConnect model classes for adapter development .
It demonstrates a “model-aware” adapter using transpiled standard definitions.
* **MtconnectTranspiler.Sinks.JsonSchema** – Another sink example which generates JSON Schema
files from the MTConnect model . This shows the flexibility of the transpiler to target formats
beyond C# code.
* **MTConnect.NET** (GitHub: TrakHound/MTConnect.NET) – A project that forked
MtconnectTranspiler to maintain its own class models for MTConnect . This underscores how
the transpiler approach aids in keeping up with standard changes.
Each of these projects includes a console application or build process that invokes MtconnectTranspiler
(often in a file named `Transpiler.cs`) to perform the transpilation. Reviewing those
implementations can provide deeper insight into how to integrate the transpiler into your own
development workflow.

## License and Contributing
MtconnectTranspiler is licensed under the Apache-2.0 License . Contributions are welcome – if you
have ideas or fixes, feel free to open issues or pull requests. By contributing, you help the MTConnect
community build robust tools around the standard.

Additionally, contributors are invited to join the [MTConnect Standards Committee](https://www.mtconnect.org/standards-committee) and participate in the frequent MTConnect Validation Working Group where we discuss work relavent to tools like the MtconnectCore project.

## Documentation
Any documentation surrounding MTConnect&reg; can be found on the [MTCup](https://mtcup.org/) site (MTConnect User Portal).

Any technical documentation surrounding MTConnect&reg; can be found on the [MTConnect&reg; Model Browser](https://model.mtconnect.org/) generated from the SysML model.

For more information about this project and how to navigate it, visit the [Wiki](wiki).

[1]: https://github.com/mtconnect/MtconnectTranspiler/tree/develop/MtconnectTranspiler/Xmi
[2]: https://www.mtcup.org/MTConnect-Transpiler
[3]: https://www.nuget.org/packages/MtconnectTranspiler
