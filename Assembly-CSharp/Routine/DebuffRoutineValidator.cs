// Decompiled with JetBrains decompiler
// Type: Routine.DebuffRoutineValidator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.RouteSearch;
using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002242")]
  public class DebuffRoutineValidator : ModifierRoutineValidator
  {
    [Token(Token = "0x600D066")]
    [Address(RVA = "0x4CD49D0", Offset = "0x4CD49D0", VA = "0x4CD49D0")]
    public DebuffRoutineValidator(
      UnitParameterData activator,
      MovableAreaSearcher movable,
      ModifierArg arg)
    {
    }

    [Token(Token = "0x600D067")]
    [Address(RVA = "0x4CD733C", Offset = "0x4CD733C", VA = "0x4CD733C", Slot = "8")]
    protected override bool IsValidSkill(SkillParameterData skillParam) => new bool();
  }
}
