// Decompiled with JetBrains decompiler
// Type: Routine.ActionRoutineValidator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002210")]
  public abstract class ActionRoutineValidator
  {
    [Token(Token = "0x17002D2E")]
    protected UnitParameterData Activator
    {
      [Token(Token = "0x600CF7A"), Address(RVA = "0x4B6FDFC", Offset = "0x4B6FDFC", VA = "0x4B6FDFC")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600CF7B"), Address(RVA = "0x4B6FE04", Offset = "0x4B6FE04", VA = "0x4B6FE04")] set
      {
      }
    }

    [Token(Token = "0x17002D2F")]
    protected MovableAreaSearcher Movable
    {
      [Token(Token = "0x600CF7C"), Address(RVA = "0x4B6FE0C", Offset = "0x4B6FE0C", VA = "0x4B6FE0C")] get
      {
        return (MovableAreaSearcher) null;
      }
      [Token(Token = "0x600CF7D"), Address(RVA = "0x4B6FE14", Offset = "0x4B6FE14", VA = "0x4B6FE14")] set
      {
      }
    }

    [Token(Token = "0x17002D30")]
    protected ActionArg Arg
    {
      [Token(Token = "0x600CF7E"), Address(RVA = "0x4B6FE1C", Offset = "0x4B6FE1C", VA = "0x4B6FE1C")] get
      {
        return (ActionArg) null;
      }
      [Token(Token = "0x600CF7F"), Address(RVA = "0x4B6FE24", Offset = "0x4B6FE24", VA = "0x4B6FE24")] set
      {
      }
    }

    [Token(Token = "0x600CF80")]
    [Address(RVA = "0x4B6FE2C", Offset = "0x4B6FE2C", VA = "0x4B6FE2C")]
    public ActionRoutineValidator(
      UnitParameterData activator,
      MovableAreaSearcher movable,
      ActionArg arg)
    {
    }

    [Token(Token = "0x600CF81")]
    [Address(RVA = "0x4B6FE68", Offset = "0x4B6FE68", VA = "0x4B6FE68")]
    protected bool IsMatchUserOwned(
      BoardData board,
      UnitParameterData activator,
      UnitParameterData target)
    {
      return new bool();
    }

    [Token(Token = "0x600CF82")]
    [Address(RVA = "0x4B6FEA4", Offset = "0x4B6FEA4", VA = "0x4B6FEA4")]
    protected bool IsMatchGuestOwned(
      BoardData board,
      UnitParameterData activator,
      UnitParameterData target)
    {
      return new bool();
    }

    [Token(Token = "0x600CF83")]
    [Address(RVA = "0x4B6FEC4", Offset = "0x4B6FEC4", VA = "0x4B6FEC4")]
    protected bool IsMatchEnemyOwned(
      BoardData board,
      UnitParameterData activator,
      UnitParameterData target)
    {
      return new bool();
    }

    [Token(Token = "0x600CF84")]
    [Address(RVA = "0x4B6FEE4", Offset = "0x4B6FEE4", VA = "0x4B6FEE4")]
    protected bool IsMatchThirdOwned(
      BoardData board,
      UnitParameterData activator,
      UnitParameterData target)
    {
      return new bool();
    }

    [Token(Token = "0x600CF85")]
    public abstract List<WeaponParameterData> GetValidWeaponParams(BoardData board);

    [Token(Token = "0x600CF86")]
    public abstract List<SkillParameterData> GetValidSkillParams(BoardData board);

    [Token(Token = "0x600CF87")]
    public abstract List<UnitParameterData> GetValidMainTargets(BoardData board);

    [Token(Token = "0x600CF88")]
    [Address(RVA = "0x4B6FF04", Offset = "0x4B6FF04", VA = "0x4B6FF04", Slot = "7")]
    public virtual List<(int, int)> GetMoveGridList(BoardData board) => (List<(int, int)>) null;

    [Token(Token = "0x600CF89")]
    [Address(RVA = "0x4B70090", Offset = "0x4B70090", VA = "0x4B70090")]
    protected List<(int, int)> GetOccupiableList(BoardData board) => (List<(int, int)>) null;

    [Token(Token = "0x600CF8A")]
    [Address(RVA = "0x4B703F8", Offset = "0x4B703F8", VA = "0x4B703F8")]
    protected List<(int, int)> GetOccupiableListWithoutWarpOut(BoardData board)
    {
      return (List<(int, int)>) null;
    }
  }
}
