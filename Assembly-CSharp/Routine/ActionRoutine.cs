// Decompiled with JetBrains decompiler
// Type: Routine.ActionRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Battle.Data;
using Battle.Data.Board;
using Battle.Process;
using Battle.RouteSearch;
using Battle.Score;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

#nullable disable
namespace Routine
{
  [Token(Token = "0x200220E")]
  public abstract class ActionRoutine
  {
    [Token(Token = "0x4008FCE")]
    [FieldOffset(Offset = "0x10")]
    protected WeakReference<BattleCore> core;
    [Token(Token = "0x4008FD1")]
    [FieldOffset(Offset = "0x20")]
    protected MovableAreaSearcher Movable;
    [Token(Token = "0x4008FD2")]
    [FieldOffset(Offset = "0x28")]
    protected AttackableAreaSearcher attackable;
    [Token(Token = "0x4008FD3")]
    [FieldOffset(Offset = "0x30")]
    protected AttackableAreaSearcher effectiveAreaSearcher;
    [Token(Token = "0x4008FD4")]
    [FieldOffset(Offset = "0x38")]
    private Stopwatch stopwatch;
    [Token(Token = "0x4008FD5")]
    [FieldOffset(Offset = "0x40")]
    private StringBuilder builder;
    [Token(Token = "0x4008FD6")]
    [FieldOffset(Offset = "0x48")]
    private List<UnitParameterData> clonedUnits;

    [Token(Token = "0x17002D2A")]
    protected BattleCore Core
    {
      [Token(Token = "0x600CF63"), Address(RVA = "0x4B6D8F0", Offset = "0x4B6D8F0", VA = "0x4B6D8F0")] get
      {
        return (BattleCore) null;
      }
    }

    [Token(Token = "0x17002D2B")]
    protected BoardData CurrentBoard
    {
      [Token(Token = "0x600CF64"), Address(RVA = "0x4B6D950", Offset = "0x4B6D950", VA = "0x4B6D950")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x17002D2C")]
    protected int ActionUnitId
    {
      [Token(Token = "0x600CF65"), Address(RVA = "0x4B6D968", Offset = "0x4B6D968", VA = "0x4B6D968")] get
      {
        return new int();
      }
      [Token(Token = "0x600CF66"), Address(RVA = "0x4B6D970", Offset = "0x4B6D970", VA = "0x4B6D970")] set
      {
      }
    }

    [Token(Token = "0x17002D2D")]
    protected int RequiredHit
    {
      [Token(Token = "0x600CF67"), Address(RVA = "0x4B6D978", Offset = "0x4B6D978", VA = "0x4B6D978")] get
      {
        return new int();
      }
      [Token(Token = "0x600CF68"), Address(RVA = "0x4B6D980", Offset = "0x4B6D980", VA = "0x4B6D980")] set
      {
      }
    }

    [Token(Token = "0x600CF69")]
    public abstract List<CommandScore> SimulateAction(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference);

    [Token(Token = "0x600CF6A")]
    [Address(RVA = "0x4B6D988", Offset = "0x4B6D988", VA = "0x4B6D988", Slot = "5")]
    protected virtual void Initialize(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference)
    {
    }

    [Token(Token = "0x600CF6B")]
    protected abstract void SetArg(int[] arg, int[] preference);

    [Token(Token = "0x600CF6C")]
    protected abstract void SetValidator(UnitParameterData activator);

    [Token(Token = "0x600CF6D")]
    protected abstract bool Executable(UnitParameterData activator);

    [Token(Token = "0x600CF6E")]
    protected abstract List<(int, int)> GetMoveGridList();

    [Token(Token = "0x600CF6F")]
    [Address(RVA = "0x4B6DB24", Offset = "0x4B6DB24", VA = "0x4B6DB24", Slot = "10")]
    protected virtual IReadOnlyList<CommandScore> CreateCommandScores(
      UnitParameterData activator,
      GridData moveTarget,
      WeaponParameterData weaponParam,
      SkillParameterData skillParam,
      UnitParameterData mainTarget)
    {
      return (IReadOnlyList<CommandScore>) null;
    }

    [Token(Token = "0x600CF70")]
    [Address(RVA = "0x4B6FA08", Offset = "0x4B6FA08", VA = "0x4B6FA08", Slot = "11")]
    protected virtual bool IsMatchRequiredHit(
      UnitParameterData activator,
      WeaponParameterData weaponParam,
      SkillParameterData skillParam,
      UnitParameterData mainTarget)
    {
      return new bool();
    }

    [Token(Token = "0x600CF71")]
    [Address(RVA = "0x4B6FB54", Offset = "0x4B6FB54", VA = "0x4B6FB54", Slot = "12")]
    protected virtual void ApplyRoutineCondition(BattleCore core, UnitParameterData activator)
    {
    }

    [Token(Token = "0x600CF72")]
    [Address(RVA = "0x4B6FB58", Offset = "0x4B6FB58", VA = "0x4B6FB58")]
    protected bool IsWithoutSettingsSkill(AIParameterData aiParam, SkillParameterData skillParam)
    {
      return new bool();
    }

    [Token(Token = "0x600CF73")]
    [Address(RVA = "0x4B6F3D8", Offset = "0x4B6F3D8", VA = "0x4B6F3D8")]
    protected CommandScore CreateCommandScore(
      UnitParameterData actionUnit,
      WeaponParameterData weaponParam,
      UnitParameterData mainTarget,
      IReadOnlyList<TargetPair> targets,
      GridData castTo,
      SkillParameterData skillParam,
      GridData castFrom,
      SimulatorBase simulator,
      CommandScore.CommandScoreState state,
      SimulatorBase.ResultInfo result)
    {
      return (CommandScore) null;
    }

    [Token(Token = "0x600CF74")]
    [Address(RVA = "0x4B6FBAC", Offset = "0x4B6FBAC", VA = "0x4B6FBAC")]
    protected void Clear()
    {
    }

    [Token(Token = "0x600CF75")]
    [Address(RVA = "0x4B6FBD0", Offset = "0x4B6FBD0", VA = "0x4B6FBD0")]
    [Conditional("UNITY_EDITOR")]
    protected void StartStopwatch()
    {
    }

    [Token(Token = "0x600CF76")]
    [Address(RVA = "0x4B6FBEC", Offset = "0x4B6FBEC", VA = "0x4B6FBEC")]
    [Conditional("UNITY_EDITOR")]
    protected void DumpElapsed(string tag)
    {
    }

    [Token(Token = "0x600CF77")]
    [Address(RVA = "0x4B6FCE4", Offset = "0x4B6FCE4", VA = "0x4B6FCE4")]
    [Conditional("UNITY_EDITOR")]
    protected void ClearLog()
    {
    }

    [Token(Token = "0x600CF78")]
    [Address(RVA = "0x4B6FD00", Offset = "0x4B6FD00", VA = "0x4B6FD00")]
    public string GetElapsedLog() => (string) null;

    [Token(Token = "0x600CF79")]
    [Address(RVA = "0x4B6FD20", Offset = "0x4B6FD20", VA = "0x4B6FD20")]
    protected ActionRoutine()
    {
    }
  }
}
