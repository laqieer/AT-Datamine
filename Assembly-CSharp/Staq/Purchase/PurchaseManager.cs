// Decompiled with JetBrains decompiler
// Type: Staq.Purchase.PurchaseManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using LogModule.Logger;
using Network.Param;
using PurchaseModule;
using PurchaseModule.Enum;
using PurchaseModule.Fulfillment;
using PurchaseModule.Log;
using PurchaseModule.Platform;
using PurchaseModule.Product;
using Scenes;
using Scenes.Home.HotDeal;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Staq.Purchase
{
  [Token(Token = "0x200098E")]
  public static class PurchaseManager
  {
    [Token(Token = "0x4002C8B")]
    private const string URL = "https://production-clientlogs-bq-nb.astr.gu3.jp/";
    [Token(Token = "0x4002C8C")]
    [FieldOffset(Offset = "0x0")]
    public static bool IsOnInitResultSucceeded;
    [Token(Token = "0x4002C8D")]
    [FieldOffset(Offset = "0x8")]
    public static MonoBehaviour Mono;
    [Token(Token = "0x4002C8E")]
    [FieldOffset(Offset = "0x10")]
    public static List<string> ProductIds;
    [Token(Token = "0x4002C8F")]
    [FieldOffset(Offset = "0x18")]
    private static bool isBillingBuild;
    [Token(Token = "0x4002C90")]
    [FieldOffset(Offset = "0x20")]
    private static ILogModuleLogger purchaseLogger;
    [Token(Token = "0x4002C91")]
    [FieldOffset(Offset = "0x28")]
    private static Action<IReadOnlyCollection<ProductInfo>, UpdateProductResultCode> updateProductsCallback;
    [Token(Token = "0x4002C92")]
    [FieldOffset(Offset = "0x30")]
    private static Action<FulfillmentTransaction> purchaseFinishedSuccessdedCallback;
    [Token(Token = "0x4002C93")]
    [FieldOffset(Offset = "0x38")]
    private static Action purchaseFinishedOtherCallback;

    [Token(Token = "0x1700078E")]
    public static bool IsBillingBuild
    {
      [Token(Token = "0x6003669"), Address(RVA = "0x3534F88", Offset = "0x3534F88", VA = "0x3534F88")] get
      {
        return new bool();
      }
      [Token(Token = "0x600366A"), Address(RVA = "0x3534F90", Offset = "0x3534F90", VA = "0x3534F90")] set
      {
      }
    }

    [Token(Token = "0x600366B")]
    [Address(RVA = "0x3534FDC", Offset = "0x3534FDC", VA = "0x3534FDC")]
    public static void Initialize(IEnumerable<string> productIds)
    {
    }

    [Token(Token = "0x600366C")]
    [Address(RVA = "0x35351CC", Offset = "0x35351CC", VA = "0x35351CC")]
    public static void UpdateProducts(
      IEnumerable<string> productList,
      Action<IReadOnlyCollection<ProductInfo>, UpdateProductResultCode> callback)
    {
    }

    [Token(Token = "0x600366D")]
    [Address(RVA = "0x3535258", Offset = "0x3535258", VA = "0x3535258")]
    public static void Purchase(
      ProductInfo productInfo,
      string accountId,
      Action<FulfillmentTransaction> successdedCallback,
      Action otherCallback)
    {
    }

    [Token(Token = "0x600366E")]
    [Address(RVA = "0x3535484", Offset = "0x3535484", VA = "0x3535484")]
    public static ProductInfo GetProductInfo(
      string productId,
      double paidCoin,
      in Dictionary<string, ProductInfo> products)
    {
      return (ProductInfo) null;
    }

    [Token(Token = "0x600366F")]
    [Address(RVA = "0x35352FC", Offset = "0x35352FC", VA = "0x35352FC")]
    private static void DebugPurchase(ProductInfo productInfo)
    {
    }

    [Token(Token = "0x6003670")]
    [Address(RVA = "0x3535624", Offset = "0x3535624", VA = "0x3535624")]
    private static void PurchaseLog(PurchaseLogLevel logLevel, string tag, string message)
    {
    }

    [Token(Token = "0x6003671")]
    [Address(RVA = "0x35358C0", Offset = "0x35358C0", VA = "0x35358C0")]
    public static IEnumerator APICoinShopRefreshSuccessOrFailure(
      string productId,
      Action<bool> callback,
      int passId = 0,
      HotDealController hotDealController = null,
      PaidCoinShopPopupItemInfo paidCoinShopPopupItemInfo = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003672")]
    [Address(RVA = "0x353597C", Offset = "0x353597C", VA = "0x353597C")]
    private static void FulfillmentCallback(PurchaseResponse purchaseResponse)
    {
    }

    [Token(Token = "0x6003673")]
    [Address(RVA = "0x35359E4", Offset = "0x35359E4", VA = "0x35359E4")]
    private static IEnumerator APIFulfillment(PurchaseResponse purchaseResponse)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003674")]
    [Address(RVA = "0x3535554", Offset = "0x3535554", VA = "0x3535554")]
    private static IEnumerator APIDebugGoogleplayFulfill(DebugFulfillOrders orders)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003675")]
    [Address(RVA = "0x35355BC", Offset = "0x35355BC", VA = "0x35355BC")]
    private static IEnumerator APIDebugAppstoreFulfill(DebugFulfillOrders orders)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003676")]
    [Address(RVA = "0x3535AC4", Offset = "0x3535AC4", VA = "0x3535AC4")]
    private static void OnUpdateProductsResults(
      UpdateProductResultCode productResultCode,
      IEnumerable<ProductInfo> products)
    {
    }

    [Token(Token = "0x6003677")]
    [Address(RVA = "0x3535C1C", Offset = "0x3535C1C", VA = "0x3535C1C")]
    private static void OnInitResult(InitResultCode resultCode)
    {
    }

    [Token(Token = "0x6003678")]
    [Address(RVA = "0x3535C70", Offset = "0x3535C70", VA = "0x3535C70")]
    private static void OnPurchaseFinished(
      PurchaseResultCode purchaseResultCode,
      IFulfillmentTransaction fulfillmentTransaction)
    {
    }

    [Token(Token = "0x6003679")]
    [Address(RVA = "0x35364B8", Offset = "0x35364B8", VA = "0x35364B8")]
    private static void OnPurchaseSucceeded(FulfillmentTransaction transaction)
    {
    }

    [Token(Token = "0x200098F")]
    private class PurchaseResultListener : IPurchaseResultListener
    {
      [Token(Token = "0x600367A")]
      [Address(RVA = "0x35368B4", Offset = "0x35368B4", VA = "0x35368B4", Slot = "5")]
      public void OnUpdateProductsResults(
        UpdateProductResultCode productResultCode,
        IEnumerable<ProductInfo> products)
      {
      }

      [Token(Token = "0x600367B")]
      [Address(RVA = "0x35368C0", Offset = "0x35368C0", VA = "0x35368C0", Slot = "4")]
      public void OnInitResult(InitResultCode resultCode)
      {
      }

      [Token(Token = "0x600367C")]
      [Address(RVA = "0x3536914", Offset = "0x3536914", VA = "0x3536914", Slot = "6")]
      public void OnPurchaseFinished(
        PurchaseResultCode purchaseResultCode,
        IFulfillmentTransaction fulfillmentTransaction)
      {
      }

      [Token(Token = "0x600367D")]
      [Address(RVA = "0x35351C4", Offset = "0x35351C4", VA = "0x35351C4")]
      public PurchaseResultListener()
      {
      }
    }
  }
}
