# Singleton Design Pattern

> Part of [**csharp-design-patterns**](../../README.md) · targets **.NET 10**

This project contains various implementations of the Singleton design pattern in C#. It includes different types of Singleton design patterns, such as Eager Initialization Singleton, Lazy Initialization Singleton, Thread-Safe Lazy Singleton, and more.

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns/creational/singleton
dotnet build src
dotnet test tests
```

## What's inside

- [`src/Eager/EagerGenericSingleton.cs`](src/Eager/EagerGenericSingleton.cs)
- [`src/Eager/EagerSingleton.cs`](src/Eager/EagerSingleton.cs)
- [`src/Lazy/LazyGenericSingleton.cs`](src/Lazy/LazyGenericSingleton.cs)
- [`src/Lazy/LazySingleton.cs`](src/Lazy/LazySingleton.cs)
- [`src/Lazy/Thread Safe/BillPughSingleton.cs`](src/Lazy/Thread%20Safe/BillPughSingleton.cs)
- [`src/Lazy/Thread Safe/Generic/LazyClassicThreadSafeGenericSingleton.cs`](src/Lazy/Thread%20Safe/Generic/LazyClassicThreadSafeGenericSingleton.cs)
- [`src/Lazy/Thread Safe/Generic/LazyModernThreadSafeGenericSingleton.cs`](src/Lazy/Thread%20Safe/Generic/LazyModernThreadSafeGenericSingleton.cs)
- [`src/Lazy/Thread Safe/LazyClassicThreadSafeSingleton.cs`](src/Lazy/Thread%20Safe/LazyClassicThreadSafeSingleton.cs)
- [`src/Lazy/Thread Safe/LazyModernThreadSafeSingleton.cs`](src/Lazy/Thread%20Safe/LazyModernThreadSafeSingleton.cs)

## Use it in your project

Pick the variant that fits (for example `EagerSingleton.cs`), copy the file into your project, and access it through its instance method:

```csharp
var instance = EagerSingleton.GetInstance();
```

## Learn more

Read the full explanation on the blog: [Singleton Design Pattern – Last Night Codes](https://www.lncodes.com/singleton-design-pattern)

---

Questions? Use [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions) · [Contributing](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) · [MIT License](../../LICENSE)
