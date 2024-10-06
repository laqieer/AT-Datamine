// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.DuelData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Logic;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x2002546")]
  public sealed class DuelData
  {
    [Token(Token = "0x400A059")]
    [FieldOffset(Offset = "0x10")]
    public List<ActionData> Actions;
    [Token(Token = "0x400A05A")]
    [FieldOffset(Offset = "0x18")]
    public readonly BoardData Board;
    [Token(Token = "0x400A05B")]
    [FieldOffset(Offset = "0x20")]
    public readonly InDuelEffectTimingTypeEnum DuelTiming;
    [Token(Token = "0x400A05C")]
    [FieldOffset(Offset = "0x28")]
    public readonly UnitParameterData Attacker;
    [Token(Token = "0x400A05D")]
    [FieldOffset(Offset = "0x30")]
    public readonly UnitParameterData AttackerSupporter;
    [Token(Token = "0x400A05E")]
    [FieldOffset(Offset = "0x38")]
    public IReadOnlyList<UnitParameterData> AttackerBackupUnits;
    [Token(Token = "0x400A05F")]
    [FieldOffset(Offset = "0x40")]
    public readonly DuelLogicFluctuationParam? AttackerFluctuation;
    [Token(Token = "0x400A060")]
    [FieldOffset(Offset = "0x90")]
    public readonly UnitParameterData Defender;
    [Token(Token = "0x400A061")]
    [FieldOffset(Offset = "0x98")]
    public readonly UnitParameterData DefenderSupporter;
    [Token(Token = "0x400A062")]
    [FieldOffset(Offset = "0xA0")]
    public readonly DuelLogicFluctuationParam? DefenderFluctuation;
    [Token(Token = "0x400A063")]
    [FieldOffset(Offset = "0xF0")]
    public readonly GridData ActionTargetGrid;
    [Token(Token = "0x400A064")]
    [FieldOffset(Offset = "0xF8")]
    public readonly SkillParameterData Skill;
    [Token(Token = "0x400A065")]
    [FieldOffset(Offset = "0x100")]
    public readonly string PrimaryDuelSceneName;
    [Token(Token = "0x400A066")]
    [FieldOffset(Offset = "0x108")]
    public UnitParameterChange OwnerBeforeParam;
    [Token(Token = "0x400A067")]
    [FieldOffset(Offset = "0x110")]
    public UnitParameterChange OwnerAfterParam;
    [Token(Token = "0x400A068")]
    [FieldOffset(Offset = "0x118")]
    public List<SupportData> SupportSkillCountList;
    [Token(Token = "0x400A069")]
    [FieldOffset(Offset = "0x120")]
    public List<DuelTargetResultData> TargetResults;

    [Token(Token = "0x17003176")]
    public DuelData.SnapShot PreSnapShot
    {
      [Token(Token = "0x600E62B"), Address(RVA = "0x486CE84", Offset = "0x486CE84", VA = "0x486CE84")] get
      {
        return (DuelData.SnapShot) null;
      }
      [Token(Token = "0x600E62C"), Address(RVA = "0x486CE8C", Offset = "0x486CE8C", VA = "0x486CE8C")] private set
      {
      }
    }

    [Token(Token = "0x17003177")]
    public bool IsDefenderFirstStrikable
    {
      [Token(Token = "0x600E62D"), Address(RVA = "0x486CE94", Offset = "0x486CE94", VA = "0x486CE94")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E62E")]
    [Address(RVA = "0x486CF0C", Offset = "0x486CF0C", VA = "0x486CF0C")]
    public DuelData(
      ActionContext context,
      InDuelEffectTimingTypeEnum timing,
      DuelLogicFluctuationParam? attackerFluctuation = null,
      DuelLogicFluctuationParam? defenderFluctuation = null,
      bool isDuelFlag = false)
    {
    }

    [Token(Token = "0x600E62F")]
    [Address(RVA = "0x486D6A8", Offset = "0x486D6A8", VA = "0x486D6A8")]
    public DuelTargetResultData FindTargetResultData(UnitParameterData target)
    {
      return (DuelTargetResultData) null;
    }

    [Token(Token = "0x600E630")]
    [Address(RVA = "0x486D80C", Offset = "0x486D80C", VA = "0x486D80C")]
    public string ToJson() => (string) null;

    [Token(Token = "0x2002547")]
    public class SnapShot
    {
      [Token(Token = "0x400A06B")]
      [FieldOffset(Offset = "0x10")]
      public readonly UnitParameterData Attacker;
      [Token(Token = "0x400A06C")]
      [FieldOffset(Offset = "0x18")]
      public readonly UnitParameterData AttackerSupporter;
      [Token(Token = "0x400A06D")]
      [FieldOffset(Offset = "0x20")]
      public readonly UnitParameterData Defender;
      [Token(Token = "0x400A06E")]
      [FieldOffset(Offset = "0x28")]
      public readonly UnitParameterData DefenderSupporter;

      [Token(Token = "0x600E631")]
      [Address(RVA = "0x486D5C4", Offset = "0x486D5C4", VA = "0x486D5C4")]
      public SnapShot(
        UnitParameterData attacker,
        UnitParameterData attackerSupporter,
        UnitParameterData defender,
        UnitParameterData defenderSupporter)
      {
      }
    }
  }
}
