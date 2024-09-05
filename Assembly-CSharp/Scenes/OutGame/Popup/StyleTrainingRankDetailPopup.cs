// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.StyleTrainingRankDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x2003462")]
  public class StyleTrainingRankDetailPopup : PopupBase
  {
    [Token(Token = "0x400E3DE")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private StyleTrainingRankDetailPopup.GaugeInfo lvAndRarityGaugeInfo;
    [Token(Token = "0x400E3DF")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private StyleTrainingRankDetailPopup.GaugeInfo boardGaugeInfo;
    [Token(Token = "0x400E3E0")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private List<StyleTrainingRankDetailPopup.GaugeArrivalPointIcon> arrivalPointIcons;
    [Token(Token = "0x400E3E1")]
    [FieldOffset(Offset = "0xA0")]
    private Style style;
    [Token(Token = "0x400E3E2")]
    [FieldOffset(Offset = "0xA8")]
    private StyleTrainingRankConstData constData;

    [Token(Token = "0x60148F2")]
    [Address(RVA = "0x1AA50AC", Offset = "0x1AA50AC", VA = "0x1AA50AC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60148F3")]
    [Address(RVA = "0x1AA51B4", Offset = "0x1AA51B4", VA = "0x1AA51B4", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x60148F4")]
    [Address(RVA = "0x1AA51C0", Offset = "0x1AA51C0", VA = "0x1AA51C0", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x60148F5")]
    [Address(RVA = "0x1AA5264", Offset = "0x1AA5264", VA = "0x1AA5264", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x60148F6")]
    [Address(RVA = "0x1AA52F4", Offset = "0x1AA52F4", VA = "0x1AA52F4")]
    public IEnumerator Open(Style style) => (IEnumerator) null;

    [Token(Token = "0x60148F7")]
    [Address(RVA = "0x1AA5390", Offset = "0x1AA5390", VA = "0x1AA5390")]
    private void OnFinishTimelineInitialize()
    {
    }

    [Token(Token = "0x60148F8")]
    [Address(RVA = "0x1AA53D0", Offset = "0x1AA53D0", VA = "0x1AA53D0")]
    private void Setup()
    {
    }

    [Token(Token = "0x60148F9")]
    [Address(RVA = "0x1AA59D4", Offset = "0x1AA59D4", VA = "0x1AA59D4")]
    private void ShowArrivalPointIcon(TrainingRankTypeEnum type)
    {
    }

    [Token(Token = "0x60148FA")]
    [Address(RVA = "0x1AA5528", Offset = "0x1AA5528", VA = "0x1AA5528")]
    private void HideArrivalPointIcon()
    {
    }

    [Token(Token = "0x60148FB")]
    [Address(RVA = "0x1AA5674", Offset = "0x1AA5674", VA = "0x1AA5674")]
    private float CalcGaugeValue(float point) => new float();

    [Token(Token = "0x60148FC")]
    [Address(RVA = "0x1AA5B64", Offset = "0x1AA5B64", VA = "0x1AA5B64")]
    public StyleTrainingRankDetailPopup()
    {
    }

    [Token(Token = "0x2003463")]
    [Serializable]
    private class GaugeInfo
    {
      [Token(Token = "0x400E3E3")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private Slider slider;
      [Token(Token = "0x400E3E4")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private TMP_Text ratio;

      [Token(Token = "0x60148FD")]
      [Address(RVA = "0x1AA58EC", Offset = "0x1AA58EC", VA = "0x1AA58EC")]
      public void SetValue(float gaugeValue, float ratioValue)
      {
      }

      [Token(Token = "0x60148FE")]
      [Address(RVA = "0x1AA5B6C", Offset = "0x1AA5B6C", VA = "0x1AA5B6C")]
      public GaugeInfo()
      {
      }
    }

    [Token(Token = "0x2003464")]
    [Serializable]
    private class GaugeArrivalPointIcon
    {
      [Token(Token = "0x400E3E5")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private Image imagePoint;
      [Token(Token = "0x400E3E6")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private TrainingRankTypeEnum type;

      [Token(Token = "0x17004453")]
      public TrainingRankTypeEnum Type
      {
        [Token(Token = "0x60148FF"), Address(RVA = "0x1AA5B74", Offset = "0x1AA5B74", VA = "0x1AA5B74")] get
        {
          return new TrainingRankTypeEnum();
        }
      }

      [Token(Token = "0x6014900")]
      [Address(RVA = "0x1AA5B2C", Offset = "0x1AA5B2C", VA = "0x1AA5B2C")]
      public void SetActive(bool isActive)
      {
      }

      [Token(Token = "0x6014901")]
      [Address(RVA = "0x1AA5B7C", Offset = "0x1AA5B7C", VA = "0x1AA5B7C")]
      public GaugeArrivalPointIcon()
      {
      }
    }
  }
}
