## Coding Standards for C# Contributions

To maintain code quality and ensure consistency across the **MtconnectTranspiler** project, we ask contributors to follow these coding standards when submitting changes. These guidelines are based on common best practices for C# and are intended to strike a balance between strictness and flexibility, promoting readability and maintainability.

### Naming Conventions
- **Variables and Methods**: Use camelCase for local variables and method names to improve readability (e.g., `localVariable`, `computeValue()`).
- **Constants and Fields**: Use camelCase for private fields and PascalCase for public fields and constants (e.g., `publicField`, `CONSTANT_VALUE`).
- **Classes and Interfaces**: Use PascalCase, which is standard practice in C# (e.g., `DataProcessor`, `IEntity`).

### Indentation and Formatting
- **Indentation**: Use spaces instead of tabs with an indentation size of 4 spaces. This ensures that the code looks consistent across different editors and platforms.
- **Brace Style**: Adopt the "K&R" style where the opening brace is on the same line as the statement for methods, classes, and control blocks (e.g., `if`, `for`, `while`).
- **Line Length**: Aim to keep lines under 120 characters where possible for better readability across various devices and editors.

### Commenting and Documentation
- **Inline Comments**: Use inline comments sparingly and only when necessary to explain complex logic or decisions that are not immediately obvious from the code.
- **XML Documentation Comments**: Use XML documentation comments for all public APIs, including classes, methods, properties, and events. This practice helps create comprehensive documentation and supports IntelliSense in IDEs like Visual Studio.

### Best Practices
- **Error Handling**: Prefer exceptions over returning error codes for most error handling. Use `try-catch` blocks judiciously and throw meaningful exceptions.
- **Initialization**: Use constructors for mandatory dependency injection and initialization. Consider using optional parameters or method overloading for optional dependencies.
- **String Manipulation**: Use `StringBuilder` for complex string manipulations to enhance performance.
- **LINQ**: Utilize LINQ for querying collections for more readable and concise code.

### Security Practices
- **Input Validation**: Always validate input parameters in public methods to prevent injection attacks and ensure data integrity.
- **Secure Data Handling**: Use secure methods and classes for handling sensitive data, such as passwords or personal information, and avoid storing such data in plain text.

### Testing
- **Unit Testing**: Write unit tests for new code to ensure functionality and prevent regressions. Aim for a high coverage of critical paths and edge cases.
- **Naming Tests**: Name test methods clearly, indicating what they are testing and the expected outcome (e.g., `MethodName_Condition_ExpectedResult`).

### Using Linters
- We recommend using tools like StyleCop or ReSharper to automatically check your code against these standards. These tools can help identify potential issues and enforce consistency.

By following these guidelines, you contribute to the overall quality and coherence of the **MtconnectTranspiler** project. If you have questions or need further clarification on any of the coding standards, please feel free to reach out to the project maintainers.

## Contributing to MtconnectTranspiler

Thank you for your interest in contributing to the MtconnectTranspiler project! Your contributions are vital to the project's success. Here are some guidelines to help you contribute effectively.

### Submitting Changes

1. **Fork and Clone**: Begin by forking the repository and cloning your fork to your local machine.
2. **Create a New Branch**: Make your changes in a new git branch based on the `main` branch of the original repository.
3. **Implement Your Changes**: Make your changes, ensuring they adhere to the project's coding standards and best practices for C#.
4. **Manual Testing**: Please manually test your changes by running the transpiler to ensure functionality and that no existing features are broken.
5. **Commit Your Changes**: Commit your changes with a clear and descriptive commit message, following any conventional commit message guidelines adopted by the project.
6. **Submit a Pull Request (PR)**: Push your branch to GitHub and open a pull request against the `main` branch of the original repository. In your pull request, clearly describe the problem you're addressing, how your changes solve this problem, and any other relevant details.

### Pull Requests

- **Linking to Issues**: Where applicable, please link your PR to any related issues. If your PR addresses a problem that hasn't been logged as an issue, ensure you describe the issue and how your PR addresses it.
- **No Issue Requirement**: It's not necessary to create an issue before submitting a PR. However, describing the problem your PR solves is crucial.

### Communication

- **Primary Communication Channel**: For project-related discussions, including feature requests and bug reports, please use the [MTConnect project site](projects.mtconnect.org).
- **GitHub Issues**: GitHub issues can be used as a secondary option for submitting bug reports and feature requests.

### Striving for Quality

- We aim to build a robust solution with comprehensive unit testing. While we develop our testing framework, contributors are encouraged to manually test their changes thoroughly.
- Contributions that help us advance towards automated testing are highly appreciated.

### Questions?

If you have any questions about contributing, please feel free to raise an issue on the project site or here on GitHub.

Thank you for your contributions to the MtconnectTranspiler project!
