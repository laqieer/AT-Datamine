// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestContentsList.QuestContentsListSubSceneUILogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Movie;
using GameCore.RawData;
using GlandMenu;
using GlobalMenu;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.QuestContentsList
{
  [Token(Token = "0x2003418")]
  public class QuestContentsListSubSceneUILogic : MonoBehaviour
  {
    [Token(Token = "0x400E286")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400E287")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400E288")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button ButtonStoryMainAreaQuest;
    [Token(Token = "0x400E289")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button ButtonStoryModernEdition;
    [Token(Token = "0x400E28A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button ButtonScenarioEvent;
    [Token(Token = "0x400E28B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button ButtonEventQuest;
    [Token(Token = "0x400E28C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button ButtonFreeQuest;
    [Token(Token = "0x400E28D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button ButtonStory;
    [Token(Token = "0x400E28E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button ButtonScenarioArchive;
    [Token(Token = "0x400E28F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Button ButtonBack;
    [Token(Token = "0x400E290")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Button ButtonHelp;
    [Token(Token = "0x400E291")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private RawImage ScenarioQuestImage;
    [Token(Token = "0x400E292")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Header header;
    [Token(Token = "0x400E293")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private PlayerData playerData;
    [Token(Token = "0x400E294")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private SimpleMoviePlayer moviePlayer;
    [Token(Token = "0x400E295")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ContentLockController contentLockController;
    [Token(Token = "0x400E296")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ContentLockButton ContentLockButtonScenarioEvent;
    [Token(Token = "0x400E297")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject tapBlock;
    [Token(Token = "0x400E298")]
    private const string transitionScenarioArchiveABName = "ui_page_outgame_storyarchive";
    [Token(Token = "0x400E299")]
    private const string transitionScenarioArchiveAssetName = "StoryArchiveSubScene";
    [Token(Token = "0x400E29A")]
    [FieldOffset(Offset = "0xA8")]
    private string BANNER_FORMAT;
    [Token(Token = "0x400E29B")]
    [FieldOffset(Offset = "0xB0")]
    private string QUEST_BANNER_FORMAT;
    [Token(Token = "0x400E29C")]
    [FieldOffset(Offset = "0xB8")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x400E29D")]
    [FieldOffset(Offset = "0xC0")]
    private bool playInAnimationEnd;
    [Token(Token = "0x400E29E")]
    [FieldOffset(Offset = "0xC1")]
    private bool IsOpenHelp;
    [Token(Token = "0x400E29F")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private QuestContentsBannerElement banner;
    [Token(Token = "0x400E2A0")]
    [FieldOffset(Offset = "0xD0")]
    private RawTextureManager textureManager;

    [Token(Token = "0x17004430")]
    public bool IsPlayAnimationEnd
    {
      [Token(Token = "0x6014794"), Address(RVA = "0x18962A8", Offset = "0x18962A8", VA = "0x18962A8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6014795")]
    [Address(RVA = "0x18962B0", Offset = "0x18962B0", VA = "0x18962B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6014796")]
    [Address(RVA = "0x18965D0", Offset = "0x18965D0", VA = "0x18965D0")]
    protected void OnDestroy()
    {
    }

    [Token(Token = "0x6014797")]
    [Address(RVA = "0x18962B4", Offset = "0x18962B4", VA = "0x18962B4")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6014798")]
    [Address(RVA = "0x1895C18", Offset = "0x1895C18", VA = "0x1895C18")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6014799")]
    [Address(RVA = "0x1895C80", Offset = "0x1895C80", VA = "0x1895C80")]
    public IEnumerator InitializeAsyncBeforeStart() => (IEnumerator) null;

    [Token(Token = "0x601479A")]
    [Address(RVA = "0x1896680", Offset = "0x1896680", VA = "0x1896680")]
    private IEnumerator ScenarioButtonInitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601479B")]
    [Address(RVA = "0x1896710", Offset = "0x1896710", VA = "0x1896710")]
    private IEnumerator QuestBannerInitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601479C")]
    [Address(RVA = "0x18967A0", Offset = "0x18967A0", VA = "0x18967A0")]
    private void OnClickBanner(AreaQuestEventPageData data)
    {
    }

    [Token(Token = "0x601479D")]
    [Address(RVA = "0x1895F34", Offset = "0x1895F34", VA = "0x1895F34")]
    public IEnumerator PlayStartSequnceAsync() => (IEnumerator) null;

    [Token(Token = "0x601479E")]
    [Address(RVA = "0x18965EC", Offset = "0x18965EC", VA = "0x18965EC")]
    private void ButtonSetEvent(Button button, UnityAction func)
    {
    }

    [Token(Token = "0x601479F")]
    [Address(RVA = "0x1896B40", Offset = "0x1896B40", VA = "0x1896B40")]
    private void OnClickPlayerInfo()
    {
    }

    [Token(Token = "0x60147A0")]
    [Address(RVA = "0x1896C04", Offset = "0x1896C04", VA = "0x1896C04")]
    private void OnClickStoryMainAreaQuest()
    {
    }

    [Token(Token = "0x60147A1")]
    [Address(RVA = "0x1896CDC", Offset = "0x1896CDC", VA = "0x1896CDC")]
    private void OnClickStoryMain2AreaQuest()
    {
    }

    [Token(Token = "0x60147A2")]
    [Address(RVA = "0x1896DB4", Offset = "0x1896DB4", VA = "0x1896DB4")]
    private void CheckScenarioEvent()
    {
    }

    [Token(Token = "0x60147A3")]
    [Address(RVA = "0x1896DD4", Offset = "0x1896DD4", VA = "0x1896DD4")]
    private void OnClickScenarioEvent()
    {
    }

    [Token(Token = "0x60147A4")]
    [Address(RVA = "0x1896F0C", Offset = "0x1896F0C", VA = "0x1896F0C")]
    private void CheckEventQuest()
    {
    }

    [Token(Token = "0x60147A5")]
    [Address(RVA = "0x1896F2C", Offset = "0x1896F2C", VA = "0x1896F2C")]
    private void OnClickEventQuest()
    {
    }

    [Token(Token = "0x60147A6")]
    [Address(RVA = "0x1896F58", Offset = "0x1896F58", VA = "0x1896F58")]
    private void CheckFreeQuest()
    {
    }

    [Token(Token = "0x60147A7")]
    [Address(RVA = "0x1896F78", Offset = "0x1896F78", VA = "0x1896F78")]
    private void OnClickFreeQuest()
    {
    }

    [Token(Token = "0x60147A8")]
    [Address(RVA = "0x1896AF8", Offset = "0x1896AF8", VA = "0x1896AF8")]
    private void SetTapBlock(bool flag)
    {
    }

    [Token(Token = "0x60147A9")]
    [Address(RVA = "0x18952F8", Offset = "0x18952F8", VA = "0x18952F8")]
    public bool IsTapAllowed() => new bool();

    [Token(Token = "0x60147AA")]
    [Address(RVA = "0x18970B0", Offset = "0x18970B0", VA = "0x18970B0")]
    private bool isEventOpened() => new bool();

    [Token(Token = "0x60147AB")]
    [Address(RVA = "0x1897114", Offset = "0x1897114", VA = "0x1897114")]
    private void initializeSenarioQuestButtonLock()
    {
    }

    [Token(Token = "0x60147AC")]
    [Address(RVA = "0x1897144", Offset = "0x1897144", VA = "0x1897144")]
    private void OnClickStory()
    {
    }

    [Token(Token = "0x60147AD")]
    [Address(RVA = "0x189716C", Offset = "0x189716C", VA = "0x189716C")]
    private void OnClickScenarioArchivet()
    {
    }

    [Token(Token = "0x60147AE")]
    [Address(RVA = "0x1895348", Offset = "0x1895348", VA = "0x1895348")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x60147AF")]
    [Address(RVA = "0x1897230", Offset = "0x1897230", VA = "0x1897230")]
    public void OnClickHelp()
    {
    }

    [Token(Token = "0x60147B0")]
    [Address(RVA = "0x18954F0", Offset = "0x18954F0", VA = "0x18954F0")]
    public void PlayInAnimation(Action onComplete = null)
    {
    }

    [Token(Token = "0x60147B1")]
    [Address(RVA = "0x18955D8", Offset = "0x18955D8", VA = "0x18955D8")]
    public void PlayOutAnimation(Action onComplete = null)
    {
    }

    [Token(Token = "0x60147B2")]
    [Address(RVA = "0x1897314", Offset = "0x1897314", VA = "0x1897314")]
    private string GetQuestButtonUri(string BANNER_TOP_FORMAT) => (string) null;

    [Token(Token = "0x60147B3")]
    [Address(RVA = "0x18976E0", Offset = "0x18976E0", VA = "0x18976E0")]
    private IEnumerator SetupBannerCoroutine(RawImage banner, string uri) => (IEnumerator) null;

    [Token(Token = "0x60147B4")]
    [Address(RVA = "0x1897784", Offset = "0x1897784", VA = "0x1897784")]
    private void UpdateHeader()
    {
    }

    [Token(Token = "0x60147B5")]
    [Address(RVA = "0x1895DE4", Offset = "0x1895DE4", VA = "0x1895DE4")]
    public IEnumerator OnBackSubSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x60147B6")]
    [Address(RVA = "0x18977E0", Offset = "0x18977E0", VA = "0x18977E0")]
    public QuestContentsListSubSceneUILogic()
    {
    }
  }
}
