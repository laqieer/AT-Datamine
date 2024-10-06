// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.SaleItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BC9")]
  public class SaleItemData : MonoBehaviour
  {
    [Token(Token = "0x401089A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x401089B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform itemIconParent;
    [Token(Token = "0x401089C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text saleNum;
    [Token(Token = "0x401089D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text selectNum;
    [Token(Token = "0x401089E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text possessionNum;
    [Token(Token = "0x401089F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text price;
    [Token(Token = "0x40108A0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text saleSelectCount;
    [Token(Token = "0x40108A1")]
    [FieldOffset(Offset = "0x50")]
    [Header("0 = 1の位, 1 = 10の位")]
    [SerializeField]
    private Image[] selectNumberImages;
    [Token(Token = "0x40108A2")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject selectNumObject;
    [Token(Token = "0x40108A3")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject deactiveImage;
    [Token(Token = "0x40108A4")]
    [FieldOffset(Offset = "0x68")]
    private ItemIcon itemIcon;
    [Token(Token = "0x40108A5")]
    [FieldOffset(Offset = "0x70")]
    private ItemListData itemListData;

    [Token(Token = "0x17004C5B")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6017815"), Address(RVA = "0x265B294", Offset = "0x265B294", VA = "0x265B294")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004C5C")]
    public ItemListData ItemListData
    {
      [Token(Token = "0x6017816"), Address(RVA = "0x265B29C", Offset = "0x265B29C", VA = "0x265B29C")] get
      {
        return (ItemListData) null;
      }
    }

    [Token(Token = "0x17004C5D")]
    public Action<ItemListData> OnClickToItemSelect
    {
      [Token(Token = "0x6017817"), Address(RVA = "0x265B2A4", Offset = "0x265B2A4", VA = "0x265B2A4")] get
      {
        return (Action<ItemListData>) null;
      }
      [Token(Token = "0x6017818"), Address(RVA = "0x265B2AC", Offset = "0x265B2AC", VA = "0x265B2AC")] set
      {
      }
    }

    [Token(Token = "0x17004C5E")]
    public Action OnClickToDeactiveAlertAction
    {
      [Token(Token = "0x6017819"), Address(RVA = "0x265B2B4", Offset = "0x265B2B4", VA = "0x265B2B4")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601781A"), Address(RVA = "0x265B2BC", Offset = "0x265B2BC", VA = "0x265B2BC")] set
      {
      }
    }

    [Token(Token = "0x601781B")]
    [Address(RVA = "0x265B2C4", Offset = "0x265B2C4", VA = "0x265B2C4")]
    public void Initialize(ItemListData itemListData, int selectCount, Sprite costIconSprite)
    {
    }

    [Token(Token = "0x601781C")]
    [Address(RVA = "0x265B3F0", Offset = "0x265B3F0", VA = "0x265B3F0")]
    public void SetData(
      ItemListData itemListData,
      int saleIndex,
      int saleSelectCount,
      GameObject itemIconPrefab,
      Sprite[] selectNumberSprites)
    {
    }

    [Token(Token = "0x601781D")]
    [Address(RVA = "0x265B7B8", Offset = "0x265B7B8", VA = "0x265B7B8")]
    public void SetSelectNum(int num)
    {
    }

    [Token(Token = "0x601781E")]
    [Address(RVA = "0x265B884", Offset = "0x265B884", VA = "0x265B884")]
    public void SetIndexNum(int index, Sprite[] selectNumberSprites)
    {
    }

    [Token(Token = "0x601781F")]
    [Address(RVA = "0x265B978", Offset = "0x265B978", VA = "0x265B978")]
    public void SetDeactiveObject(bool isActive)
    {
    }

    [Token(Token = "0x6017820")]
    [Address(RVA = "0x265B9A8", Offset = "0x265B9A8", VA = "0x265B9A8")]
    public void OnClickToItem()
    {
    }

    [Token(Token = "0x6017821")]
    [Address(RVA = "0x265B9C8", Offset = "0x265B9C8", VA = "0x265B9C8")]
    public void OnClickToDeactiveAlert()
    {
    }

    [Token(Token = "0x6017822")]
    [Address(RVA = "0x265B9E4", Offset = "0x265B9E4", VA = "0x265B9E4")]
    public SaleItemData()
    {
    }
  }
}
