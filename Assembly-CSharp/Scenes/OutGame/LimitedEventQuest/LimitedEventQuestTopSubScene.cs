// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.LimitedEventQuest.LimitedEventQuestTopSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.LimitedEventQuest
{
  [Token(Token = "0x2003649")]
  public class LimitedEventQuestTopSubScene : SubScene
  {
    [Token(Token = "0x400EC40")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITimelineController panelFade;
    [Token(Token = "0x400EC41")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400EC42")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private LimitedEventQuestTopBanner bannerPrefab;
    [Token(Token = "0x400EC43")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject topSubSceneObject;
    [Token(Token = "0x400EC44")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Transform subSceneRootTransform;
    [Token(Token = "0x400EC45")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private ScrollRect bannerScroll;
    [Token(Token = "0x400EC46")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private string bannerServerPath;
    [Token(Token = "0x400EC47")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private string titleServerPath;
    [Token(Token = "0x400EC48")]
    [FieldOffset(Offset = "0x98")]
    private bool displayTopScene;
    [Token(Token = "0x400EC49")]
    [FieldOffset(Offset = "0xA0")]
    private Dictionary<int, LimitedEventQuestTopBanner> eventQuestTopBanners;
    [Token(Token = "0x400EC4A")]
    [FieldOffset(Offset = "0xA8")]
    private ILimitedEventQuest limitedEventQuest;
    [Token(Token = "0x400EC4B")]
    [FieldOffset(Offset = "0xB0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400EC4C")]
    [FieldOffset(Offset = "0xB8")]
    private LimitedEventQuestStageSelectPanel stageSelectPanel;
    [Token(Token = "0x400EC4D")]
    [FieldOffset(Offset = "0xC0")]
    private List<AssetSpawnOperationBase> requests;
    [Token(Token = "0x400EC4E")]
    [FieldOffset(Offset = "0xC8")]
    private Coroutine thumnbailLoadRequest;
    [Token(Token = "0x400EC4F")]
    [FieldOffset(Offset = "0xD0")]
    private UnityAction thumnbailLoadCompleteCollback;
    [Token(Token = "0x400EC50")]
    [FieldOffset(Offset = "0xD8")]
    private int shortCutSelectPanelEventId;
    [Token(Token = "0x400EC51")]
    [FieldOffset(Offset = "0xDC")]
    private bool isNeedFadeInByTransitionScene;

    [Token(Token = "0x60155F2")]
    [Address(RVA = "0x18D6D8C", Offset = "0x18D6D8C", VA = "0x18D6D8C")]
    public static bool TrytoChangeSceneByEventId(int eventId, bool needFade = false, bool isCreatedBack = false)
    {
      return new bool();
    }

    [Token(Token = "0x60155F3")]
    [Address(RVA = "0x18D6E64", Offset = "0x18D6E64", VA = "0x18D6E64")]
    public static bool TryToChangeScene(int stageId, bool needFade = false, bool isCreatedBack = false)
    {
      return new bool();
    }

    [Token(Token = "0x60155F4")]
    [Address(RVA = "0x18D700C", Offset = "0x18D700C", VA = "0x18D700C")]
    public static void ChangeScene(LimitedEventQuestTopSubScene.Parameter parameter = null)
    {
    }

    [Token(Token = "0x17004705")]
    public bool IsInitialized
    {
      [Token(Token = "0x60155F5"), Address(RVA = "0x18D70AC", Offset = "0x18D70AC", VA = "0x18D70AC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004706")]
    public bool IsEnableButton
    {
      [Token(Token = "0x60155F6"), Address(RVA = "0x18D70C8", Offset = "0x18D70C8", VA = "0x18D70C8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004707")]
    public bool IsDisplayTopScene
    {
      [Token(Token = "0x60155F7"), Address(RVA = "0x18D710C", Offset = "0x18D710C", VA = "0x18D710C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60155F8")]
    [Address(RVA = "0x18D7114", Offset = "0x18D7114", VA = "0x18D7114")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x17004708")]
    public bool IsSkipTopPanel
    {
      [Token(Token = "0x60155F9"), Address(RVA = "0x18D71DC", Offset = "0x18D71DC", VA = "0x18D71DC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60155FA")]
    [Address(RVA = "0x18D71EC", Offset = "0x18D71EC", VA = "0x18D71EC", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60155FB")]
    [Address(RVA = "0x18D7A4C", Offset = "0x18D7A4C", VA = "0x18D7A4C", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x60155FC")]
    [Address(RVA = "0x18D7A70", Offset = "0x18D7A70", VA = "0x18D7A70")]
    private void BackButtonEvent()
    {
    }

    [Token(Token = "0x60155FD")]
    [Address(RVA = "0x18D7A94", Offset = "0x18D7A94", VA = "0x18D7A94", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60155FE")]
    [Address(RVA = "0x18D7B24", Offset = "0x18D7B24", VA = "0x18D7B24", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x60155FF")]
    [Address(RVA = "0x18D7BB4", Offset = "0x18D7BB4", VA = "0x18D7BB4", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6015600")]
    [Address(RVA = "0x18D7C44", Offset = "0x18D7C44", VA = "0x18D7C44", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6015601")]
    [Address(RVA = "0x18D7CD4", Offset = "0x18D7CD4", VA = "0x18D7CD4")]
    private void CreateTopBanners()
    {
    }

    [Token(Token = "0x6015602")]
    [Address(RVA = "0x18D8180", Offset = "0x18D8180", VA = "0x18D8180")]
    private bool SetUpSelectPanelEvent(int eventId) => new bool();

    [Token(Token = "0x6015603")]
    [Address(RVA = "0x18D8448", Offset = "0x18D8448", VA = "0x18D8448")]
    private void LoadRequestThumbnailImage(UnityAction callback)
    {
    }

    [Token(Token = "0x6015604")]
    [Address(RVA = "0x18D8E88", Offset = "0x18D8E88", VA = "0x18D8E88")]
    private IEnumerator LoadWaitThumbnailImage() => (IEnumerator) null;

    [Token(Token = "0x6015605")]
    [Address(RVA = "0x18D896C", Offset = "0x18D896C", VA = "0x18D896C")]
    private void UpdateNewBadge(int eventId)
    {
    }

    [Token(Token = "0x6015606")]
    [Address(RVA = "0x18D8F18", Offset = "0x18D8F18", VA = "0x18D8F18")]
    public LimitedEventQuestTopSubScene()
    {
    }

    [Token(Token = "0x200364A")]
    public sealed class Parameter : ChangeSceneParameter
    {
      [Token(Token = "0x400EC52")]
      [FieldOffset(Offset = "0x14")]
      public int EventId;
      [Token(Token = "0x400EC53")]
      [FieldOffset(Offset = "0x18")]
      public bool NeedFadeOnInitialize;

      [Token(Token = "0x6015615")]
      [Address(RVA = "0x18D6FC4", Offset = "0x18D6FC4", VA = "0x18D6FC4")]
      public Parameter(int eventId, bool needFadeOnInitialize, bool isCreatedBack)
      {
      }
    }
  }
}
