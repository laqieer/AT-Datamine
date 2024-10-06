// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.FriendListSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.API;
using Scenes.Guild.Common;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x2003609")]
  public class FriendListSubScene : SubScene, IFriendListItemEventListener
  {
    [Token(Token = "0x400EAEF")]
    public const string SubSceneAssetBundleName = "page_friend";
    [Token(Token = "0x400EAF0")]
    public const string SubScenePrefabName = "FriendListSubScene";
    [Token(Token = "0x400EAF1")]
    public const string AnimationKeyIn = "In";
    [Token(Token = "0x400EAF2")]
    public const string AnimationKeyOut = "Out";
    [Token(Token = "0x400EAF3")]
    public const string PlayerNotFoundPopupTitle = "フレンド検索NG";
    [Token(Token = "0x400EAF4")]
    public const string PlayerNotFoundPopupMessage = "検索したプレイヤーは\n見つかりませんでした。";
    [Token(Token = "0x400EAF5")]
    public const string AlreadyFriendPopupTitle = "フレンド検索NG";
    [Token(Token = "0x400EAF6")]
    public const string AlreadyFriendPopupMessage = "既にフレンド登録されている\nプレイヤーIDです。";
    [Token(Token = "0x400EAF7")]
    private const string FriendGiftSendPopupTitle = "フレンドギフト";
    [Token(Token = "0x400EAF8")]
    private const string FriendGiftSendPopupMessage = "ギフトを贈りました。";
    [Token(Token = "0x400EAF9")]
    private const string FriendGiftReceivePopupTitle = "フレンドギフト";
    [Token(Token = "0x400EAFA")]
    private const string FriendGiftReceivePopupMessage = "フレンドギフトを受け取りました。\n{0} x {1}";
    [Token(Token = "0x400EAFB")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400EAFC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400EAFD")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private FriendList friendList;
    [Token(Token = "0x400EAFE")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI textFriendCount;
    [Token(Token = "0x400EAFF")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400EB00")]
    [FieldOffset(Offset = "0x80")]
    private GuildAssetLoader assetLoader;
    [Token(Token = "0x400EB01")]
    [FieldOffset(Offset = "0x88")]
    private FriendListSubScene.FriendListDisplayType friendListDisplayType;
    [Token(Token = "0x400EB02")]
    [FieldOffset(Offset = "0x90")]
    private List<FriendProfileInfo> uiParameters;
    [Token(Token = "0x400EB03")]
    [FieldOffset(Offset = "0x98")]
    private FriendListSortInfo friendListSortInfo;
    [Token(Token = "0x400EB04")]
    [FieldOffset(Offset = "0xA0")]
    private FriendInfoManager playerDetailInfoCache;
    [Token(Token = "0x400EB05")]
    [FieldOffset(Offset = "0xA8")]
    private FriendListSubScene.ReceivedFriendGiftInfo receivedFriendGiftInfo;

    [Token(Token = "0x6015431")]
    [Address(RVA = "0x4D914D8", Offset = "0x4D914D8", VA = "0x4D914D8")]
    public static FriendListSubScene.FriendListParameter CreateChangeSceneParameter(
      FriendListSubScene.FriendListDisplayType defaultListType)
    {
      return (FriendListSubScene.FriendListParameter) null;
    }

    [Token(Token = "0x6015432")]
    [Address(RVA = "0x4D9154C", Offset = "0x4D9154C", VA = "0x4D9154C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6015433")]
    [Address(RVA = "0x4D915B0", Offset = "0x4D915B0", VA = "0x4D915B0", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6015434")]
    [Address(RVA = "0x4D915D8", Offset = "0x4D915D8", VA = "0x4D915D8", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6015435")]
    [Address(RVA = "0x4D91670", Offset = "0x4D91670", VA = "0x4D91670", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6015436")]
    [Address(RVA = "0x4D91700", Offset = "0x4D91700", VA = "0x4D91700", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6015437")]
    [Address(RVA = "0x4D91790", Offset = "0x4D91790", VA = "0x4D91790", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6015438")]
    [Address(RVA = "0x4D91820", Offset = "0x4D91820", VA = "0x4D91820", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6015439")]
    [Address(RVA = "0x4D918B0", Offset = "0x4D918B0", VA = "0x4D918B0")]
    protected IEnumerator PlayAnimation(string animationGroupID) => (IEnumerator) null;

    [Token(Token = "0x601543A")]
    [Address(RVA = "0x4D9194C", Offset = "0x4D9194C", VA = "0x4D9194C")]
    private void SetInteractable(bool value)
    {
    }

    [Token(Token = "0x601543B")]
    [Address(RVA = "0x4D919E4", Offset = "0x4D919E4", VA = "0x4D919E4")]
    public void DisableInteractable()
    {
    }

    [Token(Token = "0x601543C")]
    [Address(RVA = "0x4D919EC", Offset = "0x4D919EC", VA = "0x4D919EC")]
    public void EnableInteractable()
    {
    }

    [Token(Token = "0x601543D")]
    [Address(RVA = "0x4D919F4", Offset = "0x4D919F4", VA = "0x4D919F4")]
    public void OnFriendListTabChanged(bool enable)
    {
    }

    [Token(Token = "0x601543E")]
    [Address(RVA = "0x4D91DCC", Offset = "0x4D91DCC", VA = "0x4D91DCC")]
    public void OnFriendNoticeListTabChanged(bool enable)
    {
    }

    [Token(Token = "0x601543F")]
    [Address(RVA = "0x4D91DE0", Offset = "0x4D91DE0", VA = "0x4D91DE0")]
    public void OnFriendRequestListChanged(bool enable)
    {
    }

    [Token(Token = "0x6015440")]
    [Address(RVA = "0x4D91DF4", Offset = "0x4D91DF4", VA = "0x4D91DF4")]
    public void OnFriendBlockListChanged(bool enable)
    {
    }

    [Token(Token = "0x6015441")]
    [Address(RVA = "0x4D91E08", Offset = "0x4D91E08", VA = "0x4D91E08", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6015442")]
    [Address(RVA = "0x4D91EB4", Offset = "0x4D91EB4", VA = "0x4D91EB4")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x6015443")]
    [Address(RVA = "0x4D91EB8", Offset = "0x4D91EB8", VA = "0x4D91EB8", Slot = "32")]
    private void Scenes\u002EOutGame\u002EFriend\u002EIFriendListItemEventListener\u002EOnFriendRemove(
      string playerName,
      string playerId)
    {
    }

    [Token(Token = "0x6015444")]
    [Address(RVA = "0x4D9205C", Offset = "0x4D9205C", VA = "0x4D9205C", Slot = "33")]
    private void Scenes\u002EOutGame\u002EFriend\u002EIFriendListItemEventListener\u002EOnFriendAccept(
      string playerName,
      string playerId)
    {
    }

    [Token(Token = "0x6015445")]
    [Address(RVA = "0x4D92200", Offset = "0x4D92200", VA = "0x4D92200", Slot = "34")]
    private void Scenes\u002EOutGame\u002EFriend\u002EIFriendListItemEventListener\u002EOnFriendReject(
      string playerName,
      string playerId)
    {
    }

    [Token(Token = "0x6015446")]
    [Address(RVA = "0x4D923A4", Offset = "0x4D923A4", VA = "0x4D923A4", Slot = "35")]
    private void Scenes\u002EOutGame\u002EFriend\u002EIFriendListItemEventListener\u002EOnFriendCancel(
      string playerName,
      string playerId)
    {
    }

    [Token(Token = "0x6015447")]
    [Address(RVA = "0x4D92548", Offset = "0x4D92548", VA = "0x4D92548", Slot = "36")]
    private void Scenes\u002EOutGame\u002EFriend\u002EIFriendListItemEventListener\u002EOnFriendBlockAdd(
      string playerName,
      string playerId)
    {
    }

    [Token(Token = "0x6015448")]
    [Address(RVA = "0x4D926EC", Offset = "0x4D926EC", VA = "0x4D926EC", Slot = "37")]
    private void Scenes\u002EOutGame\u002EFriend\u002EIFriendListItemEventListener\u002EOnFriendBlockRemove(
      string playerName,
      string playerId)
    {
    }

    [Token(Token = "0x6015449")]
    [Address(RVA = "0x4D92890", Offset = "0x4D92890", VA = "0x4D92890", Slot = "38")]
    private void Scenes\u002EOutGame\u002EFriend\u002EIFriendListItemEventListener\u002EOnDetail(
      string playerId)
    {
    }

    [Token(Token = "0x601544A")]
    [Address(RVA = "0x4D928EC", Offset = "0x4D928EC", VA = "0x4D928EC")]
    public void OnClickSearch()
    {
    }

    [Token(Token = "0x601544B")]
    [Address(RVA = "0x4D92AE4", Offset = "0x4D92AE4", VA = "0x4D92AE4")]
    public void OnClickSortChange()
    {
    }

    [Token(Token = "0x601544C")]
    [Address(RVA = "0x4D92BE0", Offset = "0x4D92BE0", VA = "0x4D92BE0")]
    public void OnClickFriendGiftSend()
    {
    }

    [Token(Token = "0x601544D")]
    [Address(RVA = "0x4D91E24", Offset = "0x4D91E24", VA = "0x4D91E24")]
    private void BackToPrevScene()
    {
    }

    [Token(Token = "0x601544E")]
    [Address(RVA = "0x4D92CE0", Offset = "0x4D92CE0", VA = "0x4D92CE0")]
    private void ClosePopup(string animationKeyOut = "Popup_Out")
    {
    }

    [Token(Token = "0x601544F")]
    [Address(RVA = "0x4D92D78", Offset = "0x4D92D78", VA = "0x4D92D78")]
    private IEnumerator OpenFriendSearchResultPopup(FriendProfileInfo friendProfileInfo)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015450")]
    [Address(RVA = "0x4D928CC", Offset = "0x4D928CC", VA = "0x4D928CC")]
    private void OpenPlayerDetailPopup(string playerId)
    {
    }

    [Token(Token = "0x6015451")]
    [Address(RVA = "0x4D92E14", Offset = "0x4D92E14", VA = "0x4D92E14")]
    private IEnumerator OpenPlayerDetailPopupAsync(string playerId) => (IEnumerator) null;

    [Token(Token = "0x6015452")]
    [Address(RVA = "0x4D92EB0", Offset = "0x4D92EB0", VA = "0x4D92EB0")]
    private IEnumerator RequestFriendList(
      Action<FriendListSubScene.ReceivedFriendGiftInfo> onSuccess)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015453")]
    [Address(RVA = "0x4D92F4C", Offset = "0x4D92F4C", VA = "0x4D92F4C")]
    public void OnSuccessFriendSearch(APIFriendSearchResponse res)
    {
    }

    [Token(Token = "0x6015454")]
    [Address(RVA = "0x4D92F68", Offset = "0x4D92F68", VA = "0x4D92F68")]
    private void OnFailureFriendSearchNotFound()
    {
    }

    [Token(Token = "0x6015455")]
    [Address(RVA = "0x4D93020", Offset = "0x4D93020", VA = "0x4D93020")]
    private void OnFailureFriendSearchAlreadyFriend()
    {
    }

    [Token(Token = "0x6015456")]
    [Address(RVA = "0x4D930D8", Offset = "0x4D930D8", VA = "0x4D930D8")]
    public void OnSuccessPlayerDetail(APIPlayerDetailResponse res)
    {
    }

    [Token(Token = "0x6015457")]
    [Address(RVA = "0x4D930F4", Offset = "0x4D930F4", VA = "0x4D930F4")]
    public void OnSuccessFriendApply(APIFriendApplyResponse res)
    {
    }

    [Token(Token = "0x6015458")]
    [Address(RVA = "0x4D931B4", Offset = "0x4D931B4", VA = "0x4D931B4")]
    public void OnSuccessFriendCancel(APIFriendCancelResponse res)
    {
    }

    [Token(Token = "0x6015459")]
    [Address(RVA = "0x4D931F8", Offset = "0x4D931F8", VA = "0x4D931F8")]
    public void OnSuccessFriendRemove(APIFriendRemoveResponse res)
    {
    }

    [Token(Token = "0x601545A")]
    [Address(RVA = "0x4D9323C", Offset = "0x4D9323C", VA = "0x4D9323C")]
    public void OnSuccessFriendAccept(APIFriendAcceptResponse res)
    {
    }

    [Token(Token = "0x601545B")]
    [Address(RVA = "0x4D93280", Offset = "0x4D93280", VA = "0x4D93280")]
    public void OnSuccessFriendReject(APIFriendRejectResponse res)
    {
    }

    [Token(Token = "0x601545C")]
    [Address(RVA = "0x4D932C4", Offset = "0x4D932C4", VA = "0x4D932C4")]
    public void OnSuccessBlockAdd(APIBlockAddResponse res)
    {
    }

    [Token(Token = "0x601545D")]
    [Address(RVA = "0x4D93308", Offset = "0x4D93308", VA = "0x4D93308")]
    public void OnSuccessBlockRemove(APIBlockRemoveResponse res)
    {
    }

    [Token(Token = "0x601545E")]
    [Address(RVA = "0x4D92C78", Offset = "0x4D92C78", VA = "0x4D92C78")]
    private IEnumerator RequestFriendGiftSend(Action<bool> onSuccess) => (IEnumerator) null;

    [Token(Token = "0x601545F")]
    [Address(RVA = "0x4D93138", Offset = "0x4D93138", VA = "0x4D93138")]
    private void RebuildUIParameters()
    {
    }

    [Token(Token = "0x6015460")]
    [Address(RVA = "0x4D93374", Offset = "0x4D93374", VA = "0x4D93374")]
    private void UpdateFriendCountText()
    {
    }

    [Token(Token = "0x6015461")]
    [Address(RVA = "0x4D91A04", Offset = "0x4D91A04", VA = "0x4D91A04")]
    private void UpdateView()
    {
    }

    [Token(Token = "0x6015462")]
    [Address(RVA = "0x4D93480", Offset = "0x4D93480", VA = "0x4D93480")]
    private List<FriendProfileInfo> GetSortedFriendList(IEnumerable<FriendProfileInfo> uiParameters)
    {
      return (List<FriendProfileInfo>) null;
    }

    [Token(Token = "0x6015463")]
    [Address(RVA = "0x4D934B8", Offset = "0x4D934B8", VA = "0x4D934B8")]
    private List<FriendProfileInfo> OrderByLastSignedInAt(
      bool accending,
      IEnumerable<FriendProfileInfo> uiParameters)
    {
      return (List<FriendProfileInfo>) null;
    }

    [Token(Token = "0x6015464")]
    [Address(RVA = "0x4D9365C", Offset = "0x4D9365C", VA = "0x4D9365C")]
    private List<FriendProfileInfo> OrderByRank(
      bool accending,
      IEnumerable<FriendProfileInfo> uiParameters)
    {
      return (List<FriendProfileInfo>) null;
    }

    [Token(Token = "0x6015465")]
    [Address(RVA = "0x4D93800", Offset = "0x4D93800", VA = "0x4D93800")]
    private IEnumerator LoadDependencyAssetBundles() => (IEnumerator) null;

    [Token(Token = "0x6015466")]
    [Address(RVA = "0x4D93890", Offset = "0x4D93890", VA = "0x4D93890")]
    private int GetFriendMedalAmount() => new int();

    [Token(Token = "0x6015467")]
    [Address(RVA = "0x4D93998", Offset = "0x4D93998", VA = "0x4D93998")]
    public FriendListSubScene()
    {
    }

    [Token(Token = "0x200360A")]
    public enum FriendListDisplayType
    {
      [Token(Token = "0x400EB0B")] Default = 0,
      [Token(Token = "0x400EB07")] FriendList = 0,
      [Token(Token = "0x400EB08")] FriendNoticeList = 1,
      [Token(Token = "0x400EB09")] FriendRequestList = 2,
      [Token(Token = "0x400EB0A")] BlockList = 3,
    }

    [Token(Token = "0x200360B")]
    private class ReceivedFriendGiftInfo
    {
      [Token(Token = "0x6015489")]
      [Address(RVA = "0x4D94804", Offset = "0x4D94804", VA = "0x4D94804")]
      public ReceivedFriendGiftInfo(int numberOfMedalsAdded)
      {
      }

      [Token(Token = "0x170046C2")]
      public int NumberOfMedalsAdded
      {
        [Token(Token = "0x601548A"), Address(RVA = "0x4D9482C", Offset = "0x4D9482C", VA = "0x4D9482C")] get
        {
          return new int();
        }
        [Token(Token = "0x601548B"), Address(RVA = "0x4D94834", Offset = "0x4D94834", VA = "0x4D94834")] private set
        {
        }
      }
    }

    [Token(Token = "0x200360C")]
    public class FriendListParameter : ChangeSceneParameter
    {
      [Token(Token = "0x400EB0D")]
      [FieldOffset(Offset = "0x14")]
      public FriendListSubScene.FriendListDisplayType defaultListType;

      [Token(Token = "0x601548C")]
      [Address(RVA = "0x4D91540", Offset = "0x4D91540", VA = "0x4D91540")]
      public FriendListParameter()
      {
      }
    }
  }
}
