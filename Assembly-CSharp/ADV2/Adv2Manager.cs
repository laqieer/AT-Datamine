// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2Manager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.AdvTextAccessNS;
using ADV2.LuaScript;
using Cinemachine;
using FreeMap;
using FreeMap.Parameter;
using GameCore.DesignPattern;
using GameCore.MasterData;
using Il2CppDummyDll;
using Lua;
using staq.Camera;
using Story.Adv;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003DB2")]
  [RequireComponent(typeof (Adv2ProjectFilePlayer))]
  public class Adv2Manager : SingletonMonoBehaviour<Adv2Manager>
  {
    [Token(Token = "0x4010E8F")]
    [FieldOffset(Offset = "0x28")]
    private Adv2ProjectFilePlayer adv2ProjectFilePlayer;
    [Token(Token = "0x4010E90")]
    [FieldOffset(Offset = "0x30")]
    private HashSet<char> noLipSyncTexts;
    [Token(Token = "0x4010E91")]
    [FieldOffset(Offset = "0x38")]
    private bool isProjectFilePlaying;
    [Token(Token = "0x4010E93")]
    [FieldOffset(Offset = "0x40")]
    private FreeMapManager freeMapManager;
    [Token(Token = "0x4010E94")]
    [FieldOffset(Offset = "0x48")]
    protected Stack<string> reserveDemoNames;
    [Token(Token = "0x4010E95")]
    [FieldOffset(Offset = "0x50")]
    public Dictionary<string, Adv2Placement.HumanParam> HumanPlacement;
    [Token(Token = "0x4010E96")]
    [FieldOffset(Offset = "0x58")]
    public Dictionary<string, Adv2Placement.ObjectParam> ObjectPlacement;
    [Token(Token = "0x4010E98")]
    [FieldOffset(Offset = "0x68")]
    [NonSerialized]
    protected LuaScriptableObject projectFile;
    [Token(Token = "0x4010E99")]
    [FieldOffset(Offset = "0x70")]
    public string scriptFileName;
    [Token(Token = "0x4010E9A")]
    [FieldOffset(Offset = "0x78")]
    public string scriptAssetBundleName;
    [Token(Token = "0x4010E9B")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    protected LuaScriptableObject debugFile;
    [Token(Token = "0x4010E9C")]
    [FieldOffset(Offset = "0x88")]
    public Adv2LuaPlayer ActiveLuaPlayer;
    [Token(Token = "0x4010E9D")]
    [FieldOffset(Offset = "0x90")]
    protected List<Scene> additiveScenes;
    [Token(Token = "0x4010E9E")]
    [FieldOffset(Offset = "0x98")]
    protected bool isSeHighSpeedMode;
    [Token(Token = "0x4010E9F")]
    [FieldOffset(Offset = "0xA0")]
    private List<Adv2Manager.saveSceneObjectStatus> saveSceneObjectStatuslist;
    [Token(Token = "0x4010EA0")]
    [FieldOffset(Offset = "0xA8")]
    protected List<string> additiveSoundPack;
    [Token(Token = "0x4010EA1")]
    [FieldOffset(Offset = "0xB0")]
    public AdvStageBase ActiveStage;
    [Token(Token = "0x4010EA2")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    protected int activeDemoID;
    [Token(Token = "0x4010EA3")]
    [FieldOffset(Offset = "0xBC")]
    [SerializeField]
    protected int activeOptionID;
    [Token(Token = "0x4010EA4")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    protected int activeCommunicationID;
    [Token(Token = "0x4010EA5")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    protected int activeFacilityID;
    [Token(Token = "0x4010EA6")]
    [FieldOffset(Offset = "0xC8")]
    public Adv2Manager.OptionResult BeforeOptionResult;
    [Token(Token = "0x4010EA7")]
    [FieldOffset(Offset = "0xD0")]
    private Adv2Manager.Adv2ManagerOptionLocks optionLocks;
    [Token(Token = "0x4010EA8")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    public float PlaySpeed;
    [Token(Token = "0x4010EAD")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    public Adv2Manager.ProgressMode PlayMode;
    [Token(Token = "0x4010EAF")]
    [FieldOffset(Offset = "0xF0")]
    private Adv2Manager.ProgressMode SavePlayMode;
    [Token(Token = "0x4010EB0")]
    [FieldOffset(Offset = "0xF4")]
    private bool saveIsSettingAllFast;
    [Token(Token = "0x4010EB1")]
    [FieldOffset(Offset = "0xF5")]
    private bool saveIsSettingAlreadyReadFast;
    [Token(Token = "0x4010EB4")]
    [FieldOffset(Offset = "0xF8")]
    public Adv2Manager.LocalProcessBuffer LocalProcess;
    [Token(Token = "0x4010EB5")]
    [FieldOffset(Offset = "0x100")]
    private List<int> alreadyReadChoices;
    [Token(Token = "0x4010EB6")]
    [FieldOffset(Offset = "0x108")]
    private HashSet<int> modifyAlreadyReadChoicesIds;
    [Token(Token = "0x4010EB7")]
    [FieldOffset(Offset = "0x110")]
    private List<int> selectedAllAdvOptionOnes;
    [Token(Token = "0x4010EB8")]
    [FieldOffset(Offset = "0x118")]
    private HashSet<int> modifySelectedAllAdvOptionOnes;
    [Token(Token = "0x4010EB9")]
    [FieldOffset(Offset = "0x120")]
    private bool isAfterSelectedState;
    [Token(Token = "0x4010EBA")]
    [FieldOffset(Offset = "0x121")]
    private bool alreadyReadStateForAdvDefine;
    [Token(Token = "0x4010EBB")]
    [FieldOffset(Offset = "0x122")]
    private bool alreadyReadStateForAdvOptionOne;
    [Token(Token = "0x4010EBC")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string DuelBgRegex;
    [Token(Token = "0x4010EBD")]
    [FieldOffset(Offset = "0x128")]
    private Dictionary<string, string> reservationAddScriptVariables;
    [Token(Token = "0x4010EBE")]
    [FieldOffset(Offset = "0x130")]
    protected Coroutine startProjectCoroutine;
    [Token(Token = "0x4010EBF")]
    [FieldOffset(Offset = "0x138")]
    private List<Adv2BranchPointController.BranchPointData> branchPointDataList;
    [Token(Token = "0x4010EC0")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private NoiseSettings shakeNoiseSetting;
    [Token(Token = "0x4010EC1")]
    [FieldOffset(Offset = "0x148")]
    private AdvSmallManager smallManager;
    [Token(Token = "0x4010EC2")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    protected RuntimeAnimatorController blankAnimatorControllerIK;
    [Token(Token = "0x4010EC3")]
    [FieldOffset(Offset = "0x158")]
    private bool isTutorialPlay;
    [Token(Token = "0x4010EC4")]
    [FieldOffset(Offset = "0x160")]
    private Dictionary<string, List<GameObject>> accesserDict;
    [Token(Token = "0x4010EC5")]
    [FieldOffset(Offset = "0x168")]
    private UnityAction tutorialButtonAction;
    [Token(Token = "0x4010EC6")]
    [FieldOffset(Offset = "0x170")]
    private string tutorialButtonTarget;
    [Token(Token = "0x4010EC7")]
    [FieldOffset(Offset = "0x178")]
    private Adv2Manager.OnProccessSignal tutorialButtonWaitSignal;
    [Token(Token = "0x4010EC8")]
    [FieldOffset(Offset = "0x180")]
    private List<UnityEngine.UI.Button.ButtonClickedEvent> setButtonEvents;
    [Token(Token = "0x4010EC9")]
    [FieldOffset(Offset = "0x188")]
    private Dictionary<string, bool> tutorialEvents;
    [Token(Token = "0x4010ECA")]
    [FieldOffset(Offset = "0x190")]
    private bool isEnableBackKeyTutorial;

    [Token(Token = "0x170050D3")]
    protected override bool IsDontDestroy
    {
      [Token(Token = "0x6018CBC"), Address(RVA = "0x23935EC", Offset = "0x23935EC", VA = "0x23935EC", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170050D4")]
    public PostProcessSwitcher PostProcessSwitcher
    {
      [Token(Token = "0x6018CBD"), Address(RVA = "0x23935F4", Offset = "0x23935F4", VA = "0x23935F4")] get
      {
        return (PostProcessSwitcher) null;
      }
      [Token(Token = "0x6018CBE"), Address(RVA = "0x23935FC", Offset = "0x23935FC", VA = "0x23935FC")] private set
      {
      }
    }

    [Token(Token = "0x170050D5")]
    public FreeMapAreaSituationData FreeMapAreaSituationData
    {
      [Token(Token = "0x6018CBF"), Address(RVA = "0x2393604", Offset = "0x2393604", VA = "0x2393604")] get
      {
        return new FreeMapAreaSituationData();
      }
      [Token(Token = "0x6018CC0"), Address(RVA = "0x239360C", Offset = "0x239360C", VA = "0x239360C")] private set
      {
      }
    }

    [Token(Token = "0x6018CC1")]
    [Address(RVA = "0x2393614", Offset = "0x2393614", VA = "0x2393614")]
    public Adv2ProjectFilePlayer GetProjectFilePlayer() => (Adv2ProjectFilePlayer) null;

    [Token(Token = "0x6018CC2")]
    [Address(RVA = "0x23936A8", Offset = "0x23936A8", VA = "0x23936A8", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6018CC3")]
    [Address(RVA = "0x2393800", Offset = "0x2393800", VA = "0x2393800")]
    public void DestroyManager()
    {
    }

    [Token(Token = "0x6018CC4")]
    [Address(RVA = "0x23938C0", Offset = "0x23938C0", VA = "0x23938C0")]
    public static void DestroyManagerIfExists()
    {
    }

    [Token(Token = "0x6018CC5")]
    [Address(RVA = "0x23939AC", Offset = "0x23939AC", VA = "0x23939AC")]
    public void OnApplicationPause(bool pauseStatus)
    {
    }

    [Token(Token = "0x6018CC6")]
    [Address(RVA = "0x2393A20", Offset = "0x2393A20", VA = "0x2393A20")]
    private IEnumerator PlayLuaFunctionCoroutine(string functionName) => (IEnumerator) null;

    [Token(Token = "0x6018CC7")]
    [Address(RVA = "0x2393ABC", Offset = "0x2393ABC", VA = "0x2393ABC")]
    public void AddReserveDemo(string demoName)
    {
    }

    [Token(Token = "0x6018CC8")]
    [Address(RVA = "0x2393B14", Offset = "0x2393B14", VA = "0x2393B14")]
    public Adv2Manager.OnProccessSignal CreateWaitTap() => (Adv2Manager.OnProccessSignal) null;

    [Token(Token = "0x6018CC9")]
    [Address(RVA = "0x2393B94", Offset = "0x2393B94", VA = "0x2393B94")]
    protected IEnumerator ExecuteWaitTap(Adv2Manager.OnProccessSignal signal) => (IEnumerator) null;

    [Token(Token = "0x6018CCA")]
    [Address(RVA = "0x2393C2C", Offset = "0x2393C2C", VA = "0x2393C2C")]
    public Adv2Manager.OnProccessSignal CreateTimer(float seconds)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018CCB")]
    [Address(RVA = "0x2393CBC", Offset = "0x2393CBC", VA = "0x2393CBC")]
    protected IEnumerator ExecuteTimer(Adv2Manager.OnProccessSignal signal, float seconds)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6018CCC")]
    [Address(RVA = "0x2393BFC", Offset = "0x2393BFC", VA = "0x2393BFC")]
    public void PlayCoroutine(IEnumerator routine)
    {
    }

    [Token(Token = "0x170050D6")]
    public Adv2Loader Loader
    {
      [Token(Token = "0x6018CCD"), Address(RVA = "0x2393D5C", Offset = "0x2393D5C", VA = "0x2393D5C")] get
      {
        return (Adv2Loader) null;
      }
      [Token(Token = "0x6018CCE"), Address(RVA = "0x2393D64", Offset = "0x2393D64", VA = "0x2393D64")] protected set
      {
      }
    }

    [Token(Token = "0x170050D7")]
    public LuaScriptableObject ProjectFile
    {
      [Token(Token = "0x6018CCF"), Address(RVA = "0x2393D6C", Offset = "0x2393D6C", VA = "0x2393D6C")] get
      {
        return (LuaScriptableObject) null;
      }
      [Token(Token = "0x6018CD0"), Address(RVA = "0x2393D74", Offset = "0x2393D74", VA = "0x2393D74")] set
      {
      }
    }

    [Token(Token = "0x170050D8")]
    public int ActiveDemoID
    {
      [Token(Token = "0x6018CD1"), Address(RVA = "0x2393D7C", Offset = "0x2393D7C", VA = "0x2393D7C")] set
      {
      }
      [Token(Token = "0x6018CD2"), Address(RVA = "0x2393D84", Offset = "0x2393D84", VA = "0x2393D84")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170050D9")]
    public int ActiveOptionID
    {
      [Token(Token = "0x6018CD3"), Address(RVA = "0x2393D8C", Offset = "0x2393D8C", VA = "0x2393D8C")] set
      {
      }
      [Token(Token = "0x6018CD4"), Address(RVA = "0x2393D94", Offset = "0x2393D94", VA = "0x2393D94")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170050DA")]
    public int ActiveCommunicationID
    {
      [Token(Token = "0x6018CD5"), Address(RVA = "0x2393D9C", Offset = "0x2393D9C", VA = "0x2393D9C")] set
      {
      }
      [Token(Token = "0x6018CD6"), Address(RVA = "0x2393DA4", Offset = "0x2393DA4", VA = "0x2393DA4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170050DB")]
    public int ActiveFacilityID
    {
      [Token(Token = "0x6018CD7"), Address(RVA = "0x2393DAC", Offset = "0x2393DAC", VA = "0x2393DAC")] set
      {
      }
      [Token(Token = "0x6018CD8"), Address(RVA = "0x2393DB4", Offset = "0x2393DB4", VA = "0x2393DB4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018CD9")]
    [Address(RVA = "0x2393DBC", Offset = "0x2393DBC", VA = "0x2393DBC")]
    public int GetLockState(int optionOneID) => new int();

    [Token(Token = "0x170050DC")]
    public bool OpenFooter
    {
      [Token(Token = "0x6018CDA"), Address(RVA = "0x2393E60", Offset = "0x2393E60", VA = "0x2393E60")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018CDB"), Address(RVA = "0x2393E68", Offset = "0x2393E68", VA = "0x2393E68")] set
      {
      }
    }

    [Token(Token = "0x170050DD")]
    public bool isSettingDefaultSpeedFlag
    {
      [Token(Token = "0x6018CDC"), Address(RVA = "0x2393E74", Offset = "0x2393E74", VA = "0x2393E74")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018CDD"), Address(RVA = "0x2393E7C", Offset = "0x2393E7C", VA = "0x2393E7C")] set
      {
      }
    }

    [Token(Token = "0x170050DE")]
    public bool isPauseMode
    {
      [Token(Token = "0x6018CDE"), Address(RVA = "0x2393E88", Offset = "0x2393E88", VA = "0x2393E88")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018CDF"), Address(RVA = "0x2393E90", Offset = "0x2393E90", VA = "0x2393E90")] set
      {
      }
    }

    [Token(Token = "0x170050DF")]
    public bool isAdvLogMode
    {
      [Token(Token = "0x6018CE0"), Address(RVA = "0x2393E9C", Offset = "0x2393E9C", VA = "0x2393E9C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018CE1"), Address(RVA = "0x2393EA4", Offset = "0x2393EA4", VA = "0x2393EA4")] private set
      {
      }
    }

    [Token(Token = "0x170050E0")]
    public string TargetName
    {
      [Token(Token = "0x6018CE2"), Address(RVA = "0x2393EB0", Offset = "0x2393EB0", VA = "0x2393EB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6018CE3"), Address(RVA = "0x2393EB8", Offset = "0x2393EB8", VA = "0x2393EB8")] set
      {
      }
    }

    [Token(Token = "0x170050E1")]
    public bool IsSettingAllFast
    {
      [Token(Token = "0x6018CE4"), Address(RVA = "0x2393EC0", Offset = "0x2393EC0", VA = "0x2393EC0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018CE5"), Address(RVA = "0x2393EC8", Offset = "0x2393EC8", VA = "0x2393EC8")] set
      {
      }
    }

    [Token(Token = "0x170050E2")]
    public bool IsSettingAlreadyReadFast
    {
      [Token(Token = "0x6018CE6"), Address(RVA = "0x2393ED4", Offset = "0x2393ED4", VA = "0x2393ED4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018CE7"), Address(RVA = "0x2393EDC", Offset = "0x2393EDC", VA = "0x2393EDC")] set
      {
      }
    }

    [Token(Token = "0x6018CE8")]
    [Address(RVA = "0x2393EE8", Offset = "0x2393EE8", VA = "0x2393EE8")]
    private UnityEngine.Camera CreateLinkCameraDuelBg(
      string scenename,
      BGSceneEffectController bgSceneEffectController,
      out BattleWeatherTypeEnum weather,
      out BattleTimeTypeEnum timeSlot)
    {
      return (UnityEngine.Camera) null;
    }

    [Token(Token = "0x6018CE9")]
    [Address(RVA = "0x23943B8", Offset = "0x23943B8", VA = "0x23943B8")]
    public void LinkCameraOffAlreadyScene()
    {
    }

    [Token(Token = "0x6018CEA")]
    [Address(RVA = "0x23945A0", Offset = "0x23945A0", VA = "0x23945A0")]
    public void AddSceneOnly(Scene newScene)
    {
    }

    [Token(Token = "0x6018CEB")]
    [Address(RVA = "0x238F9E8", Offset = "0x238F9E8", VA = "0x238F9E8")]
    public void AddScene(Scene newScene)
    {
    }

    [Token(Token = "0x6018CEC")]
    private T GetComponentInScene<T>(GameObject go, string name = null) where T : MonoBehaviour
    {
      return (T) null;
    }

    [Token(Token = "0x6018CED")]
    [Address(RVA = "0x2394700", Offset = "0x2394700", VA = "0x2394700")]
    public PlayableDirector GetTimelineScenePlayableDirector(string scenename)
    {
      return (PlayableDirector) null;
    }

    [Token(Token = "0x6018CEE")]
    [Address(RVA = "0x23947EC", Offset = "0x23947EC", VA = "0x23947EC")]
    public UnityEngine.Camera GetActiveSceneCamera() => (UnityEngine.Camera) null;

    [Token(Token = "0x6018CEF")]
    [Address(RVA = "0x2394914", Offset = "0x2394914", VA = "0x2394914")]
    public BGSceneEffectController GetActiveSceneBGSceneEffectController()
    {
      return (BGSceneEffectController) null;
    }

    [Token(Token = "0x6018CF0")]
    [Address(RVA = "0x2394A3C", Offset = "0x2394A3C", VA = "0x2394A3C")]
    public void SetActiveSceneLigthEffectParameter(
      Adv2Manager.LightEffectParameter parameter,
      bool disableSceneVignette)
    {
    }

    [Token(Token = "0x6018CF1")]
    [Address(RVA = "0x2394F3C", Offset = "0x2394F3C", VA = "0x2394F3C")]
    public void SetActiveSceneLightEffectParameter(
      float? bgParametersHardlightBlend,
      Color? bgParametersHardlightColor,
      LightForCharacters.LightDirectionType? lightForChrarctersDirectionType,
      float? lightForChrarctersIntensity,
      float? screenGradationIntensity)
    {
    }

    [Token(Token = "0x6018CF2")]
    [Address(RVA = "0x239500C", Offset = "0x239500C", VA = "0x239500C")]
    public void SetSceneLightEffectParameter(
      string sceneName,
      float? bgParametersHardlightBlend,
      Color? bgParametersHardlightColor,
      LightForCharacters.LightDirectionType? lightForChrarctersDirectionType,
      float? lightForChrarctersIntensity,
      float? screenGradationIntensity)
    {
    }

    [Token(Token = "0x6018CF3")]
    [Address(RVA = "0x23951AC", Offset = "0x23951AC", VA = "0x23951AC")]
    public void SetActiveSceneVignetteEffect(
      Vector2 center,
      Color color,
      float intensity,
      float smoothness,
      bool rounded)
    {
    }

    [Token(Token = "0x6018CF4")]
    [Address(RVA = "0x2395294", Offset = "0x2395294", VA = "0x2395294")]
    public void SetSceneVignetteEffect(
      string sceneName,
      Vector2 center,
      Color color,
      float intensity,
      float smoothness,
      bool rounded)
    {
    }

    [Token(Token = "0x6018CF5")]
    [Address(RVA = "0x2395540", Offset = "0x2395540", VA = "0x2395540")]
    public void SetVignetteEffect(
      GameObject go,
      Vector2 center,
      Color color,
      float intensity,
      float smoothness,
      bool rounded)
    {
    }

    [Token(Token = "0x6018CF6")]
    [Address(RVA = "0x2395788", Offset = "0x2395788", VA = "0x2395788")]
    public void RemoveVignetteEffect(GameObject go)
    {
    }

    [Token(Token = "0x6018CF7")]
    [Address(RVA = "0x2394AD4", Offset = "0x2394AD4", VA = "0x2394AD4")]
    public void SetSceneLigthEffectParameter(
      string name,
      Adv2Manager.LightEffectParameter parameter,
      bool disableSceneVignette)
    {
    }

    [Token(Token = "0x6018CF8")]
    [Address(RVA = "0x2395854", Offset = "0x2395854", VA = "0x2395854")]
    public Adv2Camera GetCameraByName(string cameraName) => (Adv2Camera) null;

    [Token(Token = "0x6018CF9")]
    public T[] GetActiveVolumeComponent<T>() where T : VolumeComponent => (T[]) null;

    [Token(Token = "0x6018CFA")]
    [Address(RVA = "0x2395AE8", Offset = "0x2395AE8", VA = "0x2395AE8")]
    public void ChangeScene(string scenename)
    {
    }

    [Token(Token = "0x6018CFB")]
    [Address(RVA = "0x2396164", Offset = "0x2396164", VA = "0x2396164")]
    public void ChangeActiveSceneWeather(int weather)
    {
    }

    [Token(Token = "0x6018CFC")]
    [Address(RVA = "0x23962F0", Offset = "0x23962F0", VA = "0x23962F0")]
    public void PlayEnvSe(bool flag)
    {
    }

    [Token(Token = "0x6018CFD")]
    [Address(RVA = "0x2396708", Offset = "0x2396708", VA = "0x2396708")]
    public void SetActiveSceneRootObject(string scenename, bool active)
    {
    }

    [Token(Token = "0x6018CFE")]
    [Address(RVA = "0x239686C", Offset = "0x239686C", VA = "0x239686C")]
    public void SetActiveTimelineSceneObject(string scenename)
    {
    }

    [Token(Token = "0x6018CFF")]
    [Address(RVA = "0x2396AFC", Offset = "0x2396AFC", VA = "0x2396AFC")]
    public void SetActiveSceneLinkCamera(bool active)
    {
    }

    [Token(Token = "0x6018D00")]
    [Address(RVA = "0x2396BAC", Offset = "0x2396BAC", VA = "0x2396BAC")]
    public void AddSoundPack(string fileName)
    {
    }

    [Token(Token = "0x6018D01")]
    [Address(RVA = "0x2396D00", Offset = "0x2396D00", VA = "0x2396D00")]
    public bool isPsBattleAdv() => new bool();

    [Token(Token = "0x6018D02")]
    [Address(RVA = "0x2396D74", Offset = "0x2396D74", VA = "0x2396D74")]
    public bool IsBattleAdvActiveNow() => new bool();

    [Token(Token = "0x6018D03")]
    [Address(RVA = "0x2396DD4", Offset = "0x2396DD4", VA = "0x2396DD4")]
    private BattleAdvData GetBattleAdvData() => (BattleAdvData) null;

    [Token(Token = "0x6018D04")]
    [Address(RVA = "0x2397188", Offset = "0x2397188", VA = "0x2397188")]
    public bool IsSkippableBattleAdv() => new bool();

    [Token(Token = "0x6018D05")]
    [Address(RVA = "0x23971A8", Offset = "0x23971A8", VA = "0x23971A8")]
    public bool CheckBattleAdvEnableSound() => new bool();

    [Token(Token = "0x6018D06")]
    [Address(RVA = "0x2397294", Offset = "0x2397294", VA = "0x2397294")]
    public void AdvOpenLog(bool openflag)
    {
    }

    [Token(Token = "0x6018D07")]
    [Address(RVA = "0x239735C", Offset = "0x239735C", VA = "0x239735C")]
    private IEnumerator BackkeyActionCloseLog() => (IEnumerator) null;

    [Token(Token = "0x6018D08")]
    [Address(RVA = "0x23973EC", Offset = "0x23973EC", VA = "0x23973EC")]
    private IEnumerator BackkeyReturnTitle() => (IEnumerator) null;

    [Token(Token = "0x6018D09")]
    [Address(RVA = "0x239747C", Offset = "0x239747C", VA = "0x239747C")]
    public void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6018D0A")]
    [Address(RVA = "0x2397640", Offset = "0x2397640", VA = "0x2397640")]
    private void BackKeyDownActionPopup()
    {
    }

    [Token(Token = "0x6018D0B")]
    [Address(RVA = "0x2397588", Offset = "0x2397588", VA = "0x2397588")]
    public bool IsEnableBackKey() => new bool();

    [Token(Token = "0x6018D0C")]
    [Address(RVA = "0x23979C8", Offset = "0x23979C8", VA = "0x23979C8")]
    public IEnumerator ClearProjectFile(Adv2Manager.OnProccessSignal signal) => (IEnumerator) null;

    [Token(Token = "0x6018D0D")]
    [Address(RVA = "0x2397A64", Offset = "0x2397A64", VA = "0x2397A64")]
    public void AddScriptVariable(string name, string value)
    {
    }

    [Token(Token = "0x6018D0E")]
    [Address(RVA = "0x2397B68", Offset = "0x2397B68", VA = "0x2397B68")]
    public IEnumerator LoadProjectFile(
      Adv2Manager.OnProccessSignal signal,
      string assetbundleName,
      string fileName,
      TextAttributeData textAt,
      string preBGMBank,
      string preBGMEvent,
      string preLoadVoiceBank,
      bool isTutorial = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6018D0F")]
    [Address(RVA = "0x2397C50", Offset = "0x2397C50", VA = "0x2397C50")]
    public IEnumerator PlayProjectFile(Adv2Manager.OnProccessSignal signal) => (IEnumerator) null;

    [Token(Token = "0x6018D10")]
    [Address(RVA = "0x2397CEC", Offset = "0x2397CEC", VA = "0x2397CEC")]
    public void OnResetSettingWhenHomeTiming()
    {
    }

    [Token(Token = "0x6018D11")]
    [Address(RVA = "0x2397CFC", Offset = "0x2397CFC", VA = "0x2397CFC")]
    public void OnResetSettingWhenStoryStartTiming()
    {
    }

    [Token(Token = "0x6018D12")]
    [Address(RVA = "0x2397D04", Offset = "0x2397D04", VA = "0x2397D04")]
    public void OnResetSettingWhenBattleStartTiming()
    {
    }

    [Token(Token = "0x6018D13")]
    [Address(RVA = "0x2397CF4", Offset = "0x2397CF4", VA = "0x2397CF4")]
    private void ResetSaveFastSetting()
    {
    }

    [Token(Token = "0x6018D14")]
    [Address(RVA = "0x2397D68", Offset = "0x2397D68", VA = "0x2397D68")]
    public void OnSelectStartTiming()
    {
    }

    [Token(Token = "0x6018D15")]
    [Address(RVA = "0x2397D74", Offset = "0x2397D74", VA = "0x2397D74")]
    private bool IsSelectedUnselectedOptionState() => new bool();

    [Token(Token = "0x6018D16")]
    [Address(RVA = "0x2397D9C", Offset = "0x2397D9C", VA = "0x2397D9C")]
    private bool IsMainStoryAlreadyReadNowInternal() => new bool();

    [Token(Token = "0x6018D17")]
    [Address(RVA = "0x2397E94", Offset = "0x2397E94", VA = "0x2397E94")]
    public bool IsAlreadyReadNow() => new bool();

    [Token(Token = "0x6018D18")]
    [Address(RVA = "0x239815C", Offset = "0x239815C", VA = "0x239815C")]
    public void OpenFooterFunction(bool fristOpenInLifeTime)
    {
    }

    [Token(Token = "0x6018D19")]
    [Address(RVA = "0x239817C", Offset = "0x239817C", VA = "0x239817C")]
    public void LoadProject(
      Adv2Manager.OnProccessSignal signal,
      string assetbundleName,
      string fileName,
      TextAttributeData texAtt,
      string preBGMBank,
      string preBGMEvent,
      string preLoadVoiceBank,
      bool isTutorial = false)
    {
    }

    [Token(Token = "0x6018D1A")]
    [Address(RVA = "0x23981B8", Offset = "0x23981B8", VA = "0x23981B8")]
    public void StartProject(Adv2Manager.OnProccessSignal signal)
    {
    }

    [Token(Token = "0x6018D1B")]
    [Address(RVA = "0x239836C", Offset = "0x239836C", VA = "0x239836C")]
    private bool HaveAdvOptionActiveNow() => new bool();

    [Token(Token = "0x6018D1C")]
    [Address(RVA = "0x2398448", Offset = "0x2398448", VA = "0x2398448")]
    public bool IsActiveSelectedOptionOn(int optionOneId) => new bool();

    [Token(Token = "0x6018D1D")]
    [Address(RVA = "0x23984F0", Offset = "0x23984F0", VA = "0x23984F0")]
    public void ClearProject(Adv2Manager.OnProccessSignal signal)
    {
    }

    [Token(Token = "0x6018D1E")]
    [Address(RVA = "0x2398518", Offset = "0x2398518", VA = "0x2398518")]
    public IEnumerator StartProject(
      Adv2Manager.OnProccessSignal signal,
      string assetbundleName,
      string fileName,
      TextAttributeData texAtt,
      string preBGMBank,
      string preBGMEvent,
      string preLoadVoiceBank)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6018D1F")]
    [Address(RVA = "0x23985F0", Offset = "0x23985F0", VA = "0x23985F0")]
    protected bool CheckLoadedMasterData() => new bool();

    [Token(Token = "0x6018D20")]
    [Address(RVA = "0x23986B4", Offset = "0x23986B4", VA = "0x23986B4")]
    protected void OnReloadedMasterData()
    {
    }

    [Token(Token = "0x6018D21")]
    [Address(RVA = "0x23986B8", Offset = "0x23986B8", VA = "0x23986B8")]
    public Adv2Manager.OnProccessSignal ForceExitProject() => (Adv2Manager.OnProccessSignal) null;

    [Token(Token = "0x6018D22")]
    [Address(RVA = "0x239873C", Offset = "0x239873C", VA = "0x239873C")]
    public IEnumerator ForceExitProject(Adv2Manager.OnProccessSignal signal) => (IEnumerator) null;

    [Token(Token = "0x6018D23")]
    [Address(RVA = "0x23987D8", Offset = "0x23987D8", VA = "0x23987D8")]
    public void CacheFreeMapAreaSituationData(
      FreeMapAreaSituationData freeMapAreaSituationData,
      FreeMapManager freeMapManager)
    {
    }

    [Token(Token = "0x6018D24")]
    [Address(RVA = "0x23987E4", Offset = "0x23987E4", VA = "0x23987E4")]
    public void SetActiveFreeMapTransitionAreaUnit(bool isView)
    {
    }

    [Token(Token = "0x6018D25")]
    [Address(RVA = "0x239887C", Offset = "0x239887C", VA = "0x239887C")]
    public void SelectMenuItem(int menuID)
    {
    }

    [Token(Token = "0x6018D26")]
    [Address(RVA = "0x2398890", Offset = "0x2398890", VA = "0x2398890")]
    public int CheckDisplaySelectOptionCharacter(string textId) => new int();

    [Token(Token = "0x6018D27")]
    [Address(RVA = "0x2398AD0", Offset = "0x2398AD0", VA = "0x2398AD0")]
    public void SelectOptionOne(int optionID, int order)
    {
    }

    [Token(Token = "0x6018D28")]
    [Address(RVA = "0x2399B14", Offset = "0x2399B14", VA = "0x2399B14")]
    private void SetBranchPointSelectOptionOneData(AdvOptionOneData selectedOptionOneData)
    {
    }

    [Token(Token = "0x6018D29")]
    [Address(RVA = "0x23998EC", Offset = "0x23998EC", VA = "0x23998EC")]
    private void SetBranchPointProcessDatas(List<AdvProcessOneData> processTable)
    {
    }

    [Token(Token = "0x6018D2A")]
    [Address(RVA = "0x2399C00", Offset = "0x2399C00", VA = "0x2399C00")]
    private bool CheckBranchPoint(AdvVariableTypeEnum kind, int id) => new bool();

    [Token(Token = "0x6018D2B")]
    [Address(RVA = "0x2398AA8", Offset = "0x2398AA8", VA = "0x2398AA8")]
    private int isBranchPoint(AdvVariableTypeEnum kind, int id) => new int();

    [Token(Token = "0x6018D2C")]
    [Address(RVA = "0x2399CF0", Offset = "0x2399CF0", VA = "0x2399CF0")]
    public List<Adv2BranchPointController.BranchPointData> GetBranchPointData()
    {
      return (List<Adv2BranchPointController.BranchPointData>) null;
    }

    [Token(Token = "0x6018D2D")]
    [Address(RVA = "0x2399CF8", Offset = "0x2399CF8", VA = "0x2399CF8")]
    public void ResetBranchPointDataList()
    {
    }

    [Token(Token = "0x6018D2E")]
    [Address(RVA = "0x2399D68", Offset = "0x2399D68", VA = "0x2399D68")]
    private bool CheckLockHumanParam(AdvLockOneData lockone) => new bool();

    [Token(Token = "0x6018D2F")]
    [Address(RVA = "0x2399DEC", Offset = "0x2399DEC", VA = "0x2399DEC")]
    private bool CheckLockComu(AdvLockOneData lockone) => new bool();

    [Token(Token = "0x6018D30")]
    [Address(RVA = "0x2399E78", Offset = "0x2399E78", VA = "0x2399E78")]
    private bool CheckLockPointIdentifier(AdvLockOneData lockone) => new bool();

    [Token(Token = "0x6018D31")]
    [Address(RVA = "0x2399F74", Offset = "0x2399F74", VA = "0x2399F74")]
    private bool CheckLockState(AdvLockOneData lockone) => new bool();

    [Token(Token = "0x6018D32")]
    [Address(RVA = "0x2399FBC", Offset = "0x2399FBC", VA = "0x2399FBC")]
    private string CreateLockText(AdvLockOneData lockone, bool lk) => (string) null;

    [Token(Token = "0x6018D33")]
    [Address(RVA = "0x239A4E0", Offset = "0x239A4E0", VA = "0x239A4E0")]
    public void SetLockState()
    {
    }

    [Token(Token = "0x6018D34")]
    [Address(RVA = "0x239AD98", Offset = "0x239AD98", VA = "0x239AD98")]
    public List<(string, bool)> GetLockOneTextInfo(int optionOneId) => (List<(string, bool)>) null;

    [Token(Token = "0x6018D35")]
    [Address(RVA = "0x239AE3C", Offset = "0x239AE3C", VA = "0x239AE3C")]
    public void SetAlreadyReadChoices(string MessageId)
    {
    }

    [Token(Token = "0x6018D36")]
    [Address(RVA = "0x239B0C8", Offset = "0x239B0C8", VA = "0x239B0C8")]
    public bool IsAlreadyReadChoices(string MessageId) => new bool();

    [Token(Token = "0x6018D37")]
    [Address(RVA = "0x239B2F8", Offset = "0x239B2F8", VA = "0x239B2F8")]
    public void OnTimingByCarenderChange(int carenderId)
    {
    }

    [Token(Token = "0x170050E3")]
    public NoiseSettings ShakeNoiseSetting
    {
      [Token(Token = "0x6018D38"), Address(RVA = "0x239B72C", Offset = "0x239B72C", VA = "0x239B72C")] get
      {
        return (NoiseSettings) null;
      }
    }

    [Token(Token = "0x6018D39")]
    [Address(RVA = "0x2395A04", Offset = "0x2395A04", VA = "0x2395A04")]
    public AdvSmallManager GetAdvSmallManager() => (AdvSmallManager) null;

    [Token(Token = "0x6018D3A")]
    [Address(RVA = "0x239B734", Offset = "0x239B734", VA = "0x239B734")]
    public HashSet<char> GetNoLipSyncText() => (HashSet<char>) null;

    [Token(Token = "0x6018D3B")]
    [Address(RVA = "0x239B85C", Offset = "0x239B85C", VA = "0x239B85C")]
    public int GetBGTemplateDefaultMob(int modelId, int templateNo) => new int();

    [Token(Token = "0x6018D3C")]
    [Address(RVA = "0x239BA04", Offset = "0x239BA04", VA = "0x239BA04")]
    public int GetDuelBGTemplateMob(int templateNo) => new int();

    [Token(Token = "0x6018D3D")]
    [Address(RVA = "0x239BBA8", Offset = "0x239BBA8", VA = "0x239BBA8")]
    public void ChildrenDeactive()
    {
    }

    [Token(Token = "0x6018D3E")]
    [Address(RVA = "0x239BC2C", Offset = "0x239BC2C", VA = "0x239BC2C")]
    public void ChildrenActive()
    {
    }

    [Token(Token = "0x6018D3F")]
    [Address(RVA = "0x239BCB0", Offset = "0x239BCB0", VA = "0x239BCB0")]
    public void SetSeHighSpeedMode(bool enable)
    {
    }

    [Token(Token = "0x6018D40")]
    [Address(RVA = "0x2397268", Offset = "0x2397268", VA = "0x2397268")]
    public bool IsNotHighSpeedStage() => new bool();

    [Token(Token = "0x170050E4")]
    public RuntimeAnimatorController BlankAnimatorControllerIK
    {
      [Token(Token = "0x6018D41"), Address(RVA = "0x239BD90", Offset = "0x239BD90", VA = "0x239BD90")] get
      {
        return (RuntimeAnimatorController) null;
      }
    }

    [Token(Token = "0x6018D42")]
    [Address(RVA = "0x239BD98", Offset = "0x239BD98", VA = "0x239BD98")]
    public void PlayTutorialAdv(TutorialAdv tutorialAdv, Action endCallback)
    {
    }

    [Token(Token = "0x6018D43")]
    [Address(RVA = "0x239BE34", Offset = "0x239BE34", VA = "0x239BE34")]
    public void LoadTutorialAdv(
      TutorialAdv tutorialAdv,
      string assetLable,
      string fileName,
      Action endCallback)
    {
    }

    [Token(Token = "0x6018D44")]
    [Address(RVA = "0x239BE54", Offset = "0x239BE54", VA = "0x239BE54")]
    private IEnumerator coLoadTutorialAdv(
      TutorialAdv tutorialAdv,
      string assetLable,
      string fileName,
      Action endCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6018D45")]
    [Address(RVA = "0x239BDB8", Offset = "0x239BDB8", VA = "0x239BDB8")]
    private IEnumerator coPlayTutorialAdv(TutorialAdv tutorialAdv, Action endCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6018D46")]
    [Address(RVA = "0x239BF2C", Offset = "0x239BF2C", VA = "0x239BF2C")]
    public bool HasPresentBox() => new bool();

    [Token(Token = "0x6018D47")]
    [Address(RVA = "0x239BF94", Offset = "0x239BF94", VA = "0x239BF94")]
    public bool HasStyle(int styleId) => new bool();

    [Token(Token = "0x6018D48")]
    [Address(RVA = "0x239C0C0", Offset = "0x239C0C0", VA = "0x239C0C0")]
    public bool ChangeExpeditionParty() => new bool();

    [Token(Token = "0x6018D49")]
    [Address(RVA = "0x239C394", Offset = "0x239C394", VA = "0x239C394")]
    public bool HasTwoHourExpeditionRapidTicket() => new bool();

    [Token(Token = "0x6018D4A")]
    [Address(RVA = "0x239C3FC", Offset = "0x239C3FC", VA = "0x239C3FC")]
    public int GetExpeditionBossLevel(int stageId) => new int();

    [Token(Token = "0x6018D4B")]
    [Address(RVA = "0x239C4FC", Offset = "0x239C4FC", VA = "0x239C4FC")]
    public void SetTutorialNextSequence()
    {
    }

    [Token(Token = "0x6018D4C")]
    [Address(RVA = "0x239C5D8", Offset = "0x239C5D8", VA = "0x239C5D8")]
    public void AddTutorialAccesser(string name, GameObject accessObject)
    {
    }

    [Token(Token = "0x6018D4D")]
    [Address(RVA = "0x239CB8C", Offset = "0x239CB8C", VA = "0x239CB8C")]
    public void RemoveTutorialAccesser(string name, GameObject accessObject)
    {
    }

    [Token(Token = "0x6018D4E")]
    [Address(RVA = "0x239CCA8", Offset = "0x239CCA8", VA = "0x239CCA8")]
    public bool IsTutorialAccesserExist(string accesserName, bool activeOnly) => new bool();

    [Token(Token = "0x6018D4F")]
    [Address(RVA = "0x23977D8", Offset = "0x23977D8", VA = "0x23977D8")]
    public GameObject GetTutorialGameObject(string accesserName) => (GameObject) null;

    [Token(Token = "0x6018D50")]
    [Address(RVA = "0x239CE18", Offset = "0x239CE18", VA = "0x239CE18")]
    public List<GameObject> GetTutorialGameObjectList(string accesserName)
    {
      return (List<GameObject>) null;
    }

    [Token(Token = "0x6018D51")]
    [Address(RVA = "0x239CE90", Offset = "0x239CE90", VA = "0x239CE90")]
    public LuaSignalMini AddTutorialButtonEvent(string accesserName) => (LuaSignalMini) null;

    [Token(Token = "0x6018D52")]
    [Address(RVA = "0x239D3C4", Offset = "0x239D3C4", VA = "0x239D3C4")]
    public LuaSignalMini AddTutorialButtonEvent(string accesserName, GameObject targetGo)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6018D53")]
    [Address(RVA = "0x239C774", Offset = "0x239C774", VA = "0x239C774")]
    private void ReplaceTutorialButtonEvent(string accesserName)
    {
    }

    [Token(Token = "0x6018D54")]
    [Address(RVA = "0x239D1F4", Offset = "0x239D1F4", VA = "0x239D1F4")]
    public void RemoveTutorialButtonEvent()
    {
    }

    [Token(Token = "0x6018D55")]
    [Address(RVA = "0x239D5C8", Offset = "0x239D5C8", VA = "0x239D5C8")]
    public void SetInteractableButton(string accesserName, bool interactable)
    {
    }

    [Token(Token = "0x6018D56")]
    [Address(RVA = "0x239D7AC", Offset = "0x239D7AC", VA = "0x239D7AC")]
    public bool IsPlayingUIAnimation(string accesserName) => new bool();

    [Token(Token = "0x6018D57")]
    [Address(RVA = "0x239D9A0", Offset = "0x239D9A0", VA = "0x239D9A0")]
    public void SetDisableScroll(string scrollObjAccessName)
    {
    }

    [Token(Token = "0x6018D58")]
    [Address(RVA = "0x239DA80", Offset = "0x239DA80", VA = "0x239DA80")]
    public void SetDisableCommonGesture(string accessName)
    {
    }

    [Token(Token = "0x6018D59")]
    [Address(RVA = "0x239DB78", Offset = "0x239DB78", VA = "0x239DB78")]
    public GameObject GetExpeditionFieldBannerGameObject(string scrollObjAccessName, int stageId)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6018D5A")]
    [Address(RVA = "0x239DCBC", Offset = "0x239DCBC", VA = "0x239DCBC")]
    public GameObject GetExpeditionBossListGameObject(string scrollObjAccessName, int bossId)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6018D5B")]
    [Address(RVA = "0x239DE00", Offset = "0x239DE00", VA = "0x239DE00")]
    public GameObject GetStyleThumbGameObject(string scrollObjAccessName, int styleId)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6018D5C")]
    private GameObject GetScrollItemObject<T>(GameObject scrollRoot, Func<T, bool> check) where T : MonoBehaviour
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6018D5D")]
    [Address(RVA = "0x239DF44", Offset = "0x239DF44", VA = "0x239DF44")]
    public void SetTutorialEvent(string eventName, bool check)
    {
    }

    [Token(Token = "0x6018D5E")]
    [Address(RVA = "0x239DFC4", Offset = "0x239DFC4", VA = "0x239DFC4")]
    public bool GetTutorialEvent(string eventName) => new bool();

    [Token(Token = "0x6018D5F")]
    [Address(RVA = "0x239E04C", Offset = "0x239E04C", VA = "0x239E04C")]
    public void ActiveTutorialCanvas()
    {
    }

    [Token(Token = "0x6018D60")]
    [Address(RVA = "0x239E110", Offset = "0x239E110", VA = "0x239E110")]
    public bool IsReadedBackHomeTutorial() => new bool();

    [Token(Token = "0x6018D61")]
    [Address(RVA = "0x239E1A0", Offset = "0x239E1A0", VA = "0x239E1A0")]
    public void SetReadedBackHomeTutorial()
    {
    }

    [Token(Token = "0x6018D62")]
    [Address(RVA = "0x239E22C", Offset = "0x239E22C", VA = "0x239E22C")]
    public bool IsEnableBackKeyTutorial() => new bool();

    [Token(Token = "0x6018D63")]
    [Address(RVA = "0x239E234", Offset = "0x239E234", VA = "0x239E234")]
    public void SetEnableBackKeyTutorial(bool isEnable)
    {
    }

    [Token(Token = "0x6018D64")]
    [Address(RVA = "0x239E240", Offset = "0x239E240", VA = "0x239E240")]
    public Adv2Manager()
    {
    }

    [Token(Token = "0x6018D65")]
    [Address(RVA = "0x239E7F4", Offset = "0x239E7F4", VA = "0x239E7F4")]
    static Adv2Manager()
    {
    }

    [Token(Token = "0x2003DB3")]
    public class OnProccessSignal
    {
      [Token(Token = "0x4010ECB")]
      [FieldOffset(Offset = "0x10")]
      protected bool isProccessing;

      [Token(Token = "0x170050E5")]
      public bool IsProccessing
      {
        [Token(Token = "0x6018D6A"), Address(RVA = "0x239E8EC", Offset = "0x239E8EC", VA = "0x239E8EC")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6018D6B")]
      [Address(RVA = "0x239E8F4", Offset = "0x239E8F4", VA = "0x239E8F4", Slot = "4")]
      public virtual void SetProccessing(bool value)
      {
      }

      [Token(Token = "0x6018D6C")]
      [Address(RVA = "0x238F01C", Offset = "0x238F01C", VA = "0x238F01C")]
      public OnProccessSignal()
      {
      }
    }

    [Token(Token = "0x2003DB4")]
    public class saveSceneObjectStatus
    {
      [Token(Token = "0x4010ECC")]
      [FieldOffset(Offset = "0x10")]
      public string sceneName;
      [Token(Token = "0x4010ECD")]
      [FieldOffset(Offset = "0x18")]
      public GameObject soundObject;
      [Token(Token = "0x4010ECE")]
      [FieldOffset(Offset = "0x20")]
      public UnityEngine.Camera LinkCamera;
      [Token(Token = "0x4010ECF")]
      [FieldOffset(Offset = "0x28")]
      public BattleWeatherTypeEnum Weather;
      [Token(Token = "0x4010ED0")]
      [FieldOffset(Offset = "0x2C")]
      public BattleTimeTypeEnum TimeSlot;
      [Token(Token = "0x4010ED1")]
      [FieldOffset(Offset = "0x30")]
      public BGSceneEffectController EffectController;
      [Token(Token = "0x4010ED2")]
      [FieldOffset(Offset = "0x38")]
      public BGColorCollect BGColorCollect;
      [Token(Token = "0x4010ED3")]
      [FieldOffset(Offset = "0x40")]
      public BGParameters BGParameters;
      [Token(Token = "0x4010ED4")]
      [FieldOffset(Offset = "0x48")]
      public LightForCharacters LightForCharacters;
      [Token(Token = "0x4010ED5")]
      [FieldOffset(Offset = "0x50")]
      public Volume GlobalVolume;
      [Token(Token = "0x4010ED6")]
      [FieldOffset(Offset = "0x58")]
      public Adv2Manager.LightEffectParameter lightEffetctDefaultParameter;
      [Token(Token = "0x4010ED7")]
      [FieldOffset(Offset = "0x60")]
      public Adv2Manager.LightEffectParameter lightEffetctSceneParameter;
      [Token(Token = "0x4010ED8")]
      [FieldOffset(Offset = "0x68")]
      public GameObject VignetteObject;
      [Token(Token = "0x4010ED9")]
      [FieldOffset(Offset = "0x70")]
      public PlayableDirector playableDirector;
      [Token(Token = "0x4010EDA")]
      [FieldOffset(Offset = "0x78")]
      public List<Adv2Manager.saveSceneObjectStatus.GameObjectStatus> gameObjectStatuses;

      [Token(Token = "0x6018D6D")]
      [Address(RVA = "0x2394648", Offset = "0x2394648", VA = "0x2394648")]
      public saveSceneObjectStatus()
      {
      }

      [Token(Token = "0x2003DB5")]
      public class GameObjectStatus
      {
        [Token(Token = "0x4010EDB")]
        [FieldOffset(Offset = "0x10")]
        public GameObject go;
        [Token(Token = "0x4010EDC")]
        [FieldOffset(Offset = "0x18")]
        public bool active;

        [Token(Token = "0x6018D6E")]
        [Address(RVA = "0x23946F0", Offset = "0x23946F0", VA = "0x23946F0")]
        public GameObjectStatus()
        {
        }
      }
    }

    [Token(Token = "0x2003DB6")]
    public class LightEffectParameter
    {
      [Token(Token = "0x4010EDD")]
      [FieldOffset(Offset = "0x10")]
      public float? LightForChrarctersIntensity;
      [Token(Token = "0x4010EDE")]
      [FieldOffset(Offset = "0x18")]
      public LightForCharacters.LightDirectionType? LightForChrarctersDirectionType;
      [Token(Token = "0x4010EDF")]
      [FieldOffset(Offset = "0x20")]
      public float? BGParametersHardlightBlend;
      [Token(Token = "0x4010EE0")]
      [FieldOffset(Offset = "0x28")]
      public Color? BGParametersHardlightColor;
      [Token(Token = "0x4010EE1")]
      [FieldOffset(Offset = "0x3C")]
      public float? ScreenGradationIntensity;

      [Token(Token = "0x6018D6F")]
      [Address(RVA = "0x23946F8", Offset = "0x23946F8", VA = "0x23946F8")]
      public LightEffectParameter()
      {
      }
    }

    [Token(Token = "0x2003DB7")]
    public class OptionResult
    {
      [Token(Token = "0x4010EE2")]
      [FieldOffset(Offset = "0x10")]
      public int AddCommunicationID;
      [Token(Token = "0x4010EE3")]
      [FieldOffset(Offset = "0x14")]
      public int AddCommunicationPoint;

      [Token(Token = "0x6018D70")]
      [Address(RVA = "0x2398F50", Offset = "0x2398F50", VA = "0x2398F50")]
      public OptionResult()
      {
      }
    }

    [Token(Token = "0x2003DB8")]
    public enum ProgressMode
    {
      [Token(Token = "0x4010EE5")] Manual,
      [Token(Token = "0x4010EE6")] Auto,
    }

    [Token(Token = "0x2003DB9")]
    public class LocalProcessBuffer
    {
      [Token(Token = "0x4010EE7")]
      [FieldOffset(Offset = "0x10")]
      public Adv2Manager.LocalProcessBuffer.IntVariable intVariables;

      [Token(Token = "0x170050E6")]
      public QuestVariable QuestVariables
      {
        [Token(Token = "0x6018D71"), Address(RVA = "0x239E900", Offset = "0x239E900", VA = "0x239E900")] get
        {
          return (QuestVariable) null;
        }
      }

      [Token(Token = "0x6018D72")]
      [Address(RVA = "0x239E908", Offset = "0x239E908", VA = "0x239E908")]
      public void Initialize()
      {
      }

      [Token(Token = "0x6018D73")]
      [Address(RVA = "0x239F128", Offset = "0x239F128", VA = "0x239F128")]
      public void SyncParam()
      {
      }

      [Token(Token = "0x6018D74")]
      [Address(RVA = "0x2398F58", Offset = "0x2398F58", VA = "0x2398F58")]
      public void Execute(AdvProcessOneData processData)
      {
      }

      [Token(Token = "0x6018D75")]
      [Address(RVA = "0x239E760", Offset = "0x239E760", VA = "0x239E760")]
      public LocalProcessBuffer()
      {
      }

      [Token(Token = "0x2003DBA")]
      public class VariableBase<KIND, KEY, VALUE>
      {
        [Token(Token = "0x4010EE9")]
        [FieldOffset(Offset = "0x0")]
        protected Dictionary<KIND, Dictionary<KEY, VALUE>> variables;

        [Token(Token = "0x6018D76")]
        public void Clear()
        {
        }

        [Token(Token = "0x6018D77")]
        public void Set(KIND kind, KEY key, VALUE value)
        {
        }

        [Token(Token = "0x6018D78")]
        protected virtual VALUE GetInitValue(KIND kind, KEY key) => (VALUE) null;

        [Token(Token = "0x6018D79")]
        public VALUE Get(KIND kind, KEY key) => (VALUE) null;

        [Token(Token = "0x6018D7A")]
        public bool TryGet(ref VALUE value, KIND kind, KEY key) => new bool();

        [Token(Token = "0x6018D7B")]
        public Dictionary<KEY, VALUE> Get(KIND kind) => (Dictionary<KEY, VALUE>) null;

        [Token(Token = "0x6018D7C")]
        public VariableBase()
        {
        }
      }

      [Token(Token = "0x2003DBB")]
      public class IntVariable : 
        Adv2Manager.LocalProcessBuffer.VariableBase<AdvVariableTypeEnum, int, int>
      {
        [Token(Token = "0x6018D7D")]
        [Address(RVA = "0x239F3C8", Offset = "0x239F3C8", VA = "0x239F3C8", Slot = "4")]
        protected override int GetInitValue(AdvVariableTypeEnum kind, int key) => new int();

        [Token(Token = "0x6018D7E")]
        [Address(RVA = "0x239F380", Offset = "0x239F380", VA = "0x239F380")]
        public IntVariable()
        {
        }
      }
    }

    [Token(Token = "0x2003DBC")]
    private class Adv2ManagerOptionLocks
    {
      [Token(Token = "0x4010EEA")]
      [FieldOffset(Offset = "0x10")]
      private Dictionary<int, Adv2Manager.Adv2ManagerOptionLocks.LockStatus> lockStatus;

      [Token(Token = "0x6018D7F")]
      [Address(RVA = "0x239A4F8", Offset = "0x239A4F8", VA = "0x239A4F8")]
      public void StatusUpdate()
      {
      }

      [Token(Token = "0x6018D80")]
      [Address(RVA = "0x2393DD4", Offset = "0x2393DD4", VA = "0x2393DD4")]
      public int GetLockState(int optionOneID) => new int();

      [Token(Token = "0x6018D81")]
      [Address(RVA = "0x239ADB0", Offset = "0x239ADB0", VA = "0x239ADB0")]
      public List<(string, bool)> GetLockOneTextInfo(int optionOneID)
      {
        return (List<(string, bool)>) null;
      }

      [Token(Token = "0x6018D82")]
      [Address(RVA = "0x2398EC0", Offset = "0x2398EC0", VA = "0x2398EC0")]
      public bool IsLcocked(int optionOneId) => new bool();

      [Token(Token = "0x6018D83")]
      protected bool ValueCompare<T>(AdvComparisonTypeEnum comparisonType, T value1, T value2) where T : IComparable
      {
        return new bool();
      }

      [Token(Token = "0x6018D84")]
      [Address(RVA = "0x239FAB0", Offset = "0x239FAB0", VA = "0x239FAB0")]
      private int GetParameterValue(AdvVariableTypeEnum type, int id) => new int();

      [Token(Token = "0x6018D85")]
      [Address(RVA = "0x239FBE0", Offset = "0x239FBE0", VA = "0x239FBE0")]
      private bool IsUnlockOpened(int optionOneID) => new bool();

      [Token(Token = "0x6018D86")]
      [Address(RVA = "0x239E6E4", Offset = "0x239E6E4", VA = "0x239E6E4")]
      public Adv2ManagerOptionLocks()
      {
      }

      [Token(Token = "0x2003DBD")]
      private class NormalLockStatus : Adv2Manager.Adv2ManagerOptionLocks.LockStatus
      {
        [Token(Token = "0x4010EEB")]
        [FieldOffset(Offset = "0x19")]
        private bool locked;
        [Token(Token = "0x4010EEC")]
        [FieldOffset(Offset = "0x1C")]
        private int lockOperator;
        [Token(Token = "0x4010EED")]
        [FieldOffset(Offset = "0x20")]
        private List<(string, bool)> lockoneTexts;
        [Token(Token = "0x4010EEE")]
        [FieldOffset(Offset = "0x28")]
        private bool opended;

        [Token(Token = "0x6018D87")]
        [Address(RVA = "0x239F7CC", Offset = "0x239F7CC", VA = "0x239F7CC")]
        public NormalLockStatus(Adv2Manager.Adv2ManagerOptionLocks parentInstance)
        {
        }

        [Token(Token = "0x6018D88")]
        [Address(RVA = "0x239F85C", Offset = "0x239F85C", VA = "0x239F85C")]
        public void InitialUpdate(int lockOneId, int optionOneId, int lockOperator)
        {
        }

        [Token(Token = "0x6018D89")]
        [Address(RVA = "0x23A06EC", Offset = "0x23A06EC", VA = "0x23A06EC", Slot = "4")]
        public override int GetLockStatus() => new int();

        [Token(Token = "0x6018D8A")]
        [Address(RVA = "0x23A0704", Offset = "0x23A0704", VA = "0x23A0704", Slot = "5")]
        public override List<(string, bool)> GetLockOneTexts() => (List<(string, bool)>) null;

        [Token(Token = "0x6018D8B")]
        [Address(RVA = "0x23A070C", Offset = "0x23A070C", VA = "0x23A070C", Slot = "6")]
        public override bool IsLocked() => new bool();

        [Token(Token = "0x6018D8C")]
        [Address(RVA = "0x23A0714", Offset = "0x23A0714", VA = "0x23A0714", Slot = "7")]
        public override void UpdateWhenAllLocked()
        {
        }

        [Token(Token = "0x6018D8D")]
        [Address(RVA = "0x239FD4C", Offset = "0x239FD4C", VA = "0x239FD4C")]
        private bool CheckLockState(AdvLockOneData lockinfo) => new bool();

        [Token(Token = "0x6018D8E")]
        [Address(RVA = "0x23A0430", Offset = "0x23A0430", VA = "0x23A0430")]
        private string CreateLockText(AdvLockOneData lockone) => (string) null;
      }

      [Token(Token = "0x2003DBE")]
      private class ExpandedLockStatus : Adv2Manager.Adv2ManagerOptionLocks.LockStatus
      {
        [Token(Token = "0x4010EEF")]
        [FieldOffset(Offset = "0x19")]
        private bool locked;
        [Token(Token = "0x4010EF0")]
        [FieldOffset(Offset = "0x20")]
        private List<(string, bool)> lockoneTexts;
        [Token(Token = "0x4010EF1")]
        [FieldOffset(Offset = "0x28")]
        private bool fallbackInAllLocked;
        [Token(Token = "0x4010EF2")]
        [FieldOffset(Offset = "0x29")]
        private bool opended;

        [Token(Token = "0x6018D8F")]
        [Address(RVA = "0x239F3D0", Offset = "0x239F3D0", VA = "0x239F3D0")]
        public ExpandedLockStatus(Adv2Manager.Adv2ManagerOptionLocks parentInstance)
        {
        }

        [Token(Token = "0x6018D90")]
        [Address(RVA = "0x239F460", Offset = "0x239F460", VA = "0x239F460")]
        public void InitialUpdate(int exlockedId, int optionOneID)
        {
        }

        [Token(Token = "0x6018D91")]
        [Address(RVA = "0x23A0730", Offset = "0x23A0730", VA = "0x23A0730")]
        private bool CheckLockState(AdvExpandedLockComparisonTermData lockinfo) => new bool();

        [Token(Token = "0x6018D92")]
        [Address(RVA = "0x23A0888", Offset = "0x23A0888", VA = "0x23A0888")]
        private Decimal GetExLockValue(int exlockValueId) => 0M;

        [Token(Token = "0x6018D93")]
        [Address(RVA = "0x23A07D4", Offset = "0x23A07D4", VA = "0x23A07D4")]
        private string CreateLockText(AdvExpandedLockComparisonTermData data) => (string) null;

        [Token(Token = "0x6018D94")]
        [Address(RVA = "0x23A0B70", Offset = "0x23A0B70", VA = "0x23A0B70", Slot = "4")]
        public override int GetLockStatus() => new int();

        [Token(Token = "0x6018D95")]
        [Address(RVA = "0x23A0B88", Offset = "0x23A0B88", VA = "0x23A0B88", Slot = "5")]
        public override List<(string, bool)> GetLockOneTexts() => (List<(string, bool)>) null;

        [Token(Token = "0x6018D96")]
        [Address(RVA = "0x23A0B90", Offset = "0x23A0B90", VA = "0x23A0B90", Slot = "6")]
        public override bool IsLocked() => new bool();

        [Token(Token = "0x6018D97")]
        [Address(RVA = "0x23A0B98", Offset = "0x23A0B98", VA = "0x23A0B98", Slot = "7")]
        public override void UpdateWhenAllLocked()
        {
        }
      }

      [Token(Token = "0x2003DBF")]
      private abstract class LockStatus
      {
        [Token(Token = "0x4010EF3")]
        [FieldOffset(Offset = "0x10")]
        private Adv2Manager.Adv2ManagerOptionLocks parentInstance;
        [Token(Token = "0x4010EF4")]
        [FieldOffset(Offset = "0x18")]
        public bool isOr;

        [Token(Token = "0x6018D98")]
        [Address(RVA = "0x239FD24", Offset = "0x239FD24", VA = "0x239FD24")]
        public LockStatus(Adv2Manager.Adv2ManagerOptionLocks parentInstance)
        {
        }

        [Token(Token = "0x6018D99")]
        public abstract int GetLockStatus();

        [Token(Token = "0x6018D9A")]
        public abstract List<(string, bool)> GetLockOneTexts();

        [Token(Token = "0x6018D9B")]
        public abstract bool IsLocked();

        [Token(Token = "0x6018D9C")]
        public abstract void UpdateWhenAllLocked();

        [Token(Token = "0x6018D9D")]
        protected bool ValueCompare<T>(AdvComparisonTypeEnum comparisonType, T value1, T value2) where T : IComparable
        {
          return new bool();
        }

        [Token(Token = "0x6018D9E")]
        [Address(RVA = "0x23A0718", Offset = "0x23A0718", VA = "0x23A0718")]
        protected int GetParameterValue(AdvVariableTypeEnum type, int id) => new int();

        [Token(Token = "0x6018D9F")]
        [Address(RVA = "0x23A06D4", Offset = "0x23A06D4", VA = "0x23A06D4")]
        protected bool IsUnlockOpened(int optionOneID) => new bool();
      }
    }
  }
}
