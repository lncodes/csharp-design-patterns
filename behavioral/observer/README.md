# Observer Design Pattern

> Part of [**csharp-design-patterns**](../../README.md) · targets **.NET 10**

This project demonstrates the **Observer** design pattern in C#. An `AreaSubject` notifies a set of enemy observers (`GoblinEnemyObserver`, `OrcEnemyObserver`, `SlimeEnemyObserver`) when something happens in the area, so the subject never depends on concrete enemy types.

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns/behavioral/observer
dotnet build src
dotnet test test
```

## What's inside

- [`src/AreaSubject.cs`](src/AreaSubject.cs)
- [`src/Observer/EnemyObserver.cs`](src/Observer/EnemyObserver.cs)
- [`src/Observer/GoblinEnemyObserver.cs`](src/Observer/GoblinEnemyObserver.cs)
- [`src/Observer/OrcEnemyObserver.cs`](src/Observer/OrcEnemyObserver.cs)
- [`src/Observer/SlimeEnemyObserver.cs`](src/Observer/SlimeEnemyObserver.cs)

---

Questions? Use [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions) · [Contributing](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) · [MIT License](../../LICENSE)
