// Decompiled with JetBrains decompiler
// Type: UI.Direction.UITimelineController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace UI.Direction
{
  [Token(Token = "0x20008F3")]
  [DisallowMultipleComponent]
  public class UITimelineController : MonoBehaviour
  {
    [Token(Token = "0x40029D7")]
    public const string MarkerTrackDataName = "Markers";
    [Token(Token = "0x40029D8")]
    public const string NonBindingTrackSuffixKeyword = "TrackName:";
    [Token(Token = "0x40029D9")]
    public const string RootPlayableDirectorNamePrefixKeyword = "[RootPlayableDirector]";
    [Token(Token = "0x40029DA")]
    public const string EmptyTargetDataKeyword = "None";
    [Token(Token = "0x40029DB")]
    [FieldOffset(Offset = "0x18")]
    private UITimelineViewer debugViewer;
    [Token(Token = "0x40029DC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool autoInitialize;
    [Token(Token = "0x40029DD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITimelineSettingAsset timelineSetting;
    [Token(Token = "0x40029DE")]
    [FieldOffset(Offset = "0x30")]
    [Tooltip("非推奨です。\n「Timeline Setting」プロパティを使用してください。")]
    [ResourceType(typeof (UITimelineSettingAsset))]
    [SerializeField]
    private AssetBundleLoadData timelineSettingAssetBundleLoad;
    [Token(Token = "0x40029DF")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<string, UITimelineController.UITimelineControllerData> directorList;
    [Token(Token = "0x40029E0")]
    [FieldOffset(Offset = "0x40")]
    private UITimelineController.DirectionType directionStatus;
    [Token(Token = "0x40029E1")]
    [FieldOffset(Offset = "0x44")]
    private UITimelineController.InitializeProcess initializeProcess;
    [Token(Token = "0x40029E2")]
    [FieldOffset(Offset = "0x48")]
    private int directionMax;
    [Token(Token = "0x40029E3")]
    [FieldOffset(Offset = "0x4C")]
    private int directionEndCount;
    [Token(Token = "0x40029E4")]
    [FieldOffset(Offset = "0x50")]
    private int requestLoadAssetBundleCounter;
    [Token(Token = "0x40029E5")]
    [FieldOffset(Offset = "0x58")]
    private readonly Dictionary<string, bool> loadedAssetBundles;
    [Token(Token = "0x40029E6")]
    [FieldOffset(Offset = "0x60")]
    private readonly Dictionary<string, UITimelineBindingAsset> loadedBindingSettings;
    [Token(Token = "0x40029E7")]
    [FieldOffset(Offset = "0x68")]
    private readonly Dictionary<(PlayableDirector director, string path), GameObject> bindingObjects;
    [Token(Token = "0x40029E8")]
    [FieldOffset(Offset = "0x70")]
    private readonly Dictionary<string, TimelineAsset> loadedTimelines;
    [Token(Token = "0x40029E9")]
    [FieldOffset(Offset = "0x78")]
    private readonly Dictionary<string, RuntimeAnimatorController> loadedAnimators;
    [Token(Token = "0x40029EA")]
    [FieldOffset(Offset = "0x80")]
    private readonly Dictionary<string, AnimationClip> loadedAnimations;
    [Token(Token = "0x40029EB")]
    [FieldOffset(Offset = "0x88")]
    private Action<PlayableDirector> stopDirectorEvent;
    [Token(Token = "0x40029EC")]
    [FieldOffset(Offset = "0x90")]
    private UITimelineController.DirectionType playedDirectionType;
    [Token(Token = "0x40029EE")]
    [FieldOffset(Offset = "0xA0")]
    private Dictionary<string, Action> playFinishCallbacks;
    [Token(Token = "0x40029EF")]
    [FieldOffset(Offset = "0xA8")]
    private Action<PlayableDirector> backUpStoppedCallback;
    [Token(Token = "0x40029F0")]
    [FieldOffset(Offset = "0xB0")]
    private Dictionary<string, UITimelineController.UITimelineControllerData> playingDirections;
    [Token(Token = "0x40029F1")]
    [FieldOffset(Offset = "0xB8")]
    private Dictionary<string, float> playingDirectionPlayRatios;
    [Token(Token = "0x40029F2")]
    [FieldOffset(Offset = "0xC0")]
    private List<UITimelineController.UITimelineControllerData> holdedDirectors;

    [Token(Token = "0x1700074C")]
    public UITimelineSettingAsset TimelineSetting
    {
      [Token(Token = "0x600327F"), Address(RVA = "0x3C23040", Offset = "0x3C23040", VA = "0x3C23040")] set
      {
      }
    }

    [Token(Token = "0x1700074D")]
    public bool IsCheckSettingTimelineAsset
    {
      [Token(Token = "0x6003280"), Address(RVA = "0x3C23048", Offset = "0x3C23048", VA = "0x3C23048")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700074E")]
    public Dictionary<string, UITimelineController.UITimelineControllerData> DirectorList
    {
      [Token(Token = "0x6003281"), Address(RVA = "0x3C230A8", Offset = "0x3C230A8", VA = "0x3C230A8")] get
      {
        return (Dictionary<string, UITimelineController.UITimelineControllerData>) null;
      }
    }

    [Token(Token = "0x1700074F")]
    public UITimelineController.DirectionType PlayedDirectionType
    {
      [Token(Token = "0x6003282"), Address(RVA = "0x3C230B0", Offset = "0x3C230B0", VA = "0x3C230B0")] get
      {
        return new UITimelineController.DirectionType();
      }
    }

    [Token(Token = "0x17000750")]
    public bool IsDirection
    {
      [Token(Token = "0x6003283"), Address(RVA = "0x3C1CFF4", Offset = "0x3C1CFF4", VA = "0x3C1CFF4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000751")]
    private bool IsInitializeStarted
    {
      [Token(Token = "0x6003284"), Address(RVA = "0x3C230B8", Offset = "0x3C230B8", VA = "0x3C230B8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000752")]
    public bool IsInitializing
    {
      [Token(Token = "0x6003285"), Address(RVA = "0x3C230C8", Offset = "0x3C230C8", VA = "0x3C230C8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000753")]
    public bool IsInitialized
    {
      [Token(Token = "0x6003286"), Address(RVA = "0x3C1D004", Offset = "0x3C1D004", VA = "0x3C1D004")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000754")]
    public Action FinishedCallback
    {
      [Token(Token = "0x6003287"), Address(RVA = "0x3C230D8", Offset = "0x3C230D8", VA = "0x3C230D8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6003288"), Address(RVA = "0x3C230E0", Offset = "0x3C230E0", VA = "0x3C230E0")] set
      {
      }
    }

    [Token(Token = "0x6003289")]
    [Address(RVA = "0x3C230E8", Offset = "0x3C230E8", VA = "0x3C230E8")]
    private void InvokeFinishedCallback()
    {
    }

    [Token(Token = "0x600328A")]
    [Address(RVA = "0x3C23114", Offset = "0x3C23114", VA = "0x3C23114")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600328B")]
    [Address(RVA = "0x3C18D04", Offset = "0x3C18D04", VA = "0x3C18D04")]
    public IEnumerator Initialize(Action callback = null) => (IEnumerator) null;

    [Token(Token = "0x600328C")]
    [Address(RVA = "0x3C2317C", Offset = "0x3C2317C", VA = "0x3C2317C")]
    public void InitializeBySynchronous()
    {
    }

    [Token(Token = "0x600328D")]
    [Address(RVA = "0x3C234E4", Offset = "0x3C234E4", VA = "0x3C234E4")]
    public void Release()
    {
    }

    [Token(Token = "0x600328E")]
    [Address(RVA = "0x3C23770", Offset = "0x3C23770", VA = "0x3C23770")]
    public void PlayTimelineDirection(UITimelineController.DirectionType type, Action callback = null)
    {
    }

    [Token(Token = "0x600328F")]
    [Address(RVA = "0x3C237D4", Offset = "0x3C237D4", VA = "0x3C237D4")]
    public void PlayTimelineDirection(
      UITimelineController.DirectionType type,
      string keyword,
      Action callback = null,
      float playRatio = 1f)
    {
    }

    [Token(Token = "0x6003290")]
    [Address(RVA = "0x3C23E84", Offset = "0x3C23E84", VA = "0x3C23E84")]
    public void StopPlayback(string key = "")
    {
    }

    [Token(Token = "0x6003291")]
    [Address(RVA = "0x3C2429C", Offset = "0x3C2429C", VA = "0x3C2429C")]
    public void SkipLastFrame(string key = "")
    {
    }

    [Token(Token = "0x6003292")]
    [Address(RVA = "0x3C244DC", Offset = "0x3C244DC", VA = "0x3C244DC")]
    private static bool IsSetResourcesLoadString(ResourceLoadData data) => new bool();

    [Token(Token = "0x6003293")]
    [Address(RVA = "0x3C24520", Offset = "0x3C24520", VA = "0x3C24520")]
    private static bool IsSetAssetBundleLoadString(AssetBundleLoadData data) => new bool();

    [Token(Token = "0x6003294")]
    [Address(RVA = "0x3C23180", Offset = "0x3C23180", VA = "0x3C23180")]
    private void InitializeInternal()
    {
    }

    [Token(Token = "0x6003295")]
    [Address(RVA = "0x3C267D0", Offset = "0x3C267D0", VA = "0x3C267D0")]
    private IEnumerator InitializeInternalWithLoadAssetBundle(bool autoInitialize, Action callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003296")]
    [Address(RVA = "0x3C250CC", Offset = "0x3C250CC", VA = "0x3C250CC")]
    private void LoadResourcesByBindingAssetAndTimelineAsset()
    {
    }

    [Token(Token = "0x6003297")]
    [Address(RVA = "0x3C24564", Offset = "0x3C24564", VA = "0x3C24564")]
    private void LoadAssetByBindingAssetAndTimelineAsset()
    {
    }

    [Token(Token = "0x6003298")]
    [Address(RVA = "0x3C26854", Offset = "0x3C26854", VA = "0x3C26854")]
    private void LoadRequestAssetBundleByBindingIntoAnimationComponentAsset()
    {
    }

    [Token(Token = "0x6003299")]
    [Address(RVA = "0x3C24878", Offset = "0x3C24878", VA = "0x3C24878")]
    private void LoadAssetByBindingIntoAnimationComponentAsset()
    {
    }

    [Token(Token = "0x600329A")]
    [Address(RVA = "0x3C236B4", Offset = "0x3C236B4", VA = "0x3C236B4")]
    private void ResetData()
    {
    }

    [Token(Token = "0x600329B")]
    private static T GetAsset<T>(AssetBundleLoadData assetBundleLoadData) where T : UnityEngine.Object
    {
      return (T) null;
    }

    [Token(Token = "0x600329C")]
    private static T GetAsset<T>(ResourceLoadData resourceLoadData) where T : UnityEngine.Object
    {
      return (T) null;
    }

    [Token(Token = "0x600329D")]
    [Address(RVA = "0x3C27000", Offset = "0x3C27000", VA = "0x3C27000")]
    private void RequestLoadAssetBundle(string label)
    {
    }

    [Token(Token = "0x600329E")]
    [Address(RVA = "0x3C271A8", Offset = "0x3C271A8", VA = "0x3C271A8")]
    private IEnumerator LoadAssetBundle(Action<bool> successAction) => (IEnumerator) null;

    [Token(Token = "0x600329F")]
    [Address(RVA = "0x3C2721C", Offset = "0x3C2721C", VA = "0x3C2721C")]
    private static void UnloadAssetBundle(string label, bool canUnloadAssetBundle)
    {
    }

    [Token(Token = "0x60032A0")]
    [Address(RVA = "0x3C25F8C", Offset = "0x3C25F8C", VA = "0x3C25F8C")]
    private void SetPlayableDirectorEvent()
    {
    }

    [Token(Token = "0x60032A1")]
    [Address(RVA = "0x3C23ADC", Offset = "0x3C23ADC", VA = "0x3C23ADC")]
    private void StopPlayableDirectorDuringPlayback(PlayableDirector targetPlayableDirector)
    {
    }

    [Token(Token = "0x60032A2")]
    [Address(RVA = "0x3C23DB0", Offset = "0x3C23DB0", VA = "0x3C23DB0")]
    private void AddPlayFinishCallbacks(string key, Action callback)
    {
    }

    [Token(Token = "0x60032A3")]
    [Address(RVA = "0x3C23CDC", Offset = "0x3C23CDC", VA = "0x3C23CDC")]
    private bool PlayTimelineDirectionInternal(
      UITimelineController.DirectionType type,
      UITimelineController.UITimelineControllerData uiTimelineControllerData)
    {
      return new bool();
    }

    [Token(Token = "0x60032A4")]
    [Address(RVA = "0x3C272BC", Offset = "0x3C272BC", VA = "0x3C272BC")]
    private void SetBindingSettings(
      TimelineAsset asset,
      UITimelineController.UITimelineControllerData uiTimelineControllerData)
    {
    }

    [Token(Token = "0x60032A5")]
    [Address(RVA = "0x3C253E0", Offset = "0x3C253E0", VA = "0x3C253E0")]
    private void SearchPlayableDirector()
    {
    }

    [Token(Token = "0x60032A6")]
    [Address(RVA = "0x3C28760", Offset = "0x3C28760", VA = "0x3C28760")]
    private List<PlayableDirector> SearchMultiPlayableDirector(PlayableDirector[] playableDirectors)
    {
      return (List<PlayableDirector>) null;
    }

    [Token(Token = "0x60032A7")]
    [Address(RVA = "0x3C2968C", Offset = "0x3C2968C", VA = "0x3C2968C")]
    private static string GetTransformPath(Transform transform, Transform root = null)
    {
      return (string) null;
    }

    [Token(Token = "0x60032A8")]
    [Address(RVA = "0x3C23514", Offset = "0x3C23514", VA = "0x3C23514")]
    public void ClearDirectorList()
    {
    }

    [Token(Token = "0x60032A9")]
    [Address(RVA = "0x3C297FC", Offset = "0x3C297FC", VA = "0x3C297FC")]
    public void ClearDirectorMaxCounter()
    {
    }

    [Token(Token = "0x60032AA")]
    [Address(RVA = "0x3C29800", Offset = "0x3C29800", VA = "0x3C29800")]
    public void AddDirectorList(string keyword, PlayableDirector director, TimelineAsset timeline)
    {
    }

    [Token(Token = "0x60032AB")]
    [Address(RVA = "0x3C298D8", Offset = "0x3C298D8", VA = "0x3C298D8")]
    public void SetBind(string targetTrackName, UnityEngine.Object bindObject)
    {
    }

    [Token(Token = "0x60032AC")]
    [Address(RVA = "0x3C29F90", Offset = "0x3C29F90", VA = "0x3C29F90")]
    public void SetBind(string targetRootTrackName, string targetTrackName, UnityEngine.Object bindObject)
    {
    }

    [Token(Token = "0x60032AD")]
    [Address(RVA = "0x3C2A110", Offset = "0x3C2A110", VA = "0x3C2A110")]
    public void SetBindByNonRootTrack(string targetTrackName, UnityEngine.Object bindObject)
    {
    }

    [Token(Token = "0x60032AE")]
    [Address(RVA = "0x3C2A288", Offset = "0x3C2A288", VA = "0x3C2A288")]
    public void SetRootTrackMuted(string rootTrackName, bool isMuted)
    {
    }

    [Token(Token = "0x60032AF")]
    [Address(RVA = "0x3C2A498", Offset = "0x3C2A498", VA = "0x3C2A498")]
    public void SetSubTrackMuted(string rootTrackName, string subTrackName, bool isMuted)
    {
    }

    [Token(Token = "0x60032B0")]
    [Address(RVA = "0x3C2A6B8", Offset = "0x3C2A6B8", VA = "0x3C2A6B8")]
    public void UpdateNonPlayAsset(UITimelineController.DirectionType directionType, string keyword = "")
    {
    }

    [Token(Token = "0x60032B1")]
    [Address(RVA = "0x3C2A858", Offset = "0x3C2A858", VA = "0x3C2A858")]
    public bool HasPlayAsset(string keyword = "") => new bool();

    [Token(Token = "0x60032B2")]
    [Address(RVA = "0x3C2621C", Offset = "0x3C2621C", VA = "0x3C2621C")]
    private void SearchBindingObjects()
    {
    }

    [Token(Token = "0x60032B3")]
    [Address(RVA = "0x3C2A8C8", Offset = "0x3C2A8C8", VA = "0x3C2A8C8")]
    private void AddObjectGetter(PlayableDirector playableDirector, string path, GameObject obj)
    {
    }

    [Token(Token = "0x60032B4")]
    [Address(RVA = "0x3C2A9C8", Offset = "0x3C2A9C8", VA = "0x3C2A9C8")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x60032B5")]
    [Address(RVA = "0x3C2B190", Offset = "0x3C2B190", VA = "0x3C2B190")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60032B6")]
    [Address(RVA = "0x3C2AFE0", Offset = "0x3C2AFE0", VA = "0x3C2AFE0")]
    private void HoldedDirector(string keyword)
    {
    }

    [Token(Token = "0x60032B7")]
    [Address(RVA = "0x3C2B2F4", Offset = "0x3C2B2F4", VA = "0x3C2B2F4")]
    [Conditional("UNITY_EDITOR")]
    private void Log(string log)
    {
    }

    [Token(Token = "0x60032B8")]
    [Address(RVA = "0x3C2B2F8", Offset = "0x3C2B2F8", VA = "0x3C2B2F8")]
    [Conditional("UNITY_EDITOR")]
    private void LogWarning(string log)
    {
    }

    [Token(Token = "0x60032B9")]
    [Address(RVA = "0x3C2B2FC", Offset = "0x3C2B2FC", VA = "0x3C2B2FC")]
    [Conditional("UNITY_EDITOR")]
    private void LogError(string log)
    {
    }

    [Token(Token = "0x60032BA")]
    [Address(RVA = "0x3C2B300", Offset = "0x3C2B300", VA = "0x3C2B300")]
    public UITimelineController()
    {
    }

    [Token(Token = "0x20008F4")]
    [Serializable]
    public class UITimelineControllerData
    {
      [Token(Token = "0x40029F3")]
      [FieldOffset(Offset = "0x10")]
      public string Keyword;
      [Token(Token = "0x40029F4")]
      [FieldOffset(Offset = "0x18")]
      public UITimelineController.DirectionType Type;
      [Token(Token = "0x40029F5")]
      [FieldOffset(Offset = "0x1C")]
      public bool completedBinds;
      [Token(Token = "0x40029F6")]
      [FieldOffset(Offset = "0x20")]
      public PlayableDirector Director;
      [Token(Token = "0x40029F7")]
      [FieldOffset(Offset = "0x28")]
      public TimelineAsset Timeline;
      [Token(Token = "0x40029F8")]
      [FieldOffset(Offset = "0x30")]
      public DirectorWrapMode WrapMode;
      [Token(Token = "0x40029F9")]
      [FieldOffset(Offset = "0x38")]
      public UITimelineSettingParameter SettingParameter;

      [Token(Token = "0x60032BE")]
      [Address(RVA = "0x36223C8", Offset = "0x36223C8", VA = "0x36223C8")]
      public UITimelineControllerData()
      {
      }
    }

    [Token(Token = "0x20008F5")]
    public enum DirectionType
    {
      [Token(Token = "0x40029FB")] None = -1, // 0xFFFFFFFF
      [Token(Token = "0x40029FC")] In = 0,
      [Token(Token = "0x40029FD")] Out = 1,
      [Token(Token = "0x40029FE")] General = 2,
      [Token(Token = "0x40029FF")] Max = 3,
    }

    [Token(Token = "0x20008F6")]
    private enum InitializeProcess
    {
      [Token(Token = "0x4002A01")] InComplete,
      [Token(Token = "0x4002A02")] Execution,
      [Token(Token = "0x4002A03")] Completed,
    }
  }
}
