// Decompiled with JetBrains decompiler
// Type: Routine.AttackRoutineValidator
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
  [Token(Token = "0x200221B")]
  public class AttackRoutineValidator : ActionRoutineValidator
  {
    [Token(Token = "0x17002D3B")]
    protected AttackArg AttackArg
    {
      [Token(Token = "0x600CFB8"), Address(RVA = "0x4CCC42C", Offset = "0x4CCC42C", VA = "0x4CCC42C")] get
      {
        return (AttackArg) null;
      }
    }

    [Token(Token = "0x600CFB9")]
    [Address(RVA = "0x4CCC3F4", Offset = "0x4CCC3F4", VA = "0x4CCC3F4")]
    public AttackRoutineValidator(
      UnitParameterData activator,
      MovableAreaSearcher movable,
      AttackArg attackArg)
    {
    }

    [Token(Token = "0x600CFBA")]
    [Address(RVA = "0x4CCC4A8", Offset = "0x4CCC4A8", VA = "0x4CCC4A8", Slot = "6")]
    public override List<UnitParameterData> GetValidMainTargets(BoardData board)
    {
      return (List<UnitParameterData>) null;
    }

    [Token(Token = "0x600CFBB")]
    [Address(RVA = "0x4CCD0B0", Offset = "0x4CCD0B0", VA = "0x4CCD0B0", Slot = "5")]
    public override List<SkillParameterData> GetValidSkillParams(BoardData board)
    {
      return (List<SkillParameterData>) null;
    }

    [Token(Token = "0x600CFBC")]
    [Address(RVA = "0x4CCD50C", Offset = "0x4CCD50C", VA = "0x4CCD50C", Slot = "8")]
    protected virtual bool IsValidSkill(SkillParameterData skillParam) => new bool();

    [Token(Token = "0x600CFBD")]
    [Address(RVA = "0x4CCD9CC", Offset = "0x4CCD9CC", VA = "0x4CCD9CC")]
    protected bool IsValidElement(SkillParameterData skillParam) => new bool();

    [Token(Token = "0x600CFBE")]
    [Address(RVA = "0x4CCDA8C", Offset = "0x4CCDA8C", VA = "0x4CCDA8C")]
    protected bool IsValidWeaponType(SkillParameterData skillParam) => new bool();

    [Token(Token = "0x600CFBF")]
    [Address(RVA = "0x4CCDDEC", Offset = "0x4CCDDEC", VA = "0x4CCDDEC")]
    protected bool IsValidWeaponClassification(SkillParameterData skillParam) => new bool();

    [Token(Token = "0x600CFC0")]
    [Address(RVA = "0x4CCE1D0", Offset = "0x4CCE1D0", VA = "0x4CCE1D0")]
    protected bool IsValidAttackType(SkillParameterData skillParam) => new bool();

    [Token(Token = "0x600CFC1")]
    [Address(RVA = "0x4CCD600", Offset = "0x4CCD600", VA = "0x4CCD600")]
    protected bool IsValidFiringRange(SkillParameterData skillParam) => new bool();

    [Token(Token = "0x600CFC2")]
    [Address(RVA = "0x4CCE298", Offset = "0x4CCE298", VA = "0x4CCE298", Slot = "4")]
    public override List<WeaponParameterData> GetValidWeaponParams(BoardData board)
    {
      return (List<WeaponParameterData>) null;
    }
  }
}
