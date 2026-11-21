# Strategy Design Pattern

> Part of [**csharp-design-patterns**](../../README.md) · targets **.NET 10**

This project demonstrates the **Strategy** design pattern in C#. A `PlayerController` swaps between interchangeable companion behaviours (`BearCompanion`, `CrocodileCompanion`, `DogCompanion`) at runtime through a shared `Companion` abstraction.

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns/behavioral/strategy
dotnet build src
dotnet test test
```

## What's inside

- [`src/Companion/BearCompanion.cs`](src/Companion/BearCompanion.cs)
- [`src/Companion/Companion.cs`](src/Companion/Companion.cs)
- [`src/Companion/CrocodileCompanion.cs`](src/Companion/CrocodileCompanion.cs)
- [`src/Companion/DogCompanion.cs`](src/Companion/DogCompanion.cs)
- [`src/PlayerController.cs`](src/PlayerController.cs)

---

Questions? Use [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions) · [Contributing](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) · [MIT License](../../LICENSE)
