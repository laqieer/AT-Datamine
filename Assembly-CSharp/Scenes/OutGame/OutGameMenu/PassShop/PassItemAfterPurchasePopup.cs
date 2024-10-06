// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.PassShop.PassItemAfterPurchasePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Data;
using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using PurchaseModule.Product;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.PassShop
{
  [Token(Token = "0x2003B3E")]
  public class PassItemAfterPurchasePopup : PopupBase
  {
    [Token(Token = "0x40105AD")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x40105AE")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text paidCoinNum;
    [Token(Token = "0x40105AF")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text addPaidCoinNum;
    [Token(Token = "0x40105B0")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private RectTransform nonScrollParent;
    [Token(Token = "0x40105B1")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private RectTransform scrollParent;

    [Token(Token = "0x17004C07")]
    public Action<ItemPurchaseData.ItemRewardData> OnClickItemAction
    {
      [Token(Token = "0x6017506"), Address(RVA = "0x2720A70", Offset = "0x2720A70", VA = "0x2720A70")] get
      {
        return (Action<ItemPurchaseData.ItemRewardData>) null;
      }
      [Token(Token = "0x6017507"), Address(RVA = "0x2720A78", Offset = "0x2720A78", VA = "0x2720A78")] set
      {
      }
    }

    [Token(Token = "0x6017508")]
    [Address(RVA = "0x2720A80", Offset = "0x2720A80", VA = "0x2720A80")]
    public void SetData(
      CommonShopItemData commonShopItem,
      GameObject passGroupItemPrefab,
      GameObject passItemPrefab,
      AssetCachedSpawner cachedSpawner)
    {
    }

    [Token(Token = "0x6017509")]
    [Address(RVA = "0x2721398", Offset = "0x2721398", VA = "0x2721398")]
    public void SetData(
      ProductInfo productInfo,
      int AddPaidCoin,
      int passId,
      GameObject passGroupItemPrefab,
      GameObject passItemPrefab,
      AssetCachedSpawner cachedSpawner)
    {
    }

    [Token(Token = "0x601750A")]
    [Address(RVA = "0x2721498", Offset = "0x2721498", VA = "0x2721498")]
    public void SetItemData(int beforePaidCoin, int afterPaidCoin, string articleName)
    {
    }

    [Token(Token = "0x601750B")]
    [Address(RVA = "0x2720BC0", Offset = "0x2720BC0", VA = "0x2720BC0")]
    private void CreateItems(
      ProductInfo productInfo,
      int AddPaidCoin,
      CommonShopItemData.CommonShopInsideData insideData,
      int loginBounsId,
      GameObject passGroupItemPrefab,
      GameObject passItemPrefab,
      AssetCachedSpawner cachedSpawner)
    {
    }

    [Token(Token = "0x601750C")]
    [Address(RVA = "0x27219B0", Offset = "0x27219B0", VA = "0x27219B0")]
    private void CreateItems(
      CommonShopItemData commonShopItem,
      int loginBounsId,
      GameObject passGroupItemPrefab,
      GameObject passItemPrefab,
      AssetCachedSpawner cachedSpawner)
    {
    }

    [Token(Token = "0x601750D")]
    [Address(RVA = "0x27221C4", Offset = "0x27221C4", VA = "0x27221C4")]
    public PassItemAfterPurchasePopup()
    {
    }
  }
}
