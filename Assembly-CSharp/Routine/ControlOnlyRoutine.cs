// Decompiled with JetBrains decompiler
// Type: Routine.ControlOnlyRoutine
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
  [Token(Token = "0x2002221")]
  public class ControlOnlyRoutine : ActionRoutine
  {
    [Token(Token = "0x600CFD5")]
    [Address(RVA = "0x4CCE814", Offset = "0x4CCE814", VA = "0x4CCE814", Slot = "4")]
    public override List<CommandScore> SimulateAction(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference)
    {
      return (List<CommandScore>) null;
    }

    [Token(Token = "0x600CFD6")]
    [Address(RVA = "0x4CCE9A8", Offset = "0x4CCE9A8", VA = "0x4CCE9A8", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600CFD7")]
    [Address(RVA = "0x4CCE9E8", Offset = "0x4CCE9E8", VA = "0x4CCE9E8", Slot = "9")]
    protected override List<(int, int)> GetMoveGridList() => (List<(int, int)>) null;

    [Token(Token = "0x600CFD8")]
    [Address(RVA = "0x4CCEA28", Offset = "0x4CCEA28", VA = "0x4CCEA28", Slot = "6")]
    protected override void SetArg(int[] arg, int[] preference)
    {
    }

    [Token(Token = "0x600CFD9")]
    [Address(RVA = "0x4CCEA2C", Offset = "0x4CCEA2C", VA = "0x4CCEA2C", Slot = "7")]
    protected override void SetValidator(UnitParameterData activator)
    {
    }

    [Token(Token = "0x600CFDA")]
    [Address(RVA = "0x4CCEA6C", Offset = "0x4CCEA6C", VA = "0x4CCEA6C")]
    public ControlOnlyRoutine()
    {
    }
  }
}
