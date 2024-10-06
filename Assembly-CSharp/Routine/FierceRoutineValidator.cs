// Decompiled with JetBrains decompiler
// Type: Routine.FierceRoutineValidator
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
  [Token(Token = "0x2002225")]
  public class FierceRoutineValidator : ActionRoutineValidator
  {
    [Token(Token = "0x17002D41")]
    private FierceArg fierceArg
    {
      [Token(Token = "0x600CFED"), Address(RVA = "0x4CCFA0C", Offset = "0x4CCFA0C", VA = "0x4CCFA0C")] get
      {
        return (FierceArg) null;
      }
    }

    [Token(Token = "0x600CFEE")]
    [Address(RVA = "0x4CCF910", Offset = "0x4CCF910", VA = "0x4CCF910")]
    public FierceRoutineValidator(
      UnitParameterData activator,
      MovableAreaSearcher movable,
      FierceArg fierceArg)
    {
    }

    [Token(Token = "0x600CFEF")]
    [Address(RVA = "0x4CCFA88", Offset = "0x4CCFA88", VA = "0x4CCFA88", Slot = "6")]
    public override List<UnitParameterData> GetValidMainTargets(BoardData board)
    {
      return (List<UnitParameterData>) null;
    }

    [Token(Token = "0x600CFF0")]
    [Address(RVA = "0x4CCFED4", Offset = "0x4CCFED4", VA = "0x4CCFED4", Slot = "5")]
    public override List<SkillParameterData> GetValidSkillParams(BoardData board)
    {
      return (List<SkillParameterData>) null;
    }

    [Token(Token = "0x600CFF1")]
    [Address(RVA = "0x4CD00E8", Offset = "0x4CD00E8", VA = "0x4CD00E8", Slot = "4")]
    public override List<WeaponParameterData> GetValidWeaponParams(BoardData board)
    {
      return (List<WeaponParameterData>) null;
    }

    [Token(Token = "0x600CFF2")]
    [Address(RVA = "0x4CD016C", Offset = "0x4CD016C", VA = "0x4CD016C", Slot = "8")]
    protected virtual bool IsValidSkill(SkillParameterData skillParam) => new bool();
  }
}
