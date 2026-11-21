# Flyweight Design Pattern

> Part of [**csharp-design-patterns**](../../README.md) · targets **.NET 10**

This project demonstrates the **Flyweight** design pattern in C#. Gun controllers share intrinsic `GunModel` data through flyweight factories, including eager and factory-based variants, to reduce memory use.

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns/structural/flyweight
dotnet build src
dotnet test test
```

## What's inside

- [`src/Object/GunController.cs`](src/Object/GunController.cs)
- [`src/Object/GunModel.cs`](src/Object/GunModel.cs)
- [`src/Object/GunTypes.cs`](src/Object/GunTypes.cs)
- [`src/Types/Eager/EagerFactoryGunModelFlyweight.cs`](src/Types/Eager/EagerFactoryGunModelFlyweight.cs)
- [`src/Types/Eager/EagerGunModelFlyweight.cs`](src/Types/Eager/EagerGunModelFlyweight.cs)
- [`src/Types/FactoryGunModelFlyweight.cs`](src/Types/FactoryGunModelFlyweight.cs)
- [`src/Types/GunModelFlyweight.cs`](src/Types/GunModelFlyweight.cs)
- [`src/Types/Lazy/LazyFactoryGunModelFlyweight.cs`](src/Types/Lazy/LazyFactoryGunModelFlyweight.cs)
- [`src/Types/Lazy/LazyGunModelFlyweight.cs`](src/Types/Lazy/LazyGunModelFlyweight.cs)
- [`src/Types/Lazy/SingletonLazyFactoryGunModelFlyweight.cs`](src/Types/Lazy/SingletonLazyFactoryGunModelFlyweight.cs)

---

Questions? Use [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions) · [Contributing](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) · [MIT License](../../LICENSE)
