// Decompiled with JetBrains decompiler
// Type: Battle.Logic.ActionLogicBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.DuelScene;
using Battle.Process;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic
{
  [Token(Token = "0x20024CD")]
  public abstract class ActionLogicBase
  {
    [Token(Token = "0x4009DD9")]
    [FieldOffset(Offset = "0x0")]
    public static readonly List<UnitParameterData> EmptySupporters;
    [Token(Token = "0x4009DDA")]
    [FieldOffset(Offset = "0xA0")]
    protected Dictionary<(UnitParameterData unit, int index), BarrierDamageLogic> reserveBarrierDamageDic;

    [Token(Token = "0x1700307D")]
    public ActionContext Context
    {
      [Token(Token = "0x600E26B"), Address(RVA = "0x4017B6C", Offset = "0x4017B6C", VA = "0x4017B6C")] get
      {
        return new ActionContext();
      }
      [Token(Token = "0x600E26C"), Address(RVA = "0x4017B7C", Offset = "0x4017B7C", VA = "0x4017B7C")] protected set
      {
      }
    }

    [Token(Token = "0x1700307E")]
    public Team ActivatorTeam
    {
      [Token(Token = "0x600E26D"), Address(RVA = "0x4017B94", Offset = "0x4017B94", VA = "0x4017B94")] get
      {
        return (Team) null;
      }
      [Token(Token = "0x600E26E"), Address(RVA = "0x4017B9C", Offset = "0x4017B9C", VA = "0x4017B9C")] protected set
      {
      }
    }

    [Token(Token = "0x1700307F")]
    public TargetPair MainTarget
    {
      [Token(Token = "0x600E26F"), Address(RVA = "0x4017BA4", Offset = "0x4017BA4", VA = "0x4017BA4")] get
      {
        return (TargetPair) null;
      }
      [Token(Token = "0x600E270"), Address(RVA = "0x4017BAC", Offset = "0x4017BAC", VA = "0x4017BAC")] protected set
      {
      }
    }

    [Token(Token = "0x17003080")]
    public List<TargetPair> Targets
    {
      [Token(Token = "0x600E271"), Address(RVA = "0x4017BB4", Offset = "0x4017BB4", VA = "0x4017BB4")] get
      {
        return (List<TargetPair>) null;
      }
      [Token(Token = "0x600E272"), Address(RVA = "0x4017BBC", Offset = "0x4017BBC", VA = "0x4017BBC")] protected set
      {
      }
    }

    [Token(Token = "0x17003081")]
    protected BattleTaskManager TaskManager
    {
      [Token(Token = "0x600E273"), Address(RVA = "0x4017BC4", Offset = "0x4017BC4", VA = "0x4017BC4")] get
      {
        return (BattleTaskManager) null;
      }
      [Token(Token = "0x600E274"), Address(RVA = "0x4017BCC", Offset = "0x4017BCC", VA = "0x4017BCC")] set
      {
      }
    }

    [Token(Token = "0x17003082")]
    protected DuelData Result
    {
      [Token(Token = "0x600E275"), Address(RVA = "0x4017BD4", Offset = "0x4017BD4", VA = "0x4017BD4")] get
      {
        return (DuelData) null;
      }
      [Token(Token = "0x600E276"), Address(RVA = "0x4017BDC", Offset = "0x4017BDC", VA = "0x4017BDC")] set
      {
      }
    }

    [Token(Token = "0x17003083")]
    public IReadOnlyDictionary<(UnitParameterData unit, int index), BarrierDamageLogic> ReserveBarrierDamageDic
    {
      [Token(Token = "0x600E277"), Address(RVA = "0x4017BE4", Offset = "0x4017BE4", VA = "0x4017BE4")] get
      {
        return (IReadOnlyDictionary<(UnitParameterData, int), BarrierDamageLogic>) null;
      }
    }

    [Token(Token = "0x600E278")]
    public abstract DuelData Execute();

    [Token(Token = "0x600E279")]
    public abstract DuelData ExecutePreEffect();

    [Token(Token = "0x600E27A")]
    public abstract DuelData ExecutePostEffect();

    [Token(Token = "0x600E27B")]
    [Address(RVA = "0x4017BEC", Offset = "0x4017BEC", VA = "0x4017BEC", Slot = "7")]
    protected virtual void SolveActiveSkillLogic(ActiveSkillLogic logic)
    {
    }

    [Token(Token = "0x600E27C")]
    [Address(RVA = "0x4018610", Offset = "0x4018610", VA = "0x4018610")]
    protected bool IsExecutableUnit(UnitParameterData activator, UnitParameterData target)
    {
      return new bool();
    }

    [Token(Token = "0x600E27D")]
    [Address(RVA = "0x401879C", Offset = "0x401879C", VA = "0x401879C")]
    protected bool IsExecutableSkill(
      SkillTriggerTimingTypeEnum timing,
      TargetPair activator,
      TargetPair target,
      SkillParameterData activeSkillParam)
    {
      return new bool();
    }

    [Token(Token = "0x600E27E")]
    [Address(RVA = "0x40189FC", Offset = "0x40189FC", VA = "0x40189FC")]
    protected bool IsExecutableAction(
      SkillTriggerTimingTypeEnum timing,
      TargetPair activator,
      TargetPair target,
      SkillParameterData activeSkillParam)
    {
      return new bool();
    }

    [Token(Token = "0x600E27F")]
    [Address(RVA = "0x4018190", Offset = "0x4018190", VA = "0x4018190")]
    protected void CollectReserveBarrierDamage(ActiveSkillLogic logic)
    {
    }

    [Token(Token = "0x600E280")]
    [Address(RVA = "0x4018594", Offset = "0x4018594", VA = "0x4018594")]
    protected void CollectSupportCount(ActionData action)
    {
    }

    [Token(Token = "0x600E281")]
    [Address(RVA = "0x4018AF8", Offset = "0x4018AF8", VA = "0x4018AF8")]
    protected void CountUpSupport(UnitParameterData mainUnit, SkillParameterData supportSkill)
    {
    }

    [Token(Token = "0x600E282")]
    [Address(RVA = "0x4018DF0", Offset = "0x4018DF0", VA = "0x4018DF0")]
    protected ActionLogicBase()
    {
    }

    [Token(Token = "0x600E283")]
    [Address(RVA = "0x4018E9C", Offset = "0x4018E9C", VA = "0x4018E9C")]
    static ActionLogicBase()
    {
    }
  }
}
