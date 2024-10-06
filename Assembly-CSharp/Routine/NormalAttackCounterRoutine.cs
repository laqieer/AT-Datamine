// Decompiled with JetBrains decompiler
// Type: Routine.NormalAttackCounterRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002250")]
  public class NormalAttackCounterRoutine : NormalAttackRoutine
  {
    [Token(Token = "0x600D090")]
    [Address(RVA = "0x4CDA2EC", Offset = "0x4CDA2EC", VA = "0x4CDA2EC", Slot = "12")]
    protected override void ApplyRoutineCondition(BattleCore core, UnitParameterData activator)
    {
    }

    [Token(Token = "0x600D091")]
    [Address(RVA = "0x4CDA434", Offset = "0x4CDA434", VA = "0x4CDA434", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600D092")]
    [Address(RVA = "0x4CDA4BC", Offset = "0x4CDA4BC", VA = "0x4CDA4BC")]
    public NormalAttackCounterRoutine()
    {
    }
  }
}
