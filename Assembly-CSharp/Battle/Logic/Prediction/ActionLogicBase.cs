// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.ActionLogicBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Process;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x20024E8")]
  public abstract class ActionLogicBase
  {
    [Token(Token = "0x4009E47")]
    [FieldOffset(Offset = "0x88")]
    public readonly List<TargetPair> Targets;
    [Token(Token = "0x4009E48")]
    [FieldOffset(Offset = "0x90")]
    protected Dictionary<TargetPair, List<UnitParameterData>> targetSupportersDic;
    [Token(Token = "0x4009E4B")]
    [FieldOffset(Offset = "0xA8")]
    protected Dictionary<(UnitParameterData unit, int index), BarrierDamageLogic> reserveBarrierDamageDic;

    [Token(Token = "0x170030B8")]
    public ActionContext Context
    {
      [Token(Token = "0x600E36D"), Address(RVA = "0x4029DFC", Offset = "0x4029DFC", VA = "0x4029DFC")] get
      {
        return new ActionContext();
      }
      [Token(Token = "0x600E36E"), Address(RVA = "0x4029E0C", Offset = "0x4029E0C", VA = "0x4029E0C")] protected set
      {
      }
    }

    [Token(Token = "0x170030B9")]
    public TargetPair ActivatorPair
    {
      [Token(Token = "0x600E36F"), Address(RVA = "0x4029E24", Offset = "0x4029E24", VA = "0x4029E24")] get
      {
        return (TargetPair) null;
      }
      [Token(Token = "0x600E370"), Address(RVA = "0x4029E2C", Offset = "0x4029E2C", VA = "0x4029E2C")] protected set
      {
      }
    }

    [Token(Token = "0x170030BA")]
    public TargetPair MainTargetPair
    {
      [Token(Token = "0x600E371"), Address(RVA = "0x4029E34", Offset = "0x4029E34", VA = "0x4029E34")] get
      {
        return (TargetPair) null;
      }
      [Token(Token = "0x600E372"), Address(RVA = "0x4029E3C", Offset = "0x4029E3C", VA = "0x4029E3C")] protected set
      {
      }
    }

    [Token(Token = "0x170030BB")]
    protected BattleTaskManager TaskManager
    {
      [Token(Token = "0x600E373"), Address(RVA = "0x4029E44", Offset = "0x4029E44", VA = "0x4029E44")] get
      {
        return (BattleTaskManager) null;
      }
      [Token(Token = "0x600E374"), Address(RVA = "0x4029E4C", Offset = "0x4029E4C", VA = "0x4029E4C")] set
      {
      }
    }

    [Token(Token = "0x170030BC")]
    protected ActionResult Res
    {
      [Token(Token = "0x600E375"), Address(RVA = "0x4029E54", Offset = "0x4029E54", VA = "0x4029E54")] get
      {
        return (ActionResult) null;
      }
      [Token(Token = "0x600E376"), Address(RVA = "0x4029E5C", Offset = "0x4029E5C", VA = "0x4029E5C")] set
      {
      }
    }

    [Token(Token = "0x600E377")]
    public abstract ActionResult Execute();

    [Token(Token = "0x600E378")]
    public abstract ActionResult ExecutePreEffect();

    [Token(Token = "0x600E379")]
    public abstract ActionResult ExecutePostEffect();

    [Token(Token = "0x170030BD")]
    public List<(UnitParameterData unit, int index, BarrierDamageLogic damage)> ReserveBarrierDamages
    {
      [Token(Token = "0x600E37A"), Address(RVA = "0x4029E64", Offset = "0x4029E64", VA = "0x4029E64")] get
      {
        return (List<(UnitParameterData, int, BarrierDamageLogic)>) null;
      }
    }

    [Token(Token = "0x600E37B")]
    [Address(RVA = "0x402A0E4", Offset = "0x402A0E4", VA = "0x402A0E4")]
    protected bool IsExecutableSkill(SkillParameterData activeSkillParam) => new bool();

    [Token(Token = "0x600E37C")]
    [Address(RVA = "0x402A0FC", Offset = "0x402A0FC", VA = "0x402A0FC")]
    protected void SolveActiveSkillLogic(
      ActiveSkillLogic logic,
      SkillTriggerTimingTypeEnum trigger,
      ActiveSkillActionGroup duelActionType = ActiveSkillActionGroup.None)
    {
    }

    [Token(Token = "0x600E37D")]
    [Address(RVA = "0x402A288", Offset = "0x402A288", VA = "0x402A288")]
    protected void CollectReserveBarrierDamage(ActiveSkillLogic logic)
    {
    }

    [Token(Token = "0x600E37E")]
    [Address(RVA = "0x402A740", Offset = "0x402A740", VA = "0x402A740")]
    protected ActionLogicBase()
    {
    }
  }
}
