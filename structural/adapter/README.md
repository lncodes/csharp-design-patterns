# Adapter Design Pattern

> Part of [**csharp-design-patterns**](../../README.md) · targets **.NET 10**

This project demonstrates the **Adapter** design pattern in C#. An `NpcAdapterEnemy` lets an existing `Npc` be used wherever the `Enemy` abstraction (`GoblinEnemy`, `OrcEnemy`) is expected.

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns/structural/adapter
dotnet build src
dotnet test test
```

## What's inside

- [`src/Enemy/Adapter/NpcAdapterEnemy.cs`](src/Enemy/Adapter/NpcAdapterEnemy.cs)
- [`src/Enemy/Enemy.cs`](src/Enemy/Enemy.cs)
- [`src/Enemy/GoblinEnemy.cs`](src/Enemy/GoblinEnemy.cs)
- [`src/Enemy/OrcEnemy.cs`](src/Enemy/OrcEnemy.cs)
- [`src/Npc/Npc.cs`](src/Npc/Npc.cs)

## Learn more

Read the full explanation on the blog: [Adapter Design Pattern – Last Night Codes](https://www.lncodes.com/adapter-design-pattern)

---

Questions? Use [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions) · [Contributing](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) · [MIT License](../../LICENSE)
