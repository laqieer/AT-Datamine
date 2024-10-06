// Decompiled with JetBrains decompiler
// Type: Routine.AttackSkillPrevUnitRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002256")]
  public sealed class AttackSkillPrevUnitRoutine : AttackSkillRoutine
  {
    [Token(Token = "0x600D0A5")]
    [Address(RVA = "0x4CDB3B8", Offset = "0x4CDB3B8", VA = "0x4CDB3B8", Slot = "12")]
    protected override void ApplyRoutineCondition(BattleCore core, UnitParameterData activator)
    {
    }

    [Token(Token = "0x600D0A6")]
    [Address(RVA = "0x4CDB500", Offset = "0x4CDB500", VA = "0x4CDB500", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600D0A7")]
    [Address(RVA = "0x4CDB588", Offset = "0x4CDB588", VA = "0x4CDB588")]
    public AttackSkillPrevUnitRoutine()
    {
    }
  }
}
