# Bridge Design Pattern

> Part of [**csharp-design-patterns**](../../README.md) · targets **.NET 10**

This project demonstrates the **Bridge** design pattern in C#. Enemy types (`GoblinEnemy`, `OrcEnemy`, `SlimeEnemy`) are decoupled from their elements (`FireElement`, `WaterElement`, `WindElement`) so both hierarchies can vary independently.

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns/structural/bridge
dotnet build src
dotnet test test
```

## What's inside

- [`src/Element/Element.cs`](src/Element/Element.cs)
- [`src/Element/FireElement.cs`](src/Element/FireElement.cs)
- [`src/Element/WaterElement.cs`](src/Element/WaterElement.cs)
- [`src/Element/WindElement.cs`](src/Element/WindElement.cs)
- [`src/Enemy/Enemy.cs`](src/Enemy/Enemy.cs)
- [`src/Enemy/GoblinEnemy.cs`](src/Enemy/GoblinEnemy.cs)
- [`src/Enemy/OrcEnemy.cs`](src/Enemy/OrcEnemy.cs)
- [`src/Enemy/SlimeEnemy.cs`](src/Enemy/SlimeEnemy.cs)

---

Questions? Use [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions) · [Contributing](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) · [MIT License](../../LICENSE)
