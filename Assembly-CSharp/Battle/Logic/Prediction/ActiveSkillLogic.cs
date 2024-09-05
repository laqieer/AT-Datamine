// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.ActiveSkillLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x20024EA")]
  public class ActiveSkillLogic : ActiveSkillLogicBase
  {
    [Token(Token = "0x4009E57")]
    [FieldOffset(Offset = "0xB8")]
    protected List<EffectData> ActiveEffects;
    [Token(Token = "0x4009E59")]
    [FieldOffset(Offset = "0xC8")]
    public readonly HashSet<TargetPair> Targets;
    [Token(Token = "0x4009E5A")]
    [FieldOffset(Offset = "0xD0")]
    protected bool AnyHit;

    [Token(Token = "0x600E388")]
    [Address(RVA = "0x402B388", Offset = "0x402B388", VA = "0x402B388")]
    public static ActiveSkillLogic CreateMainEffect(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets)
    {
      return (ActiveSkillLogic) null;
    }

    [Token(Token = "0x600E389")]
    [Address(RVA = "0x402B6C0", Offset = "0x402B6C0", VA = "0x402B6C0")]
    public static ActiveSkillLogic CreatePreEffect(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets)
    {
      return (ActiveSkillLogic) null;
    }

    [Token(Token = "0x600E38A")]
    [Address(RVA = "0x402B884", Offset = "0x402B884", VA = "0x402B884")]
    public static ActiveSkillLogic CreatePostEffect(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets)
    {
      return (ActiveSkillLogic) null;
    }

    [Token(Token = "0x170030C1")]
    protected ActionContext Context
    {
      [Token(Token = "0x600E38B"), Address(RVA = "0x402BA48", Offset = "0x402BA48", VA = "0x402BA48")] get
      {
        return new ActionContext();
      }
      [Token(Token = "0x600E38C"), Address(RVA = "0x402BA58", Offset = "0x402BA58", VA = "0x402BA58")] private set
      {
      }
    }

    [Token(Token = "0x170030C2")]
    protected BoardData Board
    {
      [Token(Token = "0x600E38D"), Address(RVA = "0x402BA70", Offset = "0x402BA70", VA = "0x402BA70")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x170030C3")]
    public TargetPair ActionUnitPair
    {
      [Token(Token = "0x600E38E"), Address(RVA = "0x402BA78", Offset = "0x402BA78", VA = "0x402BA78")] get
      {
        return (TargetPair) null;
      }
      [Token(Token = "0x600E38F"), Address(RVA = "0x402BA80", Offset = "0x402BA80", VA = "0x402BA80")] private set
      {
      }
    }

    [Token(Token = "0x170030C4")]
    public WeaponParameterData UsingWeaponParam
    {
      [Token(Token = "0x600E390"), Address(RVA = "0x402BA88", Offset = "0x402BA88", VA = "0x402BA88")] get
      {
        return (WeaponParameterData) null;
      }
      [Token(Token = "0x600E391"), Address(RVA = "0x402BA90", Offset = "0x402BA90", VA = "0x402BA90")] private set
      {
      }
    }

    [Token(Token = "0x600E392")]
    [Address(RVA = "0x402B54C", Offset = "0x402B54C", VA = "0x402B54C")]
    protected ActiveSkillLogic(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets)
    {
    }

    [Token(Token = "0x600E393")]
    [Address(RVA = "0x402BA98", Offset = "0x402BA98", VA = "0x402BA98", Slot = "4")]
    public override List<EffectResult> Execute() => (List<EffectResult>) null;

    [Token(Token = "0x600E394")]
    [Address(RVA = "0x402BC40", Offset = "0x402BC40", VA = "0x402BC40")]
    protected void CollectEffectiveTargets()
    {
    }

    [Token(Token = "0x600E395")]
    [Address(RVA = "0x402C5A0", Offset = "0x402C5A0", VA = "0x402C5A0", Slot = "5")]
    protected virtual bool ApplyActiveSkill(TargetPair targetPair) => new bool();

    [Token(Token = "0x600E396")]
    [Address(RVA = "0x402C9E4", Offset = "0x402C9E4", VA = "0x402C9E4")]
    protected void ApplyEffect(
      ICorrectableParameter<IBattleParameter> actionBattleParam,
      TargetPair targetPair,
      ICorrectableParameter<IBattleParameter> targetBattleParam,
      List<EffectData> supportGuardEffects,
      EffectData effect,
      ActiveSkillLogicBase.HitResult cachedHitResult,
      ref bool isPutOperationEndure)
    {
    }

    [Token(Token = "0x600E397")]
    [Address(RVA = "0x402CBA4", Offset = "0x402CBA4", VA = "0x402CBA4")]
    protected EffectLogic.EffectLogicOutputParam ApplyEffectInternal(
      ICorrectableParameter<IBattleParameter> actionBattleParam,
      TargetPair targetPair,
      ICorrectableParameter<IBattleParameter> targetBattleParam,
      List<EffectData> supportGuardEffects,
      EffectData effect,
      ref bool isPutOperationEndure)
    {
      return (EffectLogic.EffectLogicOutputParam) null;
    }

    [Token(Token = "0x600E398")]
    [Address(RVA = "0x402CD68", Offset = "0x402CD68", VA = "0x402CD68")]
    protected void AddEffectResult(
      ICorrectableParameter<IBattleParameter> activatorBattleParam,
      TargetPair targetPair,
      ICorrectableParameter<IBattleParameter> targetBattleParam,
      EffectData effect,
      EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E399")]
    [Address(RVA = "0x402D66C", Offset = "0x402D66C", VA = "0x402D66C")]
    protected EffectResult GetEffectResult(EffectData effect) => (EffectResult) null;
  }
}
