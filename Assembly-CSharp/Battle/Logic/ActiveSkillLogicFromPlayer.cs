// Decompiled with JetBrains decompiler
// Type: Battle.Logic.ActiveSkillLogicFromPlayer
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
  [Token(Token = "0x20024D2")]
  public class ActiveSkillLogicFromPlayer : ActiveSkillLogicBase
  {
    [Token(Token = "0x4009DF5")]
    [FieldOffset(Offset = "0x58")]
    private BoardData board;
    [Token(Token = "0x4009DF6")]
    [FieldOffset(Offset = "0x60")]
    private BattlePlayerData actionPlayer;
    [Token(Token = "0x4009DF7")]
    [FieldOffset(Offset = "0x68")]
    private GridData castFrom;

    [Token(Token = "0x600E2BC")]
    [Address(RVA = "0x401C980", Offset = "0x401C980", VA = "0x401C980")]
    public ActiveSkillLogicFromPlayer(
      BoardData board,
      BattlePlayerData actionPlayer,
      GridData castFrom,
      SkillParameterData useSkill,
      TargetPair target)
    {
    }

    [Token(Token = "0x600E2BD")]
    [Address(RVA = "0x401C9C0", Offset = "0x401C9C0", VA = "0x401C9C0", Slot = "4")]
    public override IReadOnlyList<ActionData> Execute() => (IReadOnlyList<ActionData>) null;

    [Token(Token = "0x600E2BE")]
    [Address(RVA = "0x401CB3C", Offset = "0x401CB3C", VA = "0x401CB3C")]
    private List<TargetPair> GetEffectiveTargets() => (List<TargetPair>) null;

    [Token(Token = "0x600E2BF")]
    [Address(RVA = "0x401D1A4", Offset = "0x401D1A4", VA = "0x401D1A4")]
    private bool ApplyActiveSkill(TargetPair targetPair, ref UnitParameterChange targetParamChange)
    {
      return new bool();
    }

    [Token(Token = "0x600E2C0")]
    [Address(RVA = "0x401D470", Offset = "0x401D470", VA = "0x401D470")]
    private void ApplyEffect(
      TargetPair targetPair,
      ICorrectableParameter<IBattleParameter> targetBattleParam,
      EffectData effect,
      ActiveSkillLogicBase.HitResult hitResult,
      ref UnitParameterChange targetUnitParamChange,
      ref bool isPutOperationEnudure,
      out bool isCritical)
    {
    }

    [Token(Token = "0x600E2C1")]
    [Address(RVA = "0x401D8F4", Offset = "0x401D8F4", VA = "0x401D8F4")]
    private EffectLogic.EffectLogicOutputParam ApplyEffectInternal(
      TargetPair targetPair,
      ICorrectableParameter<IBattleParameter> targetBattleParam,
      EffectData effect,
      ref UnitParameterChange targetUnitParamChange,
      ref bool isPutOperationEndure,
      out bool isCritical)
    {
      return (EffectLogic.EffectLogicOutputParam) null;
    }

    [Token(Token = "0x600E2C2")]
    [Address(RVA = "0x401D5AC", Offset = "0x401D5AC", VA = "0x401D5AC")]
    private void AddEffectActionData(EffectData effect)
    {
    }

    [Token(Token = "0x600E2C3")]
    [Address(RVA = "0x401D770", Offset = "0x401D770", VA = "0x401D770")]
    private void AddEffectActionTargetData(
      EffectData effect,
      UnitParameterData targetUnit,
      GridData targetGrid,
      UnitParameterChange beforeParamChange,
      UnitParameterChange afterParamChange,
      bool isHit,
      bool isCritical)
    {
    }
  }
}
