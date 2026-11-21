# State Design Pattern

> Part of [**csharp-design-patterns**](../../README.md) · targets **.NET 10**

This project demonstrates the **State** design pattern in C#. Player controllers delegate their behaviour to battle state contexts, with both a single-active-state context and a multiple-active-state context.

## Quick start

```bash
git clone https://github.com/lncodes/csharp-design-patterns.git
cd csharp-design-patterns/behavioral/state
dotnet build src
dotnet test test
```

## What's inside

- [`src/Object/PlayerController.cs`](src/Object/PlayerController.cs)
- [`src/Object/PlayerOneController.cs`](src/Object/PlayerOneController.cs)
- [`src/Object/PlayerThreeController.cs`](src/Object/PlayerThreeController.cs)
- [`src/Object/PlayerTwoController.cs`](src/Object/PlayerTwoController.cs)
- [`src/Types/State Context/Multiple Active State Context/MultiBattleStateContext.cs`](src/Types/State%20Context/Multiple%20Active%20State%20Context/MultiBattleStateContext.cs)
- [`src/Types/State Context/Single Active State Context/AutoBattleStateContext.cs`](src/Types/State%20Context/Single%20Active%20State%20Context/AutoBattleStateContext.cs)
- [`src/Types/State Context/Single Active State Context/ManualBattleStateContext.cs`](src/Types/State%20Context/Single%20Active%20State%20Context/ManualBattleStateContext.cs)
- [`src/Types/State Context/Unique State Context Types/SingletonBattleStateContext.cs`](src/Types/State%20Context/Unique%20State%20Context%20Types/SingletonBattleStateContext.cs)
- [`src/Types/State/Auto Assign State/AutoBattleState.cs`](src/Types/State/Auto%20Assign%20State/AutoBattleState.cs)
- [`src/Types/State/Auto Assign State/PlayerOneAutoBattleState.cs`](src/Types/State/Auto%20Assign%20State/PlayerOneAutoBattleState.cs)
- [`src/Types/State/Auto Assign State/PlayerThreeAutoBattleState.cs`](src/Types/State/Auto%20Assign%20State/PlayerThreeAutoBattleState.cs)
- [`src/Types/State/Auto Assign State/PlayerTwoAutoBattleState.cs`](src/Types/State/Auto%20Assign%20State/PlayerTwoAutoBattleState.cs)
- [`src/Types/State/Manual Assign State/ManualBattleState.cs`](src/Types/State/Manual%20Assign%20State/ManualBattleState.cs)
- [`src/Types/State/Manual Assign State/PlayerOneManualBattleState.cs`](src/Types/State/Manual%20Assign%20State/PlayerOneManualBattleState.cs)
- [`src/Types/State/Manual Assign State/PlayerThreeManualBattleState.cs`](src/Types/State/Manual%20Assign%20State/PlayerThreeManualBattleState.cs)
- [`src/Types/State/Manual Assign State/PlayerTwoManualBattleState.cs`](src/Types/State/Manual%20Assign%20State/PlayerTwoManualBattleState.cs)

---

Questions? Use [Discussions](https://github.com/lncodes/csharp-design-patterns/discussions) · [Contributing](https://github.com/lncodes/.github/blob/main/CONTRIBUTING.md) · [MIT License](../../LICENSE)
