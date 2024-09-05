// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.SalePopupContent.SaleCheckContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop.SalePopupContent
{
  [Token(Token = "0x2003BDA")]
  public class SaleCheckContainer : MonoBehaviour
  {
    [Token(Token = "0x4010948")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x4010949")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform itemIconParent;
    [Token(Token = "0x401094A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject wraningObj;
    [Token(Token = "0x401094B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text wraningText;
    [Token(Token = "0x401094C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject wraningImageObj;
    [Token(Token = "0x401094D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI salaZenyTxt;
    [Token(Token = "0x401094E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text beforeZenyTxt;
    [Token(Token = "0x401094F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text afterZenyTxt;
    [Token(Token = "0x4010950")]
    [FieldOffset(Offset = "0x58")]
    private List<ItemIcon> createdItemIconList;

    [Token(Token = "0x17004C71")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x601788E"), Address(RVA = "0x2376B4C", Offset = "0x2376B4C", VA = "0x2376B4C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x601788F")]
    [Address(RVA = "0x2376B54", Offset = "0x2376B54", VA = "0x2376B54")]
    public void SetSaleCheckData(
      Dictionary<ItemListData, int> saleCountMap,
      bool isExchangeOnly,
      GameObject itemIconPrefab)
    {
    }

    [Token(Token = "0x6017890")]
    [Address(RVA = "0x2377320", Offset = "0x2377320", VA = "0x2377320")]
    public void AfterSaleData(int prevZeny, int getZeny)
    {
    }

    [Token(Token = "0x6017891")]
    [Address(RVA = "0x2377314", Offset = "0x2377314", VA = "0x2377314")]
    private string GetNumText(int num) => (string) null;

    [Token(Token = "0x6017892")]
    [Address(RVA = "0x2377454", Offset = "0x2377454", VA = "0x2377454")]
    public SaleCheckContainer()
    {
    }
  }
}
