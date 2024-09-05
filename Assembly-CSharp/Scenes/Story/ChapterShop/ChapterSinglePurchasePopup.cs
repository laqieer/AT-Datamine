// Decompiled with JetBrains decompiler
// Type: Scenes.Story.ChapterShop.ChapterSinglePurchasePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.ChapterShop
{
  [Token(Token = "0x2002F12")]
  public class ChapterSinglePurchasePopup : PopupBase
  {
    [Token(Token = "0x400C9F7")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x400C9F8")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text possessionNum;
    [Token(Token = "0x400C9F9")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text description;
    [Token(Token = "0x400C9FA")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400C9FB")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Slider itemNumSlider;
    [Token(Token = "0x400C9FC")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text purchaseNumber;
    [Token(Token = "0x400C9FD")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text priceText;
    [Token(Token = "0x400C9FE")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject limitIcon;
    [Token(Token = "0x400C9FF")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private LongPressButton plusButton;
    [Token(Token = "0x400CA00")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private LongPressButton minusButton;
    [Token(Token = "0x400CA01")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private RectTransform alertUiParent;
    [Token(Token = "0x400CA02")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Text positiveButtonText;
    [Token(Token = "0x400CA03")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private CommonButton DeactiveBuybutton;
    [Token(Token = "0x400CA04")]
    [FieldOffset(Offset = "0xF0")]
    private int maxItemNum;
    [Token(Token = "0x400CA05")]
    [FieldOffset(Offset = "0xF4")]
    private int addItemNum;
    [Token(Token = "0x400CA06")]
    [FieldOffset(Offset = "0xF8")]
    private bool isCostSufficient;
    [Token(Token = "0x400CA0A")]
    [FieldOffset(Offset = "0x118")]
    private ChapterShopData chapterShopData;
    [Token(Token = "0x400CA0B")]
    [FieldOffset(Offset = "0x120")]
    private bool isBilling;
    [Token(Token = "0x400CA0C")]
    [FieldOffset(Offset = "0x128")]
    private AlertUI alertUi;

    [Token(Token = "0x17003E5E")]
    public Action<int> OnBuyAction
    {
      [Token(Token = "0x6012641"), Address(RVA = "0x2303028", Offset = "0x2303028", VA = "0x2303028")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6012642"), Address(RVA = "0x2303030", Offset = "0x2303030", VA = "0x2303030")] set
      {
      }
    }

    [Token(Token = "0x17003E5F")]
    public Action<bool> OnInsufficientFundsAction
    {
      [Token(Token = "0x6012643"), Address(RVA = "0x2303038", Offset = "0x2303038", VA = "0x2303038")] get
      {
        return (Action<bool>) null;
      }
      [Token(Token = "0x6012644"), Address(RVA = "0x2303040", Offset = "0x2303040", VA = "0x2303040")] set
      {
      }
    }

    [Token(Token = "0x17003E60")]
    public Action<ChapterShopData> OnLongPressAction
    {
      [Token(Token = "0x6012645"), Address(RVA = "0x2303048", Offset = "0x2303048", VA = "0x2303048")] get
      {
        return (Action<ChapterShopData>) null;
      }
      [Token(Token = "0x6012646"), Address(RVA = "0x2303050", Offset = "0x2303050", VA = "0x2303050")] set
      {
      }
    }

    [Token(Token = "0x6012647")]
    [Address(RVA = "0x2303058", Offset = "0x2303058", VA = "0x2303058")]
    public void SetAlertUI(AlertUI alertUI)
    {
    }

    [Token(Token = "0x6012648")]
    [Address(RVA = "0x2303130", Offset = "0x2303130", VA = "0x2303130")]
    private bool IsCurrencyCost() => new bool();

    [Token(Token = "0x6012649")]
    [Address(RVA = "0x230316C", Offset = "0x230316C", VA = "0x230316C")]
    public void SetBuyData(ChapterShopData chapterShopData)
    {
    }

    [Token(Token = "0x601264A")]
    [Address(RVA = "0x23037F4", Offset = "0x23037F4", VA = "0x23037F4")]
    private void SetBuyCountByMinus(bool useSlider = false)
    {
    }

    [Token(Token = "0x601264B")]
    [Address(RVA = "0x230352C", Offset = "0x230352C", VA = "0x230352C")]
    private void SetPurchaseData(int nextValue)
    {
    }

    [Token(Token = "0x601264C")]
    [Address(RVA = "0x2303A60", Offset = "0x2303A60", VA = "0x2303A60")]
    public void OnValueChangeSlider(float notWorkValue)
    {
    }

    [Token(Token = "0x601264D")]
    [Address(RVA = "0x23038B4", Offset = "0x23038B4", VA = "0x23038B4")]
    private void SetBuyCostData(int amount)
    {
    }

    [Token(Token = "0x601264E")]
    [Address(RVA = "0x2303ABC", Offset = "0x2303ABC", VA = "0x2303ABC")]
    public void OnPlusSliderClick()
    {
    }

    [Token(Token = "0x601264F")]
    [Address(RVA = "0x2303AF0", Offset = "0x2303AF0", VA = "0x2303AF0")]
    public void OnPlusSliderLongPress()
    {
    }

    [Token(Token = "0x6012650")]
    [Address(RVA = "0x2303B24", Offset = "0x2303B24", VA = "0x2303B24")]
    public void OnMinusSliderClick()
    {
    }

    [Token(Token = "0x6012651")]
    [Address(RVA = "0x2303B3C", Offset = "0x2303B3C", VA = "0x2303B3C")]
    public void OnMinusSliderLongPress()
    {
    }

    [Token(Token = "0x6012652")]
    [Address(RVA = "0x23036D4", Offset = "0x23036D4", VA = "0x23036D4")]
    private void SetLongPressCallback()
    {
    }

    [Token(Token = "0x6012653")]
    [Address(RVA = "0x2303B54", Offset = "0x2303B54", VA = "0x2303B54")]
    public void OnLongPressToDedscription()
    {
    }

    [Token(Token = "0x6012654")]
    [Address(RVA = "0x2303B74", Offset = "0x2303B74", VA = "0x2303B74")]
    public void OnClickBuyButton()
    {
    }

    [Token(Token = "0x6012655")]
    [Address(RVA = "0x2303BAC", Offset = "0x2303BAC", VA = "0x2303BAC")]
    public void PlayAlertUI()
    {
    }

    [Token(Token = "0x6012656")]
    [Address(RVA = "0x2303CF0", Offset = "0x2303CF0", VA = "0x2303CF0")]
    public void OnClickToDeactiveBuyAction()
    {
    }

    [Token(Token = "0x6012657")]
    [Address(RVA = "0x2303DE0", Offset = "0x2303DE0", VA = "0x2303DE0")]
    public ChapterSinglePurchasePopup()
    {
    }
  }
}
