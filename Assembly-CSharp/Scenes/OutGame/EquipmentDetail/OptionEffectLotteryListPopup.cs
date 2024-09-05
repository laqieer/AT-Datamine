// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.OptionEffectLotteryListPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using UI.Common;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x200368F")]
  public class OptionEffectLotteryListPopup : PopupBase
  {
    [Token(Token = "0x400ED58")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UITimelineController bgTimeline;
    [Token(Token = "0x400ED59")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private OptionEffectLotteryItemController lotteryItemController;
    [Token(Token = "0x400ED5A")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private BtnFullScreen _bgButton;

    [Token(Token = "0x6015766")]
    [Address(RVA = "0x18E75B0", Offset = "0x18E75B0", VA = "0x18E75B0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6015767")]
    [Address(RVA = "0x18E7678", Offset = "0x18E7678", VA = "0x18E7678")]
    public IEnumerator OpenWeapon(Weapon weapon) => (IEnumerator) null;

    [Token(Token = "0x6015768")]
    [Address(RVA = "0x18E7714", Offset = "0x18E7714", VA = "0x18E7714")]
    public IEnumerator OpenShieldAccessory(Accessory accessory) => (IEnumerator) null;

    [Token(Token = "0x6015769")]
    [Address(RVA = "0x18E77B0", Offset = "0x18E77B0", VA = "0x18E77B0", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x601576A")]
    [Address(RVA = "0x18E78C4", Offset = "0x18E78C4", VA = "0x18E78C4")]
    public OptionEffectLotteryListPopup()
    {
    }
  }
}
