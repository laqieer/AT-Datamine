// Decompiled with JetBrains decompiler
// Type: Battle.Logic.DuelActiveSkillLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic
{
  [Token(Token = "0x20024D7")]
  public class DuelActiveSkillLogic : ActiveSkillLogic
  {
    [Token(Token = "0x4009E10")]
    [FieldOffset(Offset = "0xF4")]
    private ActiveSkillActionGroup actionGroup;
    [Token(Token = "0x4009E11")]
    [FieldOffset(Offset = "0xF8")]
    private UnitParameterData activateSupportGuardUnit;
    [Token(Token = "0x4009E12")]
    [FieldOffset(Offset = "0x100")]
    private SkillParameterData activateSupportGuardSkillParam;
    [Token(Token = "0x4009E13")]
    [FieldOffset(Offset = "0x108")]
    private SkillTriggerTimingTypeEnum trigger;

    [Token(Token = "0x600E2E3")]
    [Address(RVA = "0x402064C", Offset = "0x402064C", VA = "0x402064C")]
    private DuelActiveSkillLogic(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets,
      UnitParameterData supportGuardUnit,
      SkillParameterData supportGuardSkillParam,
      ActiveSkillActionGroup duelActionType)
    {
    }

    [Token(Token = "0x600E2E4")]
    [Address(RVA = "0x401F158", Offset = "0x401F158", VA = "0x401F158")]
    public static ActiveSkillLogic CreateDuel(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets,
      UnitParameterData supportGuardUnit,
      SkillParameterData supportGuardParam,
      ActiveSkillActionGroup duelActionType)
    {
      return (ActiveSkillLogic) null;
    }

    [Token(Token = "0x600E2E5")]
    [Address(RVA = "0x401F520", Offset = "0x401F520", VA = "0x401F520")]
    public static ActiveSkillLogic CreatePreDuel(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets)
    {
      return (ActiveSkillLogic) null;
    }

    [Token(Token = "0x600E2E6")]
    [Address(RVA = "0x401F8AC", Offset = "0x401F8AC", VA = "0x401F8AC")]
    public static ActiveSkillLogic CreatePostDuel(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets)
    {
      return (ActiveSkillLogic) null;
    }

    [Token(Token = "0x600E2E7")]
    [Address(RVA = "0x40206D0", Offset = "0x40206D0", VA = "0x40206D0", Slot = "5")]
    protected override bool ApplyActiveSkill(TargetPair targetPair) => new bool();

    [Token(Token = "0x600E2E8")]
    [Address(RVA = "0x4021528", Offset = "0x4021528", VA = "0x4021528", Slot = "8")]
    protected override void OnAppliedActiveSkill()
    {
    }

    [Token(Token = "0x600E2E9")]
    [Address(RVA = "0x40216E0", Offset = "0x40216E0", VA = "0x40216E0")]
    private bool ConsumeDurability(
      UnitParameterData unit,
      SkillParameterData skillParam,
      out UnitParameterChange paramChange)
    {
      return new bool();
    }

    [Token(Token = "0x600E2EA")]
    [Address(RVA = "0x40217B0", Offset = "0x40217B0", VA = "0x40217B0", Slot = "9")]
    protected override void AddEffectActionData(
      EffectData effect,
      int hitRate,
      int criticalRate,
      UnitParameterChange paramChange)
    {
    }
  }
}
