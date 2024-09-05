// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.ItemPurchaseByJewelPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BAD")]
  public class ItemPurchaseByJewelPopup : ItemPurchasePopupBase
  {
    [Token(Token = "0x40107E6")]
    private const string TWEEN_NORMAL_TEXT_COLOR = "NormalValueColor";
    [Token(Token = "0x40107E7")]
    private const string TWEEN_ALERT_TEXT_COLOR = "MinusValueColor";
    [Token(Token = "0x40107E8")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private Text paidAfterValueTxt;
    [Token(Token = "0x40107E9")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private Text freeAfterValueTxt;
    [Token(Token = "0x40107EA")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    private Text specialCommercialLawButtonTxt;
    [Token(Token = "0x40107EB")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    private GameObject[] freeCoinIconObjects;
    [Token(Token = "0x40107EC")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    private GameObject[] paidCoinIconObjects;
    [Token(Token = "0x40107ED")]
    [FieldOffset(Offset = "0x1B0")]
    private int amount;
    [Token(Token = "0x40107EE")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    private UITweenGroup tweenGroup;

    [Token(Token = "0x6017764")]
    [Address(RVA = "0x2653C60", Offset = "0x2653C60", VA = "0x2653C60", Slot = "10")]
    protected override void SetButtonText()
    {
    }

    [Token(Token = "0x6017765")]
    [Address(RVA = "0x2653E14", Offset = "0x2653E14", VA = "0x2653E14", Slot = "16")]
    protected override void UpdateCost()
    {
    }

    [Token(Token = "0x6017766")]
    [Address(RVA = "0x2653E28", Offset = "0x2653E28", VA = "0x2653E28", Slot = "13")]
    public override void PlayAlertUI()
    {
    }

    [Token(Token = "0x6017767")]
    [Address(RVA = "0x2654068", Offset = "0x2654068", VA = "0x2654068")]
    private void SetCoinIcons(bool isFreeCoin)
    {
    }

    [Token(Token = "0x6017768")]
    [Address(RVA = "0x2654108", Offset = "0x2654108", VA = "0x2654108", Slot = "14")]
    protected override void SetCostData(int amount)
    {
    }

    [Token(Token = "0x6017769")]
    [Address(RVA = "0x2654668", Offset = "0x2654668", VA = "0x2654668", Slot = "15")]
    protected override void SetCountByMinus(bool isCountMax = false)
    {
    }

    [Token(Token = "0x601776A")]
    [Address(RVA = "0x26547F0", Offset = "0x26547F0", VA = "0x26547F0")]
    public void OnClickToSpecialCommercialLaw()
    {
    }

    [Token(Token = "0x601776B")]
    [Address(RVA = "0x26547F8", Offset = "0x26547F8", VA = "0x26547F8")]
    public ItemPurchaseByJewelPopup()
    {
    }
  }
}
