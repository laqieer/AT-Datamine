// Decompiled with JetBrains decompiler
// Type: Battle.Logic.DuelActionLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.DuelScene;
using Battle.RouteSearch;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic
{
  [Token(Token = "0x20024D4")]
  public class DuelActionLogic : ActionLogicBase
  {
    [Token(Token = "0x4009DFD")]
    [FieldOffset(Offset = "0xA8")]
    private DuelLogicFluctuationParam activatorFluctuation;
    [Token(Token = "0x4009DFE")]
    [FieldOffset(Offset = "0xF0")]
    private DuelLogicFluctuationParam targetFluctuation;
    [Token(Token = "0x4009DFF")]
    [FieldOffset(Offset = "0x138")]
    private bool targetAttackable;
    [Token(Token = "0x4009E00")]
    [FieldOffset(Offset = "0x140")]
    private TargetPair targetAttackTarget;
    [Token(Token = "0x4009E01")]
    [FieldOffset(Offset = "0x148")]
    private Dictionary<ActiveSkillActionGroup, List<DuelConfirmedAttackParam>> confirmedDic;
    [Token(Token = "0x4009E02")]
    [FieldOffset(Offset = "0x150")]
    private DuelLogicFluctuationParam firstAttackFluctuation;
    [Token(Token = "0x4009E03")]
    [FieldOffset(Offset = "0x198")]
    private UnitParameterData firstAttackUnit;
    [Token(Token = "0x4009E04")]
    [FieldOffset(Offset = "0x1A0")]
    private DuelLogicFluctuationParam secondAttackFluctuation;
    [Token(Token = "0x4009E05")]
    [FieldOffset(Offset = "0x1E8")]
    private UnitParameterData secondAttackUnit;
    [Token(Token = "0x4009E06")]
    [FieldOffset(Offset = "0x1F0")]
    private bool doneFirstAttack;
    [Token(Token = "0x4009E07")]
    [FieldOffset(Offset = "0x1F1")]
    private bool doneSecondAttack;
    [Token(Token = "0x4009E08")]
    [FieldOffset(Offset = "0x1F2")]
    private bool isReverse;
    [Token(Token = "0x4009E09")]
    [FieldOffset(Offset = "0x1F8")]
    private AttackableAreaSearcher searcher;
    [Token(Token = "0x4009E0A")]
    [FieldOffset(Offset = "0x200")]
    private List<ActiveSkillActionGroup> duelFlow;

    [Token(Token = "0x600E2CB")]
    [Address(RVA = "0x401DAD0", Offset = "0x401DAD0", VA = "0x401DAD0")]
    public DuelActionLogic(
      ActionContext context,
      Team activatorTeam,
      TargetPair mainTargetUnitPair,
      List<TargetPair> targets,
      DuelLogicFluctuationParam activatorFluctuation,
      DuelLogicFluctuationParam targetFluctuation)
    {
    }

    [Token(Token = "0x600E2CC")]
    [Address(RVA = "0x401DE94", Offset = "0x401DE94", VA = "0x401DE94", Slot = "4")]
    public override DuelData Execute() => (DuelData) null;

    [Token(Token = "0x600E2CD")]
    [Address(RVA = "0x401E41C", Offset = "0x401E41C", VA = "0x401E41C")]
    private void ConfirmDuelFlow()
    {
    }

    [Token(Token = "0x600E2CE")]
    [Address(RVA = "0x401F0B8", Offset = "0x401F0B8", VA = "0x401F0B8")]
    private void ReplaceFlow(int index, ActiveSkillActionGroup actionType)
    {
    }

    [Token(Token = "0x600E2CF")]
    [Address(RVA = "0x401ECC4", Offset = "0x401ECC4", VA = "0x401ECC4")]
    private void RequestAttackLogic(
      ActiveSkillActionGroup actionType,
      DuelConfirmedAttackParam confirmed)
    {
    }

    [Token(Token = "0x600E2D0")]
    [Address(RVA = "0x401F340", Offset = "0x401F340", VA = "0x401F340", Slot = "5")]
    public override DuelData ExecutePreEffect() => (DuelData) null;

    [Token(Token = "0x600E2D1")]
    [Address(RVA = "0x401F6F4", Offset = "0x401F6F4", VA = "0x401F6F4", Slot = "6")]
    public override DuelData ExecutePostEffect() => (DuelData) null;

    [Token(Token = "0x600E2D2")]
    [Address(RVA = "0x401FA80", Offset = "0x401FA80", VA = "0x401FA80")]
    private void SolveAttackLogic(
      ActiveSkillActionGroup actionType,
      DuelActiveSkillLogic skillLogic)
    {
    }

    [Token(Token = "0x600E2D3")]
    [Address(RVA = "0x401FAFC", Offset = "0x401FAFC", VA = "0x401FAFC")]
    private void IgnitionTriggerAttack(
      ActiveSkillActionGroup duelActionType,
      SkillTriggerTimingTypeEnum timing,
      DuelActiveSkillLogic skillLogic)
    {
    }

    [Token(Token = "0x600E2D4")]
    [Address(RVA = "0x401FC9C", Offset = "0x401FC9C", VA = "0x401FC9C")]
    private void IgnitionTriggerAttack(
      ActiveSkillActionGroup duelActionType,
      SkillTriggerTimingTypeEnum timing,
      UnitParameterData triggerSkillActivator,
      UnitParameterData target,
      UnitParameterData activator,
      ref SkillLogic.EffectedTriggerSkillContainer container)
    {
    }

    [Token(Token = "0x600E2D5")]
    [Address(RVA = "0x4020244", Offset = "0x4020244", VA = "0x4020244")]
    private bool IsExecutableAction(
      ActiveSkillActionGroup actionType,
      DuelConfirmedAttackParam confirmed)
    {
      return new bool();
    }

    [Token(Token = "0x600E2D6")]
    [Address(RVA = "0x402050C", Offset = "0x402050C", VA = "0x402050C")]
    private bool IsTargetInRange(DuelConfirmedAttackParam confirmed) => new bool();

    [Token(Token = "0x600E2D7")]
    [Address(RVA = "0x4020388", Offset = "0x4020388", VA = "0x4020388")]
    private bool IsFirstAttackable(DuelConfirmedAttackParam confirmed) => new bool();

    [Token(Token = "0x600E2D8")]
    [Address(RVA = "0x40203A4", Offset = "0x40203A4", VA = "0x40203A4")]
    private bool IsSecondAttackable(DuelConfirmedAttackParam confirmed) => new bool();

    [Token(Token = "0x600E2D9")]
    [Address(RVA = "0x402041C", Offset = "0x402041C", VA = "0x402041C")]
    private bool IsFirstChasable(DuelConfirmedAttackParam confirmed) => new bool();

    [Token(Token = "0x600E2DA")]
    [Address(RVA = "0x4020448", Offset = "0x4020448", VA = "0x4020448")]
    private bool IsSecondChasable(DuelConfirmedAttackParam confirmed) => new bool();

    [Token(Token = "0x600E2DB")]
    [Address(RVA = "0x402047C", Offset = "0x402047C", VA = "0x402047C")]
    private bool IsFirstSupportAttackable() => new bool();

    [Token(Token = "0x600E2DC")]
    [Address(RVA = "0x40204C4", Offset = "0x40204C4", VA = "0x40204C4")]
    private bool IsSecondSupportAttackable() => new bool();

    [Token(Token = "0x600E2DD")]
    [Address(RVA = "0x401EF64", Offset = "0x401EF64", VA = "0x401EF64")]
    private void AddConfirmedAttackParam(
      ActiveSkillActionGroup duelActionType,
      DuelConfirmedAttackParam confirmed)
    {
    }

    [Token(Token = "0x600E2DE")]
    [Address(RVA = "0x401EC04", Offset = "0x401EC04", VA = "0x401EC04")]
    private IReadOnlyList<DuelConfirmedAttackParam> GetConfirmedAttackParam(
      ActiveSkillActionGroup duelActionType)
    {
      return (IReadOnlyList<DuelConfirmedAttackParam>) null;
    }
  }
}
