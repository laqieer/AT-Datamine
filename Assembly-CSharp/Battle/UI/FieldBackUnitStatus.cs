// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldBackUnitStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Logic.Prediction;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UI.Utilities.SerializeUI;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023E7")]
  public sealed class FieldBackUnitStatus : FieldUnitStatusBase
  {
    [Token(Token = "0x400994C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ActiveObjectContainers supportSkillActiveObjects;
    [Token(Token = "0x400994D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<FieldBackUnitStatus.AffectHpContainer> changeHpContainers;
    [Token(Token = "0x400994E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ActiveObjectContainers supportTypeNames;
    [Token(Token = "0x400994F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextContainer supportRateText;
    [Token(Token = "0x4009950")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ActiveObjectContainers supportRanks;

    [Token(Token = "0x600DC05")]
    [Address(RVA = "0x215315C", Offset = "0x215315C", VA = "0x215315C")]
    public void SetSupportSkillActiveObjects(
      PredictionUnitResult.OpponentAffectViewType opponentAffectViewType)
    {
    }

    [Token(Token = "0x600DC06")]
    [Address(RVA = "0x21531E8", Offset = "0x21531E8", VA = "0x21531E8")]
    public void SetAffectHpInformation(
      int affectValues,
      int maxHp,
      int beforeGauge,
      int afterGauge,
      int hpStockNumber,
      ForceTypeEnum force)
    {
    }

    [Token(Token = "0x600DC07")]
    [Address(RVA = "0x2153338", Offset = "0x2153338", VA = "0x2153338")]
    public void SetActiveSupportSkillIcon(SkillCategoryTypeEnum? skillCategory = null, int rate = -1)
    {
    }

    [Token(Token = "0x600DC08")]
    [Address(RVA = "0x2153508", Offset = "0x2153508", VA = "0x2153508")]
    public void SetActiveSupportRankIcon(SupportRankTypeEnum? rank)
    {
    }

    [Token(Token = "0x600DC09")]
    [Address(RVA = "0x21535E0", Offset = "0x21535E0", VA = "0x21535E0")]
    public void SetUnitThumbnailImage(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DC0A")]
    [Address(RVA = "0x21536AC", Offset = "0x21536AC", VA = "0x21536AC")]
    public FieldBackUnitStatus()
    {
    }

    [Token(Token = "0x20023E8")]
    [Serializable]
    public class AffectHpContainer
    {
      [Token(Token = "0x4009951")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private string description;
      [Token(Token = "0x4009952")]
      [FieldOffset(Offset = "0x18")]
      public TextContainer affectValueText;
      [Token(Token = "0x4009953")]
      [FieldOffset(Offset = "0x20")]
      public PredictionUI.HpGaugeContainer hpGaugeContainer;

      [Token(Token = "0x600DC0B")]
      [Address(RVA = "0x21536B4", Offset = "0x21536B4", VA = "0x21536B4")]
      public void Set(
        int affectValues,
        int maxHp,
        int beforeGauge,
        int afterGauge,
        int hpStockNumber,
        ForceTypeEnum force)
      {
      }

      [Token(Token = "0x600DC0C")]
      [Address(RVA = "0x21538F0", Offset = "0x21538F0", VA = "0x21538F0")]
      private Sprite GetForceBarSprite(ForceTypeEnum force) => (Sprite) null;

      [Token(Token = "0x600DC0D")]
      [Address(RVA = "0x2153A28", Offset = "0x2153A28", VA = "0x2153A28")]
      private Sprite GetForceStockSprite(ForceTypeEnum force) => (Sprite) null;

      [Token(Token = "0x600DC0E")]
      [Address(RVA = "0x2153B60", Offset = "0x2153B60", VA = "0x2153B60")]
      public AffectHpContainer()
      {
      }
    }
  }
}
