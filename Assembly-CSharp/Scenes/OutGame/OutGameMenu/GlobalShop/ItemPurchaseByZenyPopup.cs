// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.ItemPurchaseByZenyPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BAF")]
  public class ItemPurchaseByZenyPopup : ItemPurchasePopupBase
  {
    [Token(Token = "0x40107F2")]
    private const string COMMON_ATLAS_NAME = "ui_common_splite_spriteatlas";
    [Token(Token = "0x40107F3")]
    private const string ZENY_ICON_NAME = "Img_Icon_Zeny";
    [Token(Token = "0x40107F4")]
    private const string CHAPTER_COIN_NAME = "Img_Icon_ChapterCoins";
    [Token(Token = "0x40107F5")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private Text paymentTitle;
    [Token(Token = "0x40107F6")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private Image[] icons;
    [Token(Token = "0x40107F7")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    private Color zenyIconColor;
    [Token(Token = "0x40107F8")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    private Text zenyBeforeValueTxt;
    [Token(Token = "0x40107F9")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    private Text zenyAfterValueTxt;
    [Token(Token = "0x40107FA")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x6017770")]
    [Address(RVA = "0x26549E4", Offset = "0x26549E4", VA = "0x26549E4", Slot = "14")]
    protected override void SetCostData(int amount)
    {
    }

    [Token(Token = "0x6017771")]
    [Address(RVA = "0x2655008", Offset = "0x2655008", VA = "0x2655008")]
    public ItemPurchaseByZenyPopup()
    {
    }
  }
}
