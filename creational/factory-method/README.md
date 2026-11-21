# Factory Method Design Pattern

> Part of [**csharp-design-patterns**](../../README.md) · targets **.NET 10**

This project demonstrates the **Factory Method** design pattern in C#. Enemy factories (`GoblinEnemyFactory`, `OrcEnemyFactory`, `SlimeEnemyFactory`) create enemies through a common `EnemyFactory` abstraction.

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns/creational/factory-method
dotnet build src
dotnet test test
```

## What's inside

- [`src/Data/EnemyTypes.cs`](src/Data/EnemyTypes.cs)
- [`src/Data/Vector2.cs`](src/Data/Vector2.cs)
- [`src/Enemy/Enemy.cs`](src/Enemy/Enemy.cs)
- [`src/Enemy/Types/GoblinEnemy.cs`](src/Enemy/Types/GoblinEnemy.cs)
- [`src/Enemy/Types/OrcEnemy.cs`](src/Enemy/Types/OrcEnemy.cs)
- [`src/Enemy/Types/SlimeEnemy.cs`](src/Enemy/Types/SlimeEnemy.cs)
- [`src/Factory/EnemyFactory.cs`](src/Factory/EnemyFactory.cs)
- [`src/Factory/GoblinEnemyFactory.cs`](src/Factory/GoblinEnemyFactory.cs)
- [`src/Factory/OrcEnemyFactory.cs`](src/Factory/OrcEnemyFactory.cs)
- [`src/Factory/SlimeEnemyFactory.cs`](src/Factory/SlimeEnemyFactory.cs)

---

Questions? Use [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions) · [Contributing](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) · [MIT License](../../LICENSE)
