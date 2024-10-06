// Decompiled with JetBrains decompiler
// Type: Routine.StratagemRoutineValidator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.RouteSearch;
using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x200225C")]
  public class StratagemRoutineValidator : AttackSkillRoutineValidator
  {
    [Token(Token = "0x600D0BA")]
    [Address(RVA = "0x4CDC57C", Offset = "0x4CDC57C", VA = "0x4CDC57C")]
    public StratagemRoutineValidator(
      UnitParameterData activator,
      MovableAreaSearcher movable,
      AttackArg attackArg)
    {
    }

    [Token(Token = "0x600D0BB")]
    [Address(RVA = "0x4CDC584", Offset = "0x4CDC584", VA = "0x4CDC584", Slot = "8")]
    protected override bool IsValidSkill(SkillParameterData skillParam) => new bool();
  }
}
