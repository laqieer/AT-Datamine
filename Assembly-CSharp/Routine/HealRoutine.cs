// Decompiled with JetBrains decompiler
// Type: Routine.HealRoutine
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
  [Token(Token = "0x2002229")]
  public class HealRoutine : ActionRoutine
  {
    [Token(Token = "0x4009050")]
    [FieldOffset(Offset = "0x60")]
    protected List<(int skillParamId, string weaponId, int targetId)> HealableMap;

    [Token(Token = "0x17002D47")]
    protected HealArg Arg
    {
      [Token(Token = "0x600CFFF"), Address(RVA = "0x4CD041C", Offset = "0x4CD041C", VA = "0x4CD041C")] get
      {
        return (HealArg) null;
      }
      [Token(Token = "0x600D000"), Address(RVA = "0x4CD0424", Offset = "0x4CD0424", VA = "0x4CD0424")] set
      {
      }
    }

    [Token(Token = "0x17002D48")]
    protected ActionRoutineValidator Validator
    {
      [Token(Token = "0x600D001"), Address(RVA = "0x4CD042C", Offset = "0x4CD042C", VA = "0x4CD042C")] get
      {
        return (ActionRoutineValidator) null;
      }
      [Token(Token = "0x600D002"), Address(RVA = "0x4CD0434", Offset = "0x4CD0434", VA = "0x4CD0434")] set
      {
      }
    }

    [Token(Token = "0x600D003")]
    [Address(RVA = "0x4CD043C", Offset = "0x4CD043C", VA = "0x4CD043C", Slot = "4")]
    public override List<CommandScore> SimulateAction(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference)
    {
      return (List<CommandScore>) null;
    }

    [Token(Token = "0x600D004")]
    [Address(RVA = "0x4CD0AB8", Offset = "0x4CD0AB8", VA = "0x4CD0AB8", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600D005")]
    [Address(RVA = "0x4CD14C4", Offset = "0x4CD14C4", VA = "0x4CD14C4", Slot = "6")]
    protected override void SetArg(int[] arg, int[] preference)
    {
    }

    [Token(Token = "0x600D006")]
    [Address(RVA = "0x4CD153C", Offset = "0x4CD153C", VA = "0x4CD153C", Slot = "7")]
    protected override void SetValidator(UnitParameterData activator)
    {
    }

    [Token(Token = "0x600D007")]
    [Address(RVA = "0x4CD15C4", Offset = "0x4CD15C4", VA = "0x4CD15C4", Slot = "9")]
    protected override List<(int, int)> GetMoveGridList() => (List<(int, int)>) null;

    [Token(Token = "0x600D008")]
    [Address(RVA = "0x4CD15F4", Offset = "0x4CD15F4", VA = "0x4CD15F4")]
    public HealRoutine()
    {
    }
  }
}
