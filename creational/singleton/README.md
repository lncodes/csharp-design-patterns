<br>
<p align="center">
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="https://lncodes.com">
    <img src="https://github.com/lncodes/docs/blob/main/assets/animations/lncodes-logo-animation.gif" height="175" alt="Last Night Codes Logo">
  </a>
</p>

<h1 align="center">Singleton Design Pattern in C#</h1>
<p align="center">
  <a href="https://github.com/lncodes/csharp-design-patterns/actions/workflows/ci.yml"><img src="https://github.com/lncodes/csharp-design-patterns/actions/workflows/ci.yml/badge.svg"></a>
</p>

<p align="center">
  <a href="#introduction">Introduction</a> •
  <a href="#installation">Installation</a> •
  <a href="#usage">Usage</a> •
  <a href="#contribute">Contribute</a> •
  <a href="#discussion">Discussion</a> •
  <a href="#license">License</a>
</p>

<h2 id="introduction">🌟 Introduction</h2>

This repository is a submodule of the [singleton-design-pattern](https://github.com/lncodes/singleton-design-pattern) repository and contains various implementations of the Singleton design pattern in C#. It includes different types of Singleton design patterns, such as Eager Initialization Singleton, Lazy Initialization Singleton, Thread-Safe Lazy Singleton, and more.

<h2 id="installation">📦 Installation</h2>

To set up this C# project on your local machine, ensure that the system requirements are met, and then follow these instructions:

<h3>System Requirements</h3>

- **.NET SDK:** Version 8 or later ([Download .NET](https://dotnet.microsoft.com/en-us/download)).

- **Operating System:** Windows, macOS, or Linux.

<h3>Steps to Install</h3>

1. **Clone or Download the Project**

    - **Clone the Repository**
    
      Use Git to create a local copy by executing the following command:

      ```bash
      git clone https://github.com/lncodes/singleton-design-pattern-csharp.git
      ```

    - **Download as ZIP**

      If Git is not available, you can download the project as a ZIP file from the GitHub repository by clicking the “Code” button and selecting the “Download ZIP" option.

2. **Navigate to the Project Directory**

    Navigate to the project directory containing the source files by executing the following command:

    ```bash
    cd singleton-design-pattern-csharp/src
    ```

    > **Note:** Make sure you're in the correct parent directory where the `singleton-design-pattern-csharp` folder is located.
    
3. **Restore Dependencies**

    Install all required packages and libraries by executing the following command:

    ```bash
    dotnet restore
    ```

    This command uses NuGet to download and install the dependencies specified in the project’s configuration files.

<h2 id="usage">🧑‍💻 Usage</h2>

To use the Singleton design pattern from this repository in your project, follow these steps:

1. **Run Unit Tests (Optional but Recommended)**

    To ensure that the implementation is functioning correctly, it is recommended to run the unit tests provided in the repository. To run the tests, open a command line or terminal in the project directory and use the following command:

      ```bash
      dotnet test
      ```

    This command will run all unit tests in the project and show which tests passed or failed.

2. **Select and Copy Singleton File**

    Browse the repository to locate the Singleton design pattern that aligns with your project’s requirements. For example, if `EagerSingleton.cs` seems like a suitable choice, copy this file from the repository. Ensure the selected Singleton design pattern file meets your project’s requirements for efficient resource management and proper functionality within the application.

3. **Use the Singleton File in the Project**

    Paste the copied Singleton file into your project’s solution. To use the Singleton in your application, access the instance as follows:

    ```csharp
    var singletonInstance = EagerSingleton.GetInstance();
    // Use the singleton instance as needed within the application
    ```

    Ensure that `EagerSingleton` is replaced with the name of the chosen class to guarantee the correct Singleton instance is used in the application.

<h2 id="contribute">🤝 Contribute</h2>

We appreciate your interest in contributing to this project! For detailed guidelines on how to report issues and submit pull requests, please check out our [Contributing Guidelines](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md).

<h2 id="discussion">💬 Discussion</h2>

If you have any questions or want to discuss anything related to this project, visit our [Discussion Forum](https://github.com/lncodes/singleton-design-pattern-csharp/discussions). You can also leave comments on the [Singleton Design Pattern - Last Night Codes](https://lncodes.com/singleton-design-pattern/) blog post for a more in-depth discussion on this project’s topics.

<h2 id="license"> 📋 License</h2>

This project is licensed under the [MIT License](../../LICENSE).<br>