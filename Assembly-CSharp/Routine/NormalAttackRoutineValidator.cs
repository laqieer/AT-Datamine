// Decompiled with JetBrains decompiler
// Type: Routine.NormalAttackRoutineValidator
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
  [Token(Token = "0x2002255")]
  public class NormalAttackRoutineValidator : AttackRoutineValidator
  {
    [Token(Token = "0x600D0A3")]
    [Address(RVA = "0x4CDB168", Offset = "0x4CDB168", VA = "0x4CDB168")]
    public NormalAttackRoutineValidator(
      UnitParameterData activator,
      MovableAreaSearcher movable,
      AttackArg arg)
    {
    }

    [Token(Token = "0x600D0A4")]
    [Address(RVA = "0x4CDB170", Offset = "0x4CDB170", VA = "0x4CDB170", Slot = "5")]
    public override List<SkillParameterData> GetValidSkillParams(BoardData board)
    {
      return (List<SkillParameterData>) null;
    }
  }
}
