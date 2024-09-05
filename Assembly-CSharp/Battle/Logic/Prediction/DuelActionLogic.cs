// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.DuelActionLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x20024EF")]
  public class DuelActionLogic : ActionLogicBase
  {
    [Token(Token = "0x4009E6C")]
    [FieldOffset(Offset = "0xB0")]
    private DuelLogicFluctuationParam activatorFluctuation;
    [Token(Token = "0x4009E6F")]
    [FieldOffset(Offset = "0x100")]
    private DuelLogicFluctuationParam targetFluctuation;
    [Token(Token = "0x4009E72")]
    [FieldOffset(Offset = "0x150")]
    private Dictionary<UnitParameterData, HashSet<UnitParameterData>> supporterBuffDic;
    [Token(Token = "0x4009E73")]
    [FieldOffset(Offset = "0x158")]
    private Dictionary<ActiveSkillActionGroup, List<DuelConfirmedAttackParam>> confirmedDic;
    [Token(Token = "0x4009E74")]
    [FieldOffset(Offset = "0x160")]
    private DuelLogicFluctuationParam firstAttackFluctuation;
    [Token(Token = "0x4009E75")]
    [FieldOffset(Offset = "0x1A8")]
    private DuelLogicFluctuationParam secondAttackFluctuation;
    [Token(Token = "0x4009E76")]
    [FieldOffset(Offset = "0x1F0")]
    private bool isReverse;
    [Token(Token = "0x4009E77")]
    [FieldOffset(Offset = "0x1F8")]
    private AttackableAreaSearcher searcher;
    [Token(Token = "0x4009E78")]
    [FieldOffset(Offset = "0x200")]
    private List<ActiveSkillActionGroup> duelFlow;

    [Token(Token = "0x170030CD")]
    public bool ActivatorFirstStrike
    {
      [Token(Token = "0x600E3BE"), Address(RVA = "0x4778FD4", Offset = "0x4778FD4", VA = "0x4778FD4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E3BF"), Address(RVA = "0x4778FDC", Offset = "0x4778FDC", VA = "0x4778FDC")] private set
      {
      }
    }

    [Token(Token = "0x170030CE")]
    public bool ActivatorSecondStrike
    {
      [Token(Token = "0x600E3C0"), Address(RVA = "0x4778FE8", Offset = "0x4778FE8", VA = "0x4778FE8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E3C1"), Address(RVA = "0x4778FF0", Offset = "0x4778FF0", VA = "0x4778FF0")] private set
      {
      }
    }

    [Token(Token = "0x170030CF")]
    public bool TargetFirstStrike
    {
      [Token(Token = "0x600E3C2"), Address(RVA = "0x4778FFC", Offset = "0x4778FFC", VA = "0x4778FFC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E3C3"), Address(RVA = "0x4779004", Offset = "0x4779004", VA = "0x4779004")] private set
      {
      }
    }

    [Token(Token = "0x170030D0")]
    public bool TargetSecondStrike
    {
      [Token(Token = "0x600E3C4"), Address(RVA = "0x4779010", Offset = "0x4779010", VA = "0x4779010")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E3C5"), Address(RVA = "0x4779018", Offset = "0x4779018", VA = "0x4779018")] private set
      {
      }
    }

    [Token(Token = "0x600E3C6")]
    [Address(RVA = "0x4779024", Offset = "0x4779024", VA = "0x4779024")]
    public DuelActionLogic(
      ActionContext context,
      TargetPair activatorPair,
      TargetPair mainTargetPair,
      List<TargetPair> targets,
      DuelLogicFluctuationParam activatorFluctuation,
      DuelLogicFluctuationParam targetFluctuation)
    {
    }

    [Token(Token = "0x600E3C7")]
    [Address(RVA = "0x4779590", Offset = "0x4779590", VA = "0x4779590", Slot = "4")]
    public override ActionResult Execute() => (ActionResult) null;

    [Token(Token = "0x600E3C8")]
    [Address(RVA = "0x477A518", Offset = "0x477A518", VA = "0x477A518", Slot = "5")]
    public override ActionResult ExecutePreEffect() => (ActionResult) null;

    [Token(Token = "0x600E3C9")]
    [Address(RVA = "0x477A7E0", Offset = "0x477A7E0", VA = "0x477A7E0", Slot = "6")]
    public override ActionResult ExecutePostEffect() => (ActionResult) null;

    [Token(Token = "0x600E3CA")]
    [Address(RVA = "0x4779A24", Offset = "0x4779A24", VA = "0x4779A24")]
    private void ConfirmDuelFlow()
    {
    }

    [Token(Token = "0x600E3CB")]
    [Address(RVA = "0x477AC90", Offset = "0x477AC90", VA = "0x477AC90")]
    private void ReplaceFlow(int index, ActiveSkillActionGroup actionType)
    {
    }

    [Token(Token = "0x600E3CC")]
    [Address(RVA = "0x477A33C", Offset = "0x477A33C", VA = "0x477A33C")]
    private void RequestAttackLogic(
      ActiveSkillActionGroup actionType,
      DuelConfirmedAttackParam confirmed)
    {
    }

    [Token(Token = "0x600E3CD")]
    [Address(RVA = "0x477AF14", Offset = "0x477AF14", VA = "0x477AF14")]
    private void AddSupportBuffInfo(UnitParameterData unit, UnitParameterData supporter)
    {
    }

    [Token(Token = "0x600E3CE")]
    [Address(RVA = "0x477B020", Offset = "0x477B020", VA = "0x477B020")]
    private List<UnitParameterData> GetSupportBuffInfo(UnitParameterData unit)
    {
      return (List<UnitParameterData>) null;
    }

    [Token(Token = "0x600E3CF")]
    [Address(RVA = "0x477B124", Offset = "0x477B124", VA = "0x477B124")]
    private bool IsTargetInRange(DuelConfirmedAttackParam confirmed) => new bool();

    [Token(Token = "0x600E3D0")]
    [Address(RVA = "0x477AA90", Offset = "0x477AA90", VA = "0x477AA90")]
    private bool IsFirstAttackable(DuelConfirmedAttackParam confirmed) => new bool();

    [Token(Token = "0x600E3D1")]
    [Address(RVA = "0x477AC00", Offset = "0x477AC00", VA = "0x477AC00")]
    private bool IsSecondAttackable() => new bool();

    [Token(Token = "0x600E3D2")]
    [Address(RVA = "0x477AC30", Offset = "0x477AC30", VA = "0x477AC30")]
    private bool IsFirstChasable(DuelConfirmedAttackParam confirmed) => new bool();

    [Token(Token = "0x600E3D3")]
    [Address(RVA = "0x477AC5C", Offset = "0x477AC5C", VA = "0x477AC5C")]
    private bool IsSecondChasable(DuelConfirmedAttackParam confirmed) => new bool();

    [Token(Token = "0x600E3D4")]
    [Address(RVA = "0x477AAAC", Offset = "0x477AAAC", VA = "0x477AAAC")]
    private void AddConfirmedAttackParam(
      ActiveSkillActionGroup duelActionType,
      DuelConfirmedAttackParam confirmed)
    {
    }

    [Token(Token = "0x600E3D5")]
    [Address(RVA = "0x477A27C", Offset = "0x477A27C", VA = "0x477A27C")]
    private IReadOnlyList<DuelConfirmedAttackParam> GetConfirmedAttackParam(
      ActiveSkillActionGroup duelActionType)
    {
      return (IReadOnlyList<DuelConfirmedAttackParam>) null;
    }
  }
}
