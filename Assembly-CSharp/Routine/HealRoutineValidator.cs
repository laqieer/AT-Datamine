// Decompiled with JetBrains decompiler
// Type: Routine.HealRoutineValidator
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
  [Token(Token = "0x200222A")]
  public class HealRoutineValidator : ActionRoutineValidator
  {
    [Token(Token = "0x17002D49")]
    private HealArg healArg
    {
      [Token(Token = "0x600D009"), Address(RVA = "0x4CD1670", Offset = "0x4CD1670", VA = "0x4CD1670")] get
      {
        return (HealArg) null;
      }
    }

    [Token(Token = "0x600D00A")]
    [Address(RVA = "0x4CD15BC", Offset = "0x4CD15BC", VA = "0x4CD15BC")]
    public HealRoutineValidator(
      UnitParameterData activator,
      MovableAreaSearcher movable,
      HealArg arg)
    {
    }

    [Token(Token = "0x600D00B")]
    [Address(RVA = "0x4CD16EC", Offset = "0x4CD16EC", VA = "0x4CD16EC", Slot = "5")]
    public override List<SkillParameterData> GetValidSkillParams(BoardData board)
    {
      return (List<SkillParameterData>) null;
    }

    [Token(Token = "0x600D00C")]
    [Address(RVA = "0x4CD1B48", Offset = "0x4CD1B48", VA = "0x4CD1B48", Slot = "4")]
    public override List<WeaponParameterData> GetValidWeaponParams(BoardData board)
    {
      return (List<WeaponParameterData>) null;
    }

    [Token(Token = "0x600D00D")]
    [Address(RVA = "0x4CD1DC4", Offset = "0x4CD1DC4", VA = "0x4CD1DC4", Slot = "6")]
    public override List<UnitParameterData> GetValidMainTargets(BoardData board)
    {
      return (List<UnitParameterData>) null;
    }

    [Token(Token = "0x600D00E")]
    [Address(RVA = "0x4CD2848", Offset = "0x4CD2848", VA = "0x4CD2848", Slot = "8")]
    protected virtual bool IsValidSkill(SkillParameterData skillParam) => new bool();
  }
}
