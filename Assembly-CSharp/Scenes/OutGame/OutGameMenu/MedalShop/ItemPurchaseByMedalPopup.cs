// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MedalShop.ItemPurchaseByMedalPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu.GlobalShop;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.MedalShop
{
  [Token(Token = "0x2003B01")]
  public class ItemPurchaseByMedalPopup : ItemPurchasePopupBase
  {
    [Token(Token = "0x401042E")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private Image paymentIcon;
    [Token(Token = "0x401042F")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private Text paymentTitle;
    [Token(Token = "0x4010430")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    private Text medalBeforeValueTxt;
    [Token(Token = "0x4010431")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    private Text medalAfterValueTxt;

    [Token(Token = "0x6017382")]
    [Address(RVA = "0x301CFA0", Offset = "0x301CFA0", VA = "0x301CFA0", Slot = "10")]
    protected override void SetButtonText()
    {
    }

    [Token(Token = "0x6017383")]
    [Address(RVA = "0x301D0A8", Offset = "0x301D0A8", VA = "0x301D0A8", Slot = "14")]
    protected override void SetCostData(int amount)
    {
    }

    [Token(Token = "0x6017384")]
    [Address(RVA = "0x301D31C", Offset = "0x301D31C", VA = "0x301D31C")]
    public ItemPurchaseByMedalPopup()
    {
    }
  }
}
