// Decompiled with JetBrains decompiler
// Type: Scenes.Story.ChapterShop.ChapterShopItemList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Story.ChapterShop
{
  [Token(Token = "0x2002EF7")]
  public class ChapterShopItemList : MonoBehaviour
  {
    [Token(Token = "0x400C962")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x400C963")]
    [FieldOffset(Offset = "0x20")]
    private List<ChapterShopItem> chapterShopItemList;
    [Token(Token = "0x400C966")]
    [FieldOffset(Offset = "0x38")]
    private GameObject chapterShopItemBase;
    [Token(Token = "0x400C967")]
    [FieldOffset(Offset = "0x40")]
    private ChapterShopLoader loader;

    [Token(Token = "0x17003E45")]
    public Action<ChapterShopItem.ShopItemType, ChapterShopData> OnClickShopItemAction
    {
      [Token(Token = "0x601259F"), Address(RVA = "0x22FB340", Offset = "0x22FB340", VA = "0x22FB340")] get
      {
        return (Action<ChapterShopItem.ShopItemType, ChapterShopData>) null;
      }
      [Token(Token = "0x60125A0"), Address(RVA = "0x22FB348", Offset = "0x22FB348", VA = "0x22FB348")] set
      {
      }
    }

    [Token(Token = "0x17003E46")]
    public Action<ChapterShopData> OnClickDescriptionAction
    {
      [Token(Token = "0x60125A1"), Address(RVA = "0x22FB350", Offset = "0x22FB350", VA = "0x22FB350")] get
      {
        return (Action<ChapterShopData>) null;
      }
      [Token(Token = "0x60125A2"), Address(RVA = "0x22FB358", Offset = "0x22FB358", VA = "0x22FB358")] set
      {
      }
    }

    [Token(Token = "0x60125A3")]
    [Address(RVA = "0x22FB360", Offset = "0x22FB360", VA = "0x22FB360")]
    public void SetShopItemBase(GameObject chapterShopItemBase)
    {
    }

    [Token(Token = "0x60125A4")]
    [Address(RVA = "0x22FB368", Offset = "0x22FB368", VA = "0x22FB368")]
    public void SetAssetLoader(ChapterShopLoader loader)
    {
    }

    [Token(Token = "0x60125A5")]
    [Address(RVA = "0x22F8FF0", Offset = "0x22F8FF0", VA = "0x22F8FF0")]
    public void InitializeBySingle(ChapterShopData[] chapterShopDataList)
    {
    }

    [Token(Token = "0x60125A6")]
    [Address(RVA = "0x22FB370", Offset = "0x22FB370", VA = "0x22FB370")]
    private void SetupCreatedListItem()
    {
    }

    [Token(Token = "0x60125A7")]
    [Address(RVA = "0x22FB4D4", Offset = "0x22FB4D4", VA = "0x22FB4D4")]
    public void OnClickItem(
      ChapterShopItem.ShopItemType chapterShopItemType,
      ChapterShopData chapterShop)
    {
    }

    [Token(Token = "0x60125A8")]
    [Address(RVA = "0x22FB4F0", Offset = "0x22FB4F0", VA = "0x22FB4F0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60125A9")]
    [Address(RVA = "0x22FB6C0", Offset = "0x22FB6C0", VA = "0x22FB6C0")]
    public ChapterShopItemList()
    {
    }
  }
}
