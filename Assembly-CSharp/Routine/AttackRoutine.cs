// Decompiled with JetBrains decompiler
// Type: Routine.AttackRoutine
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
  [Token(Token = "0x200221A")]
  public class AttackRoutine : ActionRoutine
  {
    [Token(Token = "0x4009028")]
    [FieldOffset(Offset = "0x60")]
    protected HashSet<(int skillParamId, string weaponId, int targetId)> AttackableMap;

    [Token(Token = "0x17002D39")]
    protected AttackArg Arg
    {
      [Token(Token = "0x600CFAE"), Address(RVA = "0x4CCBC68", Offset = "0x4CCBC68", VA = "0x4CCBC68")] get
      {
        return (AttackArg) null;
      }
      [Token(Token = "0x600CFAF"), Address(RVA = "0x4CCBC70", Offset = "0x4CCBC70", VA = "0x4CCBC70")] set
      {
      }
    }

    [Token(Token = "0x17002D3A")]
    protected ActionRoutineValidator Validator
    {
      [Token(Token = "0x600CFB0"), Address(RVA = "0x4CCBC78", Offset = "0x4CCBC78", VA = "0x4CCBC78")] get
      {
        return (ActionRoutineValidator) null;
      }
      [Token(Token = "0x600CFB1"), Address(RVA = "0x4CCBC80", Offset = "0x4CCBC80", VA = "0x4CCBC80")] set
      {
      }
    }

    [Token(Token = "0x600CFB2")]
    [Address(RVA = "0x4CCBC88", Offset = "0x4CCBC88", VA = "0x4CCBC88", Slot = "4")]
    public override List<CommandScore> SimulateAction(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference)
    {
      return (List<CommandScore>) null;
    }

    [Token(Token = "0x600CFB3")]
    [Address(RVA = "0x4CCB2E8", Offset = "0x4CCB2E8", VA = "0x4CCB2E8", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600CFB4")]
    [Address(RVA = "0x4CCC304", Offset = "0x4CCC304", VA = "0x4CCC304", Slot = "6")]
    protected override void SetArg(int[] arg, int[] preference)
    {
    }

    [Token(Token = "0x600CFB5")]
    [Address(RVA = "0x4CCC374", Offset = "0x4CCC374", VA = "0x4CCC374", Slot = "7")]
    protected override void SetValidator(UnitParameterData activator)
    {
    }

    [Token(Token = "0x600CFB6")]
    [Address(RVA = "0x4CCC3FC", Offset = "0x4CCC3FC", VA = "0x4CCC3FC", Slot = "9")]
    protected override List<(int, int)> GetMoveGridList() => (List<(int, int)>) null;

    [Token(Token = "0x600CFB7")]
    [Address(RVA = "0x4CCAA98", Offset = "0x4CCAA98", VA = "0x4CCAA98")]
    public AttackRoutine()
    {
    }
  }
}
