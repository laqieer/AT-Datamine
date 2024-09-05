// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldFrontUnitStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Logic.Prediction;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023EA")]
  public sealed class FieldFrontUnitStatus : FieldUnitStatusBase
  {
    [Token(Token = "0x400995A")]
    [FieldOffset(Offset = "0x30")]
    [Tooltip("ダメージ数値に関するコンテナ")]
    [SerializeField]
    private FieldFrontUnitStatus.DamageContainer damageContainer;
    [Token(Token = "0x400995B")]
    [FieldOffset(Offset = "0x38")]
    [Tooltip("有利値")]
    [SerializeField]
    private ActiveObjectContainers advantageousPoint;
    [Token(Token = "0x400995C")]
    [FieldOffset(Offset = "0x40")]
    [Tooltip("特効値")]
    [SerializeField]
    private ActiveObjectContainers specialEffectPoint;
    [Token(Token = "0x400995D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [Tooltip("ユニット名")]
    private TextMeshProUGUI unitName;
    [Token(Token = "0x400995E")]
    [FieldOffset(Offset = "0x50")]
    [Tooltip("ユニットレベル")]
    [SerializeField]
    private Text unitLevelValue;
    [Token(Token = "0x400995F")]
    [FieldOffset(Offset = "0x58")]
    [Tooltip("HPゲージのタイプ毎のゲームオブジェクトの表示切替設定")]
    [SerializeField]
    private ActiveObjectContainers hpGaugeObjectContainers;
    [Token(Token = "0x4009960")]
    [FieldOffset(Offset = "0x60")]
    [Tooltip("対戦相手に与えるパラメータ表示のタイプ毎のゲームオブジェクトの表示切替設定")]
    [SerializeField]
    private ActiveObjectContainers affectHpObjectContainers;
    [Token(Token = "0x4009961")]
    [FieldOffset(Offset = "0x68")]
    [Tooltip("HPに関する数値とゲージをまとめたコンテナ")]
    [SerializeField]
    private List<FieldFrontUnitStatus.AffectHpContainer> affectHpContainers;
    [Token(Token = "0x4009962")]
    [FieldOffset(Offset = "0x70")]
    [Tooltip("状態変化に関する効果アイコングループコンポーネントのリスト")]
    [SerializeField]
    private List<FieldPredictionAffectEffectGroup> affectEffectGroups;
    [Token(Token = "0x4009963")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private UI.Utilities.SerializeUI.TextContainer hitValueText;
    [Token(Token = "0x4009964")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private UI.Utilities.SerializeUI.TextContainer criticalValueText;

    [Token(Token = "0x600DC11")]
    [Address(RVA = "0x2153B90", Offset = "0x2153B90", VA = "0x2153B90")]
    public void SetName(string name)
    {
    }

    [Token(Token = "0x600DC12")]
    [Address(RVA = "0x2153B9C", Offset = "0x2153B9C", VA = "0x2153B9C")]
    public void SetLevel(int level)
    {
    }

    [Token(Token = "0x600DC13")]
    [Address(RVA = "0x2153BD4", Offset = "0x2153BD4", VA = "0x2153BD4")]
    public void SetAffectHpInformation(
      int beforeHp,
      int afterHp,
      int maxHp,
      int hpStockNumber,
      ForceTypeEnum force)
    {
    }

    [Token(Token = "0x600DC14")]
    [Address(RVA = "0x2153D20", Offset = "0x2153D20", VA = "0x2153D20")]
    public void SetDamageParameter(
      int firstDamage,
      int healPoint,
      int chaseDamage,
      int afterFieldDamage,
      bool isFirstStrike)
    {
    }

    [Token(Token = "0x600DC15")]
    [Address(RVA = "0x2153EBC", Offset = "0x2153EBC", VA = "0x2153EBC")]
    public void SetAdvantageousPoint(int point)
    {
    }

    [Token(Token = "0x600DC16")]
    [Address(RVA = "0x2153F48", Offset = "0x2153F48", VA = "0x2153F48")]
    public void SetSpecialEffectPoint(int point)
    {
    }

    [Token(Token = "0x600DC17")]
    [Address(RVA = "0x2153FD4", Offset = "0x2153FD4", VA = "0x2153FD4")]
    public void SetUnitFullImage(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DC18")]
    [Address(RVA = "0x2154050", Offset = "0x2154050", VA = "0x2154050")]
    public void SetViewHpGaugeParts(bool hasBarrier, bool isHeal)
    {
    }

    [Token(Token = "0x600DC19")]
    [Address(RVA = "0x2154118", Offset = "0x2154118", VA = "0x2154118")]
    public void SetChangeStateEffectIcon(
      PredictionUnitResult.OpponentAffectViewType opponentAffectViewType,
      List<PredictionUnitResult.EffectIcon> effectIcons)
    {
    }

    [Token(Token = "0x600DC1A")]
    [Address(RVA = "0x215455C", Offset = "0x215455C", VA = "0x215455C")]
    public void SetHitRate(int hitRate)
    {
    }

    [Token(Token = "0x600DC1B")]
    [Address(RVA = "0x2154618", Offset = "0x2154618", VA = "0x2154618")]
    public void SetCriticalRate(int criticalRate)
    {
    }

    [Token(Token = "0x600DC1C")]
    [Address(RVA = "0x21546D4", Offset = "0x21546D4", VA = "0x21546D4")]
    public FieldFrontUnitStatus()
    {
    }

    [Token(Token = "0x20023EB")]
    [Serializable]
    public class AdvantageousContainer
    {
      [Token(Token = "0x4009965")]
      [FieldOffset(Offset = "0x10")]
      [Tooltip("表示管理用のルートオブジェクト")]
      [SerializeField]
      private GameObject rootObject;
      [Token(Token = "0x4009966")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      [Tooltip("正数「▲」/負数「▼」を表すアイコン")]
      private Image advantageousIcon;

      [Token(Token = "0x600DC1D")]
      [Address(RVA = "0x21546DC", Offset = "0x21546DC", VA = "0x21546DC")]
      public void SetIconDirection(int point)
      {
      }

      [Token(Token = "0x600DC1E")]
      [Address(RVA = "0x2154738", Offset = "0x2154738", VA = "0x2154738")]
      public AdvantageousContainer()
      {
      }
    }

    [Token(Token = "0x20023EC")]
    [Serializable]
    public class AffectHpContainer
    {
      [Token(Token = "0x4009967")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private string description;
      [Token(Token = "0x4009968")]
      [FieldOffset(Offset = "0x18")]
      public UI.Utilities.SerializeUI.TextContainer beforeHpText;
      [Token(Token = "0x4009969")]
      [FieldOffset(Offset = "0x20")]
      public UI.Utilities.SerializeUI.TextContainer afterHpText;
      [Token(Token = "0x400996A")]
      [FieldOffset(Offset = "0x28")]
      public PredictionUI.HpGaugeContainer hpGaugeContainer;

      [Token(Token = "0x600DC1F")]
      [Address(RVA = "0x2154740", Offset = "0x2154740", VA = "0x2154740")]
      public void Set(
        int beforeHp,
        int afterHp,
        int maxHp,
        int hpStockNumber,
        ForceTypeEnum force)
      {
      }

      [Token(Token = "0x600DC20")]
      [Address(RVA = "0x2154994", Offset = "0x2154994", VA = "0x2154994")]
      private Sprite GetForceBarSprite(ForceTypeEnum force) => (Sprite) null;

      [Token(Token = "0x600DC21")]
      [Address(RVA = "0x2154ACC", Offset = "0x2154ACC", VA = "0x2154ACC")]
      private Sprite GetForceStockSprite(ForceTypeEnum force) => (Sprite) null;

      [Token(Token = "0x600DC22")]
      [Address(RVA = "0x2154C04", Offset = "0x2154C04", VA = "0x2154C04")]
      public AffectHpContainer()
      {
      }
    }

    [Token(Token = "0x20023ED")]
    [Serializable]
    public class DamageContainer
    {
      [Token(Token = "0x400996B")]
      [FieldOffset(Offset = "0x10")]
      [Tooltip("初撃/反撃ダメージ")]
      public UI.Utilities.SerializeUI.TextContainer attackDamage;
      [Token(Token = "0x400996C")]
      [FieldOffset(Offset = "0x18")]
      [Tooltip("回復値")]
      public UI.Utilities.SerializeUI.TextContainer healPoint;
      [Token(Token = "0x400996D")]
      [FieldOffset(Offset = "0x20")]
      [Tooltip("追撃ダメージ")]
      public UI.Utilities.SerializeUI.TextContainer chaseAttackDamage;
      [Token(Token = "0x400996E")]
      [FieldOffset(Offset = "0x28")]
      [Tooltip("デュエル後フィールドダメージ")]
      public UI.Utilities.SerializeUI.TextContainer afterFieldDamage;
      [Token(Token = "0x400996F")]
      [FieldOffset(Offset = "0x30")]
      [Tooltip("先制バッジ")]
      public GameObject firstStrikeBadge;

      [Token(Token = "0x600DC23")]
      [Address(RVA = "0x2153D3C", Offset = "0x2153D3C", VA = "0x2153D3C")]
      public void Set(
        int firstDamage,
        int healPoint,
        int chaseAttackDamage,
        int afterFieldDamage,
        bool isFirstStrike)
      {
      }

      [Token(Token = "0x600DC24")]
      [Address(RVA = "0x2154C0C", Offset = "0x2154C0C", VA = "0x2154C0C")]
      public DamageContainer()
      {
      }
    }
  }
}
