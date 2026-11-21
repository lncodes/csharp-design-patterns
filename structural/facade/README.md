# Facade Design Pattern

> Part of [**csharp-design-patterns**](../../README.md) · targets **.NET 10**

This project demonstrates the **Facade** design pattern in C#. A facade gives one simple entry point to an inventory subsystem (weapons, armor, skill books and player class data), shown as both a regular facade and a singleton facade.

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns/structural/facade
dotnet build src
dotnet test test
```

## What's inside

- [`src/Data/PlayerClassTypes.cs`](src/Data/PlayerClassTypes.cs)
- [`src/Inventory/Armor/Armors.cs`](src/Inventory/Armor/Armors.cs)
- [`src/Inventory/Armor/Types/HeavyArmor.cs`](src/Inventory/Armor/Types/HeavyArmor.cs)
- [`src/Inventory/Armor/Types/LightArmor.cs`](src/Inventory/Armor/Types/LightArmor.cs)
- [`src/Inventory/Inventory.cs`](src/Inventory/Inventory.cs)
- [`src/Inventory/SkillBook/SkillBook.cs`](src/Inventory/SkillBook/SkillBook.cs)
- [`src/Inventory/SkillBook/Types/CyrotherapySkillBook.cs`](src/Inventory/SkillBook/Types/CyrotherapySkillBook.cs)
- [`src/Inventory/SkillBook/Types/SabotageSkillBook.cs`](src/Inventory/SkillBook/Types/SabotageSkillBook.cs)
- [`src/Inventory/Weapon/Types/Bow.cs`](src/Inventory/Weapon/Types/Bow.cs)
- [`src/Inventory/Weapon/Types/Sword.cs`](src/Inventory/Weapon/Types/Sword.cs)
- [`src/Inventory/Weapon/Weapons.cs`](src/Inventory/Weapon/Weapons.cs)
- [`src/RegulerFacade.cs`](src/RegulerFacade.cs)
- [`src/SingeltonFacade.cs`](src/SingeltonFacade.cs)

## Learn more

Read the full explanation on the blog: [Facade Design Pattern – Last Night Codes](https://www.lncodes.com/facade-design-pattern)

---

Questions? Use [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions) · [Contributing](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) · [MIT License](../../LICENSE)
