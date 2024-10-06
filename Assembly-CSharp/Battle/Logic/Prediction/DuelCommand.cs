// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.DuelCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x20024F4")]
  public class DuelCommand : SkillCommand
  {
    [Token(Token = "0x4009E85")]
    [FieldOffset(Offset = "0xF8")]
    private DuelLogicFluctuationParam activatorFluctuation;
    [Token(Token = "0x4009E86")]
    [FieldOffset(Offset = "0x140")]
    private (UnitParameterData unit, SkillParameterData skill)? reservedActivatorSupportHeal;
    [Token(Token = "0x4009E87")]
    [FieldOffset(Offset = "0x158")]
    private int reservedActivatorSupportAttackRate;
    [Token(Token = "0x4009E88")]
    [FieldOffset(Offset = "0x15C")]
    private int reservedActivatorSupportGuardRate;
    [Token(Token = "0x4009E89")]
    [FieldOffset(Offset = "0x160")]
    private int reservedActivatorSupportHealRate;
    [Token(Token = "0x4009E8A")]
    [FieldOffset(Offset = "0x168")]
    private DuelLogicFluctuationParam mainTargetFluctuation;
    [Token(Token = "0x4009E8B")]
    [FieldOffset(Offset = "0x1B0")]
    private (UnitParameterData unit, SkillParameterData skill)? reservedMainTargetSupportHeal;
    [Token(Token = "0x4009E8C")]
    [FieldOffset(Offset = "0x1C8")]
    private int reservedMainTargetSupportAttackRate;
    [Token(Token = "0x4009E8D")]
    [FieldOffset(Offset = "0x1CC")]
    private int reservedMainTargetSupportGuardRate;
    [Token(Token = "0x4009E8E")]
    [FieldOffset(Offset = "0x1D0")]
    private int reservedMainTargetSupportHealRate;

    [Token(Token = "0x600E3E4")]
    [Address(RVA = "0x477BB7C", Offset = "0x477BB7C", VA = "0x477BB7C")]
    public DuelCommand(
      BattleCore core,
      UnitParameterData activator,
      List<TargetPair> targets,
      GridData castTo,
      WeaponParameterData weaponParam,
      SkillParameterData skillParam,
      List<UnitParameterData> supporters)
    {
    }

    [Token(Token = "0x600E3E5")]
    [Address(RVA = "0x477C0F4", Offset = "0x477C0F4", VA = "0x477C0F4", Slot = "4")]
    public override PredictionResult Predict() => (PredictionResult) null;

    [Token(Token = "0x600E3E6")]
    [Address(RVA = "0x477D75C", Offset = "0x477D75C", VA = "0x477D75C")]
    protected void CollectSupportSkill()
    {
    }

    [Token(Token = "0x600E3E7")]
    [Address(RVA = "0x477D8F8", Offset = "0x477D8F8", VA = "0x477D8F8", Slot = "5")]
    protected override void ExecMainEffect()
    {
    }

    [Token(Token = "0x600E3E8")]
    [Address(RVA = "0x477DD08", Offset = "0x477DD08", VA = "0x477DD08")]
    private void CollectFluctuationFlowSymbol(DuelActionLogic logic)
    {
    }

    [Token(Token = "0x600E3E9")]
    [Address(RVA = "0x477DD44", Offset = "0x477DD44", VA = "0x477DD44", Slot = "6")]
    protected override void ExecPreEffect()
    {
    }

    [Token(Token = "0x600E3EA")]
    [Address(RVA = "0x477DEC4", Offset = "0x477DEC4", VA = "0x477DEC4", Slot = "7")]
    protected override void ExecPostEffect()
    {
    }

    [Token(Token = "0x600E3EB")]
    [Address(RVA = "0x477E044", Offset = "0x477E044", VA = "0x477E044", Slot = "8")]
    protected override SkillParameterData GetCounterStrikeParam() => (SkillParameterData) null;

    [Token(Token = "0x600E3EC")]
    [Address(RVA = "0x477D3DC", Offset = "0x477D3DC", VA = "0x477D3DC")]
    private void SolvePreDuel()
    {
    }

    [Token(Token = "0x600E3ED")]
    [Address(RVA = "0x477D874", Offset = "0x477D874", VA = "0x477D874")]
    private void SolvePostDuel()
    {
    }

    [Token(Token = "0x600E3EE")]
    [Address(RVA = "0x477E374", Offset = "0x477E374", VA = "0x477E374")]
    private void ExecSupportHealEffect()
    {
    }

    [Token(Token = "0x600E3EF")]
    [Address(RVA = "0x477E4D4", Offset = "0x477E4D4", VA = "0x477E4D4")]
    private void AddSupportHealResult(
      UnitParameterData supporter,
      UnitParameterData supportTarget,
      SkillParameterData skill,
      ref ActionResult actionResult)
    {
    }
  }
}
