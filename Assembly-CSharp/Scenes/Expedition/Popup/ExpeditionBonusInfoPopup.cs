// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.ExpeditionBonusInfoPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C5C")]
  public class ExpeditionBonusInfoPopup : PopupBase
  {
    [Token(Token = "0x400BCFD")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private List<GameObject> objectBonusPanels;
    [Token(Token = "0x400BCFE")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject applyingBonusListItemPrefab;
    [Token(Token = "0x400BCFF")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Transform transformApplyingBonusContent;
    [Token(Token = "0x400BD00")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject styleBonusListItemPrefab;
    [Token(Token = "0x400BD01")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Transform transformStyleBonusContent;
    [Token(Token = "0x400BD02")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text textCampaignBonusMessage;

    [Token(Token = "0x17003BF3")]
    public Action CallbackCancel
    {
      [Token(Token = "0x60115F8"), Address(RVA = "0x4E1AAE8", Offset = "0x4E1AAE8", VA = "0x4E1AAE8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60115F9"), Address(RVA = "0x4E1AAF0", Offset = "0x4E1AAF0", VA = "0x4E1AAF0")] set
      {
      }
    }

    [Token(Token = "0x60115FA")]
    [Address(RVA = "0x4E1AAF8", Offset = "0x4E1AAF8", VA = "0x4E1AAF8")]
    public void SetData(BonusType bonusType)
    {
    }

    [Token(Token = "0x60115FB")]
    [Address(RVA = "0x4E1ABF8", Offset = "0x4E1ABF8", VA = "0x4E1ABF8")]
    private void CreateListApplyingBonus()
    {
    }

    [Token(Token = "0x60115FC")]
    [Address(RVA = "0x4E1ACA0", Offset = "0x4E1ACA0", VA = "0x4E1ACA0")]
    private void CreateListStyleBonus()
    {
    }

    [Token(Token = "0x60115FD")]
    [Address(RVA = "0x4E1B170", Offset = "0x4E1B170", VA = "0x4E1B170")]
    private IEnumerator ScrollToTop() => (IEnumerator) null;

    [Token(Token = "0x60115FE")]
    [Address(RVA = "0x4E1AE8C", Offset = "0x4E1AE8C", VA = "0x4E1AE8C")]
    private void SetCampaignBonus(
      float rateExp,
      float rateParara,
      string rateDrop,
      DateTime limitDatetime)
    {
    }

    [Token(Token = "0x60115FF")]
    [Address(RVA = "0x4E1AD48", Offset = "0x4E1AD48", VA = "0x4E1AD48")]
    public void OnClickTab(int selectNumber)
    {
    }

    [Token(Token = "0x6011600")]
    [Address(RVA = "0x4E1B200", Offset = "0x4E1B200", VA = "0x4E1B200", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6011601")]
    [Address(RVA = "0x4E1B21C", Offset = "0x4E1B21C", VA = "0x4E1B21C")]
    public ExpeditionBonusInfoPopup()
    {
    }
  }
}
