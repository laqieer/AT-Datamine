// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ShopAPIManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.API;
using Network.Param;
using PurchaseModule.Enum;
using PurchaseModule.Product;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A14")]
  public class ShopAPIManager
  {
    [Token(Token = "0x400FE3B")]
    [FieldOffset(Offset = "0x10")]
    private bool isConnectingApi;
    [Token(Token = "0x400FE3D")]
    [FieldOffset(Offset = "0x18")]
    private List<PlayerShopType> shopList;
    [Token(Token = "0x400FE3E")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, PlayerShopArticleType[]> shopGroupingData;
    [Token(Token = "0x400FE3F")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<string, ProductInfo> products;
    [Token(Token = "0x400FE41")]
    [FieldOffset(Offset = "0x38")]
    public List<PlayerShopArticleType> PassShopDataList;
    [Token(Token = "0x400FE42")]
    [FieldOffset(Offset = "0x40")]
    private bool isPlatformUnavailableError;

    [Token(Token = "0x17004AED")]
    public bool IsConnectingApi
    {
      [Token(Token = "0x6016D31"), Address(RVA = "0x2C57884", Offset = "0x2C57884", VA = "0x2C57884")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004AEE")]
    public bool IsBuying
    {
      [Token(Token = "0x6016D32"), Address(RVA = "0x2C5788C", Offset = "0x2C5788C", VA = "0x2C5788C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6016D33"), Address(RVA = "0x2C57894", Offset = "0x2C57894", VA = "0x2C57894")] set
      {
      }
    }

    [Token(Token = "0x17004AEF")]
    public List<PlayerShopType> ShopList
    {
      [Token(Token = "0x6016D34"), Address(RVA = "0x2C578A0", Offset = "0x2C578A0", VA = "0x2C578A0")] get
      {
        return (List<PlayerShopType>) null;
      }
    }

    [Token(Token = "0x17004AF0")]
    public Dictionary<int, PlayerShopArticleType[]> ShopGroupingData
    {
      [Token(Token = "0x6016D35"), Address(RVA = "0x2C578A8", Offset = "0x2C578A8", VA = "0x2C578A8")] get
      {
        return (Dictionary<int, PlayerShopArticleType[]>) null;
      }
    }

    [Token(Token = "0x17004AF1")]
    public Dictionary<string, ProductInfo> Products
    {
      [Token(Token = "0x6016D36"), Address(RVA = "0x2C578B0", Offset = "0x2C578B0", VA = "0x2C578B0")] get
      {
        return (Dictionary<string, ProductInfo>) null;
      }
    }

    [Token(Token = "0x6016D37")]
    [Address(RVA = "0x2C578B8", Offset = "0x2C578B8", VA = "0x2C578B8")]
    public bool IsEmptyCheckByProductList() => new bool();

    [Token(Token = "0x17004AF2")]
    public bool IsLineupUpdate
    {
      [Token(Token = "0x6016D38"), Address(RVA = "0x2C57918", Offset = "0x2C57918", VA = "0x2C57918")] get
      {
        return new bool();
      }
      [Token(Token = "0x6016D39"), Address(RVA = "0x2C57920", Offset = "0x2C57920", VA = "0x2C57920")] set
      {
      }
    }

    [Token(Token = "0x17004AF3")]
    public bool IsPlatformUnavailableError
    {
      [Token(Token = "0x6016D3A"), Address(RVA = "0x2C5792C", Offset = "0x2C5792C", VA = "0x2C5792C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6016D3B")]
    [Address(RVA = "0x2C54450", Offset = "0x2C54450", VA = "0x2C54450")]
    public PlayerShopArticleType[] GetShopData(int shopIndex) => (PlayerShopArticleType[]) null;

    [Token(Token = "0x6016D3C")]
    [Address(RVA = "0x2C57934", Offset = "0x2C57934", VA = "0x2C57934")]
    private void SetShopData(List<PlayerShopType> shops, List<PlayerShopArticleType> articles)
    {
    }

    [Token(Token = "0x6016D3D")]
    [Address(RVA = "0x2C56898", Offset = "0x2C56898", VA = "0x2C56898")]
    public IEnumerator CallShopAPI(Action onFinishCallback = null) => (IEnumerator) null;

    [Token(Token = "0x6016D3E")]
    [Address(RVA = "0x2C57F20", Offset = "0x2C57F20", VA = "0x2C57F20")]
    public IEnumerator CallShopUpdateAPI(
      int shopId,
      Action onFinishCallback,
      Func<NetworkErrorResult, IEnumerator> errorUpdate)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016D3F")]
    [Address(RVA = "0x2C57FD4", Offset = "0x2C57FD4", VA = "0x2C57FD4")]
    private bool IsTimeCheck(PlayerShopType playerShop) => new bool();

    [Token(Token = "0x6016D40")]
    [Address(RVA = "0x2C580B4", Offset = "0x2C580B4", VA = "0x2C580B4")]
    public IEnumerator CallPurchaseApi(
      int shopId,
      int articleId,
      int purchaseCount,
      Action<int, bool> finishAction,
      Func<NetworkErrorResult, IEnumerator> errorPurchase)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016D41")]
    [Address(RVA = "0x2C58180", Offset = "0x2C58180", VA = "0x2C58180")]
    public IEnumerator CallSaleApi(Dictionary<ItemListData, int> saleCountMap, Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016D42")]
    [Address(RVA = "0x2C5690C", Offset = "0x2C5690C", VA = "0x2C5690C")]
    public IEnumerator CallGetProductIds(Action<UpdateProductResultCode> onResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016D43")]
    [Address(RVA = "0x2C5824C", Offset = "0x2C5824C", VA = "0x2C5824C")]
    public IEnumerator CallChargeAmountByMonth(
      Action<APIChargeAmountByMonthResponse> onFinish,
      ProductInfo productInfo)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016D44")]
    [Address(RVA = "0x2C55970", Offset = "0x2C55970", VA = "0x2C55970")]
    public ShopAPIManager()
    {
    }
  }
}
