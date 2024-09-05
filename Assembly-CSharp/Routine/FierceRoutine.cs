// Decompiled with JetBrains decompiler
// Type: Routine.FierceRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Battle.Score;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002224")]
  public class FierceRoutine : ActionRoutine
  {
    [Token(Token = "0x400903C")]
    [FieldOffset(Offset = "0x60")]
    protected List<(int skillParamId, int targetId)> AttackableMap;

    [Token(Token = "0x17002D3E")]
    protected FierceArg Arg
    {
      [Token(Token = "0x600CFE1"), Address(RVA = "0x4CCEB1C", Offset = "0x4CCEB1C", VA = "0x4CCEB1C")] get
      {
        return (FierceArg) null;
      }
      [Token(Token = "0x600CFE2"), Address(RVA = "0x4CCEB24", Offset = "0x4CCEB24", VA = "0x4CCEB24")] set
      {
      }
    }

    [Token(Token = "0x17002D3F")]
    protected ActionRoutineValidator Validator
    {
      [Token(Token = "0x600CFE3"), Address(RVA = "0x4CCEB2C", Offset = "0x4CCEB2C", VA = "0x4CCEB2C")] get
      {
        return (ActionRoutineValidator) null;
      }
      [Token(Token = "0x600CFE4"), Address(RVA = "0x4CCEB34", Offset = "0x4CCEB34", VA = "0x4CCEB34")] set
      {
      }
    }

    [Token(Token = "0x17002D40")]
    protected WeakReference<SkillParameterData> ReserveSkillParamRef
    {
      [Token(Token = "0x600CFE5"), Address(RVA = "0x4CCEB3C", Offset = "0x4CCEB3C", VA = "0x4CCEB3C")] get
      {
        return (WeakReference<SkillParameterData>) null;
      }
      [Token(Token = "0x600CFE6"), Address(RVA = "0x4CCEB44", Offset = "0x4CCEB44", VA = "0x4CCEB44")] private set
      {
      }
    }

    [Token(Token = "0x600CFE7")]
    [Address(RVA = "0x4CCEB4C", Offset = "0x4CCEB4C", VA = "0x4CCEB4C", Slot = "4")]
    public override List<CommandScore> SimulateAction(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference)
    {
      return (List<CommandScore>) null;
    }

    [Token(Token = "0x600CFE8")]
    [Address(RVA = "0x4CCF070", Offset = "0x4CCF070", VA = "0x4CCF070", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600CFE9")]
    [Address(RVA = "0x4CCF820", Offset = "0x4CCF820", VA = "0x4CCF820", Slot = "6")]
    protected override void SetArg(int[] arg, int[] reference)
    {
    }

    [Token(Token = "0x600CFEA")]
    [Address(RVA = "0x4CCF890", Offset = "0x4CCF890", VA = "0x4CCF890", Slot = "7")]
    protected override void SetValidator(UnitParameterData activator)
    {
    }

    [Token(Token = "0x600CFEB")]
    [Address(RVA = "0x4CCF918", Offset = "0x4CCF918", VA = "0x4CCF918", Slot = "9")]
    protected override List<(int, int)> GetMoveGridList() => (List<(int, int)>) null;

    [Token(Token = "0x600CFEC")]
    [Address(RVA = "0x4CCF948", Offset = "0x4CCF948", VA = "0x4CCF948")]
    public FierceRoutine()
    {
    }
  }
}
