// Decompiled with JetBrains decompiler
// Type: Scenes.Home.HomeTopSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Home;
using Home.Event;
using Il2CppDummyDll;
using Network.Param;
using Scenes.Information;
using Scenes.OutGame.OutGameMenu;
using staq.SaveData;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Home
{
  [Token(Token = "0x2002AE7")]
  internal class HomeTopSubScene : SubScene
  {
    [Token(Token = "0x400B685")]
    [FieldOffset(Offset = "0x58")]
    private IHome3DEffectPlayer home3DEffectPlayer;
    [Token(Token = "0x400B686")]
    [FieldOffset(Offset = "0x60")]
    private GrandMenuController grandMenuController;
    [Token(Token = "0x400B687")]
    [FieldOffset(Offset = "0x68")]
    private HomeTransitionContoller transitionContoller;
    [Token(Token = "0x400B688")]
    [FieldOffset(Offset = "0x70")]
    private bool needFadeOnInitialize;
    [Token(Token = "0x400B689")]
    [FieldOffset(Offset = "0x71")]
    private bool needWaitHomeEnterEffect;
    [Token(Token = "0x400B68A")]
    [FieldOffset(Offset = "0x72")]
    private bool isFinishedHomeEnterEffect;
    [Token(Token = "0x400B68B")]
    [FieldOffset(Offset = "0x78")]
    private HomeSuspendResume homeSuspendResume;
    [Token(Token = "0x400B68C")]
    private const string ASSET_BUNDLE_LOSTREVIVELIST = "ui_page_characterlist";
    [Token(Token = "0x400B68D")]
    private const string ASSET_LOSTREVIVELIST = "Com_Popup_Base_L_Lost_List";
    [Token(Token = "0x400B68E")]
    [FieldOffset(Offset = "0x80")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400B68F")]
    [FieldOffset(Offset = "0x88")]
    private List<HotDealInfoType> hotDeals;
    [Token(Token = "0x400B690")]
    [FieldOffset(Offset = "0x90")]
    private InformationPopup informationPopup;
    [Token(Token = "0x400B691")]
    [FieldOffset(Offset = "0x98")]
    private bool isOpenedinformationPopup;
    [Token(Token = "0x400B692")]
    [FieldOffset(Offset = "0x99")]
    private bool isEnableEffectEnd;
    [Token(Token = "0x400B693")]
    [FieldOffset(Offset = "0x9A")]
    private bool isDisableReturnTitle;
    [Token(Token = "0x400B694")]
    [FieldOffset(Offset = "0x9B")]
    private bool isOpenPoster;
    [Token(Token = "0x400B695")]
    [FieldOffset(Offset = "0xA0")]
    private HomeEventPosterUI posterUI;
    [Token(Token = "0x400B696")]
    [FieldOffset(Offset = "0xA8")]
    private bool _openingCoinShop;

    [Token(Token = "0x6010C46")]
    [Address(RVA = "0x4BDD3B0", Offset = "0x4BDD3B0", VA = "0x4BDD3B0")]
    public static bool TryBackOrChangeScene(HomeTopChangeSceneParameter param = null) => new bool();

    [Token(Token = "0x6010C47")]
    [Address(RVA = "0x4BDD514", Offset = "0x4BDD514", VA = "0x4BDD514")]
    public static void ChangeSceneAsRoot(HomeTopChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6010C48")]
    [Address(RVA = "0x4BDD598", Offset = "0x4BDD598", VA = "0x4BDD598")]
    public static void ChangeScene(HomeTopChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6010C49")]
    [Address(RVA = "0x4BDD648", Offset = "0x4BDD648", VA = "0x4BDD648")]
    private void Update()
    {
    }

    [Token(Token = "0x6010C4A")]
    [Address(RVA = "0x4BDD664", Offset = "0x4BDD664", VA = "0x4BDD664", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6010C4B")]
    [Address(RVA = "0x4BDD8E0", Offset = "0x4BDD8E0", VA = "0x4BDD8E0")]
    private void InitAssetCachedSpawner()
    {
    }

    [Token(Token = "0x6010C4C")]
    [Address(RVA = "0x4BDD9DC", Offset = "0x4BDD9DC", VA = "0x4BDD9DC", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6010C4D")]
    [Address(RVA = "0x4BDDA44", Offset = "0x4BDDA44", VA = "0x4BDDA44", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6010C4E")]
    [Address(RVA = "0x4BDE0FC", Offset = "0x4BDE0FC", VA = "0x4BDE0FC")]
    private IEnumerator RequestAPIHome() => (IEnumerator) null;

    [Token(Token = "0x6010C4F")]
    [Address(RVA = "0x4BDE164", Offset = "0x4BDE164", VA = "0x4BDE164")]
    private List<HomeBannerType> FilterValidBanners(List<HomeBannerType> banners)
    {
      return (List<HomeBannerType>) null;
    }

    [Token(Token = "0x6010C50")]
    [Address(RVA = "0x4BDE278", Offset = "0x4BDE278", VA = "0x4BDE278")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6010C51")]
    [Address(RVA = "0x4BDE2F0", Offset = "0x4BDE2F0", VA = "0x4BDE2F0")]
    private void MenuOpen()
    {
    }

    [Token(Token = "0x6010C52")]
    [Address(RVA = "0x4BDE3A8", Offset = "0x4BDE3A8", VA = "0x4BDE3A8")]
    private IEnumerator ShowHomePopup() => (IEnumerator) null;

    [Token(Token = "0x6010C53")]
    [Address(RVA = "0x4BDE410", Offset = "0x4BDE410", VA = "0x4BDE410")]
    private IEnumerator ShowURLSchemeReward() => (IEnumerator) null;

    [Token(Token = "0x6010C54")]
    [Address(RVA = "0x4BDE470", Offset = "0x4BDE470", VA = "0x4BDE470")]
    private IEnumerator ShowInformation() => (IEnumerator) null;

    [Token(Token = "0x6010C55")]
    [Address(RVA = "0x4BDE4D8", Offset = "0x4BDE4D8", VA = "0x4BDE4D8")]
    private IEnumerator ShowMessage(List<OfficialMessageArticleType> articles)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010C56")]
    [Address(RVA = "0x4BDE54C", Offset = "0x4BDE54C", VA = "0x4BDE54C")]
    private List<OfficialMessageArticleType> GetOfficialMessageArticleTypeList()
    {
      return (List<OfficialMessageArticleType>) null;
    }

    [Token(Token = "0x6010C57")]
    [Address(RVA = "0x4BDE720", Offset = "0x4BDE720", VA = "0x4BDE720")]
    private IEnumerator ShowSuspendResume(Action<bool> onAwayFromHome) => (IEnumerator) null;

    [Token(Token = "0x6010C58")]
    [Address(RVA = "0x4BDE794", Offset = "0x4BDE794", VA = "0x4BDE794")]
    private IEnumerator ShowLostRevive(Action<bool> onRevive) => (IEnumerator) null;

    [Token(Token = "0x6010C59")]
    [Address(RVA = "0x4BDE808", Offset = "0x4BDE808", VA = "0x4BDE808")]
    private IEnumerator AnnouncePassBenefitReceive(Action closeAction) => (IEnumerator) null;

    [Token(Token = "0x6010C5A")]
    [Address(RVA = "0x4BDE870", Offset = "0x4BDE870", VA = "0x4BDE870")]
    private IEnumerator ScoreAttackRankingRewardReceive(
      List<PlayerScoreAttackRankingRewardType> scoreAttackRankingRewards)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010C5B")]
    [Address(RVA = "0x4BDE8E4", Offset = "0x4BDE8E4", VA = "0x4BDE8E4")]
    private IEnumerator ShowPassDayLeft(
      ShopAPIManager shopAPI,
      Queue<PassData> passDatas,
      Action<bool, int?> onMoveScene)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010C5C")]
    [Address(RVA = "0x4BDE964", Offset = "0x4BDE964", VA = "0x4BDE964")]
    private IEnumerator ShowPassOutPeriod(
      ShopAPIManager shopAPI,
      Queue<PassShopSaveData.PassShopSave> passShopSaves,
      Action<bool, int?> onMoveScene)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010C5D")]
    [Address(RVA = "0x4BDE9E4", Offset = "0x4BDE9E4", VA = "0x4BDE9E4")]
    private IEnumerator ShowPassItemLimit(Action<bool> moveShop) => (IEnumerator) null;

    [Token(Token = "0x6010C5E")]
    [Address(RVA = "0x4BDEA58", Offset = "0x4BDEA58", VA = "0x4BDEA58")]
    private void InitializeTransitionController()
    {
    }

    [Token(Token = "0x6010C5F")]
    [Address(RVA = "0x4BDEB4C", Offset = "0x4BDEB4C", VA = "0x4BDEB4C")]
    private IEnumerator EnterEffect() => (IEnumerator) null;

    [Token(Token = "0x6010C60")]
    [Address(RVA = "0x4BDEBB4", Offset = "0x4BDEBB4", VA = "0x4BDEBB4")]
    private IEnumerator PlayHomeEnterEffect() => (IEnumerator) null;

    [Token(Token = "0x6010C61")]
    [Address(RVA = "0x4BDEC1C", Offset = "0x4BDEC1C", VA = "0x4BDEC1C", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6010C62")]
    [Address(RVA = "0x4BDEC84", Offset = "0x4BDEC84", VA = "0x4BDEC84", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6010C63")]
    [Address(RVA = "0x4BDECEC", Offset = "0x4BDECEC", VA = "0x4BDECEC", Slot = "27")]
    public override void OnNextScene()
    {
    }

    [Token(Token = "0x6010C64")]
    [Address(RVA = "0x4BDED40", Offset = "0x4BDED40", VA = "0x4BDED40", Slot = "24")]
    public override void OnBeforeBackScene()
    {
    }

    [Token(Token = "0x6010C65")]
    [Address(RVA = "0x4BDED94", Offset = "0x4BDED94", VA = "0x4BDED94", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6010C66")]
    [Address(RVA = "0x4BDEDFC", Offset = "0x4BDEDFC", VA = "0x4BDEDFC", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6010C67")]
    [Address(RVA = "0x4BDEEC8", Offset = "0x4BDEEC8", VA = "0x4BDEEC8")]
    private IEnumerator SetLostReviveList(List<Character> chrDataList, Action<bool> onRevive)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010C68")]
    [Address(RVA = "0x4BDEF40", Offset = "0x4BDEF40", VA = "0x4BDEF40")]
    private void OnTransitionNews(int firstViewId)
    {
    }

    [Token(Token = "0x6010C69")]
    [Address(RVA = "0x4BDF050", Offset = "0x4BDF050", VA = "0x4BDF050")]
    private void OpenPaidCoinShop(int firstViewId)
    {
    }

    [Token(Token = "0x6010C6A")]
    [Address(RVA = "0x4BDF198", Offset = "0x4BDF198", VA = "0x4BDF198")]
    public IEnumerator OpenPoster() => (IEnumerator) null;

    [Token(Token = "0x6010C6B")]
    [Address(RVA = "0x4BDF200", Offset = "0x4BDF200", VA = "0x4BDF200")]
    public HomeTopSubScene()
    {
    }
  }
}
