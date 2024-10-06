// Decompiled with JetBrains decompiler
// Type: Routine.MoveTargetRoutine
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
  [Token(Token = "0x200224F")]
  public class MoveTargetRoutine : MoveRoutine
  {
    [Token(Token = "0x4009095")]
    [FieldOffset(Offset = "0x60")]
    private List<GoalScoreFactory.GoalInfo> goals;

    [Token(Token = "0x600D08C")]
    [Address(RVA = "0x4CD9B68", Offset = "0x4CD9B68", VA = "0x4CD9B68", Slot = "4")]
    public override List<CommandScore> SimulateAction(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference)
    {
      return (List<CommandScore>) null;
    }

    [Token(Token = "0x600D08D")]
    [Address(RVA = "0x4CD9DC8", Offset = "0x4CD9DC8", VA = "0x4CD9DC8", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600D08E")]
    [Address(RVA = "0x4CDA0C8", Offset = "0x4CDA0C8", VA = "0x4CDA0C8")]
    private int GetDestDistance(int x, int y) => new int();

    [Token(Token = "0x600D08F")]
    [Address(RVA = "0x4CDA270", Offset = "0x4CDA270", VA = "0x4CDA270")]
    public MoveTargetRoutine()
    {
    }
  }
}
