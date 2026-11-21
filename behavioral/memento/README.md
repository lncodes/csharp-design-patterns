# Memento Design Pattern

> Part of [**csharp-design-patterns**](../../README.md) · targets **.NET 10**

This project demonstrates the **Memento** design pattern in C#. A `PlayerPositionOriginator` saves its position into `PositionMemento` snapshots that a `PositionCaretaker` stores and restores, without exposing the originator's internals.

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns/behavioral/memento
dotnet build src
dotnet test test
```

## What's inside

- [`src/PlayerPositionOriginator.cs`](src/PlayerPositionOriginator.cs)
- [`src/PositionCaretaker.cs`](src/PositionCaretaker.cs)
- [`src/PositionMemento.cs`](src/PositionMemento.cs)
- [`src/Vector2.cs`](src/Vector2.cs)

---

Questions? Use [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions) · [Contributing](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) · [MIT License](../../LICENSE)
