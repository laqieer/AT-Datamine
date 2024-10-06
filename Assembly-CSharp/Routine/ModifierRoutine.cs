// Decompiled with JetBrains decompiler
// Type: Routine.ModifierRoutine
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
  [Token(Token = "0x200223B")]
  public abstract class ModifierRoutine : ActionRoutine
  {
    [Token(Token = "0x400907A")]
    [FieldOffset(Offset = "0x60")]
    protected List<(int skillParamId, string weaponId, int targetId)> UsableMap;

    [Token(Token = "0x17002D53")]
    protected ModifierArg Arg
    {
      [Token(Token = "0x600D047"), Address(RVA = "0x4CD4B8C", Offset = "0x4CD4B8C", VA = "0x4CD4B8C")] get
      {
        return (ModifierArg) null;
      }
      [Token(Token = "0x600D048"), Address(RVA = "0x4CD4B94", Offset = "0x4CD4B94", VA = "0x4CD4B94")] set
      {
      }
    }

    [Token(Token = "0x17002D54")]
    protected ActionRoutineValidator Validator
    {
      [Token(Token = "0x600D049"), Address(RVA = "0x4CD4B9C", Offset = "0x4CD4B9C", VA = "0x4CD4B9C")] get
      {
        return (ActionRoutineValidator) null;
      }
      [Token(Token = "0x600D04A"), Address(RVA = "0x4CD4BA4", Offset = "0x4CD4BA4", VA = "0x4CD4BA4")] set
      {
      }
    }

    [Token(Token = "0x600D04B")]
    [Address(RVA = "0x4CD4BAC", Offset = "0x4CD4BAC", VA = "0x4CD4BAC", Slot = "4")]
    public override List<CommandScore> SimulateAction(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference)
    {
      return (List<CommandScore>) null;
    }

    [Token(Token = "0x600D04C")]
    [Address(RVA = "0x4CD520C", Offset = "0x4CD520C", VA = "0x4CD520C", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600D04D")]
    [Address(RVA = "0x4CD5D74", Offset = "0x4CD5D74", VA = "0x4CD5D74")]
    protected bool IsValidDuplicateSetting(SkillParameterData skillParam, UnitParameterData target)
    {
      return new bool();
    }

    [Token(Token = "0x600D04E")]
    [Address(RVA = "0x4CD5E90", Offset = "0x4CD5E90", VA = "0x4CD5E90", Slot = "6")]
    protected override void SetArg(int[] arg, int[] preference)
    {
    }

    [Token(Token = "0x600D04F")]
    [Address(RVA = "0x4CD5F00", Offset = "0x4CD5F00", VA = "0x4CD5F00", Slot = "7")]
    protected override void SetValidator(UnitParameterData activator)
    {
    }

    [Token(Token = "0x600D050")]
    [Address(RVA = "0x4CD5F88", Offset = "0x4CD5F88", VA = "0x4CD5F88", Slot = "9")]
    protected override List<(int, int)> GetMoveGridList() => (List<(int, int)>) null;

    [Token(Token = "0x600D051")]
    [Address(RVA = "0x4CD48D4", Offset = "0x4CD48D4", VA = "0x4CD48D4")]
    protected ModifierRoutine()
    {
    }
  }
}
