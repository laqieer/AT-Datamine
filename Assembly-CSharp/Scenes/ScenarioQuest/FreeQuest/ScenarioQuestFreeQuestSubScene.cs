// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.FreeQuest.ScenarioQuestFreeQuestSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery;
using Scenes.OutGame.LimitedEventQuest;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.ScenarioQuest.FreeQuest
{
  [Token(Token = "0x2002971")]
  public class ScenarioQuestFreeQuestSubScene : SubScene
  {
    [Token(Token = "0x400B092")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private EventQuestStageDetailPanel detailPanel;
    [Token(Token = "0x400B093")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITimelineController timeline;
    [Token(Token = "0x400B094")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private EventQuestStageContainer stageCloneBase;
    [Token(Token = "0x400B095")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private ScrollRect selectStageScroll;
    [Token(Token = "0x400B096")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private ApRecoveryHeader apHeader;
    [Token(Token = "0x400B097")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400B098")]
    [FieldOffset(Offset = "0x88")]
    private UITImelineControllerFacade timelineFacade;
    [Token(Token = "0x400B099")]
    [FieldOffset(Offset = "0x90")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x400B09A")]
    [FieldOffset(Offset = "0x98")]
    private IScenarioEventFreeQuest scenarioEventFreeQuest;
    [Token(Token = "0x400B09B")]
    [FieldOffset(Offset = "0xA0")]
    private readonly List<EventQuestStageContainer> stageContainers;
    [Token(Token = "0x400B09C")]
    [FieldOffset(Offset = "0xA8")]
    private List<EventQuestStageThumbnail> stageThumbnails;
    [Token(Token = "0x400B09D")]
    [FieldOffset(Offset = "0xB0")]
    private int chapterId;
    [Token(Token = "0x400B09E")]
    [FieldOffset(Offset = "0xB8")]
    private ScenarioQuestFreeQuestSubScene.ChangeFreeQuestSceneParameter freeQuestSceneParameter;

    [Token(Token = "0x60104A9")]
    [Address(RVA = "0x47548A8", Offset = "0x47548A8", VA = "0x47548A8")]
    public static void ChangeSubScene(int chapterID, bool needFade = false, bool createdBack = false)
    {
    }

    [Token(Token = "0x170038FC")]
    public bool IsInitialized
    {
      [Token(Token = "0x60104AA"), Address(RVA = "0x475A20C", Offset = "0x475A20C", VA = "0x475A20C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170038FD")]
    private bool IsEnableButton
    {
      [Token(Token = "0x60104AB"), Address(RVA = "0x475A24C", Offset = "0x475A24C", VA = "0x475A24C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170038FE")]
    private bool IsTransitionDirect
    {
      [Token(Token = "0x60104AC"), Address(RVA = "0x475A290", Offset = "0x475A290", VA = "0x475A290")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60104AD")]
    [Address(RVA = "0x475A314", Offset = "0x475A314", VA = "0x475A314")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60104AE")]
    [Address(RVA = "0x475A3B8", Offset = "0x475A3B8", VA = "0x475A3B8", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60104AF")]
    [Address(RVA = "0x475A5B8", Offset = "0x475A5B8", VA = "0x475A5B8", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60104B0")]
    [Address(RVA = "0x475A648", Offset = "0x475A648", VA = "0x475A648", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x60104B1")]
    [Address(RVA = "0x475A6D8", Offset = "0x475A6D8", VA = "0x475A6D8", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60104B2")]
    [Address(RVA = "0x475A768", Offset = "0x475A768", VA = "0x475A768", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x60104B3")]
    [Address(RVA = "0x475A7F8", Offset = "0x475A7F8", VA = "0x475A7F8")]
    public void OnBack()
    {
    }

    [Token(Token = "0x60104B4")]
    [Address(RVA = "0x475A7FC", Offset = "0x475A7FC", VA = "0x475A7FC")]
    public void SetUp()
    {
    }

    [Token(Token = "0x60104B5")]
    [Address(RVA = "0x475AFD0", Offset = "0x475AFD0", VA = "0x475AFD0")]
    private IEnumerator OpenQuestDetailPopup(int questId) => (IEnumerator) null;

    [Token(Token = "0x60104B6")]
    [Address(RVA = "0x475B070", Offset = "0x475B070", VA = "0x475B070")]
    public void SetNextScene()
    {
    }

    [Token(Token = "0x60104B7")]
    [Address(RVA = "0x475B090", Offset = "0x475B090", VA = "0x475B090")]
    public void SetBackScene()
    {
    }

    [Token(Token = "0x60104B8")]
    [Address(RVA = "0x475B0B0", Offset = "0x475B0B0", VA = "0x475B0B0")]
    private void BackButtonEvent()
    {
    }

    [Token(Token = "0x60104B9")]
    [Address(RVA = "0x475B184", Offset = "0x475B184", VA = "0x475B184")]
    private void LoadRequestThumbnailImage()
    {
    }

    [Token(Token = "0x60104BA")]
    [Address(RVA = "0x475B5F8", Offset = "0x475B5F8", VA = "0x475B5F8")]
    public ScenarioQuestFreeQuestSubScene()
    {
    }

    [Token(Token = "0x2002972")]
    private class ChangeFreeQuestSceneParameter : ChangeSceneParameter
    {
      [Token(Token = "0x170038FF")]
      public int ChapterID
      {
        [Token(Token = "0x60104C0"), Address(RVA = "0x475B718", Offset = "0x475B718", VA = "0x475B718")] get
        {
          return new int();
        }
        [Token(Token = "0x60104C1"), Address(RVA = "0x475B720", Offset = "0x475B720", VA = "0x475B720")] private set
        {
        }
      }

      [Token(Token = "0x17003900")]
      public bool NeedFadeOnInitialize
      {
        [Token(Token = "0x60104C2"), Address(RVA = "0x475B728", Offset = "0x475B728", VA = "0x475B728")] get
        {
          return new bool();
        }
        [Token(Token = "0x60104C3"), Address(RVA = "0x475B730", Offset = "0x475B730", VA = "0x475B730")] set
        {
        }
      }

      [Token(Token = "0x60104C4")]
      [Address(RVA = "0x475A1C0", Offset = "0x475A1C0", VA = "0x475A1C0")]
      public ChangeFreeQuestSceneParameter(int chapterID, bool fade = false, bool isCreatedBack = false)
      {
      }
    }
  }
}
