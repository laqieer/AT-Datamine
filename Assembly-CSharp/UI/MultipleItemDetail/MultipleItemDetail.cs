// Decompiled with JetBrains decompiler
// Type: UI.MultipleItemDetail.MultipleItemDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using TMPro;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.MultipleItemDetail
{
  [Token(Token = "0x20008B6")]
  public class MultipleItemDetail : MonoBehaviour
  {
    [Token(Token = "0x40028DE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x40028DF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text possessionItemQuantity;
    [Token(Token = "0x40028E0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text sellingPrice;
    [Token(Token = "0x40028E1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI flavor;
    [Token(Token = "0x40028E2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RectTransform tagRoot;
    [Token(Token = "0x40028E3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RectTransform parent;
    [Token(Token = "0x40028E4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<ItemUseTag> itemUseTags;

    [Token(Token = "0x6003177")]
    [Address(RVA = "0x3C17EA0", Offset = "0x3C17EA0", VA = "0x3C17EA0")]
    public void Initialize(MultipleItemDetailParamater parameter)
    {
    }

    [Token(Token = "0x6003178")]
    [Address(RVA = "0x3C18124", Offset = "0x3C18124", VA = "0x3C18124")]
    private int GetSaleNum(ItemTypeEnum itemTypeEnum, int itemId, ItemUtility.Parameter param)
    {
      return new int();
    }

    [Token(Token = "0x6003179")]
    [Address(RVA = "0x3C1820C", Offset = "0x3C1820C", VA = "0x3C1820C")]
    private void SetUsageNames(int itemId, ItemTypeEnum itemType)
    {
    }

    [Token(Token = "0x600317A")]
    [Address(RVA = "0x3C188E4", Offset = "0x3C188E4", VA = "0x3C188E4")]
    public MultipleItemDetail()
    {
    }
  }
}
