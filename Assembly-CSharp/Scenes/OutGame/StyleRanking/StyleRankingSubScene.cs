// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.StyleRanking.StyleRankingSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using Network;
using Network.Param;
using Scenes.OutGame.PlayerInfo;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.StyleRanking
{
  [Token(Token = "0x2003368")]
  public class StyleRankingSubScene : SubScene
  {
    [Token(Token = "0x400DECB")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400DECC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITimelineController topTimelineController;
    [Token(Token = "0x400DECD")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UITimelineController bpTimelineController;
    [Token(Token = "0x400DECE")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CanvasGroup rootCG;
    [Token(Token = "0x400DECF")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Camera backUICamera;
    [Token(Token = "0x400DED0")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Canvas backUI;
    [Token(Token = "0x400DED1")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject mainBG;
    [Token(Token = "0x400DED2")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CanvasGroup safeArea;
    [Token(Token = "0x400DED3")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400DED4")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private StyleRankingTopList topList;
    [Token(Token = "0x400DED5")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private StyleRankingList rankingList;
    [Token(Token = "0x400DED6")]
    [FieldOffset(Offset = "0xB0")]
    private StyleRankingSubScene.ViewState viewState;
    [Token(Token = "0x400DED7")]
    [FieldOffset(Offset = "0xB8")]
    private List<BaseRankingListType> rankingTops;
    [Token(Token = "0x400DED8")]
    [FieldOffset(Offset = "0xC0")]
    private List<int> viewStyleList;
    [Token(Token = "0x400DED9")]
    [FieldOffset(Offset = "0xC8")]
    private BaseRankingListType rankings;
    [Token(Token = "0x400DEDA")]
    [FieldOffset(Offset = "0xD0")]
    private BasePowerRankingType myRanking;
    [Token(Token = "0x400DEDB")]
    [FieldOffset(Offset = "0xD8")]
    private int rankingCount;
    [Token(Token = "0x400DEDC")]
    [FieldOffset(Offset = "0xE0")]
    private StyleRankingOtherPlayerProfile otherPlayerProfile;
    [Token(Token = "0x400DEDD")]
    [FieldOffset(Offset = "0xE8")]
    private bool isApiError;

    [Token(Token = "0x6014336")]
    [Address(RVA = "0x1E18808", Offset = "0x1E18808", VA = "0x1E18808")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6014337")]
    [Address(RVA = "0x1E188E8", Offset = "0x1E188E8", VA = "0x1E188E8")]
    private void Update()
    {
    }

    [Token(Token = "0x6014338")]
    [Address(RVA = "0x1E18904", Offset = "0x1E18904", VA = "0x1E18904", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6014339")]
    [Address(RVA = "0x1E18BE0", Offset = "0x1E18BE0", VA = "0x1E18BE0", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601433A")]
    [Address(RVA = "0x1E18C70", Offset = "0x1E18C70", VA = "0x1E18C70", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x601433B")]
    [Address(RVA = "0x1E18FAC", Offset = "0x1E18FAC", VA = "0x1E18FAC")]
    public void SetOperationPossible(bool state)
    {
    }

    [Token(Token = "0x601433C")]
    [Address(RVA = "0x1E18FCC", Offset = "0x1E18FCC", VA = "0x1E18FCC")]
    private IEnumerator PlayTimelineTop(
      UITimelineController.DirectionType type,
      string key,
      Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601433D")]
    [Address(RVA = "0x1E19080", Offset = "0x1E19080", VA = "0x1E19080")]
    private IEnumerator PlayTimelineBP(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601433E")]
    [Address(RVA = "0x1E18D3C", Offset = "0x1E18D3C", VA = "0x1E18D3C")]
    private void OnClickBack()
    {
    }

    [Token(Token = "0x601433F")]
    [Address(RVA = "0x1E19130", Offset = "0x1E19130", VA = "0x1E19130")]
    public void SetViewStyleList(List<int> viewStyleList)
    {
    }

    [Token(Token = "0x6014340")]
    [Address(RVA = "0x1E19138", Offset = "0x1E19138", VA = "0x1E19138")]
    public IEnumerator OpenRankingList(int index) => (IEnumerator) null;

    [Token(Token = "0x6014341")]
    [Address(RVA = "0x1E191D8", Offset = "0x1E191D8", VA = "0x1E191D8")]
    public IEnumerator UpdateRanking(int index, int page) => (IEnumerator) null;

    [Token(Token = "0x6014342")]
    [Address(RVA = "0x1E1927C", Offset = "0x1E1927C", VA = "0x1E1927C")]
    private void CallUpdateRankingList(int index, int page)
    {
    }

    [Token(Token = "0x6014343")]
    [Address(RVA = "0x1E19380", Offset = "0x1E19380", VA = "0x1E19380")]
    public IEnumerator OpenPlayerProfile(BasePowerRankingType param) => (IEnumerator) null;

    [Token(Token = "0x6014344")]
    [Address(RVA = "0x1E1941C", Offset = "0x1E1941C", VA = "0x1E1941C")]
    public IEnumerator ConnectTopApi() => (IEnumerator) null;

    [Token(Token = "0x6014345")]
    [Address(RVA = "0x1E194AC", Offset = "0x1E194AC", VA = "0x1E194AC")]
    public IEnumerator ConnectRankingApi(int styleId, int page) => (IEnumerator) null;

    [Token(Token = "0x6014346")]
    [Address(RVA = "0x1E19550", Offset = "0x1E19550", VA = "0x1E19550")]
    private IEnumerator OnError(NetworkErrorResult result) => (IEnumerator) null;

    [Token(Token = "0x6014347")]
    [Address(RVA = "0x1E195E0", Offset = "0x1E195E0", VA = "0x1E195E0")]
    public StyleRankingSubScene()
    {
    }

    [Token(Token = "0x2003369")]
    private enum ViewState
    {
      [Token(Token = "0x400DEDF")] Top,
      [Token(Token = "0x400DEE0")] Ranking,
    }
  }
}
