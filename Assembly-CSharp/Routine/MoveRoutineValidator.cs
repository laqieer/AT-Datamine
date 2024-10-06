// Decompiled with JetBrains decompiler
// Type: Routine.MoveRoutineValidator
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
  [Token(Token = "0x200224E")]
  public class MoveRoutineValidator : ActionRoutineValidator
  {
    [Token(Token = "0x600D088")]
    [Address(RVA = "0x4CD9AA0", Offset = "0x4CD9AA0", VA = "0x4CD9AA0")]
    public MoveRoutineValidator(
      UnitParameterData activator,
      MovableAreaSearcher movable,
      MoveArg arg)
    {
    }

    [Token(Token = "0x600D089")]
    [Address(RVA = "0x4CD9AA8", Offset = "0x4CD9AA8", VA = "0x4CD9AA8", Slot = "4")]
    public override List<WeaponParameterData> GetValidWeaponParams(BoardData board)
    {
      return (List<WeaponParameterData>) null;
    }

    [Token(Token = "0x600D08A")]
    [Address(RVA = "0x4CD9AE8", Offset = "0x4CD9AE8", VA = "0x4CD9AE8", Slot = "5")]
    public override List<SkillParameterData> GetValidSkillParams(BoardData board)
    {
      return (List<SkillParameterData>) null;
    }

    [Token(Token = "0x600D08B")]
    [Address(RVA = "0x4CD9B28", Offset = "0x4CD9B28", VA = "0x4CD9B28", Slot = "6")]
    public override List<UnitParameterData> GetValidMainTargets(BoardData board)
    {
      return (List<UnitParameterData>) null;
    }
  }
}
