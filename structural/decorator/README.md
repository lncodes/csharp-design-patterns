# Decorator Design Pattern

> Part of [**csharp-design-patterns**](../../README.md) · targets **.NET 10**

This project demonstrates the **Decorator** design pattern in C#. Gun accessories (extended magazine, flash hider, quick-draw magazine) wrap an `AwmGun` to add behaviour at runtime, shown in both a regular and a generic implementation.

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns/structural/decorator
dotnet build src
dotnet test test
```

## What's inside

- [`src/AwmGun.cs`](src/AwmGun.cs)
- [`src/Decocator (Weapon Accessory)/Generic/ExtendedMagGunAccessoryDecocator.cs`](src/Decocator%20%28Weapon%20Accessory%29/Generic/ExtendedMagGunAccessoryDecocator.cs)
- [`src/Decocator (Weapon Accessory)/Generic/FlashHidderGunAccessoryDecocator.cs`](src/Decocator%20%28Weapon%20Accessory%29/Generic/FlashHidderGunAccessoryDecocator.cs)
- [`src/Decocator (Weapon Accessory)/Generic/GunAccessoriesDecocator.cs`](src/Decocator%20%28Weapon%20Accessory%29/Generic/GunAccessoriesDecocator.cs)
- [`src/Decocator (Weapon Accessory)/Generic/QuickDrawMagGunAccessoryDecocator.cs`](src/Decocator%20%28Weapon%20Accessory%29/Generic/QuickDrawMagGunAccessoryDecocator.cs)
- [`src/Decocator (Weapon Accessory)/Reguler/ExtendedMagGunAccessoryDecocator.cs`](src/Decocator%20%28Weapon%20Accessory%29/Reguler/ExtendedMagGunAccessoryDecocator.cs)
- [`src/Decocator (Weapon Accessory)/Reguler/FlashHidderGunAccessoryDecocator.cs`](src/Decocator%20%28Weapon%20Accessory%29/Reguler/FlashHidderGunAccessoryDecocator.cs)
- [`src/Decocator (Weapon Accessory)/Reguler/GunAccessoriesDecocator.cs`](src/Decocator%20%28Weapon%20Accessory%29/Reguler/GunAccessoriesDecocator.cs)
- [`src/Decocator (Weapon Accessory)/Reguler/QuickDrawMagGunAccessoryDecocator.cs`](src/Decocator%20%28Weapon%20Accessory%29/Reguler/QuickDrawMagGunAccessoryDecocator.cs)
- [`src/Gun.cs`](src/Gun.cs)

---

Questions? Use [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions) · [Contributing](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) · [MIT License](../../LICENSE)
