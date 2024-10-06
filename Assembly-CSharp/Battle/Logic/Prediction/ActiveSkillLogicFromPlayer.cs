// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.ActiveSkillLogicFromPlayer
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
  [Token(Token = "0x20024EE")]
  public class ActiveSkillLogicFromPlayer : ActiveSkillLogicBase
  {
    [Token(Token = "0x4009E69")]
    [FieldOffset(Offset = "0x48")]
    private BoardData board;
    [Token(Token = "0x4009E6A")]
    [FieldOffset(Offset = "0x50")]
    private BattlePlayerData actionPlayer;
    [Token(Token = "0x4009E6B")]
    [FieldOffset(Offset = "0x58")]
    private GridData castFrom;

    [Token(Token = "0x600E3B6")]
    [Address(RVA = "0x4777934", Offset = "0x4777934", VA = "0x4777934")]
    public ActiveSkillLogicFromPlayer(
      BoardData board,
      BattlePlayerData actionPlayer,
      GridData castFrom,
      SkillParameterData activeSkillParam,
      TargetPair mainTargetPair)
    {
    }

    [Token(Token = "0x600E3B7")]
    [Address(RVA = "0x4777974", Offset = "0x4777974", VA = "0x4777974", Slot = "4")]
    public override List<EffectResult> Execute() => (List<EffectResult>) null;

    [Token(Token = "0x600E3B8")]
    [Address(RVA = "0x4777AF0", Offset = "0x4777AF0", VA = "0x4777AF0")]
    private List<TargetPair> GetEffectiveTargets() => (List<TargetPair>) null;

    [Token(Token = "0x600E3B9")]
    [Address(RVA = "0x4778158", Offset = "0x4778158", VA = "0x4778158")]
    private bool ApplyActiveSkill(TargetPair targetPair, ref UnitParameterChange targetParamChange)
    {
      return new bool();
    }

    [Token(Token = "0x600E3BA")]
    [Address(RVA = "0x47783C0", Offset = "0x47783C0", VA = "0x47783C0")]
    private void ApplyEffect(
      TargetPair targetPair,
      ICorrectableParameter<IBattleParameter> targetBattleParam,
      EffectData effect,
      ActiveSkillLogicBase.HitResult hitResult,
      ref UnitParameterChange targetUnitParamChange,
      ref bool isPutOperationEndure,
      out bool isCritical)
    {
    }

    [Token(Token = "0x600E3BB")]
    [Address(RVA = "0x47784F8", Offset = "0x47784F8", VA = "0x47784F8")]
    private EffectLogic.EffectLogicOutputParam ApplyEffectInternal(
      TargetPair targetPair,
      ICorrectableParameter<IBattleParameter> targetBattleParam,
      EffectData effect,
      ref UnitParameterChange targetUnitParamChange,
      ref bool isPutOperationEndure)
    {
      return (EffectLogic.EffectLogicOutputParam) null;
    }

    [Token(Token = "0x600E3BC")]
    [Address(RVA = "0x477865C", Offset = "0x477865C", VA = "0x477865C")]
    protected void AddEffectResult(
      TargetPair targetPair,
      ICorrectableParameter<IBattleParameter> targetBattleParam,
      EffectData effect,
      EffectLogic.EffectLogicOutputParam output)
    {
    }

    [Token(Token = "0x600E3BD")]
    [Address(RVA = "0x4778C6C", Offset = "0x4778C6C", VA = "0x4778C6C")]
    protected EffectResult GetEffectResult(EffectData effect) => (EffectResult) null;
  }
}
