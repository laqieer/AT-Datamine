// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.SkillCommand
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
  [Token(Token = "0x2002503")]
  public class SkillCommand
  {
    [Token(Token = "0x4009F01")]
    [FieldOffset(Offset = "0x10")]
    protected BattleCore core;
    [Token(Token = "0x4009F02")]
    [FieldOffset(Offset = "0x18")]
    private BoardData origin;
    [Token(Token = "0x4009F03")]
    [FieldOffset(Offset = "0x20")]
    protected int activatorUnitId;
    [Token(Token = "0x4009F04")]
    [FieldOffset(Offset = "0x24")]
    protected (int x, int y) activatorCoord;
    [Token(Token = "0x4009F05")]
    [FieldOffset(Offset = "0x2C")]
    protected int mainTargetId;
    [Token(Token = "0x4009F06")]
    [FieldOffset(Offset = "0x30")]
    protected (int x, int y) mainTargetCoord;
    [Token(Token = "0x4009F07")]
    [FieldOffset(Offset = "0x38")]
    protected List<(int unitId, int x, int y)> targetParams;
    [Token(Token = "0x4009F08")]
    [FieldOffset(Offset = "0x40")]
    protected int weaponParamIndex;
    [Token(Token = "0x4009F09")]
    [FieldOffset(Offset = "0x44")]
    protected int skillParamId;
    [Token(Token = "0x4009F0A")]
    [FieldOffset(Offset = "0x48")]
    protected PredictionResult result;
    [Token(Token = "0x4009F0B")]
    [FieldOffset(Offset = "0x50")]
    protected List<ActionResult> actionResults;
    [Token(Token = "0x4009F0C")]
    [FieldOffset(Offset = "0x58")]
    protected List<int> activatableSkillParamIds;
    [Token(Token = "0x4009F0D")]
    [FieldOffset(Offset = "0x60")]
    protected List<int> mainTargetActivatableSkillParamIds;
    [Token(Token = "0x4009F0E")]
    [FieldOffset(Offset = "0x68")]
    protected TargetPair activator;
    [Token(Token = "0x4009F0F")]
    [FieldOffset(Offset = "0x70")]
    protected TargetPair mainTarget;
    [Token(Token = "0x4009F10")]
    [FieldOffset(Offset = "0x78")]
    protected List<TargetPair> targets;
    [Token(Token = "0x4009F11")]
    [FieldOffset(Offset = "0x80")]
    protected SkillParameterData skillParam;
    [Token(Token = "0x4009F12")]
    [FieldOffset(Offset = "0x88")]
    protected ActionContext duelContext;
    [Token(Token = "0x4009F13")]
    [FieldOffset(Offset = "0xF0")]
    protected List<(int unitId, int index, BarrierDamageLogic logic)> barrierDamages;

    [Token(Token = "0x170030EF")]
    protected BoardData board
    {
      [Token(Token = "0x600E47B"), Address(RVA = "0x477D398", Offset = "0x477D398", VA = "0x477D398")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x600E47C")]
    [Address(RVA = "0x477BB80", Offset = "0x477BB80", VA = "0x477BB80")]
    public SkillCommand(
      BattleCore core,
      UnitParameterData activator,
      List<TargetPair> targets,
      GridData castTo,
      WeaponParameterData weaponParam,
      SkillParameterData skillParam,
      List<UnitParameterData> supporters)
    {
    }

    [Token(Token = "0x600E47D")]
    [Address(RVA = "0x477CFAC", Offset = "0x477CFAC", VA = "0x477CFAC")]
    protected void AttachTempBoard()
    {
    }

    [Token(Token = "0x600E47E")]
    [Address(RVA = "0x477D8CC", Offset = "0x477D8CC", VA = "0x477D8CC")]
    protected void ClearTempBoard()
    {
    }

    [Token(Token = "0x600E47F")]
    [Address(RVA = "0x47853C8", Offset = "0x47853C8", VA = "0x47853C8", Slot = "4")]
    public virtual PredictionResult Predict() => (PredictionResult) null;

    [Token(Token = "0x600E480")]
    [Address(RVA = "0x4785640", Offset = "0x4785640", VA = "0x4785640")]
    public BarrierDamageLogic GetBarrierDamageLogic(int unit, int index)
    {
      return (BarrierDamageLogic) null;
    }

    [Token(Token = "0x600E481")]
    [Address(RVA = "0x477D404", Offset = "0x477D404", VA = "0x477D404")]
    protected void CollectActivatableSkills(TargetPair activator, TargetPair targetPair)
    {
    }

    [Token(Token = "0x600E482")]
    [Address(RVA = "0x477DA84", Offset = "0x477DA84", VA = "0x477DA84")]
    protected void CollectBarrierDamage(ActionLogicBase logic)
    {
    }

    [Token(Token = "0x600E483")]
    [Address(RVA = "0x4785B88", Offset = "0x4785B88", VA = "0x4785B88", Slot = "5")]
    protected virtual void ExecMainEffect()
    {
    }

    [Token(Token = "0x600E484")]
    [Address(RVA = "0x4785CC0", Offset = "0x4785CC0", VA = "0x4785CC0", Slot = "6")]
    protected virtual void ExecPreEffect()
    {
    }

    [Token(Token = "0x600E485")]
    [Address(RVA = "0x4785DF8", Offset = "0x4785DF8", VA = "0x4785DF8", Slot = "7")]
    protected virtual void ExecPostEffect()
    {
    }

    [Token(Token = "0x600E486")]
    [Address(RVA = "0x4786384", Offset = "0x4786384", VA = "0x4786384", Slot = "8")]
    protected virtual SkillParameterData GetCounterStrikeParam() => (SkillParameterData) null;

    [Token(Token = "0x600E487")]
    [Address(RVA = "0x477E150", Offset = "0x477E150", VA = "0x477E150")]
    protected void SwitchPassiveSkill(SkillTriggerTimingTypeEnum trigger)
    {
    }

    [Token(Token = "0x600E488")]
    [Address(RVA = "0x477E2C8", Offset = "0x477E2C8", VA = "0x477E2C8")]
    protected void DeactivePassiveSkill(SkillTriggerTimingTypeEnum timing)
    {
    }

    [Token(Token = "0x600E489")]
    [Address(RVA = "0x47857A8", Offset = "0x47857A8", VA = "0x47857A8")]
    protected List<SkillParameterData> GetActivatableSkills(
      UnitParameterData passiveSkillActivator,
      UnitParameterData target)
    {
      return (List<SkillParameterData>) null;
    }

    [Token(Token = "0x600E48A")]
    [Address(RVA = "0x477D3B4", Offset = "0x477D3B4", VA = "0x477D3B4")]
    protected void SolvePreActiveSkill()
    {
    }

    [Token(Token = "0x600E48B")]
    [Address(RVA = "0x477D8A4", Offset = "0x477D8A4", VA = "0x477D8A4")]
    protected void SolvePostActiveSkill()
    {
    }

    [Token(Token = "0x600E48C")]
    [Address(RVA = "0x478638C", Offset = "0x478638C", VA = "0x478638C")]
    protected ConditionParam CreateConditionParams(
      UnitParameterData triggerSkillActivator,
      UnitParameterData target)
    {
      return (ConditionParam) null;
    }
  }
}
