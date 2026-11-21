<p align="center"><a href="https://lncodes.com"><img src="https://github.com/lncodes/docs/blob/main/assets/animations/lncodes-logo-animation.gif" height="150"></a></p>

<h1 align="center">C# Design Patterns</h1>
<p align="center"><a href="https://github.com/lncodes/csharp-design-patterns/actions/workflows/ci.yml"><img src="https://github.com/lncodes/csharp-design-patterns/actions/workflows/ci.yml/badge.svg"></a></p>

Gang-of-Four design patterns implemented in C#, each with unit tests, grouped by creational, structural and behavioral. Every project targets **.NET 10**.

## Creational

| Folder | What it shows | Blog post |
|---|---|---|
| [`creational/builder`](creational/builder) | Builder design pattern example in C#. | — |
| [`creational/factory-method`](creational/factory-method) | Factory Method design pattern example in C#. | — |
| [`creational/prototype`](creational/prototype) | Prototype design pattern example in C#. | — |
| [`creational/singleton`](creational/singleton) | Singleton design pattern in C#, with tests and docs. | [read](https://lncodes.com/singleton-design-pattern/) |

## Structural

| Folder | What it shows | Blog post |
|---|---|---|
| [`structural/adapter`](structural/adapter) | Adapter design pattern example in C#. | — |
| [`structural/bridge`](structural/bridge) | Bridge design pattern example in C#. | — |
| [`structural/decorator`](structural/decorator) | Decorator design pattern example in C#. | — |
| [`structural/facade`](structural/facade) | Facade design pattern example in C#. | — |
| [`structural/flyweight`](structural/flyweight) | Flyweight design pattern example in C#. | — |

## Behavioral

| Folder | What it shows | Blog post |
|---|---|---|
| [`behavioral/memento`](behavioral/memento) | Memento design pattern example in C#. | — |
| [`behavioral/observer`](behavioral/observer) | Observer design pattern example in C#. | — |
| [`behavioral/state`](behavioral/state) | State design pattern example in C#. | — |
| [`behavioral/strategy`](behavioral/strategy) | Strategy design pattern example in C#. | — |

## Getting started

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns
dotnet build csharp-design-patterns.sln
dotnet test csharp-design-patterns.sln
```

Open `csharp-design-patterns.sln` in Visual Studio or Rider to browse every project, or open a single folder's own `.sln`.

Package versions are managed once in `Directory.Packages.props`; the target framework is set in `Directory.Build.props`.

## History

Each folder was merged from its original repository with full commit history (`git subtree`). The original repositories are archived and link here.

## Contributing

See the [Contributing Guidelines](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md).

## License

[MIT](LICENSE)
