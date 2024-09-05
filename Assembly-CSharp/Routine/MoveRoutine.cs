// Decompiled with JetBrains decompiler
// Type: Routine.MoveRoutine
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
  [Token(Token = "0x200224D")]
  public class MoveRoutine : ActionRoutine
  {
    [Token(Token = "0x17002D5A")]
    protected MoveArg Arg
    {
      [Token(Token = "0x600D07E"), Address(RVA = "0x4CD94FC", Offset = "0x4CD94FC", VA = "0x4CD94FC")] get
      {
        return (MoveArg) null;
      }
      [Token(Token = "0x600D07F"), Address(RVA = "0x4CD9504", Offset = "0x4CD9504", VA = "0x4CD9504")] set
      {
      }
    }

    [Token(Token = "0x17002D5B")]
    protected MoveRoutineValidator Validator
    {
      [Token(Token = "0x600D080"), Address(RVA = "0x4CD950C", Offset = "0x4CD950C", VA = "0x4CD950C")] get
      {
        return (MoveRoutineValidator) null;
      }
      [Token(Token = "0x600D081"), Address(RVA = "0x4CD9514", Offset = "0x4CD9514", VA = "0x4CD9514")] set
      {
      }
    }

    [Token(Token = "0x600D082")]
    [Address(RVA = "0x4CD951C", Offset = "0x4CD951C", VA = "0x4CD951C", Slot = "4")]
    public override List<CommandScore> SimulateAction(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference)
    {
      return (List<CommandScore>) null;
    }

    [Token(Token = "0x600D083")]
    [Address(RVA = "0x4CD9954", Offset = "0x4CD9954", VA = "0x4CD9954", Slot = "9")]
    protected override List<(int, int)> GetMoveGridList() => (List<(int, int)>) null;

    [Token(Token = "0x600D084")]
    [Address(RVA = "0x4CD9984", Offset = "0x4CD9984", VA = "0x4CD9984", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600D085")]
    [Address(RVA = "0x4CD99B4", Offset = "0x4CD99B4", VA = "0x4CD99B4", Slot = "6")]
    protected override void SetArg(int[] arg, int[] preference)
    {
    }

    [Token(Token = "0x600D086")]
    [Address(RVA = "0x4CD9A20", Offset = "0x4CD9A20", VA = "0x4CD9A20", Slot = "7")]
    protected override void SetValidator(UnitParameterData activator)
    {
    }

    [Token(Token = "0x600D087")]
    [Address(RVA = "0x4CD9320", Offset = "0x4CD9320", VA = "0x4CD9320")]
    public MoveRoutine()
    {
    }
  }
}
