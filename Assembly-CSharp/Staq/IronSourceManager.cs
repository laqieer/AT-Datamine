// Decompiled with JetBrains decompiler
// Type: staq.IronSourceManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C1B")]
  public class IronSourceManager : SingletonMonoBehaviour<IronSourceManager>
  {
    [Token(Token = "0x4010A9E")]
    private const float VIDEO_STATUS_TIME_OUT_SECOND = 1f;
    [Token(Token = "0x4010A9F")]
    private const float AD_REWARD_SERVER_WAIT_SECOND = 2f;
    [Token(Token = "0x4010AA2")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<(int, int), PlayerAdvertisementType> playerAdvertisements;
    [Token(Token = "0x4010AA3")]
    [FieldOffset(Offset = "0x28")]
    private Action<bool> onAdAvailableEvent;
    [Token(Token = "0x4010AA4")]
    [FieldOffset(Offset = "0x30")]
    private UnityEvent<bool> onAdAvailableEventList;
    [Token(Token = "0x4010AA5")]
    [FieldOffset(Offset = "0x38")]
    private IronSourceManager.AdStatus adStatus;
    [Token(Token = "0x4010AA6")]
    [FieldOffset(Offset = "0x40")]
    private string advertisementId;
    [Token(Token = "0x4010AA7")]
    [FieldOffset(Offset = "0x48")]
    private AdEventTypeEnum adEventType;
    [Token(Token = "0x4010AA8")]
    [FieldOffset(Offset = "0x4C")]
    private int targetId;
    [Token(Token = "0x4010AA9")]
    [FieldOffset(Offset = "0x50")]
    private float adRewardLatencyRetrySecond;
    [Token(Token = "0x4010AAA")]
    [FieldOffset(Offset = "0x54")]
    private int adRewardLatencyMaxRetryCount;
    [Token(Token = "0x4010AAB")]
    [FieldOffset(Offset = "0x58")]
    private bool isAppResume;
    [Token(Token = "0x4010AAC")]
    [FieldOffset(Offset = "0x59")]
    private bool isRewarded;

    [Token(Token = "0x17004CC7")]
    public bool IsRewardedVideoAvailable
    {
      [Token(Token = "0x6017A00"), Address(RVA = "0x2381C6C", Offset = "0x2381C6C", VA = "0x2381C6C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6017A01"), Address(RVA = "0x2381C74", Offset = "0x2381C74", VA = "0x2381C74")] private set
      {
      }
    }

    [Token(Token = "0x17004CC8")]
    public bool IsAdVideoInProgress
    {
      [Token(Token = "0x6017A02"), Address(RVA = "0x2381C80", Offset = "0x2381C80", VA = "0x2381C80")] get
      {
        return new bool();
      }
      [Token(Token = "0x6017A03"), Address(RVA = "0x2381C88", Offset = "0x2381C88", VA = "0x2381C88")] private set
      {
      }
    }

    [Token(Token = "0x6017A04")]
    [Address(RVA = "0x2381C94", Offset = "0x2381C94", VA = "0x2381C94", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6017A05")]
    [Address(RVA = "0x2381E90", Offset = "0x2381E90", VA = "0x2381E90")]
    public void InitLatencySetting()
    {
    }

    [Token(Token = "0x6017A06")]
    [Address(RVA = "0x2381F6C", Offset = "0x2381F6C", VA = "0x2381F6C")]
    private void OnApplicationPause(bool isPaused)
    {
    }

    [Token(Token = "0x6017A07")]
    [Address(RVA = "0x2381FD4", Offset = "0x2381FD4", VA = "0x2381FD4")]
    private void OnApplicationFocus(bool focusStatus)
    {
    }

    [Token(Token = "0x6017A08")]
    [Address(RVA = "0x2381FE4", Offset = "0x2381FE4", VA = "0x2381FE4")]
    private void SetSuspendResumeReset(bool pause)
    {
    }

    [Token(Token = "0x6017A09")]
    [Address(RVA = "0x2381FE8", Offset = "0x2381FE8", VA = "0x2381FE8")]
    private void RewardedVideoOnAdOpenedEvent(IronSourceAdInfo adInfo)
    {
    }

    [Token(Token = "0x6017A0A")]
    [Address(RVA = "0x2382148", Offset = "0x2382148", VA = "0x2382148")]
    private void RewardedVideoOnAdClosedEvent(IronSourceAdInfo adInfo)
    {
    }

    [Token(Token = "0x6017A0B")]
    [Address(RVA = "0x23822A8", Offset = "0x23822A8", VA = "0x23822A8")]
    private void RewardedVideoOnAdAvailable(IronSourceAdInfo adInfo)
    {
    }

    [Token(Token = "0x6017A0C")]
    [Address(RVA = "0x2382418", Offset = "0x2382418", VA = "0x2382418")]
    private void RewardedVideoOnAdUnavailable()
    {
    }

    [Token(Token = "0x6017A0D")]
    [Address(RVA = "0x2382520", Offset = "0x2382520", VA = "0x2382520")]
    private void RewardedVideoOnAdShowFailedEvent(
      IronSourceError ironSourceError,
      IronSourceAdInfo adInfo)
    {
    }

    [Token(Token = "0x6017A0E")]
    [Address(RVA = "0x23826EC", Offset = "0x23826EC", VA = "0x23826EC")]
    private void RewardedVideoOnAdRewardedEvent(
      IronSourcePlacement ironSourcePlacement,
      IronSourceAdInfo adInfo)
    {
    }

    [Token(Token = "0x6017A0F")]
    [Address(RVA = "0x2382890", Offset = "0x2382890", VA = "0x2382890")]
    public void SetOnAdAvailableCallback(Action<bool> callback)
    {
    }

    [Token(Token = "0x6017A10")]
    [Address(RVA = "0x23828CC", Offset = "0x23828CC", VA = "0x23828CC")]
    public void AddOnAdAvailableEvent(UnityAction<bool> callback)
    {
    }

    [Token(Token = "0x6017A11")]
    [Address(RVA = "0x238293C", Offset = "0x238293C", VA = "0x238293C")]
    public void RemoveOnAdAvailableEvent(UnityAction<bool> callback)
    {
    }

    [Token(Token = "0x6017A12")]
    [Address(RVA = "0x2382994", Offset = "0x2382994", VA = "0x2382994")]
    public void ClearOnAdAvailableEvent()
    {
    }

    [Token(Token = "0x6017A13")]
    [Address(RVA = "0x23829B0", Offset = "0x23829B0", VA = "0x23829B0")]
    public void SaveCachePlayerAdvertisementData(params PlayerAdvertisementType[] data)
    {
    }

    [Token(Token = "0x6017A14")]
    [Address(RVA = "0x2382AEC", Offset = "0x2382AEC", VA = "0x2382AEC")]
    public IEnumerator GetCachePlayerAdvertisementData(
      Action<PlayerAdvertisementType> onSuccess,
      Action onError,
      AdEventTypeEnum eventType,
      int targetId = 0,
      bool updateCache = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017A15")]
    [Address(RVA = "0x2382BBC", Offset = "0x2382BBC", VA = "0x2382BBC")]
    public IEnumerator RequestPlayerAdvertisementDataAndSaveCache(
      Action<PlayerAdvertisementType> onSuccess,
      Action onError,
      AdEventTypeEnum eventType,
      int targetId = 0)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017A16")]
    [Address(RVA = "0x2382C74", Offset = "0x2382C74", VA = "0x2382C74")]
    private IEnumerator RequestUpdateAdStatus(Action onError = null) => (IEnumerator) null;

    [Token(Token = "0x6017A17")]
    [Address(RVA = "0x2382D10", Offset = "0x2382D10", VA = "0x2382D10")]
    public void StartShowRewardedVideo(
      Action<bool> onFinished,
      string placementName,
      AdEventTypeEnum eventType,
      int targetId = 0,
      bool closeLoadingPanel = true)
    {
    }

    [Token(Token = "0x6017A18")]
    [Address(RVA = "0x2382D34", Offset = "0x2382D34", VA = "0x2382D34")]
    public IEnumerator ShowRewardedVideo(
      Action<bool> onFinished,
      string placementName,
      AdEventTypeEnum eventType,
      int targetId = 0,
      bool closeLoadingPanel = true)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017A19")]
    [Address(RVA = "0x2382E00", Offset = "0x2382E00", VA = "0x2382E00")]
    private IEnumerator _ShowRewardedVideo(
      Action<IronSourceManager.AdProcessResultStatus> result,
      string placementName,
      AdEventTypeEnum eventType,
      int targetId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017A1A")]
    [Address(RVA = "0x2382EB8", Offset = "0x2382EB8", VA = "0x2382EB8")]
    private IEnumerator _RewardPossibleStatusCheck(
      Action<IronSourceManager.AdProcessResultStatus> result,
      int cacheRewardPossibleCount,
      AdEventTypeEnum eventType,
      int targetId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017A1B")]
    [Address(RVA = "0x2382F74", Offset = "0x2382F74", VA = "0x2382F74")]
    private IEnumerator ShowRewardLatencyErrorDialog() => (IEnumerator) null;

    [Token(Token = "0x6017A1C")]
    [Address(RVA = "0x2382FFC", Offset = "0x2382FFC", VA = "0x2382FFC")]
    private IEnumerator ShowVideoErrorDialog() => (IEnumerator) null;

    [Token(Token = "0x6017A1D")]
    [Address(RVA = "0x2383084", Offset = "0x2383084", VA = "0x2383084")]
    private IEnumerator ShowRewardErrorDialog() => (IEnumerator) null;

    [Token(Token = "0x6017A1E")]
    [Address(RVA = "0x238310C", Offset = "0x238310C", VA = "0x238310C")]
    public IronSourceManager()
    {
    }

    [Token(Token = "0x2003C1C")]
    private enum AdStatus
    {
      [Token(Token = "0x4010AAE")] Unknown = 0,
      [Token(Token = "0x4010AAF")] VideoStart = 1,
      [Token(Token = "0x4010AB0")] VideoEnd = 2,
      [Token(Token = "0x4010AB1")] RewardPossible = 3,
      [Token(Token = "0x4010AB2")] RewardGranted = 4,
      [Token(Token = "0x4010AB3")] VideoCancel = 9,
    }

    [Token(Token = "0x2003C1D")]
    private enum AdProcessResultStatus
    {
      [Token(Token = "0x4010AB5")] None,
      [Token(Token = "0x4010AB6")] Success,
      [Token(Token = "0x4010AB7")] ApiError,
      [Token(Token = "0x4010AB8")] VideoError,
      [Token(Token = "0x4010AB9")] RewardError,
    }
  }
}
