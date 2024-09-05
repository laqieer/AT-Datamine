// Decompiled with JetBrains decompiler
// Type: Routine.BuffRoutineValidator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.RouteSearch;
using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002241")]
  public class BuffRoutineValidator : ModifierRoutineValidator
  {
    [Token(Token = "0x600D064")]
    [Address(RVA = "0x4CD48C8", Offset = "0x4CD48C8", VA = "0x4CD48C8")]
    public BuffRoutineValidator(
      UnitParameterData activator,
      MovableAreaSearcher movable,
      ModifierArg arg)
    {
    }

    [Token(Token = "0x600D065")]
    [Address(RVA = "0x4CD7230", Offset = "0x4CD7230", VA = "0x4CD7230", Slot = "8")]
    protected override bool IsValidSkill(SkillParameterData skillParam) => new bool();
  }
}
