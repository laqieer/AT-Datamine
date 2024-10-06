// Decompiled with JetBrains decompiler
// Type: Scenes.Story.ChapterShop.ChapterShopSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Data;
using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.Story.ChapterShop
{
  [Token(Token = "0x2002F01")]
  public class ChapterShopSubScene : SubScene
  {
    [Token(Token = "0x400C9A6")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Transform parent;
    [Token(Token = "0x400C9A7")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400C9A8")]
    [FieldOffset(Offset = "0x68")]
    private ChapterBuyContainer buyContainer;
    [Token(Token = "0x400C9A9")]
    [FieldOffset(Offset = "0x70")]
    private UISafeAreaInsets safeArea;
    [Token(Token = "0x400C9AA")]
    [FieldOffset(Offset = "0x78")]
    private bool isConnetingApi;
    [Token(Token = "0x400C9AB")]
    [FieldOffset(Offset = "0x7C")]
    private ShopTypeEnum shopType;
    [Token(Token = "0x400C9AC")]
    [FieldOffset(Offset = "0x80")]
    private ChapterShopLoader loader;
    [Token(Token = "0x400C9AD")]
    [FieldOffset(Offset = "0x88")]
    private ChapterShopAnimation shopAnimation;
    [Token(Token = "0x400C9AE")]
    [FieldOffset(Offset = "0x90")]
    private UITimelineController buyTimelineController;
    [Token(Token = "0x400C9AF")]
    [FieldOffset(Offset = "0x98")]
    private int objectID;
    [Token(Token = "0x400C9B0")]
    [FieldOffset(Offset = "0xA0")]
    private string characterName;
    [Token(Token = "0x400C9B1")]
    [FieldOffset(Offset = "0xA8")]
    private ChapterShopType chapterShopType;
    [Token(Token = "0x400C9B2")]
    [FieldOffset(Offset = "0xB0")]
    private List<ChapterShopData> shopList;
    [Token(Token = "0x400C9B3")]
    [FieldOffset(Offset = "0xB8")]
    private bool isChangeing;
    [Token(Token = "0x400C9B4")]
    [FieldOffset(Offset = "0xB9")]
    private bool isLoading;

    [Token(Token = "0x60125D5")]
    [Address(RVA = "0x22FE4E8", Offset = "0x22FE4E8", VA = "0x22FE4E8")]
    public void OnClickToChangeShop()
    {
    }

    [Token(Token = "0x60125D6")]
    [Address(RVA = "0x22FE610", Offset = "0x22FE610", VA = "0x22FE610")]
    private IEnumerator ChangeShopInternal() => (IEnumerator) null;

    [Token(Token = "0x60125D7")]
    [Address(RVA = "0x22FE6A0", Offset = "0x22FE6A0", VA = "0x22FE6A0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60125D8")]
    [Address(RVA = "0x22FE6D0", Offset = "0x22FE6D0", VA = "0x22FE6D0")]
    private IEnumerator CallChapterShopAPI() => (IEnumerator) null;

    [Token(Token = "0x60125D9")]
    [Address(RVA = "0x22FE760", Offset = "0x22FE760", VA = "0x22FE760", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60125DA")]
    [Address(RVA = "0x22FE818", Offset = "0x22FE818", VA = "0x22FE818", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60125DB")]
    [Address(RVA = "0x22FE8A8", Offset = "0x22FE8A8", VA = "0x22FE8A8")]
    private IEnumerator PlayToGetAbility() => (IEnumerator) null;

    [Token(Token = "0x60125DC")]
    [Address(RVA = "0x22FE938", Offset = "0x22FE938", VA = "0x22FE938")]
    private void OpenCommonPopup(string message, Action closeAction)
    {
    }

    [Token(Token = "0x60125DD")]
    [Address(RVA = "0x22FECB8", Offset = "0x22FECB8", VA = "0x22FECB8")]
    private void CreateBuyContainer()
    {
    }

    [Token(Token = "0x60125DE")]
    [Address(RVA = "0x22FF150", Offset = "0x22FF150", VA = "0x22FF150")]
    private void OpenOtherDetailPopup(int rewardId, RewardTypeEnum rewardType)
    {
    }

    [Token(Token = "0x60125DF")]
    [Address(RVA = "0x22FF424", Offset = "0x22FF424", VA = "0x22FF424")]
    private void OpenItemDetailPopup(int rewardId, RewardTypeEnum rewardType)
    {
    }

    [Token(Token = "0x60125E0")]
    [Address(RVA = "0x22FF800", Offset = "0x22FF800", VA = "0x22FF800")]
    public void OpenToInsufficientFundsPopup(PaymentTypeEnum paymentType, int paymentId)
    {
    }

    [Token(Token = "0x60125E1")]
    [Address(RVA = "0x22FF8C4", Offset = "0x22FF8C4", VA = "0x22FF8C4")]
    private void OpenAfterPurchasePopup(
      ItemPurchaseData itemPurchaseData,
      int purchaseCount,
      bool isConvertCheck,
      Action OnClickClose)
    {
    }

    [Token(Token = "0x60125E2")]
    [Address(RVA = "0x22FF740", Offset = "0x22FF740", VA = "0x22FF740")]
    private void OpenPopup(
      ChapterShopLoader.ResourceType resourceType,
      ChapterShopLoader.TimelineType timelineType,
      Action finishAction = null)
    {
    }

    [Token(Token = "0x60125E3")]
    [Address(RVA = "0x22FFB64", Offset = "0x22FFB64", VA = "0x22FFB64")]
    private void ClosePopup(
      ChapterShopLoader.ResourceType resourceType,
      ChapterShopLoader.TimelineType timelineType,
      Action finishAction = null)
    {
    }

    [Token(Token = "0x60125E4")]
    [Address(RVA = "0x22FFC24", Offset = "0x22FFC24", VA = "0x22FFC24")]
    private IEnumerator CallPurchaseApi(
      ChapterShopData data,
      int purchaseCount,
      Action<bool> finishCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60125E5")]
    [Address(RVA = "0x22FFCD8", Offset = "0x22FFCD8", VA = "0x22FFCD8")]
    private IEnumerator WaitPopupAnimation(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x60125E6")]
    [Address(RVA = "0x22FFD74", Offset = "0x22FFD74", VA = "0x22FFD74", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60125E7")]
    [Address(RVA = "0x22FFE04", Offset = "0x22FFE04", VA = "0x22FFE04", Slot = "20")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x60125E8")]
    [Address(RVA = "0x22FFE18", Offset = "0x22FFE18", VA = "0x22FFE18")]
    public ChapterShopSubScene()
    {
    }
  }
}
