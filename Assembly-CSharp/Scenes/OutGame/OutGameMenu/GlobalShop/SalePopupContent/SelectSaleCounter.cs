// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.SalePopupContent.SelectSaleCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop.SalePopupContent
{
  [Token(Token = "0x2003BDC")]
  public class SelectSaleCounter : MonoBehaviour
  {
    [Token(Token = "0x4010953")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x4010954")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform itemIconParent;
    [Token(Token = "0x4010955")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text selectNumTxt;
    [Token(Token = "0x4010956")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text maxNumTxt;
    [Token(Token = "0x4010957")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI oneSaleTxt;
    [Token(Token = "0x4010958")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI totalSaleTxt;
    [Token(Token = "0x4010959")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text beforeZenyTxt;
    [Token(Token = "0x401095A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text afterZenyTxt;
    [Token(Token = "0x401095B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private LongPressButton plusButton;
    [Token(Token = "0x401095C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private LongPressButton minusButton;
    [Token(Token = "0x401095D")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    protected CommonButton plusMaxButton;
    [Token(Token = "0x401095E")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    protected CommonButton minusResetButton;
    [Token(Token = "0x401095F")]
    [FieldOffset(Offset = "0x78")]
    private int maxItemNum;
    [Token(Token = "0x4010960")]
    [FieldOffset(Offset = "0x7C")]
    private int addItemNum;
    [Token(Token = "0x4010961")]
    [FieldOffset(Offset = "0x80")]
    private ItemIcon createdItemIcon;
    [Token(Token = "0x4010962")]
    [FieldOffset(Offset = "0x88")]
    private ItemListData itemListData;
    [Token(Token = "0x4010964")]
    [FieldOffset(Offset = "0x98")]
    private int salePrice;

    [Token(Token = "0x17004C72")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6017896"), Address(RVA = "0x237755C", Offset = "0x237755C", VA = "0x237755C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004C73")]
    public int AddItemNum
    {
      [Token(Token = "0x6017897"), Address(RVA = "0x2377564", Offset = "0x2377564", VA = "0x2377564")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004C74")]
    public Action<ItemIcon> OnClickItemAction
    {
      [Token(Token = "0x6017898"), Address(RVA = "0x237756C", Offset = "0x237756C", VA = "0x237756C")] get
      {
        return (Action<ItemIcon>) null;
      }
      [Token(Token = "0x6017899"), Address(RVA = "0x2377574", Offset = "0x2377574", VA = "0x2377574")] set
      {
      }
    }

    [Token(Token = "0x601789A")]
    [Address(RVA = "0x237757C", Offset = "0x237757C", VA = "0x237757C")]
    public void SetSaleData(
      ItemListData itemListData,
      GameObject itemIconPrefab,
      int selectedCount,
      int salePrice)
    {
    }

    [Token(Token = "0x601789B")]
    [Address(RVA = "0x2377924", Offset = "0x2377924", VA = "0x2377924")]
    private void SetLongPressCallback()
    {
    }

    [Token(Token = "0x601789C")]
    [Address(RVA = "0x2377BF4", Offset = "0x2377BF4", VA = "0x2377BF4")]
    private void SetSaleData(int amount)
    {
    }

    [Token(Token = "0x601789D")]
    [Address(RVA = "0x2377910", Offset = "0x2377910", VA = "0x2377910")]
    private string GetNumText(int num) => (string) null;

    [Token(Token = "0x601789E")]
    [Address(RVA = "0x237791C", Offset = "0x237791C", VA = "0x237791C")]
    private void SetPurchaseData(int nextValue)
    {
    }

    [Token(Token = "0x601789F")]
    [Address(RVA = "0x2377DC0", Offset = "0x2377DC0", VA = "0x2377DC0")]
    public void OnPlusClick()
    {
    }

    [Token(Token = "0x60178A0")]
    [Address(RVA = "0x2377E9C", Offset = "0x2377E9C", VA = "0x2377E9C")]
    public void OnPlusLongPress()
    {
    }

    [Token(Token = "0x60178A1")]
    [Address(RVA = "0x2377F78", Offset = "0x2377F78", VA = "0x2377F78")]
    public void OnPlusMaxClick()
    {
    }

    [Token(Token = "0x60178A2")]
    [Address(RVA = "0x2378048", Offset = "0x2378048", VA = "0x2378048")]
    public void OnMinusClick()
    {
    }

    [Token(Token = "0x60178A3")]
    [Address(RVA = "0x237805C", Offset = "0x237805C", VA = "0x237805C")]
    public void OnMinusLongPress()
    {
    }

    [Token(Token = "0x60178A4")]
    [Address(RVA = "0x2378070", Offset = "0x2378070", VA = "0x2378070")]
    public void OnMinusResetClick()
    {
    }

    [Token(Token = "0x60178A5")]
    [Address(RVA = "0x237807C", Offset = "0x237807C", VA = "0x237807C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60178A6")]
    [Address(RVA = "0x2378120", Offset = "0x2378120", VA = "0x2378120")]
    public SelectSaleCounter()
    {
    }
  }
}
