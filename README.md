<p align="center"><a href="https://www.lncodes.com"><img src="https://raw.githubusercontent.com/lncodes/docs/main/assets/animations/lncodes-logo-animation.gif" alt="Last Night Codes logo" height="120"></a></p>

# C# Design Patterns

[![CI](https://github.com/lncodes/csharp-design-patterns/actions/workflows/ci.yml/badge.svg)](https://github.com/lncodes/csharp-design-patterns/actions/workflows/ci.yml)

Gang-of-Four design patterns implemented in C#, each with unit tests. Every project targets **.NET 10** and is built and tested in CI.

## What's inside

### Creational

| Folder | What it shows | Blog post |
|---|---|---|
| [**Builder Design Pattern**](creational/builder) | This project demonstrates the Builder design pattern in C#, with a classic GoF version (Builder, Director, concrete builders) and modern variants (fluent builder and generic builder). | [Read](https://www.lncodes.com/builder-design-pattern) |
| [**Factory Method Design Pattern**](creational/factory-method) | Enemy factories (GoblinEnemyFactory, OrcEnemyFactory, SlimeEnemyFactory) create enemies through a common EnemyFactory abstraction. | — |
| [**Prototype Design Pattern**](creational/prototype) | This project demonstrates the Prototype design pattern in C#, comparing shallow and deep copy approaches: manual deep copy, JSON serialization (System.Text.Json) and XML serialization. | — |
| [**Singleton Design Pattern**](creational/singleton) | It includes different types of Singleton design patterns, such as Eager Initialization Singleton, Lazy Initialization Singleton, Thread-Safe Lazy Singleton, and more. | [Read](https://www.lncodes.com/singleton-design-pattern) |

### Structural

| Folder | What it shows | Blog post |
|---|---|---|
| [**Adapter Design Pattern**](structural/adapter) | An NpcAdapterEnemy lets an existing Npc be used wherever the Enemy abstraction (GoblinEnemy, OrcEnemy) is expected. | [Read](https://www.lncodes.com/adapter-design-pattern) |
| [**Bridge Design Pattern**](structural/bridge) | Enemy types (GoblinEnemy, OrcEnemy, SlimeEnemy) are decoupled from their elements (FireElement, WaterElement, WindElement) so both hierarchies can vary independently. | — |
| [**Decorator Design Pattern**](structural/decorator) | Gun accessories (extended magazine, flash hider, quick-draw magazine) wrap an AwmGun to add behaviour at runtime, shown in both a regular and a generic implementation. | — |
| [**Facade Design Pattern**](structural/facade) | A facade gives one simple entry point to an inventory subsystem (weapons, armor, skill books and player class data), shown as both a regular facade and a singleton facade. | [Read](https://www.lncodes.com/facade-design-pattern) |
| [**Flyweight Design Pattern**](structural/flyweight) | Gun controllers share intrinsic GunModel data through flyweight factories, including eager and factory-based variants, to reduce memory use. | — |

### Behavioral

| Folder | What it shows | Blog post |
|---|---|---|
| [**Memento Design Pattern**](behavioral/memento) | A PlayerPositionOriginator saves its position into PositionMemento snapshots that a PositionCaretaker stores and restores, without exposing the originator's internals. | — |
| [**Observer Design Pattern**](behavioral/observer) | An AreaSubject notifies a set of enemy observers (GoblinEnemyObserver, OrcEnemyObserver, SlimeEnemyObserver) when something happens in the area, so the subject never depends on concrete enemy types. | — |
| [**State Design Pattern**](behavioral/state) | Player controllers delegate their behaviour to battle state contexts, with both a single-active-state context and a multiple-active-state context. | — |
| [**Strategy Design Pattern**](behavioral/strategy) | A PlayerController swaps between interchangeable companion behaviours (BearCompanion, CrocodileCompanion, DogCompanion) at runtime through a shared Companion abstraction. | — |

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns
dotnet build csharp-design-patterns.sln
dotnet test csharp-design-patterns.sln
```

Requires the [.NET 10 SDK](https://dotnet.microsoft.com/download). Open `csharp-design-patterns.sln` in Visual Studio or Rider to browse every project; each folder's README shows how to run that project on its own.

## Repository layout

- `Directory.Build.props`: target framework and shared settings for every project
- `Directory.Packages.props`: NuGet package versions, managed in one place
- `.github/workflows/ci.yml`: restore, build and test on every push and pull request

## History

Each folder was merged from its original repository with its full commit history. The original repositories are archived and link here.

## Contributing

Questions and ideas are welcome in [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions). See the [Contributing Guidelines](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) before opening a pull request.

## License

[MIT](LICENSE)
