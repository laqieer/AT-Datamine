// Decompiled with JetBrains decompiler
// Type: Routine.AttackSkillRoutineValidator
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
  [Token(Token = "0x2002258")]
  public class AttackSkillRoutineValidator : AttackRoutineValidator
  {
    [Token(Token = "0x600D0AA")]
    [Address(RVA = "0x4CDB610", Offset = "0x4CDB610", VA = "0x4CDB610")]
    public AttackSkillRoutineValidator(
      UnitParameterData activator,
      MovableAreaSearcher movable,
      AttackArg attackArg)
    {
    }

    [Token(Token = "0x600D0AB")]
    [Address(RVA = "0x4CDB618", Offset = "0x4CDB618", VA = "0x4CDB618", Slot = "5")]
    public override List<SkillParameterData> GetValidSkillParams(BoardData board)
    {
      return (List<SkillParameterData>) null;
    }

    [Token(Token = "0x600D0AC")]
    [Address(RVA = "0x4CDB82C", Offset = "0x4CDB82C", VA = "0x4CDB82C", Slot = "8")]
    protected override bool IsValidSkill(SkillParameterData skillParam) => new bool();
  }
}
