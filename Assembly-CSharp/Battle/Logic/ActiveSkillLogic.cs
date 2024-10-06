// Decompiled with JetBrains decompiler
// Type: Battle.Logic.ActiveSkillLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.DuelScene;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic
{
  [Token(Token = "0x20024CE")]
  public class ActiveSkillLogic : ActiveSkillLogicBase
  {
    [Token(Token = "0x4009DDD")]
    [FieldOffset(Offset = "0xC8")]
    protected IReadOnlyList<EffectData> ActiveEffects;
    [Token(Token = "0x4009DE0")]
    [FieldOffset(Offset = "0xE0")]
    protected UnitParameterChange initializedUnitParamChange;
    [Token(Token = "0x4009DE1")]
    [FieldOffset(Offset = "0xE8")]
    protected List<TargetPair> subTargets;

    [Token(Token = "0x600E284")]
    [Address(RVA = "0x4018F28", Offset = "0x4018F28", VA = "0x4018F28")]
    public static ActiveSkillLogic CreateMainEffect(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets)
    {
      return (ActiveSkillLogic) null;
    }

    [Token(Token = "0x600E285")]
    [Address(RVA = "0x40193F4", Offset = "0x40193F4", VA = "0x40193F4")]
    public static ActiveSkillLogic CreatePreEffect(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets)
    {
      return (ActiveSkillLogic) null;
    }

    [Token(Token = "0x600E286")]
    [Address(RVA = "0x40195B8", Offset = "0x40195B8", VA = "0x40195B8")]
    public static ActiveSkillLogic CreatePostEffect(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets)
    {
      return (ActiveSkillLogic) null;
    }

    [Token(Token = "0x17003084")]
    protected ActionContext Context
    {
      [Token(Token = "0x600E287"), Address(RVA = "0x401977C", Offset = "0x401977C", VA = "0x401977C")] get
      {
        return new ActionContext();
      }
      [Token(Token = "0x600E288"), Address(RVA = "0x401978C", Offset = "0x401978C", VA = "0x401978C")] private set
      {
      }
    }

    [Token(Token = "0x17003085")]
    protected BoardData Board
    {
      [Token(Token = "0x600E289"), Address(RVA = "0x40197A4", Offset = "0x40197A4", VA = "0x40197A4")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x17003086")]
    public TargetPair ActionUnitPair
    {
      [Token(Token = "0x600E28A"), Address(RVA = "0x40197AC", Offset = "0x40197AC", VA = "0x40197AC")] get
      {
        return (TargetPair) null;
      }
      [Token(Token = "0x600E28B"), Address(RVA = "0x40197B4", Offset = "0x40197B4", VA = "0x40197B4")] private set
      {
      }
    }

    [Token(Token = "0x17003087")]
    public WeaponParameterData UsingWeaponParam
    {
      [Token(Token = "0x600E28C"), Address(RVA = "0x40197BC", Offset = "0x40197BC", VA = "0x40197BC")] get
      {
        return (WeaponParameterData) null;
      }
      [Token(Token = "0x600E28D"), Address(RVA = "0x40197C4", Offset = "0x40197C4", VA = "0x40197C4")] private set
      {
      }
    }

    [Token(Token = "0x17003088")]
    public HashSet<TargetPair> Targets
    {
      [Token(Token = "0x600E28E"), Address(RVA = "0x40197CC", Offset = "0x40197CC", VA = "0x40197CC")] get
      {
        return (HashSet<TargetPair>) null;
      }
      [Token(Token = "0x600E28F"), Address(RVA = "0x40197D4", Offset = "0x40197D4", VA = "0x40197D4")] private set
      {
      }
    }

    [Token(Token = "0x17003089")]
    public bool AnyHit
    {
      [Token(Token = "0x600E290"), Address(RVA = "0x40197DC", Offset = "0x40197DC", VA = "0x40197DC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E291"), Address(RVA = "0x40197E4", Offset = "0x40197E4", VA = "0x40197E4")] protected set
      {
      }
    }

    [Token(Token = "0x600E292")]
    [Address(RVA = "0x40190EC", Offset = "0x40190EC", VA = "0x40190EC")]
    protected ActiveSkillLogic(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets)
    {
    }

    [Token(Token = "0x600E293")]
    [Address(RVA = "0x4019994", Offset = "0x4019994", VA = "0x4019994", Slot = "4")]
    public override IReadOnlyList<ActionData> Execute() => (IReadOnlyList<ActionData>) null;

    [Token(Token = "0x600E294")]
    [Address(RVA = "0x4019B7C", Offset = "0x4019B7C", VA = "0x4019B7C")]
    protected void CollectEffectiveTargets()
    {
    }

    [Token(Token = "0x600E295")]
    [Address(RVA = "0x401A660", Offset = "0x401A660", VA = "0x401A660", Slot = "5")]
    protected virtual bool ApplyActiveSkill(TargetPair targetPair) => new bool();

    [Token(Token = "0x600E296")]
    [Address(RVA = "0x401B25C", Offset = "0x401B25C", VA = "0x401B25C")]
    protected EffectLogic.EffectLogicOutputParam ApplyEffect(
      ICorrectableParameter<IBattleParameter> actionBattleParam,
      TargetPair targetPair,
      ICorrectableParameter<IBattleParameter> targetBattleParam,
      List<EffectData> supportGuardEffects,
      EffectData effect,
      ActiveSkillLogicBase.HitResult hitResult,
      ref UnitParameterChange activatorParamChange,
      ref UnitParameterChange targetUnitParamChange,
      out bool isCritical,
      ref bool isPutOperationEndure,
      ref EffectParameterData burnedParam)
    {
      return (EffectLogic.EffectLogicOutputParam) null;
    }

    [Token(Token = "0x600E297")]
    [Address(RVA = "0x401B700", Offset = "0x401B700", VA = "0x401B700")]
    protected EffectLogic.EffectLogicOutputParam ApplyEffectInternal(
      ICorrectableParameter<IBattleParameter> actionBattleParam,
      TargetPair targetPair,
      ICorrectableParameter<IBattleParameter> targetBattleParam,
      List<EffectData> supportGuardEffects,
      EffectData effect,
      ref UnitParameterChange activatorParamChange,
      ref UnitParameterChange targetUnitParamChange,
      out bool isCritical,
      ref bool isPutOperationEndure,
      ref EffectParameterData burnedParam)
    {
      return (EffectLogic.EffectLogicOutputParam) null;
    }

    [Token(Token = "0x600E298")]
    [Address(RVA = "0x401C3A4", Offset = "0x401C3A4", VA = "0x401C3A4", Slot = "6")]
    protected virtual ConditionParam CreatePreCalcCondition(
      UnitParameterData triggerSkillActivator,
      UnitParameterData target)
    {
      return (ConditionParam) null;
    }

    [Token(Token = "0x600E299")]
    [Address(RVA = "0x401C474", Offset = "0x401C474", VA = "0x401C474", Slot = "7")]
    protected virtual ConditionParam CreatePostCalcCondition(
      UnitParameterData triggerSkillActivator,
      UnitParameterData target)
    {
      return (ConditionParam) null;
    }

    [Token(Token = "0x600E29A")]
    [Address(RVA = "0x401C544", Offset = "0x401C544", VA = "0x401C544", Slot = "8")]
    protected virtual void OnAppliedActiveSkill()
    {
    }

    [Token(Token = "0x600E29B")]
    [Address(RVA = "0x401C548", Offset = "0x401C548", VA = "0x401C548", Slot = "9")]
    protected virtual void AddEffectActionData(
      EffectData effect,
      int hitRate,
      int criticalRate,
      UnitParameterChange paramChange)
    {
    }

    [Token(Token = "0x600E29C")]
    [Address(RVA = "0x401B574", Offset = "0x401B574", VA = "0x401B574")]
    protected void AddEffectActionTargetData(
      EffectData effect,
      UnitParameterData targetUnit,
      GridData targetGrid,
      UnitParameterChange beforeParamChange,
      UnitParameterChange afterParamChange,
      bool isHit,
      bool isCritical,
      bool hasResistByBarrier)
    {
    }
  }
}
