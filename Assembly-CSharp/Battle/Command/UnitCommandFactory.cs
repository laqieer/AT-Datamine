// Decompiled with JetBrains decompiler
// Type: Battle.Command.UnitCommandFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Process;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024B9")]
  public static class UnitCommandFactory
  {
    [Token(Token = "0x600E1E4")]
    [Address(RVA = "0x42630C4", Offset = "0x42630C4", VA = "0x42630C4")]
    public static Queue<UnitCommandBase> CreateStayCommandQueue(
      BattleCore core,
      UnitParameterData owner)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600E1E5")]
    [Address(RVA = "0x4263198", Offset = "0x4263198", VA = "0x4263198")]
    public static Queue<UnitCommandBase> CreateStayCommandQueue(
      BattleCore core,
      UnitParameterData owner,
      GridData moveTo,
      MovableAreaSearcher movable,
      bool needSwitchDouble = false,
      bool noMoveAnime = false)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600E1E6")]
    [Address(RVA = "0x4263358", Offset = "0x4263358", VA = "0x4263358")]
    public static Queue<UnitCommandBase> CreateMoveCommandQueue(
      BattleCore core,
      UnitParameterData owner,
      GridData moveTo,
      MovableAreaSearcher movable,
      bool needSwitchDouble = false,
      bool noMoveAnime = false)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600E1E7")]
    [Address(RVA = "0x42634D8", Offset = "0x42634D8", VA = "0x42634D8")]
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
      bool needSwitchDouble = false,
      bool noMoveAnime = false)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600E1E8")]
    [Address(RVA = "0x42637F4", Offset = "0x42637F4", VA = "0x42637F4")]
    public static Queue<UnitCommandBase> CreateReserveFierceCommandQueue(
      BattleCore core,
      UnitParameterData owner,
      SkillParameterData skillParam,
      GridData castTo)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600E1E9")]
    [Address(RVA = "0x42638E0", Offset = "0x42638E0", VA = "0x42638E0")]
    public static Queue<UnitCommandBase> CreateDoubleCommandQueue(
      BattleCore core,
      UnitParameterData owner,
      GridData moveTo,
      MovableAreaSearcher movable,
      UnitParameterData target,
      GridData targetTo,
      bool noMoveAnime = false)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600E1EA")]
    [Address(RVA = "0x4263A5C", Offset = "0x4263A5C", VA = "0x4263A5C")]
    public static Queue<UnitCommandBase> CreateReleaseDoubleCommandQueue(
      BattleCore core,
      UnitParameterData owner,
      GridData moveTo,
      MovableAreaSearcher movable,
      GridData targetGrid,
      bool needSwitchDouble,
      bool noMoveAnime = false)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600E1EB")]
    [Address(RVA = "0x4263C28", Offset = "0x4263C28", VA = "0x4263C28")]
    public static Queue<UnitCommandBase> CreateInteractCommandQueue(
      BattleCore core,
      UnitParameterData owner,
      GridData moveTo,
      MovableAreaSearcher movable,
      FacilityData target,
      GridData targetTo,
      bool needSwitchDouble = false,
      bool noMoveAnime = false)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600E1EC")]
    [Address(RVA = "0x4263E08", Offset = "0x4263E08", VA = "0x4263E08")]
    public static Queue<UnitCommandBase> CreateItemCommandQueue(
      BattleCore core,
      BattlePlayerData itemUser,
      IReadOnlyList<TargetPair> targets,
      GridData castTo,
      AttackableAreaSearcher effective,
      ItemParameterData itemParam)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600E1ED")]
    [Address(RVA = "0x426409C", Offset = "0x426409C", VA = "0x426409C")]
    public static DummyMoveCommand CreateDummyMoveCommand(
      BattleCore core,
      UnitParameterData owner,
      GridData moveFrom,
      GridData moveTo,
      MovableAreaSearcher orgSeacher,
      bool noMoveAnime = false)
    {
      return (DummyMoveCommand) null;
    }

    [Token(Token = "0x600E1EE")]
    [Address(RVA = "0x4264158", Offset = "0x4264158", VA = "0x4264158")]
    public static UnitCommandBase CreateDummySwitchDoubleCommand(
      BattleCore core,
      UnitParameterData owner)
    {
      return (UnitCommandBase) null;
    }

    [Token(Token = "0x600E1EF")]
    [Address(RVA = "0x42641D4", Offset = "0x42641D4", VA = "0x42641D4")]
    public static Queue<UnitCommandBase> CreateFromCommandLog(
      BattleCore core,
      UnitCommandLog commandLog)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Token(Token = "0x600E1F0")]
    [Address(RVA = "0x4264FD4", Offset = "0x4264FD4", VA = "0x4264FD4")]
    private static void AddChargeCommand(
      Queue<UnitCommandBase> queue,
      BattleCore core,
      UnitParameterData owner,
      SkillParameterData chargeSkill,
      GridData castTo)
    {
    }

    [Token(Token = "0x600E1F1")]
    [Address(RVA = "0x42636D0", Offset = "0x42636D0", VA = "0x42636D0")]
    private static UnitCommandBase CreateSkillCommand(
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

    [Token(Token = "0x600E1F2")]
    [Address(RVA = "0x4265098", Offset = "0x4265098", VA = "0x4265098")]
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
  }
}
