// Decompiled with JetBrains decompiler
// Type: FreeMap.State.FreeMapStateManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob;
using FreeMap.Adv;
using FreeMap.Data;
using FreeMap.Instance;
using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using FreeMap.State.ModeState;
using FreeMap.State.Process;
using FreeMap.UI;
using FreeMap.UI.Element;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using Story.FreeAction.Notify;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.State
{
  [Token(Token = "0x2001792")]
  public class FreeMapStateManager
  {
    [Token(Token = "0x4006858")]
    [FieldOffset(Offset = "0x90")]
    public FreeMapStateManager.DelegateStartCoroutine StartCoroutine;
    [Token(Token = "0x400685A")]
    [FieldOffset(Offset = "0xA0")]
    private FreeMapIconEventControlElement iconEventControlElementCache;
    [Token(Token = "0x400685B")]
    [FieldOffset(Offset = "0xA8")]
    private PlayingStoryInfo storyInfo;
    [Token(Token = "0x400685C")]
    [FieldOffset(Offset = "0xB0")]
    private readonly ProcessHandler processHandler;
    [Token(Token = "0x400685D")]
    [FieldOffset(Offset = "0xB8")]
    private readonly PlayerState playerState;
    [Token(Token = "0x400685E")]
    [FieldOffset(Offset = "0xC0")]
    private readonly PlayerObserver playerObserver;
    [Token(Token = "0x4006861")]
    [FieldOffset(Offset = "0xD0")]
    private ModeStateBase modeState;

    [Token(Token = "0x17001526")]
    public FreeMapCommonElement CommonElementRef
    {
      [Token(Token = "0x6008596"), Address(RVA = "0x406CD74", Offset = "0x406CD74", VA = "0x406CD74")] get
      {
        return (FreeMapCommonElement) null;
      }
      [Token(Token = "0x6008597"), Address(RVA = "0x406CD7C", Offset = "0x406CD7C", VA = "0x406CD7C")] private set
      {
      }
    }

    [Token(Token = "0x17001527")]
    public Action<int> NoticeNextSequenceMethodRef
    {
      [Token(Token = "0x6008598"), Address(RVA = "0x406CD84", Offset = "0x406CD84", VA = "0x406CD84")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6008599"), Address(RVA = "0x406CD8C", Offset = "0x406CD8C", VA = "0x406CD8C")] set
      {
      }
    }

    [Token(Token = "0x17001528")]
    public Canvas MainCanvasRef
    {
      [Token(Token = "0x600859A"), Address(RVA = "0x406CD94", Offset = "0x406CD94", VA = "0x406CD94")] get
      {
        return (Canvas) null;
      }
      [Token(Token = "0x600859B"), Address(RVA = "0x406CD9C", Offset = "0x406CD9C", VA = "0x406CD9C")] private set
      {
      }
    }

    [Token(Token = "0x17001529")]
    public FreeMapLocationHolder LocationHolder
    {
      [Token(Token = "0x600859C"), Address(RVA = "0x406CDA4", Offset = "0x406CDA4", VA = "0x406CDA4")] get
      {
        return (FreeMapLocationHolder) null;
      }
      [Token(Token = "0x600859D"), Address(RVA = "0x406CDAC", Offset = "0x406CDAC", VA = "0x406CDAC")] private set
      {
      }
    }

    [Token(Token = "0x1700152A")]
    public PlacementHolder PlacementHolder
    {
      [Token(Token = "0x600859E"), Address(RVA = "0x406CDB4", Offset = "0x406CDB4", VA = "0x406CDB4")] get
      {
        return (PlacementHolder) null;
      }
    }

    [Token(Token = "0x1700152B")]
    public FreeMapParamList FreeMapParamList
    {
      [Token(Token = "0x600859F"), Address(RVA = "0x406CDBC", Offset = "0x406CDBC", VA = "0x406CDBC")] get
      {
        return (FreeMapParamList) null;
      }
      [Token(Token = "0x60085A0"), Address(RVA = "0x406CDC4", Offset = "0x406CDC4", VA = "0x406CDC4")] private set
      {
      }
    }

    [Token(Token = "0x1700152C")]
    public FreeMapAutoMoveRouteHandler AutoMoveRouteHandler
    {
      [Token(Token = "0x60085A1"), Address(RVA = "0x406CDCC", Offset = "0x406CDCC", VA = "0x406CDCC")] get
      {
        return (FreeMapAutoMoveRouteHandler) null;
      }
      [Token(Token = "0x60085A2"), Address(RVA = "0x406CDD4", Offset = "0x406CDD4", VA = "0x406CDD4")] private set
      {
      }
    }

    [Token(Token = "0x1700152D")]
    public FreeMapStatusChangeHandler ChangeHandler
    {
      [Token(Token = "0x60085A3"), Address(RVA = "0x406CDDC", Offset = "0x406CDDC", VA = "0x406CDDC")] get
      {
        return (FreeMapStatusChangeHandler) null;
      }
      [Token(Token = "0x60085A4"), Address(RVA = "0x406CDE4", Offset = "0x406CDE4", VA = "0x406CDE4")] private set
      {
      }
    }

    [Token(Token = "0x1700152E")]
    public MainLogic Notify
    {
      [Token(Token = "0x60085A5"), Address(RVA = "0x406CDEC", Offset = "0x406CDEC", VA = "0x406CDEC")] get
      {
        return (MainLogic) null;
      }
      [Token(Token = "0x60085A6"), Address(RVA = "0x406CDF4", Offset = "0x406CDF4", VA = "0x406CDF4")] private set
      {
      }
    }

    [Token(Token = "0x1700152F")]
    public Story.Tracker.Tracker Tracker
    {
      [Token(Token = "0x60085A7"), Address(RVA = "0x406CDFC", Offset = "0x406CDFC", VA = "0x406CDFC")] get
      {
        return (Story.Tracker.Tracker) null;
      }
      [Token(Token = "0x60085A8"), Address(RVA = "0x406CE04", Offset = "0x406CE04", VA = "0x406CE04")] set
      {
      }
    }

    [Token(Token = "0x17001530")]
    public MovableMobManager MovableManager
    {
      [Token(Token = "0x60085A9"), Address(RVA = "0x406CE0C", Offset = "0x406CE0C", VA = "0x406CE0C")] get
      {
        return (MovableMobManager) null;
      }
      [Token(Token = "0x60085AA"), Address(RVA = "0x406CE14", Offset = "0x406CE14", VA = "0x406CE14")] private set
      {
      }
    }

    [Token(Token = "0x17001531")]
    public FreeMapBackGroundTemporarySceneLoader BackGroundSceneReloadHandler
    {
      [Token(Token = "0x60085AB"), Address(RVA = "0x406CE1C", Offset = "0x406CE1C", VA = "0x406CE1C")] get
      {
        return (FreeMapBackGroundTemporarySceneLoader) null;
      }
      [Token(Token = "0x60085AC"), Address(RVA = "0x406CE24", Offset = "0x406CE24", VA = "0x406CE24")] private set
      {
      }
    }

    [Token(Token = "0x17001532")]
    public MapAdvControlAdapter AreaAdvControl
    {
      [Token(Token = "0x60085AD"), Address(RVA = "0x406CE2C", Offset = "0x406CE2C", VA = "0x406CE2C")] get
      {
        return (MapAdvControlAdapter) null;
      }
      [Token(Token = "0x60085AE"), Address(RVA = "0x406CE34", Offset = "0x406CE34", VA = "0x406CE34")] private set
      {
      }
    }

    [Token(Token = "0x17001533")]
    public int FreeActionSettingID
    {
      [Token(Token = "0x60085AF"), Address(RVA = "0x406CE3C", Offset = "0x406CE3C", VA = "0x406CE3C")] get
      {
        return new int();
      }
      [Token(Token = "0x60085B0"), Address(RVA = "0x406CE44", Offset = "0x406CE44", VA = "0x406CE44")] private set
      {
      }
    }

    [Token(Token = "0x17001534")]
    public int CalenderID
    {
      [Token(Token = "0x60085B1"), Address(RVA = "0x406CE4C", Offset = "0x406CE4C", VA = "0x406CE4C")] get
      {
        return new int();
      }
      [Token(Token = "0x60085B2"), Address(RVA = "0x406CE54", Offset = "0x406CE54", VA = "0x406CE54")] private set
      {
      }
    }

    [Token(Token = "0x17001535")]
    public int CurrentAreaID
    {
      [Token(Token = "0x60085B3"), Address(RVA = "0x406CE5C", Offset = "0x406CE5C", VA = "0x406CE5C")] get
      {
        return new int();
      }
      [Token(Token = "0x60085B4"), Address(RVA = "0x406CE64", Offset = "0x406CE64", VA = "0x406CE64")] private set
      {
      }
    }

    [Token(Token = "0x17001536")]
    public int ChapterID
    {
      [Token(Token = "0x60085B5"), Address(RVA = "0x406CE6C", Offset = "0x406CE6C", VA = "0x406CE6C")] get
      {
        return new int();
      }
      [Token(Token = "0x60085B6"), Address(RVA = "0x406CE74", Offset = "0x406CE74", VA = "0x406CE74")] private set
      {
      }
    }

    [Token(Token = "0x17001537")]
    public int SequenceID
    {
      [Token(Token = "0x60085B7"), Address(RVA = "0x406CE7C", Offset = "0x406CE7C", VA = "0x406CE7C")] get
      {
        return new int();
      }
      [Token(Token = "0x60085B8"), Address(RVA = "0x406CE84", Offset = "0x406CE84", VA = "0x406CE84")] private set
      {
      }
    }

    [Token(Token = "0x17001538")]
    public int NextSequenceID
    {
      [Token(Token = "0x60085B9"), Address(RVA = "0x406CE8C", Offset = "0x406CE8C", VA = "0x406CE8C")] get
      {
        return new int();
      }
      [Token(Token = "0x60085BA"), Address(RVA = "0x406CE94", Offset = "0x406CE94", VA = "0x406CE94")] private set
      {
      }
    }

    [Token(Token = "0x17001539")]
    public FreeMapIconEventControlElement IconEventControlElement
    {
      [Token(Token = "0x60085BB"), Address(RVA = "0x406BD34", Offset = "0x406BD34", VA = "0x406BD34")] get
      {
        return (FreeMapIconEventControlElement) null;
      }
    }

    [Token(Token = "0x1700153A")]
    public StoryFreeActionSettingData CurrentSettingData
    {
      [Token(Token = "0x60085BC"), Address(RVA = "0x406CE9C", Offset = "0x406CE9C", VA = "0x406CE9C")] get
      {
        return (StoryFreeActionSettingData) null;
      }
      [Token(Token = "0x60085BD"), Address(RVA = "0x406CEA4", Offset = "0x406CEA4", VA = "0x406CEA4")] set
      {
      }
    }

    [Token(Token = "0x60085BE")]
    [Address(RVA = "0x406CEAC", Offset = "0x406CEAC", VA = "0x406CEAC")]
    public PlayingStoryInfo GetStoryInfo() => (PlayingStoryInfo) null;

    [Token(Token = "0x1700153B")]
    public ProcessHandler ProcessHandler
    {
      [Token(Token = "0x60085BF"), Address(RVA = "0x406CEB4", Offset = "0x406CEB4", VA = "0x406CEB4")] get
      {
        return (ProcessHandler) null;
      }
    }

    [Token(Token = "0x1700153C")]
    public PlayerObserver PlayerObserver
    {
      [Token(Token = "0x60085C0"), Address(RVA = "0x406CEBC", Offset = "0x406CEBC", VA = "0x406CEBC")] get
      {
        return (PlayerObserver) null;
      }
    }

    [Token(Token = "0x1700153D")]
    public bool IsInitialized
    {
      [Token(Token = "0x60085C1"), Address(RVA = "0x406CEC4", Offset = "0x406CEC4", VA = "0x406CEC4")] get
      {
        return new bool();
      }
      [Token(Token = "0x60085C2"), Address(RVA = "0x406CECC", Offset = "0x406CECC", VA = "0x406CECC")] set
      {
      }
    }

    [Token(Token = "0x1700153E")]
    public bool IsFreeSubSeceneStarted
    {
      [Token(Token = "0x60085C3"), Address(RVA = "0x406CED8", Offset = "0x406CED8", VA = "0x406CED8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60085C4"), Address(RVA = "0x406CEE0", Offset = "0x406CEE0", VA = "0x406CEE0")] set
      {
      }
    }

    [Token(Token = "0x1700153F")]
    public bool IsFinalized
    {
      [Token(Token = "0x60085C5"), Address(RVA = "0x406CEEC", Offset = "0x406CEEC", VA = "0x406CEEC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60085C6")]
    [Address(RVA = "0x406CF08", Offset = "0x406CF08", VA = "0x406CF08")]
    public FreeMapStateManager()
    {
    }

    [Token(Token = "0x60085C7")]
    [Address(RVA = "0x406D3F0", Offset = "0x406D3F0", VA = "0x406D3F0")]
    public void PlayerStateAllow()
    {
    }

    [Token(Token = "0x60085C8")]
    [Address(RVA = "0x406D444", Offset = "0x406D444", VA = "0x406D444")]
    public void PlayerStateDisallow()
    {
    }

    [Token(Token = "0x60085C9")]
    [Address(RVA = "0x406D498", Offset = "0x406D498", VA = "0x406D498")]
    public void Initialize(PlayingStoryInfo storyInfo = null)
    {
    }

    [Token(Token = "0x60085CA")]
    [Address(RVA = "0x406D4C8", Offset = "0x406D4C8", VA = "0x406D4C8")]
    public IEnumerator InitializeAsync(PlayingStoryInfo storyInfo = null) => (IEnumerator) null;

    [Token(Token = "0x60085CB")]
    [Address(RVA = "0x406D564", Offset = "0x406D564", VA = "0x406D564")]
    public void Release()
    {
    }

    [Token(Token = "0x60085CC")]
    [Address(RVA = "0x406D618", Offset = "0x406D618", VA = "0x406D618")]
    public void Update()
    {
    }

    [Token(Token = "0x60085CD")]
    [Address(RVA = "0x406D7CC", Offset = "0x406D7CC", VA = "0x406D7CC")]
    public void SetNextSequenceID(int id)
    {
    }

    [Token(Token = "0x60085CE")]
    [Address(RVA = "0x406D7D4", Offset = "0x406D7D4", VA = "0x406D7D4")]
    public void AddProcess(FreeMapProcess process)
    {
    }

    [Token(Token = "0x60085CF")]
    [Address(RVA = "0x406D7F0", Offset = "0x406D7F0", VA = "0x406D7F0")]
    public void OnBackKeyDownAction()
    {
    }

    [Token(Token = "0x60085D0")]
    [Address(RVA = "0x406D88C", Offset = "0x406D88C", VA = "0x406D88C")]
    public void ProcessAllCancel()
    {
    }

    [Token(Token = "0x60085D1")]
    [Address(RVA = "0x406D8A8", Offset = "0x406D8A8", VA = "0x406D8A8")]
    public bool IsProcessing() => new bool();

    [Token(Token = "0x60085D2")]
    [Address(RVA = "0x406D8C4", Offset = "0x406D8C4", VA = "0x406D8C4")]
    public void EndFreeMap()
    {
    }

    [Token(Token = "0x60085D3")]
    [Address(RVA = "0x406D8E4", Offset = "0x406D8E4", VA = "0x406D8E4")]
    public void FreeMapTutorialStart(IntroChapterSequenceFreeActionSettingData param)
    {
    }

    [Token(Token = "0x60085D4")]
    [Address(RVA = "0x406D998", Offset = "0x406D998", VA = "0x406D998")]
    public void FreeMapStart(int chapterId, int sequenceID, int currentSettingDataID)
    {
    }

    [Token(Token = "0x60085D5")]
    [Address(RVA = "0x406DA3C", Offset = "0x406DA3C", VA = "0x406DA3C")]
    public void FreeMapPreStart(int chapterId, int sequenceID, int settingID)
    {
    }

    [Token(Token = "0x60085D6")]
    [Address(RVA = "0x406DAE0", Offset = "0x406DAE0", VA = "0x406DAE0")]
    public void FreeMapAreaEventPreStart(int chapterId, int sequenceID, int settingID)
    {
    }

    [Token(Token = "0x60085D7")]
    [Address(RVA = "0x406DB84", Offset = "0x406DB84", VA = "0x406DB84")]
    public bool IsPreStartEnded() => new bool();

    [Token(Token = "0x60085D8")]
    [Address(RVA = "0x406DBA4", Offset = "0x406DBA4", VA = "0x406DBA4")]
    public void FreeMapAreaEventStart(int chapterId, int sequenceID, int currentSettingDataID)
    {
    }

    [Token(Token = "0x60085D9")]
    [Address(RVA = "0x406D974", Offset = "0x406D974", VA = "0x406D974")]
    public void SetFreeMapSettingID(int id)
    {
    }

    [Token(Token = "0x60085DA")]
    [Address(RVA = "0x406DC48", Offset = "0x406DC48", VA = "0x406DC48")]
    public void OnSetupFreeMap(FreeMapParamList paramList)
    {
    }

    [Token(Token = "0x60085DB")]
    [Address(RVA = "0x406DE1C", Offset = "0x406DE1C", VA = "0x406DE1C")]
    public void SetAreaID(int id)
    {
    }

    [Token(Token = "0x60085DC")]
    [Address(RVA = "0x406DE24", Offset = "0x406DE24", VA = "0x406DE24")]
    private void OnRefresh(LocationData _, FreeMapInstanceHolder __)
    {
    }

    [Token(Token = "0x60085DD")]
    [Address(RVA = "0x406DE40", Offset = "0x406DE40", VA = "0x406DE40")]
    public void AutoMove(FreeMapUIParamBase target, IPlayerAreaOperationEvent playerOperation)
    {
    }

    [Token(Token = "0x60085DE")]
    [Address(RVA = "0x406DE88", Offset = "0x406DE88", VA = "0x406DE88")]
    public void CancelAutoMove()
    {
    }

    [Token(Token = "0x17001540")]
    public FreeMapStateManager.OnChangeAreaByTransitionArea ChangeAreaByTransitionAreaCallback
    {
      [Token(Token = "0x60085DF"), Address(RVA = "0x406DED0", Offset = "0x406DED0", VA = "0x406DED0")] get
      {
        return (FreeMapStateManager.OnChangeAreaByTransitionArea) null;
      }
      [Token(Token = "0x60085E0"), Address(RVA = "0x406DED8", Offset = "0x406DED8", VA = "0x406DED8")] set
      {
      }
    }

    [Token(Token = "0x60085E1")]
    [Address(RVA = "0x406DEE0", Offset = "0x406DEE0", VA = "0x406DEE0")]
    public void ChangeAreaByTransitionArea(string objectName)
    {
    }

    [Token(Token = "0x60085E2")]
    [Address(RVA = "0x406DEFC", Offset = "0x406DEFC", VA = "0x406DEFC")]
    public void FreeMapUIShow()
    {
    }

    [Token(Token = "0x60085E3")]
    [Address(RVA = "0x406BEA8", Offset = "0x406BEA8", VA = "0x406BEA8")]
    public void FreeMapUIRefreshActionPlaying()
    {
    }

    [Token(Token = "0x60085E4")]
    [Address(RVA = "0x406DF1C", Offset = "0x406DF1C", VA = "0x406DF1C")]
    public void FreeMapUIHide()
    {
    }

    [Token(Token = "0x60085E5")]
    [Address(RVA = "0x406DF3C", Offset = "0x406DF3C", VA = "0x406DF3C")]
    public void FreeMapHeaderUIInteractEnable()
    {
    }

    [Token(Token = "0x60085E6")]
    [Address(RVA = "0x406DF5C", Offset = "0x406DF5C", VA = "0x406DF5C")]
    public void FreeMapHeaderUIInteractDisable()
    {
    }

    [Token(Token = "0x60085E7")]
    [Address(RVA = "0x406DF80", Offset = "0x406DF80", VA = "0x406DF80")]
    public void FreeMapTrackerUIInteractEnable()
    {
    }

    [Token(Token = "0x60085E8")]
    [Address(RVA = "0x406DFA4", Offset = "0x406DFA4", VA = "0x406DFA4")]
    public void FreeMapTrackerUIInteractDisable()
    {
    }

    [Token(Token = "0x60085E9")]
    [Address(RVA = "0x406DFC8", Offset = "0x406DFC8", VA = "0x406DFC8")]
    public void FreeMapActionIconUIInvisible()
    {
    }

    [Token(Token = "0x2001793")]
    public delegate Coroutine DelegateStartCoroutine(IEnumerator enumerator);

    [Token(Token = "0x2001794")]
    public delegate void OnChangeAreaByTransitionArea(string objectName);
  }
}
