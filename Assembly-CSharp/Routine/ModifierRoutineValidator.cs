// Decompiled with JetBrains decompiler
// Type: Routine.ModifierRoutineValidator
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
  [Token(Token = "0x200223C")]
  public class ModifierRoutineValidator : ActionRoutineValidator
  {
    [Token(Token = "0x17002D55")]
    protected ModifierArg ModifierArg
    {
      [Token(Token = "0x600D052"), Address(RVA = "0x4CD5FB8", Offset = "0x4CD5FB8", VA = "0x4CD5FB8")] get
      {
        return (ModifierArg) null;
      }
    }

    [Token(Token = "0x600D053")]
    [Address(RVA = "0x4CD5F80", Offset = "0x4CD5F80", VA = "0x4CD5F80")]
    public ModifierRoutineValidator(
      UnitParameterData activator,
      MovableAreaSearcher movable,
      ModifierArg arg)
    {
    }

    [Token(Token = "0x600D054")]
    [Address(RVA = "0x4CD6034", Offset = "0x4CD6034", VA = "0x4CD6034", Slot = "6")]
    public override List<UnitParameterData> GetValidMainTargets(BoardData board)
    {
      return (List<UnitParameterData>) null;
    }

    [Token(Token = "0x600D055")]
    [Address(RVA = "0x4CD6C3C", Offset = "0x4CD6C3C", VA = "0x4CD6C3C", Slot = "5")]
    public override List<SkillParameterData> GetValidSkillParams(BoardData board)
    {
      return (List<SkillParameterData>) null;
    }

    [Token(Token = "0x600D056")]
    [Address(RVA = "0x4CD6E50", Offset = "0x4CD6E50", VA = "0x4CD6E50", Slot = "8")]
    protected virtual bool IsValidSkill(SkillParameterData skillParam) => new bool();

    [Token(Token = "0x600D057")]
    [Address(RVA = "0x4CD6F4C", Offset = "0x4CD6F4C", VA = "0x4CD6F4C", Slot = "4")]
    public override List<WeaponParameterData> GetValidWeaponParams(BoardData board)
    {
      return (List<WeaponParameterData>) null;
    }
  }
}
