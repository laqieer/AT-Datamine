// Decompiled with JetBrains decompiler
// Type: Scenes.Home.HotDeal.HotDealController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GlobalMenu;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using PurchaseModule.Product;
using Staq.Purchase;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Home.HotDeal
{
  [Token(Token = "0x2002B15")]
  public class HotDealController : MonoBehaviour
  {
    [Token(Token = "0x400B742")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400B743")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text timeText;
    [Token(Token = "0x400B744")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Header header;
    [Token(Token = "0x400B745")]
    [FieldOffset(Offset = "0x30")]
    private DateTime endDate;
    [Token(Token = "0x400B746")]
    [FieldOffset(Offset = "0x38")]
    private TimeSpan limit;
    [Token(Token = "0x400B749")]
    [FieldOffset(Offset = "0x50")]
    public Dictionary<string, ProductInfo> products;
    [Token(Token = "0x400B74A")]
    [FieldOffset(Offset = "0x58")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400B74B")]
    [FieldOffset(Offset = "0x60")]
    private ItemDetailPopupProvider itemDetailPopupProvider;
    [Token(Token = "0x400B74C")]
    [FieldOffset(Offset = "0x68")]
    private ItemDetailPopup itemDetailPopup;
    [Token(Token = "0x400B74D")]
    [FieldOffset(Offset = "0x70")]
    private GameObject hotDealPrefab;
    [Token(Token = "0x400B74E")]
    [FieldOffset(Offset = "0x78")]
    private HotDealPopup hotDealPopup;
    [Token(Token = "0x400B74F")]
    [FieldOffset(Offset = "0x80")]
    private GameObject afterPurchasePrefab;
    [Token(Token = "0x400B750")]
    [FieldOffset(Offset = "0x88")]
    private HotDealAfterPurchasePopup hotDealAfterPurchasePopup;
    [Token(Token = "0x400B751")]
    [FieldOffset(Offset = "0x90")]
    private int beforePaid;
    [Token(Token = "0x400B752")]
    [FieldOffset(Offset = "0x94")]
    private int beforeFree;
    [Token(Token = "0x400B753")]
    [FieldOffset(Offset = "0x98")]
    private bool requestedOpenPopup;
    [Token(Token = "0x400B754")]
    [FieldOffset(Offset = "0x99")]
    private bool isUnavableError;
    [Token(Token = "0x400B755")]
    [FieldOffset(Offset = "0xA0")]
    private Action<bool> tapBlockAction;

    [Token(Token = "0x17003A25")]
    public List<HotDealInfoType> hotDeals
    {
      [Token(Token = "0x6010D4C"), Address(RVA = "0x1C35A18", Offset = "0x1C35A18", VA = "0x1C35A18")] get
      {
        return (List<HotDealInfoType>) null;
      }
      [Token(Token = "0x6010D4D"), Address(RVA = "0x1C35A20", Offset = "0x1C35A20", VA = "0x1C35A20")] private set
      {
      }
    }

    [Token(Token = "0x17003A26")]
    public HotDealInfoType selectHotDeal
    {
      [Token(Token = "0x6010D4E"), Address(RVA = "0x1C35A28", Offset = "0x1C35A28", VA = "0x1C35A28")] get
      {
        return (HotDealInfoType) null;
      }
      [Token(Token = "0x6010D4F"), Address(RVA = "0x1C35A30", Offset = "0x1C35A30", VA = "0x1C35A30")] set
      {
      }
    }

    [Token(Token = "0x6010D50")]
    [Address(RVA = "0x1C2F810", Offset = "0x1C2F810", VA = "0x1C2F810")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      Action<bool> tapBlockAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010D51")]
    [Address(RVA = "0x1C35A60", Offset = "0x1C35A60", VA = "0x1C35A60")]
    private void Update()
    {
    }

    [Token(Token = "0x6010D52")]
    [Address(RVA = "0x1C31BBC", Offset = "0x1C31BBC", VA = "0x1C31BBC")]
    public IEnumerator InitializeHotDeal(List<HotDealInfoType> hotDeals) => (IEnumerator) null;

    [Token(Token = "0x6010D53")]
    [Address(RVA = "0x1C35BC8", Offset = "0x1C35BC8", VA = "0x1C35BC8")]
    public void UpdateHotDealData(List<HotDealInfoType> hotDeals)
    {
    }

    [Token(Token = "0x6010D54")]
    [Address(RVA = "0x1C35DE4", Offset = "0x1C35DE4", VA = "0x1C35DE4")]
    public void ShowIcon(bool isDisplay)
    {
    }

    [Token(Token = "0x6010D55")]
    [Address(RVA = "0x1C35E0C", Offset = "0x1C35E0C", VA = "0x1C35E0C")]
    public void SetButtonInteractable(bool isInteractable)
    {
    }

    [Token(Token = "0x6010D56")]
    [Address(RVA = "0x1C35E2C", Offset = "0x1C35E2C", VA = "0x1C35E2C")]
    public IEnumerator OpenHotDealPopup() => (IEnumerator) null;

    [Token(Token = "0x6010D57")]
    [Address(RVA = "0x1C35EBC", Offset = "0x1C35EBC", VA = "0x1C35EBC")]
    private void CheckTimeLimit()
    {
    }

    [Token(Token = "0x6010D58")]
    [Address(RVA = "0x1C35F68", Offset = "0x1C35F68", VA = "0x1C35F68")]
    public IEnumerator ConnectHotDealAPI(Action action = null) => (IEnumerator) null;

    [Token(Token = "0x6010D59")]
    [Address(RVA = "0x1C36004", Offset = "0x1C36004", VA = "0x1C36004")]
    public void CloseAll(bool showIcon)
    {
    }

    [Token(Token = "0x6010D5A")]
    [Address(RVA = "0x1C35158", Offset = "0x1C35158", VA = "0x1C35158")]
    public void OnClickRewardItem(Reward reward)
    {
    }

    [Token(Token = "0x6010D5B")]
    [Address(RVA = "0x1C36338", Offset = "0x1C36338", VA = "0x1C36338")]
    private void OpenItemDetailPopup(Reward reward)
    {
    }

    [Token(Token = "0x6010D5C")]
    [Address(RVA = "0x1C3593C", Offset = "0x1C3593C", VA = "0x1C3593C")]
    public void OpenCoinDetailPopup(bool isPaidCoin)
    {
    }

    [Token(Token = "0x6010D5D")]
    [Address(RVA = "0x1C361C8", Offset = "0x1C361C8", VA = "0x1C361C8")]
    private void OpenOtherDetailPopup(Reward reward)
    {
    }

    [Token(Token = "0x6010D5E")]
    [Address(RVA = "0x1C363D4", Offset = "0x1C363D4", VA = "0x1C363D4")]
    private IEnumerator GetProductIds() => (IEnumerator) null;

    [Token(Token = "0x6010D5F")]
    [Address(RVA = "0x1C36464", Offset = "0x1C36464", VA = "0x1C36464")]
    private void OnClickBuy(PaidCoinShopPopupItemInfo info)
    {
    }

    [Token(Token = "0x6010D60")]
    [Address(RVA = "0x1C36468", Offset = "0x1C36468", VA = "0x1C36468")]
    private void BirthdayRegistration(PaidCoinShopPopupItemInfo info)
    {
    }

    [Token(Token = "0x6010D61")]
    [Address(RVA = "0x1C365E0", Offset = "0x1C365E0", VA = "0x1C365E0")]
    private void OnConfirm(PaidCoinShopPopupItemInfo info)
    {
    }

    [Token(Token = "0x6010D62")]
    [Address(RVA = "0x1C367E0", Offset = "0x1C367E0", VA = "0x1C367E0")]
    private IEnumerator IFPurchase(ProductInfo productInfo) => (IEnumerator) null;

    [Token(Token = "0x6010D63")]
    [Address(RVA = "0x1C3687C", Offset = "0x1C3687C", VA = "0x1C3687C")]
    public void Purchase(ProductInfo info)
    {
    }

    [Token(Token = "0x6010D64")]
    [Address(RVA = "0x1C3689C", Offset = "0x1C3689C", VA = "0x1C3689C")]
    private IEnumerator PurchaseInternal(ProductInfo info) => (IEnumerator) null;

    [Token(Token = "0x6010D65")]
    [Address(RVA = "0x1C36938", Offset = "0x1C36938", VA = "0x1C36938")]
    private void PurchaseFinishedSucceededCallback(FulfillmentTransaction transaction)
    {
    }

    [Token(Token = "0x6010D66")]
    [Address(RVA = "0x1C36CAC", Offset = "0x1C36CAC", VA = "0x1C36CAC")]
    private void UpdateHeader()
    {
    }

    [Token(Token = "0x6010D67")]
    [Address(RVA = "0x1C36C38", Offset = "0x1C36C38", VA = "0x1C36C38")]
    private IEnumerator APICoinShopAfterPurchase(FulfillmentTransaction transaction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010D68")]
    [Address(RVA = "0x1C36A3C", Offset = "0x1C36A3C", VA = "0x1C36A3C")]
    private void OpenItemAfterPurchasePopup(int afterPaid, int afterFree, Action onClickClose)
    {
    }

    [Token(Token = "0x6010D69")]
    [Address(RVA = "0x1C36CFC", Offset = "0x1C36CFC", VA = "0x1C36CFC")]
    private IEnumerator APIChargeAmountByMonthConnect(
      Action<APIChargeAmountByMonthResponse> onFinish,
      ProductInfo productInfo)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010D6A")]
    [Address(RVA = "0x1C36D98", Offset = "0x1C36D98", VA = "0x1C36D98")]
    public HotDealController()
    {
    }
  }
}
