// Decompiled with JetBrains decompiler
// Type: Routine.StayRoutine
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
  [Token(Token = "0x2002259")]
  public class StayRoutine : ActionRoutine
  {
    [Token(Token = "0x600D0AD")]
    [Address(RVA = "0x4CDB924", Offset = "0x4CDB924", VA = "0x4CDB924", Slot = "4")]
    public override List<CommandScore> SimulateAction(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference)
    {
      return (List<CommandScore>) null;
    }

    [Token(Token = "0x600D0AE")]
    [Address(RVA = "0x4CDBB48", Offset = "0x4CDBB48", VA = "0x4CDBB48", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600D0AF")]
    [Address(RVA = "0x4CDBB68", Offset = "0x4CDBB68", VA = "0x4CDBB68", Slot = "9")]
    protected override List<(int, int)> GetMoveGridList() => (List<(int, int)>) null;

    [Token(Token = "0x600D0B0")]
    [Address(RVA = "0x4CDBBA8", Offset = "0x4CDBBA8", VA = "0x4CDBBA8", Slot = "6")]
    protected override void SetArg(int[] arg, int[] preference)
    {
    }

    [Token(Token = "0x600D0B1")]
    [Address(RVA = "0x4CDBBAC", Offset = "0x4CDBBAC", VA = "0x4CDBBAC", Slot = "7")]
    protected override void SetValidator(UnitParameterData activator)
    {
    }

    [Token(Token = "0x600D0B2")]
    [Address(RVA = "0x4CDBBB0", Offset = "0x4CDBBB0", VA = "0x4CDBBB0")]
    public StayRoutine()
    {
    }
  }
}
