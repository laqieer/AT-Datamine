// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Command.UnitCommandFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data;
using Battle.Data.Board;
using Battle.Process;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Expedition.Command
{
  [Token(Token = "0x20025DF")]
  public static class UnitCommandFactory
  {
    [Token(Token = "0x600EA05")]
    [Address(RVA = "0x4C4F350", Offset = "0x4C4F350", VA = "0x4C4F350")]
    public static Queue<UnitCommandBase> CreateStayCommandQueue(
      BattleCore core,
      UnitParameterData owner)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600EA06")]
    [Address(RVA = "0x4C4F428", Offset = "0x4C4F428", VA = "0x4C4F428")]
    public static Queue<UnitCommandBase> CreateStayCommandQueue(
      BattleCore core,
      UnitParameterData owner,
      GridData moveTo,
      MovableAreaSearcher movable,
      bool noMoveAnime = false)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600EA07")]
    [Address(RVA = "0x4C4F590", Offset = "0x4C4F590", VA = "0x4C4F590")]
    public static Queue<UnitCommandBase> CreateMoveStayCommandQueue(
      BattleCore core,
      UnitParameterData owner,
      GridData moveTo,
      MovableAreaSearcher movable)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600EA08")]
    [Address(RVA = "0x4C4F6EC", Offset = "0x4C4F6EC", VA = "0x4C4F6EC")]
    public static Queue<UnitCommandBase> CreateMoveCommandQueue(
      BattleCore core,
      UnitParameterData owner,
      GridData moveTo,
      MovableAreaSearcher movable,
      bool noMoveAnime = false)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600EA09")]
    [Address(RVA = "0x4C4F810", Offset = "0x4C4F810", VA = "0x4C4F810")]
    public static Queue<UnitCommandBase> CreateSkillCommandQueue(
      BattleCore core,
      UnitParameterData owner,
      GridData ownerGrid,
      GridData moveTo,
      MovableAreaSearcher movable,
      TargetPair mainTarget,
      Dictionary<int, List<TargetPair>> targetsByEffect,
      AttackableAreaSearcher attackable,
      AttackableAreaSearcher effectable,
      SkillParameterData skillParam,
      bool noMoveAnime = false)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600EA0A")]
    [Address(RVA = "0x4C4F9B4", Offset = "0x4C4F9B4", VA = "0x4C4F9B4")]
    private static UnitCommandBase CreateSkillCommand(
      BattleCore core,
      UnitParameterData owner,
      GridData ownerGrid,
      TargetPair mainTarget,
      Dictionary<int, List<TargetPair>> targetsByEffect,
      AttackableAreaSearcher attackable,
      AttackableAreaSearcher effectable,
      SkillParameterData skillParam)
    {
      return (UnitCommandBase) null;
    }

    [Token(Token = "0x600EA0B")]
    [Address(RVA = "0x4C4FB0C", Offset = "0x4C4FB0C", VA = "0x4C4FB0C")]
    private static UnitCommandBase CreateChargeSkillCommand(
      BattleCore core,
      UnitParameterData owner,
      GridData ownerGrid,
      TargetPair mainTarget,
      Dictionary<int, List<TargetPair>> targetsByEffect,
      AttackableAreaSearcher effectable,
      SkillParameterData skillParam)
    {
      return (UnitCommandBase) null;
    }

    [Token(Token = "0x600EA0C")]
    [Address(RVA = "0x4C4FC74", Offset = "0x4C4FC74", VA = "0x4C4FC74")]
    public static Queue<UnitCommandBase> CreateInteractCommandQueue(
      BattleCore core,
      UnitParameterData owner,
      GridData moveTo,
      MovableAreaSearcher movable,
      FacilityData target,
      GridData targetTo,
      bool noMoveAnime = false)
    {
      return (Queue<UnitCommandBase>) null;
    }
  }
}
