# Prototype Design Pattern

> Part of [**csharp-design-patterns**](../../README.md) · targets **.NET 10**

This project demonstrates the **Prototype** design pattern in C#, comparing shallow and deep copy approaches: manual deep copy, JSON serialization (System.Text.Json) and XML serialization.

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns/creational/prototype
dotnet build src
dotnet test test
```

## What's inside

- [`src/Types/Deep Copy/ManualDeepCopyPrototype.cs`](src/Types/Deep%20Copy/ManualDeepCopyPrototype.cs)
- [`src/Types/Deep Copy/Object/DeepCharacter.cs`](src/Types/Deep%20Copy/Object/DeepCharacter.cs)
- [`src/Types/Deep Copy/Object/DeepInventory.cs`](src/Types/Deep%20Copy/Object/DeepInventory.cs)
- [`src/Types/Deep Copy/Serialization/JsonSerializationPrototype.cs`](src/Types/Deep%20Copy/Serialization/JsonSerializationPrototype.cs)
- [`src/Types/Deep Copy/Serialization/XmlSerializationPrototype.cs`](src/Types/Deep%20Copy/Serialization/XmlSerializationPrototype.cs)
- [`src/Types/Shallow Copy/CloneableInterfacePrototype.cs`](src/Types/Shallow%20Copy/CloneableInterfacePrototype.cs)
- [`src/Types/Shallow Copy/ConstructorPrototype.cs`](src/Types/Shallow%20Copy/ConstructorPrototype.cs)
- [`src/Types/Shallow Copy/Object/ShallowCharacter.cs`](src/Types/Shallow%20Copy/Object/ShallowCharacter.cs)
- [`src/Types/Shallow Copy/Object/ShallowInventory.cs`](src/Types/Shallow%20Copy/Object/ShallowInventory.cs)
- [`src/Types/Shallow Copy/Registry Prototype/Object/RegistryCharacter.cs`](src/Types/Shallow%20Copy/Registry%20Prototype/Object/RegistryCharacter.cs)
- [`src/Types/Shallow Copy/Registry Prototype/RegistryPrototype.cs`](src/Types/Shallow%20Copy/Registry%20Prototype/RegistryPrototype.cs)
- [`src/Types/Shallow Copy/Registry Prototype/SingeltonRegistryPrototype.cs`](src/Types/Shallow%20Copy/Registry%20Prototype/SingeltonRegistryPrototype.cs)

---

Questions? Use [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions) · [Contributing](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) · [MIT License](../../LICENSE)
