// Decompiled with JetBrains decompiler
// Type: Routine.AttackPrevUnitRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002219")]
  public sealed class AttackPrevUnitRoutine : AttackRoutine
  {
    [Token(Token = "0x600CFAB")]
    [Address(RVA = "0x4CCB118", Offset = "0x4CCB118", VA = "0x4CCB118", Slot = "12")]
    protected override void ApplyRoutineCondition(BattleCore core, UnitParameterData activator)
    {
    }

    [Token(Token = "0x600CFAC")]
    [Address(RVA = "0x4CCB260", Offset = "0x4CCB260", VA = "0x4CCB260", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600CFAD")]
    [Address(RVA = "0x4CCBC64", Offset = "0x4CCBC64", VA = "0x4CCBC64")]
    public AttackPrevUnitRoutine()
    {
    }
  }
}
