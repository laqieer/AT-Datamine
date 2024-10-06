// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.SceneHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000C5F")]
  public class SceneHandler : SingletonMonoBehaviour<SceneHandler>
  {
    [Token(Token = "0x40037D7")]
    [FieldOffset(Offset = "0x0")]
    public static int RenderFrameIntervalOnLoading;
    [Token(Token = "0x40037D8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string bootSceneName;
    [Token(Token = "0x40037D9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string bootSceneAssetBundleName;
    [Token(Token = "0x40037DA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string bootSubSceneAssetBundleName;
    [Token(Token = "0x40037DB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string bootSubSceneName;
    [Token(Token = "0x40037DC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Camera transitionCamera;
    [Token(Token = "0x40037DD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Canvas transitionCanvas;
    [Token(Token = "0x40037DE")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<string, TransitionEffectBase> transitionObjectDic;
    [Token(Token = "0x40037DF")]
    [FieldOffset(Offset = "0x58")]
    private TransitionEffectBase activeTransitionObject;
    [Token(Token = "0x40037E0")]
    [FieldOffset(Offset = "0x60")]
    private List<SubScene> subSceneList;
    [Token(Token = "0x40037E1")]
    [FieldOffset(Offset = "0x68")]
    private List<WeakReference<ProcessingFlag>> processingSceneFlags;
    [Token(Token = "0x40037E2")]
    [FieldOffset(Offset = "0x70")]
    private List<WeakReference<ProcessingFlag>> processingSubSceneFlags;
    [Token(Token = "0x40037E3")]
    [FieldOffset(Offset = "0x78")]
    private SceneHandler.ProcessingSceneFlag processingScene;
    [Token(Token = "0x40037E4")]
    [FieldOffset(Offset = "0x80")]
    private GameObject subSceneAttachObject;
    [Token(Token = "0x40037E5")]
    [FieldOffset(Offset = "0x88")]
    private bool subSceneLoadComplete;
    [Token(Token = "0x40037E6")]
    [FieldOffset(Offset = "0x8C")]
    private int currentSortOrder;
    [Token(Token = "0x40037E7")]
    [FieldOffset(Offset = "0x90")]
    private bool isProcessingBackSubScene;
    [Token(Token = "0x40037EE")]
    [FieldOffset(Offset = "0xC0")]
    public LoadingPanelController currentLoadingPanelController;
    [Token(Token = "0x40037EF")]
    [FieldOffset(Offset = "0xC8")]
    private bool isLoadingPanelsInitialized;
    [Token(Token = "0x40037F0")]
    private const string LOADING_PANEL_ROOT = "Prefabs/LoadingPanel";
    [Token(Token = "0x40037F1")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private List<string> staticLoadingPanelNames;
    [Token(Token = "0x40037F2")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private string dynamicLoadingPanelAssetbundleName;
    [Token(Token = "0x40037F3")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private List<string> dynamicLoadingPanelNames;
    [Token(Token = "0x40037F4")]
    [FieldOffset(Offset = "0xE8")]
    private List<LoadingPanelController> loadingPanelControllers;

    [Token(Token = "0x17000A47")]
    private bool IsRequestClearSubSceneAll
    {
      [Token(Token = "0x600472C"), Address(RVA = "0x351E08C", Offset = "0x351E08C", VA = "0x351E08C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600472D"), Address(RVA = "0x351E094", Offset = "0x351E094", VA = "0x351E094")] set
      {
      }
    }

    [Token(Token = "0x17000A48")]
    public GameCore.Scene.Scene CurrentScene
    {
      [Token(Token = "0x600472E"), Address(RVA = "0x351E0A0", Offset = "0x351E0A0", VA = "0x351E0A0")] get
      {
        return (GameCore.Scene.Scene) null;
      }
      [Token(Token = "0x600472F"), Address(RVA = "0x351E0A8", Offset = "0x351E0A8", VA = "0x351E0A8")] private set
      {
      }
    }

    [Token(Token = "0x17000A49")]
    public int SubSceneCount
    {
      [Token(Token = "0x6004730"), Address(RVA = "0x351DE18", Offset = "0x351DE18", VA = "0x351DE18")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000A4A")]
    public bool IsProcessing
    {
      [Token(Token = "0x6004731"), Address(RVA = "0x351E0B0", Offset = "0x351E0B0", VA = "0x351E0B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A4B")]
    public bool IsProcessingScene
    {
      [Token(Token = "0x6004732"), Address(RVA = "0x351E0E8", Offset = "0x351E0E8", VA = "0x351E0E8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A4C")]
    public bool IsProcessingSubScene
    {
      [Token(Token = "0x6004733"), Address(RVA = "0x351DC1C", Offset = "0x351DC1C", VA = "0x351DC1C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A4D")]
    public int CurrentSortOrder
    {
      [Token(Token = "0x6004734"), Address(RVA = "0x351E138", Offset = "0x351E138", VA = "0x351E138")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000A4E")]
    public Action<System.Type> ChangeMainScene
    {
      [Token(Token = "0x6004735"), Address(RVA = "0x351E140", Offset = "0x351E140", VA = "0x351E140")] get
      {
        return (Action<System.Type>) null;
      }
      [Token(Token = "0x6004736"), Address(RVA = "0x351E148", Offset = "0x351E148", VA = "0x351E148")] set
      {
      }
    }

    [Token(Token = "0x17000A4F")]
    public Action<string> ChangeSubSceneAction
    {
      [Token(Token = "0x6004737"), Address(RVA = "0x351E150", Offset = "0x351E150", VA = "0x351E150")] get
      {
        return (Action<string>) null;
      }
      [Token(Token = "0x6004738"), Address(RVA = "0x351E158", Offset = "0x351E158", VA = "0x351E158")] set
      {
      }
    }

    [Token(Token = "0x17000A50")]
    public int SortOrderByTransitionCanvas
    {
      [Token(Token = "0x6004739"), Address(RVA = "0x351E160", Offset = "0x351E160", VA = "0x351E160")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000A51")]
    public Action BackSceneAction
    {
      [Token(Token = "0x600473A"), Address(RVA = "0x351E17C", Offset = "0x351E17C", VA = "0x351E17C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x600473B"), Address(RVA = "0x351E184", Offset = "0x351E184", VA = "0x351E184")] set
      {
      }
    }

    [Token(Token = "0x17000A52")]
    public Action<System.Type> SetPrevSceneType
    {
      [Token(Token = "0x600473C"), Address(RVA = "0x351E18C", Offset = "0x351E18C", VA = "0x351E18C")] get
      {
        return (Action<System.Type>) null;
      }
      [Token(Token = "0x600473D"), Address(RVA = "0x351E194", Offset = "0x351E194", VA = "0x351E194")] set
      {
      }
    }

    [Token(Token = "0x600473E")]
    [Address(RVA = "0x351E19C", Offset = "0x351E19C", VA = "0x351E19C", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600473F")]
    [Address(RVA = "0x351E3A0", Offset = "0x351E3A0", VA = "0x351E3A0", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6004740")]
    [Address(RVA = "0x351E4AC", Offset = "0x351E4AC", VA = "0x351E4AC")]
    private void Update()
    {
    }

    [Token(Token = "0x6004741")]
    [Address(RVA = "0x351E4B0", Offset = "0x351E4B0", VA = "0x351E4B0")]
    private void OnApplicationQuit()
    {
    }

    [Token(Token = "0x6004742")]
    [Address(RVA = "0x351E554", Offset = "0x351E554", VA = "0x351E554")]
    private void OnApplicationPause(bool pause)
    {
    }

    [Token(Token = "0x6004743")]
    [Address(RVA = "0x351D6C8", Offset = "0x351D6C8", VA = "0x351D6C8")]
    public SubScene GetCurrentSubScene() => (SubScene) null;

    [Token(Token = "0x6004744")]
    public bool IsCurrentScene<T>() where T : SubScene => new bool();

    [Token(Token = "0x6004745")]
    public T GetSubScene<T>() where T : SubScene => (T) null;

    [Token(Token = "0x6004746")]
    [Address(RVA = "0x351E6BC", Offset = "0x351E6BC", VA = "0x351E6BC")]
    private IEnumerator TransitionOutEffect(ChangeSceneParameter param, Action completeAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004747")]
    [Address(RVA = "0x351E730", Offset = "0x351E730", VA = "0x351E730")]
    public void ClearTransitionObject()
    {
    }

    [Token(Token = "0x6004748")]
    private bool ContainsSubScene<T>() where T : SubScene => new bool();

    [Token(Token = "0x6004749")]
    [Address(RVA = "0x351E8CC", Offset = "0x351E8CC", VA = "0x351E8CC")]
    public void ClearSubScene(SubScene scene)
    {
    }

    [Token(Token = "0x600474A")]
    [Address(RVA = "0x351E9B0", Offset = "0x351E9B0", VA = "0x351E9B0")]
    public void ClearCurrentSubScene()
    {
    }

    [Token(Token = "0x600474B")]
    [Address(RVA = "0x351E9CC", Offset = "0x351E9CC", VA = "0x351E9CC")]
    public void ClearPreviousScene()
    {
    }

    [Token(Token = "0x600474C")]
    [Address(RVA = "0x351EA4C", Offset = "0x351EA4C", VA = "0x351EA4C")]
    public void ClearSubSceneAll()
    {
    }

    [Token(Token = "0x600474D")]
    [Address(RVA = "0x351EC58", Offset = "0x351EC58", VA = "0x351EC58")]
    public void BackSubScene(string SubSceneClassName, bool isLastScene = true, Action<SubScene> callback = null)
    {
    }

    [Token(Token = "0x600474E")]
    public void BackSubScene<T>(Action<SubScene> callback = null) where T : SubScene
    {
    }

    [Token(Token = "0x600474F")]
    [Address(RVA = "0x351DE60", Offset = "0x351DE60", VA = "0x351DE60")]
    public void BackSubScene(Action<SubScene> callback = null, Action<SubScene> onBeforeBackSceneCallBack = null)
    {
    }

    [Token(Token = "0x6004750")]
    [Address(RVA = "0x351F004", Offset = "0x351F004", VA = "0x351F004")]
    private IEnumerator WaitOnBackSceneAsync(IEnumerator onBackSceneAsync, Action endAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004751")]
    [Address(RVA = "0x351F078", Offset = "0x351F078", VA = "0x351F078")]
    public bool TryBackSubSceneOrChangeSimple(
      string assetBundleName,
      string name,
      ChangeSceneParameter param = null,
      bool isClearSubSceneListFailedBack = false)
    {
      return new bool();
    }

    [Token(Token = "0x6004752")]
    [Address(RVA = "0x351F108", Offset = "0x351F108", VA = "0x351F108")]
    public bool TryBackSubSceneOrAction(Action action) => new bool();

    [Token(Token = "0x6004753")]
    public bool TryBackSubSceneOrChangeSimple<T>(
      string assetBundleName,
      string name,
      ChangeSceneParameter param = null,
      bool isClearSubSceneListFailedBack = true)
      where T : SubScene
    {
      return new bool();
    }

    [Token(Token = "0x6004754")]
    private void BackSubSceneWithLoadingPanel<T>(SceneHandler.LoadingPanelType loadingPanelType) where T : SubScene
    {
    }

    [Token(Token = "0x6004755")]
    private void BackSubSceneTriangle<T>(bool isFast = false) where T : SubScene
    {
    }

    [Token(Token = "0x6004756")]
    public bool TryBackSubSceneOrChangeTriangle<T>(
      string assetBundleName,
      string name,
      ChangeSceneParameter param = null,
      bool isFast = false,
      bool isClearSubSceneListFailedBack = true)
      where T : SubScene
    {
      return new bool();
    }

    [Token(Token = "0x6004757")]
    [Address(RVA = "0x351F160", Offset = "0x351F160", VA = "0x351F160")]
    [Obsolete("LoadingPanelTypeを指定しないメソッドを使ってほしいです")]
    public void ChangeSubScene(
      string assetBundleName,
      string name,
      SceneHandler.LoadingPanelType loadingPanelType,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6004758")]
    [Address(RVA = "0x351F0F8", Offset = "0x351F0F8", VA = "0x351F0F8")]
    public void ChangeSubSceneSimple(
      string assetBundleName,
      string name,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6004759")]
    [Address(RVA = "0x351F2AC", Offset = "0x351F2AC", VA = "0x351F2AC")]
    public void ChangeSubSceneTraiangleTransition(
      string assetBundleName,
      string name,
      ChangeSceneParameter param = null,
      bool isFast = false)
    {
    }

    [Token(Token = "0x600475A")]
    [Address(RVA = "0x351F358", Offset = "0x351F358", VA = "0x351F358")]
    public void ChangeSubSceneComplex(
      string assetBundleName,
      string name,
      SceneHandler.LoadingTips loadingTips,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x600475B")]
    [Address(RVA = "0x351F170", Offset = "0x351F170", VA = "0x351F170")]
    private void ChangeSubScene(
      string assetBundleName,
      string name,
      SceneHandler.LoadingTips? loadingTips,
      SceneHandler.LoadingPanelType loadingPanelType,
      ChangeSceneParameter param)
    {
    }

    [Token(Token = "0x600475C")]
    [Address(RVA = "0x351F788", Offset = "0x351F788", VA = "0x351F788")]
    private TransitionEffectBase GetTransitionEffectCacheWithLoad(string effectName)
    {
      return (TransitionEffectBase) null;
    }

    [Token(Token = "0x600475D")]
    [Address(RVA = "0x351F98C", Offset = "0x351F98C", VA = "0x351F98C")]
    private IEnumerator AddSubScene(
      string assetBundleName,
      string name,
      ChangeSceneParameter param)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600475E")]
    [Address(RVA = "0x351FA3C", Offset = "0x351FA3C", VA = "0x351FA3C")]
    [Obsolete("非推奨")]
    public void ChangeSubSceneMulti(
      List<SceneHandler.SubSceneTransitionData> transitionData)
    {
    }

    [Token(Token = "0x600475F")]
    [Address(RVA = "0x351FA48", Offset = "0x351FA48", VA = "0x351FA48")]
    [Obsolete("非推奨")]
    public void ChangeSubSceneMulti(
      List<SceneHandler.SubSceneTransitionData> transitionData,
      SceneHandler.LoadingTips loadingTips)
    {
    }

    [Token(Token = "0x6004760")]
    [Address(RVA = "0x351F3FC", Offset = "0x351F3FC", VA = "0x351F3FC")]
    private void ChangeSubSceneMulti(
      List<SceneHandler.SubSceneTransitionData> transitionData,
      SceneHandler.LoadingTips? loadingTips,
      SceneHandler.LoadingPanelType loadingPanelType)
    {
    }

    [Token(Token = "0x6004761")]
    [Address(RVA = "0x351FAD0", Offset = "0x351FAD0", VA = "0x351FAD0")]
    private IEnumerator ShowLoadingPanelAndAddSubSceneMulti(
      List<SceneHandler.SubSceneTransitionData> transitionData,
      SceneHandler.LoadingTips? loadingTips,
      SceneHandler.LoadingPanelType loadingPanelType)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004762")]
    [Address(RVA = "0x351FB5C", Offset = "0x351FB5C", VA = "0x351FB5C")]
    private IEnumerator AddSubSceneMulti(
      List<SceneHandler.SubSceneTransitionData> transitionData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004763")]
    [Address(RVA = "0x351FBF8", Offset = "0x351FBF8", VA = "0x351FBF8")]
    public void BootSceneSetting()
    {
    }

    [Token(Token = "0x6004764")]
    [Address(RVA = "0x351FCBC", Offset = "0x351FCBC", VA = "0x351FCBC")]
    public void ReturnToTitleScene()
    {
    }

    [Token(Token = "0x6004765")]
    [Address(RVA = "0x351FDB4", Offset = "0x351FDB4", VA = "0x351FDB4")]
    public void JumpToHomeSceneFromEnding()
    {
    }

    [Token(Token = "0x6004766")]
    [Address(RVA = "0x3520118", Offset = "0x3520118", VA = "0x3520118")]
    [Obsolete("LoadingPanelTypeを指定しないメソッドを使ってほしいです")]
    public void ChangeSceneAsync(
      string name,
      string subSceneAssetBundleName,
      string subSceneName,
      SceneHandler.LoadingPanelType loadingPanelType,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6004767")]
    [Address(RVA = "0x351FC94", Offset = "0x351FC94", VA = "0x351FC94")]
    public void ChangeSceneAsyncSimple(
      string name,
      string subSceneAssetBundleName,
      string subSceneName,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6004768")]
    [Address(RVA = "0x352013C", Offset = "0x352013C", VA = "0x352013C")]
    public void ChangeSceneAsyncSimple(
      string name,
      string subSceneAssetBundleName,
      string subSceneName,
      bool isContinueSound,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6004769")]
    [Address(RVA = "0x3520164", Offset = "0x3520164", VA = "0x3520164")]
    public void ChangeSceneAsyncComplex(
      string name,
      string subSceneAssetBundleName,
      string subSceneName,
      SceneHandler.LoadingTips loadingTips,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x600476A")]
    [Address(RVA = "0x3520210", Offset = "0x3520210", VA = "0x3520210")]
    public void ChangeSceneAsyncComplex(
      string name,
      string subSceneAssetBundleName,
      string subSceneName,
      SceneHandler.LoadingTips loadingTips,
      bool isContinueSound,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x600476B")]
    [Address(RVA = "0x35202C0", Offset = "0x35202C0", VA = "0x35202C0")]
    public void ChangeSceneAsyncTriangle(
      string name,
      string subSceneAssetBundleName,
      string subSceneName,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x600476C")]
    [Address(RVA = "0x35202E8", Offset = "0x35202E8", VA = "0x35202E8")]
    public void ChangeSceneAsyncTriangle(
      string name,
      string subSceneAssetBundleName,
      string subSceneName,
      bool isContinueSound,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x600476D")]
    [Address(RVA = "0x351FE60", Offset = "0x351FE60", VA = "0x351FE60")]
    private void ChangeSceneAsync(
      string name,
      string subSceneAssetBundleName,
      string subSceneName,
      SceneHandler.LoadingPanelType loadingPanelType,
      SceneHandler.LoadingTips? loadingTips,
      bool isContinueSound,
      ChangeSceneParameter param)
    {
    }

    [Token(Token = "0x600476E")]
    [Address(RVA = "0x351E1F0", Offset = "0x351E1F0", VA = "0x351E1F0")]
    private GameCore.Scene.Scene GetCurrentScene() => (GameCore.Scene.Scene) null;

    [Token(Token = "0x600476F")]
    [Address(RVA = "0x3520324", Offset = "0x3520324", VA = "0x3520324")]
    private IEnumerator ChangeSceneAsyncLocal(
      string name,
      string assetBundlename,
      string subSceneName,
      SceneHandler.LoadingPanelType loadingPanelType,
      SceneHandler.LoadingTips? loadingTips,
      ChangeSceneParameter param,
      bool isContinueSound)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004770")]
    [Address(RVA = "0x3520404", Offset = "0x3520404", VA = "0x3520404")]
    public bool IsShowLoadingPanel() => new bool();

    [Token(Token = "0x6004771")]
    [Address(RVA = "0x3520464", Offset = "0x3520464", VA = "0x3520464")]
    public string GetShowingLoadingPanelName() => (string) null;

    [Token(Token = "0x6004772")]
    public bool GetLoadingPanelController<T>(SceneHandler.LoadingPanelType type, out T controller) where T : LoadingPanelController
    {
      return new bool();
    }

    [Token(Token = "0x6004773")]
    [Address(RVA = "0x3520514", Offset = "0x3520514", VA = "0x3520514")]
    private IEnumerator ShowComplexLoadingPanel(
      VisibleProgressLoadingPanelController.TipsCategory tipsCategory,
      bool isEnabledVideo,
      bool isEnableBG = true)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004774")]
    [Address(RVA = "0x35205AC", Offset = "0x35205AC", VA = "0x35205AC")]
    public void SetupTipsFont()
    {
    }

    [Token(Token = "0x6004775")]
    [Address(RVA = "0x35206B8", Offset = "0x35206B8", VA = "0x35206B8")]
    public IEnumerator ShowComplexNoneSimpleLoadingPanel() => (IEnumerator) null;

    [Token(Token = "0x6004776")]
    [Address(RVA = "0x3520720", Offset = "0x3520720", VA = "0x3520720")]
    public IEnumerator ShowComplexNoneLoadingPanel() => (IEnumerator) null;

    [Token(Token = "0x6004777")]
    [Address(RVA = "0x3520788", Offset = "0x3520788", VA = "0x3520788")]
    public IEnumerator ShowComplexStoryLoadingPanel() => (IEnumerator) null;

    [Token(Token = "0x6004778")]
    [Address(RVA = "0x35207F0", Offset = "0x35207F0", VA = "0x35207F0")]
    public IEnumerator ShowComplexBattleLoadingPanel() => (IEnumerator) null;

    [Token(Token = "0x6004779")]
    [Address(RVA = "0x3520858", Offset = "0x3520858", VA = "0x3520858")]
    public IEnumerator ShowComplexOtherLoadingPanel() => (IEnumerator) null;

    [Token(Token = "0x600477A")]
    [Address(RVA = "0x35208C0", Offset = "0x35208C0", VA = "0x35208C0")]
    public IEnumerator ShowVideoLoadingPanel() => (IEnumerator) null;

    [Token(Token = "0x600477B")]
    [Address(RVA = "0x3520928", Offset = "0x3520928", VA = "0x3520928")]
    public IEnumerator ShowLoadingPanel(SceneHandler.LoadingPanelType type) => (IEnumerator) null;

    [Token(Token = "0x600477C")]
    [Address(RVA = "0x35209A0", Offset = "0x35209A0", VA = "0x35209A0")]
    private IEnumerator ShowLoadingPanel(
      SceneHandler.LoadingTips? loadingTips,
      SceneHandler.LoadingPanelType loadingPanelType)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600477D")]
    [Address(RVA = "0x3520A1C", Offset = "0x3520A1C", VA = "0x3520A1C")]
    public IEnumerator HideLoadingPanel() => (IEnumerator) null;

    [Token(Token = "0x600477E")]
    [Address(RVA = "0x3520A84", Offset = "0x3520A84", VA = "0x3520A84")]
    public IEnumerator HideLoadingPanel(SceneHandler.LoadingPanelType loadingPanelType)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600477F")]
    [Address(RVA = "0x3520AFC", Offset = "0x3520AFC", VA = "0x3520AFC")]
    public IEnumerator InitializeLoadingPanelsResources() => (IEnumerator) null;

    [Token(Token = "0x6004780")]
    [Address(RVA = "0x3520B64", Offset = "0x3520B64", VA = "0x3520B64")]
    private void InitLoadingPanelControllerComplex()
    {
    }

    [Token(Token = "0x6004781")]
    [Address(RVA = "0x3520C58", Offset = "0x3520C58", VA = "0x3520C58")]
    public IEnumerator InitializeLoadingPanelsAssetbundle() => (IEnumerator) null;

    [Token(Token = "0x6004782")]
    [Address(RVA = "0x3520CC0", Offset = "0x3520CC0", VA = "0x3520CC0")]
    public void DestroyAssetbundleLoadingPanels()
    {
    }

    [Token(Token = "0x6004783")]
    [Address(RVA = "0x3520E1C", Offset = "0x3520E1C", VA = "0x3520E1C")]
    public SceneHandler()
    {
    }

    [Token(Token = "0x6004784")]
    [Address(RVA = "0x3520F8C", Offset = "0x3520F8C", VA = "0x3520F8C")]
    static SceneHandler()
    {
    }

    [Token(Token = "0x2000C60")]
    public struct SubSceneTransitionData
    {
      [Token(Token = "0x17000A53")]
      public readonly string AssetBundleName
      {
        [Token(Token = "0x6004787"), Address(RVA = "0x3521060", Offset = "0x3521060", VA = "0x3521060")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000A54")]
      public readonly string AssetName
      {
        [Token(Token = "0x6004788"), Address(RVA = "0x3521068", Offset = "0x3521068", VA = "0x3521068")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000A55")]
      public readonly ChangeSceneParameter Parameter
      {
        [Token(Token = "0x6004789"), Address(RVA = "0x3521070", Offset = "0x3521070", VA = "0x3521070")] get
        {
          return (ChangeSceneParameter) null;
        }
      }

      [Token(Token = "0x600478A")]
      [Address(RVA = "0x351F3F0", Offset = "0x351F3F0", VA = "0x351F3F0")]
      public SubSceneTransitionData(
        string assetBundleName,
        string assetName,
        ChangeSceneParameter param = null)
      {
      }
    }

    [Token(Token = "0x2000C61")]
    private class ProcessingSceneFlag : ProcessingFlag
    {
      [Token(Token = "0x600478B")]
      [Address(RVA = "0x3520318", Offset = "0x3520318", VA = "0x3520318")]
      public ProcessingSceneFlag(bool cntlEventSystem)
      {
      }

      [Token(Token = "0x600478C")]
      [Address(RVA = "0x3521078", Offset = "0x3521078", VA = "0x3521078", Slot = "5")]
      protected override List<WeakReference<ProcessingFlag>> GetInspectors()
      {
        return (List<WeakReference<ProcessingFlag>>) null;
      }

      [Token(Token = "0x600478D")]
      [Address(RVA = "0x35210F0", Offset = "0x35210F0", VA = "0x35210F0", Slot = "6")]
      protected override IReadOnlyList<WeakReference<ProcessingFlag>>[] GetAllInspectors()
      {
        return (IReadOnlyList<WeakReference<ProcessingFlag>>[]) null;
      }
    }

    [Token(Token = "0x2000C62")]
    public class ProcessingSubSceneFlag : ProcessingFlag
    {
      [Token(Token = "0x600478E")]
      [Address(RVA = "0x351EFF8", Offset = "0x351EFF8", VA = "0x351EFF8")]
      public ProcessingSubSceneFlag(bool cntlEventSystem)
      {
      }

      [Token(Token = "0x600478F")]
      [Address(RVA = "0x3521230", Offset = "0x3521230", VA = "0x3521230", Slot = "5")]
      protected override List<WeakReference<ProcessingFlag>> GetInspectors()
      {
        return (List<WeakReference<ProcessingFlag>>) null;
      }

      [Token(Token = "0x6004790")]
      [Address(RVA = "0x35212A8", Offset = "0x35212A8", VA = "0x35212A8", Slot = "6")]
      protected override IReadOnlyList<WeakReference<ProcessingFlag>>[] GetAllInspectors()
      {
        return (IReadOnlyList<WeakReference<ProcessingFlag>>[]) null;
      }
    }

    [Token(Token = "0x2000C63")]
    public enum LoadingPanelType
    {
      [Token(Token = "0x40037F9")] Simple,
      [Token(Token = "0x40037FA")] Complex,
      [Token(Token = "0x40037FB")] Fade,
      [Token(Token = "0x40037FC")] Custom,
      [Token(Token = "0x40037FD")] TraiangleTransition,
      [Token(Token = "0x40037FE")] None,
    }

    [Token(Token = "0x2000C64")]
    public enum LoadingTips
    {
      [Token(Token = "0x4003800")] None,
      [Token(Token = "0x4003801")] Story,
      [Token(Token = "0x4003802")] Battle,
      [Token(Token = "0x4003803")] Other,
    }
  }
}
