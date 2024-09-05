// Decompiled with JetBrains decompiler
// Type: Routine.StratagemBarrierRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Battle.Score;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Routine
{
  [Token(Token = "0x200225A")]
  public class StratagemBarrierRoutine : StratagemRoutine
  {
    [Token(Token = "0x600D0B3")]
    [Address(RVA = "0x4CDBBB8", Offset = "0x4CDBBB8", VA = "0x4CDBBB8", Slot = "12")]
    protected override void ApplyRoutineCondition(BattleCore core, UnitParameterData activator)
    {
    }

    [Token(Token = "0x600D0B4")]
    [Address(RVA = "0x4CDBD40", Offset = "0x4CDBD40", VA = "0x4CDBD40", Slot = "10")]
    protected override IReadOnlyList<CommandScore> CreateCommandScores(
      UnitParameterData activator,
      GridData moveTarget,
      WeaponParameterData weaponParam,
      SkillParameterData skillParam,
      UnitParameterData mainTarget)
    {
      return (IReadOnlyList<CommandScore>) null;
    }

    [Token(Token = "0x600D0B5")]
    [Address(RVA = "0x4CDC438", Offset = "0x4CDC438", VA = "0x4CDC438")]
    public StratagemBarrierRoutine()
    {
    }
  }
}
