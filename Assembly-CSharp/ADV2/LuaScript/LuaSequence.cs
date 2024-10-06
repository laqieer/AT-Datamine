// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using Opening;
using StaqData.AreaEvent;
using StaqData.SubQuest;
using Story.Adv;
using Story.Adv.Facility;
using Story.Adv.StoryMainQuest;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EC7")]
  [MoonSharpUserData]
  public class LuaSequence : LuaSignal
  {
    [Token(Token = "0x4011357")]
    [FieldOffset(Offset = "0x18")]
    protected Adv2Manager advManager;
    [Token(Token = "0x4011358")]
    [FieldOffset(Offset = "0x20")]
    protected Adv2LuaPlayer luaPlayer;
    [Token(Token = "0x4011359")]
    [FieldOffset(Offset = "0x28")]
    private Regex lookonRegex;
    [Token(Token = "0x401135A")]
    [FieldOffset(Offset = "0x30")]
    private Adv2PlayerModelInfo adv2PlayerModelInfo;
    [Token(Token = "0x401135B")]
    private const string SE_LoopStop = "SE_ADV_Loop_Stop";
    [Token(Token = "0x401135C")]
    [FieldOffset(Offset = "0x38")]
    public LuaSequence.ParamControl Param;
    [Token(Token = "0x401135D")]
    [FieldOffset(Offset = "0x40")]
    public LuaResouceDataUtility ResouceDataUtility;

    [Token(Token = "0x6019520")]
    [Address(RVA = "0x2FF07B4", Offset = "0x2FF07B4", VA = "0x2FF07B4")]
    public LuaSequence(Adv2Manager manager, Adv2LuaPlayer player)
    {
    }

    [Token(Token = "0x6019521")]
    [Address(RVA = "0x2FF8104", Offset = "0x2FF8104", VA = "0x2FF8104")]
    public void PreLoadRequest(string assetBundleName)
    {
    }

    [Token(Token = "0x6019522")]
    [Address(RVA = "0x2FF8128", Offset = "0x2FF8128", VA = "0x2FF8128")]
    public void PreDownloadRequest(string assetBundleName)
    {
    }

    [Token(Token = "0x6019523")]
    [Address(RVA = "0x2FF814C", Offset = "0x2FF814C", VA = "0x2FF814C")]
    public void PreDownloadMovieRequest(string movieName, bool existH265)
    {
    }

    [Token(Token = "0x6019524")]
    [Address(RVA = "0x2FF8174", Offset = "0x2FF8174", VA = "0x2FF8174")]
    public void SetTrackingId(int id)
    {
    }

    [Token(Token = "0x6019525")]
    [Address(RVA = "0x2FF81F4", Offset = "0x2FF81F4", VA = "0x2FF81F4")]
    public LuaObject CreateObject(string layerName) => (LuaObject) null;

    [Token(Token = "0x6019526")]
    [Address(RVA = "0x2FF836C", Offset = "0x2FF836C", VA = "0x2FF836C")]
    public LuaEffectParticle CreateParticleEffect(string layerName, bool isActive, bool enableSE)
    {
      return (LuaEffectParticle) null;
    }

    [Token(Token = "0x6019527")]
    [Address(RVA = "0x2FF8504", Offset = "0x2FF8504", VA = "0x2FF8504")]
    public LuaBgParamter CreateBgParametersObject(string layerName) => (LuaBgParamter) null;

    [Token(Token = "0x6019528")]
    [Address(RVA = "0x2FF8678", Offset = "0x2FF8678", VA = "0x2FF8678")]
    public LuaHuman CreateHuman(string layerName) => (LuaHuman) null;

    [Token(Token = "0x6019529")]
    [Address(RVA = "0x2FF8868", Offset = "0x2FF8868", VA = "0x2FF8868")]
    public LuaCamera CreateCamera() => (LuaCamera) null;

    [Token(Token = "0x601952A")]
    [Address(RVA = "0x2FF89A4", Offset = "0x2FF89A4", VA = "0x2FF89A4")]
    public LuaAdvSmallManager CreateAdvSmallManager() => (LuaAdvSmallManager) null;

    [Token(Token = "0x601952B")]
    [Address(RVA = "0x2FF8A70", Offset = "0x2FF8A70", VA = "0x2FF8A70")]
    public LuaSignal LoadTutorialPopup() => (LuaSignal) null;

    [Token(Token = "0x601952C")]
    [Address(RVA = "0x2FF8B3C", Offset = "0x2FF8B3C", VA = "0x2FF8B3C")]
    public LuaSignalMini CreateTutorialPopup(int tutorialId, bool tutorialLayer = false)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x601952D")]
    [Address(RVA = "0x2FF8C6C", Offset = "0x2FF8C6C", VA = "0x2FF8C6C")]
    public LuaSignalMini OpenTutorialPopup() => (LuaSignalMini) null;

    [Token(Token = "0x601952E")]
    [Address(RVA = "0x2FF8DE8", Offset = "0x2FF8DE8", VA = "0x2FF8DE8")]
    public List<LuaHuman> GetAdv2Human() => (List<LuaHuman>) null;

    [Token(Token = "0x601952F")]
    [Address(RVA = "0x2FF8FE8", Offset = "0x2FF8FE8", VA = "0x2FF8FE8")]
    public LuaCommonPopup CreateSystemPopup() => (LuaCommonPopup) null;

    [Token(Token = "0x6019530")]
    [Address(RVA = "0x2FF9040", Offset = "0x2FF9040", VA = "0x2FF9040")]
    public LuaSkipPopup CreateSkipPopup() => (LuaSkipPopup) null;

    [Token(Token = "0x6019531")]
    [Address(RVA = "0x2FF9098", Offset = "0x2FF9098", VA = "0x2FF9098")]
    public void SetLookonRegex(string regexStr)
    {
    }

    [Token(Token = "0x6019532")]
    [Address(RVA = "0x2FF9108", Offset = "0x2FF9108", VA = "0x2FF9108")]
    public bool IsMatchLookonRegex(string str) => new bool();

    [Token(Token = "0x6019533")]
    [Address(RVA = "0x2FF9124", Offset = "0x2FF9124", VA = "0x2FF9124")]
    public string GetPlayerModelInfo(string label) => (string) null;

    [Token(Token = "0x6019534")]
    [Address(RVA = "0x2FF91AC", Offset = "0x2FF91AC", VA = "0x2FF91AC")]
    public int GetPlayerStyleId() => new int();

    [Token(Token = "0x6019535")]
    [Address(RVA = "0x2FF922C", Offset = "0x2FF922C", VA = "0x2FF922C")]
    public Adv2LuaNetworkConnection Connection() => (Adv2LuaNetworkConnection) null;

    [Token(Token = "0x6019536")]
    [Address(RVA = "0x2FF92BC", Offset = "0x2FF92BC", VA = "0x2FF92BC")]
    public void AddCinemachineBrain()
    {
    }

    [Token(Token = "0x6019537")]
    [Address(RVA = "0x2FF93C0", Offset = "0x2FF93C0", VA = "0x2FF93C0")]
    public float GetDeltaTime() => new float();

    [Token(Token = "0x6019538")]
    [Address(RVA = "0x2FF93C8", Offset = "0x2FF93C8", VA = "0x2FF93C8")]
    public int GetStorySequenceWeather() => new int();

    [Token(Token = "0x6019539")]
    [Address(RVA = "0x2FF9454", Offset = "0x2FF9454", VA = "0x2FF9454")]
    public int GetStorySequenceTimeSlot() => new int();

    [Token(Token = "0x601953A")]
    [Address(RVA = "0x2FF94DC", Offset = "0x2FF94DC", VA = "0x2FF94DC")]
    public bool IsIndoor() => new bool();

    [Token(Token = "0x601953B")]
    [Address(RVA = "0x2FF9500", Offset = "0x2FF9500", VA = "0x2FF9500")]
    public string GetPlayerName() => (string) null;

    [Token(Token = "0x601953C")]
    [Address(RVA = "0x2FF9584", Offset = "0x2FF9584", VA = "0x2FF9584")]
    public int GetPlayerType() => new int();

    [Token(Token = "0x601953D")]
    [Address(RVA = "0x2FF958C", Offset = "0x2FF958C", VA = "0x2FF958C")]
    public string GetStorySequenceDemoTitle() => (string) null;

    [Token(Token = "0x601953E")]
    [Address(RVA = "0x2FF96B0", Offset = "0x2FF96B0", VA = "0x2FF96B0")]
    public LuaSignal CreateTimer(float seconds) => (LuaSignal) null;

    [Token(Token = "0x601953F")]
    [Address(RVA = "0x2FF977C", Offset = "0x2FF977C", VA = "0x2FF977C")]
    public void DateOut()
    {
    }

    [Token(Token = "0x6019540")]
    [Address(RVA = "0x2FF97FC", Offset = "0x2FF97FC", VA = "0x2FF97FC")]
    public void DateIn()
    {
    }

    [Token(Token = "0x6019541")]
    [Address(RVA = "0x2FF98FC", Offset = "0x2FF98FC", VA = "0x2FF98FC")]
    public void SetPlaySpeed(float speed)
    {
    }

    [Token(Token = "0x6019542")]
    [Address(RVA = "0x2FF9A94", Offset = "0x2FF9A94", VA = "0x2FF9A94")]
    public int GetPlaySpeed() => new int();

    [Token(Token = "0x6019543")]
    [Address(RVA = "0x2FF9B24", Offset = "0x2FF9B24", VA = "0x2FF9B24")]
    public void SetPlayMode(Adv2Manager.ProgressMode playMode)
    {
    }

    [Token(Token = "0x6019544")]
    [Address(RVA = "0x2FF9BA0", Offset = "0x2FF9BA0", VA = "0x2FF9BA0")]
    public Adv2Manager.ProgressMode GetPlayMode() => new Adv2Manager.ProgressMode();

    [Token(Token = "0x6019545")]
    [Address(RVA = "0x2FF9C18", Offset = "0x2FF9C18", VA = "0x2FF9C18")]
    public void SetSettingAllFast(bool active)
    {
    }

    [Token(Token = "0x6019546")]
    [Address(RVA = "0x2FF9C98", Offset = "0x2FF9C98", VA = "0x2FF9C98")]
    public bool GetSettingAllFast() => new bool();

    [Token(Token = "0x6019547")]
    [Address(RVA = "0x2FF9D10", Offset = "0x2FF9D10", VA = "0x2FF9D10")]
    public void SetSettingAlreadyReadFast(bool active)
    {
    }

    [Token(Token = "0x6019548")]
    [Address(RVA = "0x2FF9D90", Offset = "0x2FF9D90", VA = "0x2FF9D90")]
    public bool GetSettingAlreadyReadFast() => new bool();

    [Token(Token = "0x6019549")]
    [Address(RVA = "0x2FF9E08", Offset = "0x2FF9E08", VA = "0x2FF9E08")]
    public bool IsAlreadyReadNow() => new bool();

    [Token(Token = "0x601954A")]
    [Address(RVA = "0x2FF9E80", Offset = "0x2FF9E80", VA = "0x2FF9E80")]
    public bool isPsBattleAdv() => new bool();

    [Token(Token = "0x601954B")]
    [Address(RVA = "0x2FF9EF8", Offset = "0x2FF9EF8", VA = "0x2FF9EF8")]
    public bool IsFastBattleAdv() => new bool();

    [Token(Token = "0x601954C")]
    [Address(RVA = "0x2FF9FA8", Offset = "0x2FF9FA8", VA = "0x2FF9FA8")]
    public bool IsBattleAdv() => new bool();

    [Token(Token = "0x601954D")]
    [Address(RVA = "0x2FF9FC4", Offset = "0x2FF9FC4", VA = "0x2FF9FC4")]
    public bool IsSkippableBattleAdv() => new bool();

    [Token(Token = "0x601954E")]
    [Address(RVA = "0x2FF9FE0", Offset = "0x2FF9FE0", VA = "0x2FF9FE0")]
    public bool IsPsBattleAdv() => new bool();

    [Token(Token = "0x601954F")]
    [Address(RVA = "0x2FF9FFC", Offset = "0x2FF9FFC", VA = "0x2FF9FFC")]
    public void SetDefaultPlaySpeed(bool flag)
    {
    }

    [Token(Token = "0x6019550")]
    [Address(RVA = "0x2FFA154", Offset = "0x2FFA154", VA = "0x2FFA154")]
    public bool GetDefaultPlaySpeed() => new bool();

    [Token(Token = "0x6019551")]
    [Address(RVA = "0x2FFA1CC", Offset = "0x2FFA1CC", VA = "0x2FFA1CC")]
    public void AdvOpenLog(bool openflag)
    {
    }

    [Token(Token = "0x6019552")]
    [Address(RVA = "0x2FFA1EC", Offset = "0x2FFA1EC", VA = "0x2FFA1EC")]
    public bool IsAdvLogMode() => new bool();

    [Token(Token = "0x6019553")]
    [Address(RVA = "0x2FFA208", Offset = "0x2FFA208", VA = "0x2FFA208")]
    public string GetLanguage() => (string) null;

    [Token(Token = "0x6019554")]
    [Address(RVA = "0x2FFA258", Offset = "0x2FFA258", VA = "0x2FFA258")]
    public void DebugLog(string message)
    {
    }

    [Token(Token = "0x6019555")]
    [Address(RVA = "0x2FFA25C", Offset = "0x2FFA25C", VA = "0x2FFA25C")]
    public bool CheckDebugMode() => new bool();

    [Token(Token = "0x6019556")]
    [Address(RVA = "0x2FFA2E0", Offset = "0x2FFA2E0", VA = "0x2FFA2E0")]
    public string GetScriptFileName() => (string) null;

    [Token(Token = "0x6019557")]
    [Address(RVA = "0x2FFA38C", Offset = "0x2FFA38C", VA = "0x2FFA38C")]
    public void SetActiveFreeMapTransitionAreaUnit(bool isView)
    {
    }

    [Token(Token = "0x6019558")]
    [Address(RVA = "0x2FFA3AC", Offset = "0x2FFA3AC", VA = "0x2FFA3AC")]
    public LuaSignal DebugPause() => (LuaSignal) null;

    [Token(Token = "0x6019559")]
    [Address(RVA = "0x2FFA468", Offset = "0x2FFA468", VA = "0x2FFA468")]
    public void BindTimelineSceneObject(string scenename)
    {
    }

    [Token(Token = "0x601955A")]
    [Address(RVA = "0x2FFA5CC", Offset = "0x2FFA5CC", VA = "0x2FFA5CC")]
    public LuaSignal PlayTimeline(string scenename) => (LuaSignal) null;

    [Token(Token = "0x601955B")]
    [Address(RVA = "0x2FFA67C", Offset = "0x2FFA67C", VA = "0x2FFA67C")]
    public void StopTimeline()
    {
    }

    [Token(Token = "0x601955C")]
    [Address(RVA = "0x2FFA6D8", Offset = "0x2FFA6D8", VA = "0x2FFA6D8")]
    public void PauseTimeline()
    {
    }

    [Token(Token = "0x601955D")]
    [Address(RVA = "0x2FFA734", Offset = "0x2FFA734", VA = "0x2FFA734")]
    public void ResumeTimeline()
    {
    }

    [Token(Token = "0x601955E")]
    [Address(RVA = "0x2FFA790", Offset = "0x2FFA790", VA = "0x2FFA790")]
    public bool IsPlayingTimeline() => new bool();

    [Token(Token = "0x601955F")]
    [Address(RVA = "0x2FFA7EC", Offset = "0x2FFA7EC", VA = "0x2FFA7EC")]
    public void Set3DRootActive(bool active)
    {
    }

    [Token(Token = "0x6019560")]
    [Address(RVA = "0x2FFA8A4", Offset = "0x2FFA8A4", VA = "0x2FFA8A4")]
    public void SetActiveSceneRootObject(string scenename, bool active)
    {
    }

    [Token(Token = "0x6019561")]
    [Address(RVA = "0x2FFA934", Offset = "0x2FFA934", VA = "0x2FFA934")]
    public void SetScriptEndFlag()
    {
    }

    [Token(Token = "0x6019562")]
    [Address(RVA = "0x2FFA994", Offset = "0x2FFA994", VA = "0x2FFA994")]
    public LuaSignal LoadScene(string sceneAssetbundleName, string sceneFileName)
    {
      return (LuaSignal) null;
    }

    [Token(Token = "0x6019563")]
    [Address(RVA = "0x2FFAAB0", Offset = "0x2FFAAB0", VA = "0x2FFAAB0")]
    public void ChangeScene(string scenename)
    {
    }

    [Token(Token = "0x6019564")]
    [Address(RVA = "0x2FFAB30", Offset = "0x2FFAB30", VA = "0x2FFAB30")]
    public void ChangeSceneWeather(int weather)
    {
    }

    [Token(Token = "0x6019565")]
    [Address(RVA = "0x2FFABB0", Offset = "0x2FFABB0", VA = "0x2FFABB0")]
    public int GetSequenceBackGround(int areaId) => new int();

    [Token(Token = "0x6019566")]
    [Address(RVA = "0x2FFAFD0", Offset = "0x2FFAFD0", VA = "0x2FFAFD0")]
    public LuaSignal LoadPlacement(string assetbundleName, string fileName) => (LuaSignal) null;

    [Token(Token = "0x6019567")]
    [Address(RVA = "0x2FFB070", Offset = "0x2FFB070", VA = "0x2FFB070")]
    public LuaUI LoadUI(string assetbundleName, string fileName, int siblingIndex) => (LuaUI) null;

    [Token(Token = "0x6019568")]
    [Address(RVA = "0x2FFB1E8", Offset = "0x2FFB1E8", VA = "0x2FFB1E8")]
    public LuaUI LoadUIToRootCanvas(string assetbundleName, string fileName, int siblingIndex)
    {
      return (LuaUI) null;
    }

    [Token(Token = "0x6019569")]
    [Address(RVA = "0x2FFB378", Offset = "0x2FFB378", VA = "0x2FFB378")]
    public LuaUI LoadUIToBack(string assetbundleName, string fileName, int siblingIndex)
    {
      return (LuaUI) null;
    }

    [Token(Token = "0x601956A")]
    [Address(RVA = "0x2FFB4F0", Offset = "0x2FFB4F0", VA = "0x2FFB4F0")]
    public LuaUI LoadUIToFront(string assetbundleName, string fileName, int siblingIndex)
    {
      return (LuaUI) null;
    }

    [Token(Token = "0x601956B")]
    [Address(RVA = "0x2FFB668", Offset = "0x2FFB668", VA = "0x2FFB668")]
    public LuaUI LoadUIToRoot(string assetbundleName, string fileName) => (LuaUI) null;

    [Token(Token = "0x601956C")]
    [Address(RVA = "0x2FFB7EC", Offset = "0x2FFB7EC", VA = "0x2FFB7EC")]
    public LuaUI LoadUIToTutorialRoot(string assetbundleName, string fileName) => (LuaUI) null;

    [Token(Token = "0x601956D")]
    [Address(RVA = "0x2FFB960", Offset = "0x2FFB960", VA = "0x2FFB960")]
    public LuaUI LoadUIToTutorial(string assetbundleName, string fileName) => (LuaUI) null;

    [Token(Token = "0x601956E")]
    [Address(RVA = "0x2FFBAD4", Offset = "0x2FFBAD4", VA = "0x2FFBAD4")]
    public LuaUI LoadUIToTextBoxAnchor(string assetbundleName, string fileName, int siblingIndex)
    {
      return (LuaUI) null;
    }

    [Token(Token = "0x601956F")]
    [Address(RVA = "0x2FFBD50", Offset = "0x2FFBD50", VA = "0x2FFBD50")]
    public LuaUI LinkUI(string objectName, int siblingIndex) => (LuaUI) null;

    [Token(Token = "0x6019570")]
    [Address(RVA = "0x2FFBE9C", Offset = "0x2FFBE9C", VA = "0x2FFBE9C")]
    public LuaUI LinkFrontUI(string objectName, int siblingIndex) => (LuaUI) null;

    [Token(Token = "0x6019571")]
    [Address(RVA = "0x2FFBFE8", Offset = "0x2FFBFE8", VA = "0x2FFBFE8")]
    public LuaMovieDirector LoadMovieDirector() => (LuaMovieDirector) null;

    [Token(Token = "0x6019572")]
    [Address(RVA = "0x2FFC290", Offset = "0x2FFC290", VA = "0x2FFC290")]
    public LuaSignal OpenSystemMenu(string type) => (LuaSignal) null;

    [Token(Token = "0x6019573")]
    [Address(RVA = "0x2FFC30C", Offset = "0x2FFC30C", VA = "0x2FFC30C")]
    public void OpenHome()
    {
    }

    [Token(Token = "0x6019574")]
    [Address(RVA = "0x2FFC390", Offset = "0x2FFC390", VA = "0x2FFC390")]
    private IEnumerator coOpenHome() => (IEnumerator) null;

    [Token(Token = "0x6019575")]
    [Address(RVA = "0x2FFC3F0", Offset = "0x2FFC3F0", VA = "0x2FFC3F0")]
    public bool IsPreHomeAdvSituation() => new bool();

    [Token(Token = "0x6019576")]
    [Address(RVA = "0x2FFC450", Offset = "0x2FFC450", VA = "0x2FFC450")]
    public void OpenSkip()
    {
    }

    [Token(Token = "0x6019577")]
    [Address(RVA = "0x2FFC4D4", Offset = "0x2FFC4D4", VA = "0x2FFC4D4")]
    private IEnumerator coOpenSkip() => (IEnumerator) null;

    [Token(Token = "0x6019578")]
    [Address(RVA = "0x2FFC534", Offset = "0x2FFC534", VA = "0x2FFC534")]
    public LuaSignalMini OpenGlobalMenu() => (LuaSignalMini) null;

    [Token(Token = "0x6019579")]
    [Address(RVA = "0x2FFC7BC", Offset = "0x2FFC7BC", VA = "0x2FFC7BC")]
    public LuaPersonalUp LoadPersonalUp(string assetbundleName, string fileName)
    {
      return (LuaPersonalUp) null;
    }

    [Token(Token = "0x601957A")]
    [Address(RVA = "0x2FFC8F0", Offset = "0x2FFC8F0", VA = "0x2FFC8F0")]
    public LuaFriendshipUp LoadFriendshipUp(string assetbundleName, string fileName)
    {
      return (LuaFriendshipUp) null;
    }

    [Token(Token = "0x601957B")]
    [Address(RVA = "0x2FFCA24", Offset = "0x2FFCA24", VA = "0x2FFCA24")]
    public LuaUI LoadTrustUp(string assetbundleName, string fileName) => (LuaUI) null;

    [Token(Token = "0x601957C")]
    [Address(RVA = "0x2FFCBA8", Offset = "0x2FFCBA8", VA = "0x2FFCBA8")]
    public LuaUI LoadTrustRelease(string assetbundleName, string fileName) => (LuaUI) null;

    [Token(Token = "0x601957D")]
    [Address(RVA = "0x2FFCD2C", Offset = "0x2FFCD2C", VA = "0x2FFCD2C")]
    public LuaTrustResultUI LoadTrustResultUI(string assetbundleName, string fileName)
    {
      return (LuaTrustResultUI) null;
    }

    [Token(Token = "0x601957E")]
    [Address(RVA = "0x2FFCE1C", Offset = "0x2FFCE1C", VA = "0x2FFCE1C")]
    public LuaParameterUpResultUI LoadParameterUpResult(
      string mainAssetbundleName,
      string mainFileName,
      string dialogAssetbundleName,
      string dialogFileName)
    {
      return (LuaParameterUpResultUI) null;
    }

    [Token(Token = "0x601957F")]
    [Address(RVA = "0x2FFCFB0", Offset = "0x2FFCFB0", VA = "0x2FFCFB0")]
    public Lua1stAppearanceUI Load1StAppeaerance(
      string assetbundleName,
      string fileName,
      int siblingIndex)
    {
      return (Lua1stAppearanceUI) null;
    }

    [Token(Token = "0x6019580")]
    [Address(RVA = "0x2FFD124", Offset = "0x2FFD124", VA = "0x2FFD124")]
    public Adv2LuaUIShader LoadUIShader(string assetbundleName, string fileName, int siblingIndex)
    {
      return (Adv2LuaUIShader) null;
    }

    [Token(Token = "0x6019581")]
    [Address(RVA = "0x2FFD288", Offset = "0x2FFD288", VA = "0x2FFD288")]
    public Adv2LuaPopupReward OpenPopupReward() => (Adv2LuaPopupReward) null;

    [Token(Token = "0x6019582")]
    [Address(RVA = "0x2FFD31C", Offset = "0x2FFD31C", VA = "0x2FFD31C")]
    public void Adv2SystemDeactive()
    {
    }

    [Token(Token = "0x6019583")]
    [Address(RVA = "0x2FFD338", Offset = "0x2FFD338", VA = "0x2FFD338")]
    public void Adv2SystemActive()
    {
    }

    [Token(Token = "0x6019584")]
    [Address(RVA = "0x2FFD354", Offset = "0x2FFD354", VA = "0x2FFD354")]
    public LuaSignal InitializeBranchSelect(int[] selectableStyleIds) => (LuaSignal) null;

    [Token(Token = "0x6019585")]
    [Address(RVA = "0x2FFD504", Offset = "0x2FFD504", VA = "0x2FFD504")]
    public LuaSignal PrePlayBranchSelect() => (LuaSignal) null;

    [Token(Token = "0x6019586")]
    [Address(RVA = "0x2FFD660", Offset = "0x2FFD660", VA = "0x2FFD660")]
    public LuaSignal PlayBranchSelect() => (LuaSignal) null;

    [Token(Token = "0x6019587")]
    [Address(RVA = "0x2FFD7BC", Offset = "0x2FFD7BC", VA = "0x2FFD7BC")]
    public int GetSelectedStyleId() => new int();

    [Token(Token = "0x6019588")]
    [Address(RVA = "0x2FFD8B4", Offset = "0x2FFD8B4", VA = "0x2FFD8B4")]
    public void SetActiveOptionOne(int number)
    {
    }

    [Token(Token = "0x6019589")]
    [Address(RVA = "0x2FFD8DC", Offset = "0x2FFD8DC", VA = "0x2FFD8DC")]
    public LuaSignal InitializeMA0010023(int charaId) => (LuaSignal) null;

    [Token(Token = "0x601958A")]
    [Address(RVA = "0x2FFDA40", Offset = "0x2FFDA40", VA = "0x2FFDA40")]
    private IEnumerator MA0010023InitializeFromAdv(
      MA_00100_23_Manager MA0010023Manager,
      int charaId,
      Adv2Manager.OnProccessSignal onProccessSignal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601958B")]
    [Address(RVA = "0x2FFDABC", Offset = "0x2FFDABC", VA = "0x2FFDABC")]
    public void AddLog(
      int WinType,
      string TalkerTag,
      string ThumbImageTag,
      string Message,
      string VoiceTag)
    {
    }

    [Token(Token = "0x601958C")]
    [Address(RVA = "0x2FFDD48", Offset = "0x2FFDD48", VA = "0x2FFDD48")]
    public void OnSelectStartTiming()
    {
    }

    [Token(Token = "0x601958D")]
    [Address(RVA = "0x2FFDD64", Offset = "0x2FFDD64", VA = "0x2FFDD64")]
    public void SetAlreadyReadChoices(string messageId)
    {
    }

    [Token(Token = "0x601958E")]
    [Address(RVA = "0x2FFDD80", Offset = "0x2FFDD80", VA = "0x2FFDD80")]
    public bool IsAlreadyReadChoices(string messageId) => new bool();

    [Token(Token = "0x601958F")]
    [Address(RVA = "0x2FFDD9C", Offset = "0x2FFDD9C", VA = "0x2FFDD9C")]
    public bool GetOptionCharacterActive(string messageId, int characterId) => new bool();

    [Token(Token = "0x6019590")]
    [Address(RVA = "0x2FFDDC8", Offset = "0x2FFDDC8", VA = "0x2FFDDC8")]
    public LuaEffectPostProcess LoadPostEffect(
      string assetbundleName,
      string fileName,
      string layerName = null)
    {
      return (LuaEffectPostProcess) null;
    }

    [Token(Token = "0x6019591")]
    [Address(RVA = "0x2FFDEC8", Offset = "0x2FFDEC8", VA = "0x2FFDEC8")]
    public LuaFogControl CreateFogController() => (LuaFogControl) null;

    [Token(Token = "0x6019592")]
    [Address(RVA = "0x2FFDF48", Offset = "0x2FFDF48", VA = "0x2FFDF48")]
    public LuaSignal LoadHavingChapterItemResource() => (LuaSignal) null;

    [Token(Token = "0x6019593")]
    [Address(RVA = "0x2FFE390", Offset = "0x2FFE390", VA = "0x2FFE390")]
    public LuaSignal LoadStackObject(string stackTag, string assetbundleName, string fileName)
    {
      return (LuaSignal) null;
    }

    [Token(Token = "0x6019594")]
    [Address(RVA = "0x2FFE440", Offset = "0x2FFE440", VA = "0x2FFE440")]
    public LuaSignal LoadAsset(string assetbundleName, string fileName) => (LuaSignal) null;

    [Token(Token = "0x6019595")]
    [Address(RVA = "0x2FFE4F4", Offset = "0x2FFE4F4", VA = "0x2FFE4F4")]
    public LuaSignal LoadIllustLayoutInfo(LuaObject character, int styleId) => (LuaSignal) null;

    [Token(Token = "0x6019596")]
    [Address(RVA = "0x2FFE62C", Offset = "0x2FFE62C", VA = "0x2FFE62C")]
    public void RemoveStackObject(string stackTag)
    {
    }

    [Token(Token = "0x6019597")]
    [Address(RVA = "0x2FFE6E8", Offset = "0x2FFE6E8", VA = "0x2FFE6E8")]
    public LuaSignal LoadStackImage(string stackTag, string assetbundleName, string fileName)
    {
      return (LuaSignal) null;
    }

    [Token(Token = "0x6019598")]
    [Address(RVA = "0x2FFE798", Offset = "0x2FFE798", VA = "0x2FFE798")]
    public LuaSignal LoadPsBattleAdvObj(string assetbundleName, string fileName)
    {
      return (LuaSignal) null;
    }

    [Token(Token = "0x6019599")]
    [Address(RVA = "0x2FFE838", Offset = "0x2FFE838", VA = "0x2FFE838")]
    public LuaPsBattleAdv LoadBattleMap(string mapname, string mapdata) => (LuaPsBattleAdv) null;

    [Token(Token = "0x601959A")]
    [Address(RVA = "0x2FFE8E8", Offset = "0x2FFE8E8", VA = "0x2FFE8E8")]
    public bool IsFinishedIntroduction() => new bool();

    [Token(Token = "0x601959B")]
    [Address(RVA = "0x2FFE948", Offset = "0x2FFE948", VA = "0x2FFE948")]
    public LuaBattleAdv CreateBattleAdv() => (LuaBattleAdv) null;

    [Token(Token = "0x601959C")]
    [Address(RVA = "0x2FFE9A4", Offset = "0x2FFE9A4", VA = "0x2FFE9A4")]
    public void AddCoroutine(DynValue coroutine)
    {
    }

    [Token(Token = "0x601959D")]
    [Address(RVA = "0x2FFEA44", Offset = "0x2FFEA44", VA = "0x2FFEA44")]
    public void AddReserveDemo(string demoName)
    {
    }

    [Token(Token = "0x601959E")]
    [Address(RVA = "0x2FFEAC4", Offset = "0x2FFEAC4", VA = "0x2FFEAC4")]
    public void FadeIn(float duration)
    {
    }

    [Token(Token = "0x601959F")]
    [Address(RVA = "0x2FFEBCC", Offset = "0x2FFEBCC", VA = "0x2FFEBCC")]
    public void FadeOut(float r, float g, float b, float a, float duration)
    {
    }

    [Token(Token = "0x60195A0")]
    [Address(RVA = "0x2FFED0C", Offset = "0x2FFED0C", VA = "0x2FFED0C")]
    public void TransitionOut()
    {
    }

    [Token(Token = "0x60195A1")]
    [Address(RVA = "0x2FFEDE0", Offset = "0x2FFEDE0", VA = "0x2FFEDE0")]
    public void TransitionIn()
    {
    }

    [Token(Token = "0x60195A2")]
    [Address(RVA = "0x2FFEEB8", Offset = "0x2FFEEB8", VA = "0x2FFEEB8")]
    public void LoadSoundFile(string fileName)
    {
    }

    [Token(Token = "0x60195A3")]
    [Address(RVA = "0x2FFDC70", Offset = "0x2FFDC70", VA = "0x2FFDC70")]
    public string GetMessageText(string messageTag) => (string) null;

    [Token(Token = "0x60195A4")]
    [Address(RVA = "0x2FFEF38", Offset = "0x2FFEF38", VA = "0x2FFEF38")]
    public string GetVoiceTag(string messageTag) => (string) null;

    [Token(Token = "0x60195A5")]
    [Address(RVA = "0x2FFF010", Offset = "0x2FFF010", VA = "0x2FFF010")]
    public void DispCalendar(bool dispflag)
    {
    }

    [Token(Token = "0x60195A6")]
    [Address(RVA = "0x2FFF108", Offset = "0x2FFF108", VA = "0x2FFF108")]
    public void SetActiveSceneLightEffectParameter(
      float? bgParametersHardlightBlend,
      string bgParametersHardlightColorCode,
      string lightForChrarctersDirectionTypeName,
      float? lightForChrarctersIntensity,
      float? screenGradationIntensity)
    {
    }

    [Token(Token = "0x60195A7")]
    [Address(RVA = "0x2FFF2FC", Offset = "0x2FFF2FC", VA = "0x2FFF2FC")]
    public void SetActiveSceneVignetteEffect(
      float centerX,
      float centerY,
      string colorCode,
      float intensity,
      float smoothness,
      bool rounded)
    {
    }

    [Token(Token = "0x60195A8")]
    [Address(RVA = "0x2FFF3E0", Offset = "0x2FFF3E0", VA = "0x2FFF3E0")]
    public void SetLightEffectParameter(
      string cameraName,
      float? bgParametersHardlightBlend,
      string bgParametersHardlightColorCode,
      string lightForChrarctersDirectionTypeName,
      float? lightForChrarctersIntensity,
      float? screenGradationIntensity)
    {
    }

    [Token(Token = "0x60195A9")]
    [Address(RVA = "0x2FFF634", Offset = "0x2FFF634", VA = "0x2FFF634")]
    public void SetVignetteEffect(
      string cameraName,
      float centerX,
      float centerY,
      string colorCode,
      float intensity,
      float smoothness,
      bool rounded)
    {
    }

    [Token(Token = "0x60195AA")]
    [Address(RVA = "0x2FFF83C", Offset = "0x2FFF83C", VA = "0x2FFF83C")]
    public void DisableVignetteEffect(string cameraName)
    {
    }

    [Token(Token = "0x60195AB")]
    [Address(RVA = "0x2FFF9E8", Offset = "0x2FFF9E8", VA = "0x2FFF9E8")]
    public LuaSequence.SoundSignal GetSoundSignal(LuaSignalMini signal)
    {
      return (LuaSequence.SoundSignal) null;
    }

    [Token(Token = "0x60195AC")]
    [Address(RVA = "0x2FFFA68", Offset = "0x2FFFA68", VA = "0x2FFFA68")]
    public LuaSignalMini PlayBGM(string resourceName, float fadeDuration) => (LuaSignalMini) null;

    [Token(Token = "0x60195AD")]
    [Address(RVA = "0x2FFFC08", Offset = "0x2FFFC08", VA = "0x2FFFC08")]
    public void PlayEnvSe(bool flag)
    {
    }

    [Token(Token = "0x60195AE")]
    [Address(RVA = "0x2FFFC88", Offset = "0x2FFFC88", VA = "0x2FFFC88")]
    public LuaSignalMini PlaySE(string resourceName) => (LuaSignalMini) null;

    [Token(Token = "0x60195AF")]
    [Address(RVA = "0x2FFFEB8", Offset = "0x2FFFEB8", VA = "0x2FFFEB8")]
    public LuaSignalMini PlayVoice(string resourceName) => (LuaSignalMini) null;

    [Token(Token = "0x60195B0")]
    [Address(RVA = "0x300006C", Offset = "0x300006C", VA = "0x300006C")]
    public void StopBGM(LuaSignalMini signal, float fadeDuration)
    {
    }

    [Token(Token = "0x60195B1")]
    [Address(RVA = "0x3000154", Offset = "0x3000154", VA = "0x3000154")]
    public void StopSE(LuaSignalMini signal)
    {
    }

    [Token(Token = "0x60195B2")]
    [Address(RVA = "0x3000238", Offset = "0x3000238", VA = "0x3000238")]
    public void StopVoice(LuaSignalMini signal)
    {
    }

    [Token(Token = "0x60195B3")]
    [Address(RVA = "0x300031C", Offset = "0x300031C", VA = "0x300031C")]
    public void StopVoiceAll()
    {
    }

    [Token(Token = "0x60195B4")]
    [Address(RVA = "0x300039C", Offset = "0x300039C", VA = "0x300039C")]
    public LuaSequence.ActiveOptionInfo[] CreateActiveOptionInfo(bool validLock)
    {
      return (LuaSequence.ActiveOptionInfo[]) null;
    }

    [Token(Token = "0x60195B5")]
    [Address(RVA = "0x30008D0", Offset = "0x30008D0", VA = "0x30008D0")]
    public string GetActiveOptionOneText(int index) => (string) null;

    [Token(Token = "0x60195B6")]
    [Address(RVA = "0x30009D8", Offset = "0x30009D8", VA = "0x30009D8")]
    public void SetLockState()
    {
    }

    [Token(Token = "0x60195B7")]
    [Address(RVA = "0x3000A50", Offset = "0x3000A50", VA = "0x3000A50")]
    public int GetActiveOptionState(int index) => new int();

    [Token(Token = "0x60195B8")]
    [Address(RVA = "0x3000BB0", Offset = "0x3000BB0", VA = "0x3000BB0")]
    public bool IsActiveSelectedOptionOne(int index) => new bool();

    [Token(Token = "0x60195B9")]
    [Address(RVA = "0x3000D00", Offset = "0x3000D00", VA = "0x3000D00")]
    public bool IsActiveOption(string[] textTags) => new bool();

    [Token(Token = "0x60195BA")]
    [Address(RVA = "0x3000E88", Offset = "0x3000E88", VA = "0x3000E88")]
    public bool GetActiveOptionLockIsOr(int closedIndex) => new bool();

    [Token(Token = "0x60195BB")]
    [Address(RVA = "0x30011D4", Offset = "0x30011D4", VA = "0x30011D4")]
    public LuaSequence.LockOneState[] GetActiveOptionLockOneStates(int index)
    {
      return (LuaSequence.LockOneState[]) null;
    }

    [Token(Token = "0x60195BC")]
    [Address(RVA = "0x3001564", Offset = "0x3001564", VA = "0x3001564")]
    public LuaSequence.LockOneState[] GetActiveOptionLockState(int closedIndex)
    {
      return (LuaSequence.LockOneState[]) null;
    }

    [Token(Token = "0x60195BD")]
    [Address(RVA = "0x3001A78", Offset = "0x3001A78", VA = "0x3001A78")]
    public CommunicationLuaFunction.Object GetCommu() => (CommunicationLuaFunction.Object) null;

    [Token(Token = "0x60195BE")]
    [Address(RVA = "0x3001B38", Offset = "0x3001B38", VA = "0x3001B38")]
    private AdvStageFacility GetFacilityStage() => (AdvStageFacility) null;

    [Token(Token = "0x60195BF")]
    [Address(RVA = "0x3001BFC", Offset = "0x3001BFC", VA = "0x3001BFC")]
    public LuaFunction.Object GetFacilityObject() => (LuaFunction.Object) null;

    [Token(Token = "0x60195C0")]
    [Address(RVA = "0x3001C20", Offset = "0x3001C20", VA = "0x3001C20")]
    public AreaEventQuestLuaFunction.Object GetAreaEventQuestObject()
    {
      return (AreaEventQuestLuaFunction.Object) null;
    }

    [Token(Token = "0x60195C1")]
    [Address(RVA = "0x3001CE8", Offset = "0x3001CE8", VA = "0x3001CE8")]
    public LuaSubQuestPopup SubQuestPopup(int subquestTaskID) => (LuaSubQuestPopup) null;

    [Token(Token = "0x60195C2")]
    [Address(RVA = "0x3001D4C", Offset = "0x3001D4C", VA = "0x3001D4C")]
    public SubQuestLuaFunction.Object GetSubQuestObject() => (SubQuestLuaFunction.Object) null;

    [Token(Token = "0x60195C3")]
    [Address(RVA = "0x3001E14", Offset = "0x3001E14", VA = "0x3001E14")]
    public ReadBookAdvLuaFunction.Object GetStoryMainQuestReadBookObject()
    {
      return (ReadBookAdvLuaFunction.Object) null;
    }

    [Token(Token = "0x60195C4")]
    [Address(RVA = "0x3001EDC", Offset = "0x3001EDC", VA = "0x3001EDC")]
    public static LuaRewardItem[] GetStudyRewardItems() => (LuaRewardItem[]) null;

    [Token(Token = "0x60195C5")]
    [Address(RVA = "0x30021F4", Offset = "0x30021F4", VA = "0x30021F4")]
    public void Cancel()
    {
    }

    [Token(Token = "0x60195C6")]
    [Address(RVA = "0x30022C8", Offset = "0x30022C8", VA = "0x30022C8")]
    public void CancelFacility()
    {
    }

    [Token(Token = "0x60195C7")]
    [Address(RVA = "0x30023A8", Offset = "0x30023A8", VA = "0x30023A8")]
    public void SelectMenuItem(int menuID)
    {
    }

    [Token(Token = "0x60195C8")]
    [Address(RVA = "0x3002428", Offset = "0x3002428", VA = "0x3002428")]
    public void SetSelectedKey(int order)
    {
    }

    [Token(Token = "0x60195C9")]
    [Address(RVA = "0x30024EC", Offset = "0x30024EC", VA = "0x30024EC")]
    public string GetComuRankUpRewardName(int index) => (string) null;

    [Token(Token = "0x60195CA")]
    [Address(RVA = "0x300258C", Offset = "0x300258C", VA = "0x300258C")]
    public string GetComuRankUpRewardInfo(int idx) => (string) null;

    [Token(Token = "0x60195CB")]
    [Address(RVA = "0x3002640", Offset = "0x3002640", VA = "0x3002640")]
    public bool ProcessingChangeScene() => new bool();

    [Token(Token = "0x60195CC")]
    [Address(RVA = "0x30026B8", Offset = "0x30026B8", VA = "0x30026B8")]
    public void ActiveTutorialCanvas()
    {
    }

    [Token(Token = "0x60195CD")]
    [Address(RVA = "0x30026D4", Offset = "0x30026D4", VA = "0x30026D4")]
    public bool IsReadedBackHomeTutorial() => new bool();

    [Token(Token = "0x60195CE")]
    [Address(RVA = "0x30026F0", Offset = "0x30026F0", VA = "0x30026F0")]
    public void SetReadedBackHomeTutorial()
    {
    }

    [Token(Token = "0x60195CF")]
    [Address(RVA = "0x300270C", Offset = "0x300270C", VA = "0x300270C")]
    public void SetTutorialNextSequence()
    {
    }

    [Token(Token = "0x60195D0")]
    [Address(RVA = "0x3002728", Offset = "0x3002728", VA = "0x3002728")]
    public void SetEnableBackKeyTutorial(bool isEnable)
    {
    }

    [Token(Token = "0x60195D1")]
    [Address(RVA = "0x3002748", Offset = "0x3002748", VA = "0x3002748")]
    public LuaSignalMini AddTutorialButtonEvent(string accesserName) => (LuaSignalMini) null;

    [Token(Token = "0x60195D2")]
    [Address(RVA = "0x3002764", Offset = "0x3002764", VA = "0x3002764")]
    public void RemoveTutorialButtonEvent()
    {
    }

    [Token(Token = "0x60195D3")]
    [Address(RVA = "0x3002780", Offset = "0x3002780", VA = "0x3002780")]
    public void SetDisableScroll(string accesserName)
    {
    }

    [Token(Token = "0x60195D4")]
    [Address(RVA = "0x3002800", Offset = "0x3002800", VA = "0x3002800")]
    public void SetDisableCommonGesture(string accesserName)
    {
    }

    [Token(Token = "0x60195D5")]
    [Address(RVA = "0x3002880", Offset = "0x3002880", VA = "0x3002880")]
    public LuaSignalMini AddTutorialButtonEventStyleThumb(string accesserName, int styleId)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x60195D6")]
    [Address(RVA = "0x3002930", Offset = "0x3002930", VA = "0x3002930")]
    public LuaSignalMini AddTutorialButtonEventExpeditionFieldBanner(
      string accesserName,
      int stageId)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x60195D7")]
    [Address(RVA = "0x30029E0", Offset = "0x30029E0", VA = "0x30029E0")]
    public LuaSignalMini AddTutorialButtonEventExpeditionBossList(
      string accesserName,
      int bossId,
      string objectName)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x60195D8")]
    [Address(RVA = "0x3002AC4", Offset = "0x3002AC4", VA = "0x3002AC4")]
    public void SetInteractableButton(string accesserName, bool interactable)
    {
    }

    [Token(Token = "0x60195D9")]
    [Address(RVA = "0x3002AE4", Offset = "0x3002AE4", VA = "0x3002AE4")]
    public bool IsPlayingUIAnimation(string accesserName) => new bool();

    [Token(Token = "0x60195DA")]
    [Address(RVA = "0x3002B00", Offset = "0x3002B00", VA = "0x3002B00")]
    public bool GetTutorialEvent(string eventName) => new bool();

    [Token(Token = "0x60195DB")]
    [Address(RVA = "0x3002B1C", Offset = "0x3002B1C", VA = "0x3002B1C")]
    public bool IsAccesserExist(string accesserName, bool activeOnly) => new bool();

    [Token(Token = "0x60195DC")]
    [Address(RVA = "0x3002B3C", Offset = "0x3002B3C", VA = "0x3002B3C")]
    public bool IsPlayGacha(string accesserName) => new bool();

    [Token(Token = "0x60195DD")]
    [Address(RVA = "0x3002C2C", Offset = "0x3002C2C", VA = "0x3002C2C")]
    public void RegisterGachaCameraTutorialCamera(string accesserName)
    {
    }

    [Token(Token = "0x60195DE")]
    [Address(RVA = "0x3002D80", Offset = "0x3002D80", VA = "0x3002D80")]
    public bool HasPreset_ForTutorial() => new bool();

    [Token(Token = "0x60195DF")]
    [Address(RVA = "0x3002D9C", Offset = "0x3002D9C", VA = "0x3002D9C")]
    public bool HasStyle(int styleId) => new bool();

    [Token(Token = "0x60195E0")]
    [Address(RVA = "0x3002DB8", Offset = "0x3002DB8", VA = "0x3002DB8")]
    public bool ChangeExpeditionParty() => new bool();

    [Token(Token = "0x60195E1")]
    [Address(RVA = "0x3002DD4", Offset = "0x3002DD4", VA = "0x3002DD4")]
    public bool HasTwoHourExpeditionRapidTicket() => new bool();

    [Token(Token = "0x60195E2")]
    [Address(RVA = "0x3002DF0", Offset = "0x3002DF0", VA = "0x3002DF0")]
    public int GetExpeditionBossLevel(int stageId) => new int();

    [Token(Token = "0x60195E3")]
    [Address(RVA = "0x3002E0C", Offset = "0x3002E0C", VA = "0x3002E0C")]
    public Adv2BookListWithTab InitializeBookListWithTab() => (Adv2BookListWithTab) null;

    [Token(Token = "0x60195E4")]
    [Address(RVA = "0x3002E68", Offset = "0x3002E68", VA = "0x3002E68")]
    public Adv2LuaBookListNoTab InitializeBookList() => (Adv2LuaBookListNoTab) null;

    [Token(Token = "0x60195E5")]
    [Address(RVA = "0x3002EC4", Offset = "0x3002EC4", VA = "0x3002EC4")]
    public Adv2LuaBookPopup InitializeBookPopup() => (Adv2LuaBookPopup) null;

    [Token(Token = "0x60195E6")]
    [Address(RVA = "0x3002F58", Offset = "0x3002F58", VA = "0x3002F58")]
    public Adv2LuaBookReturnPopup InitializeBookReturnPopup() => (Adv2LuaBookReturnPopup) null;

    [Token(Token = "0x2003EC8")]
    public class SoundSignal : Adv2Manager.OnProccessSignal
    {
      [Token(Token = "0x401135E")]
      [FieldOffset(Offset = "0x14")]
      private float minVolume;
      [Token(Token = "0x401135F")]
      [FieldOffset(Offset = "0x18")]
      protected uint playingID;

      [Token(Token = "0x170051E0")]
      public uint PlayingID
      {
        [Token(Token = "0x60195E7"), Address(RVA = "0x3002FEC", Offset = "0x3002FEC", VA = "0x3002FEC")] get
        {
          return new uint();
        }
      }

      [Token(Token = "0x60195E8")]
      [Address(RVA = "0x3002FF4", Offset = "0x3002FF4", VA = "0x3002FF4")]
      public SoundSignal(uint id)
      {
      }

      [Token(Token = "0x60195E9")]
      [Address(RVA = "0x2FFFB54", Offset = "0x2FFFB54", VA = "0x2FFFB54")]
      public static LuaSignalMini Create(uint playingID) => (LuaSignalMini) null;

      [Token(Token = "0x60195EA")]
      [Address(RVA = "0x2FFFE28", Offset = "0x2FFFE28", VA = "0x2FFFE28")]
      public SoundSignal()
      {
      }

      [Token(Token = "0x60195EB")]
      [Address(RVA = "0x2FFFFEC", Offset = "0x2FFFFEC", VA = "0x2FFFFEC")]
      public LuaSignalMini VoiceCreate(uint playingID) => (LuaSignalMini) null;

      [Token(Token = "0x60195EC")]
      [Address(RVA = "0x2FFFE30", Offset = "0x2FFFE30", VA = "0x2FFFE30")]
      public LuaSignalMini SeCreate(uint playingID) => (LuaSignalMini) null;

      [Token(Token = "0x60195ED")]
      [Address(RVA = "0x30030D8", Offset = "0x30030D8", VA = "0x30030D8")]
      public void EndCallback()
      {
      }

      [Token(Token = "0x60195EE")]
      [Address(RVA = "0x300301C", Offset = "0x300301C", VA = "0x300301C")]
      private void SetMinVolume(uint playingID)
      {
      }

      [Token(Token = "0x60195EF")]
      [Address(RVA = "0x30030E8", Offset = "0x30030E8", VA = "0x30030E8")]
      public bool IsVolumeMute() => new bool();
    }

    [Token(Token = "0x2003EC9")]
    [MoonSharpUserData]
    public class ActiveOptionInfo
    {
      [Token(Token = "0x4011360")]
      [FieldOffset(Offset = "0x10")]
      public string TextValue;
      [Token(Token = "0x4011361")]
      [FieldOffset(Offset = "0x18")]
      public int IntValue;

      [Token(Token = "0x60195F0")]
      [Address(RVA = "0x3000878", Offset = "0x3000878", VA = "0x3000878")]
      public ActiveOptionInfo()
      {
      }
    }

    [Token(Token = "0x2003ECA")]
    [MoonSharpUserData]
    public class LockOneState
    {
      [Token(Token = "0x4011362")]
      [FieldOffset(Offset = "0x10")]
      public bool IsSuccess;
      [Token(Token = "0x4011363")]
      [FieldOffset(Offset = "0x18")]
      public string Text;

      [Token(Token = "0x60195F1")]
      [Address(RVA = "0x300155C", Offset = "0x300155C", VA = "0x300155C")]
      public LockOneState()
      {
      }
    }

    [Token(Token = "0x2003ECB")]
    public class ParamControl
    {
      [Token(Token = "0x60195F2")]
      [Address(RVA = "0x30031A8", Offset = "0x30031A8", VA = "0x30031A8")]
      public int GetInt(string variableName) => new int();

      [Token(Token = "0x60195F3")]
      [Address(RVA = "0x30032BC", Offset = "0x30032BC", VA = "0x30032BC")]
      public void SetInt(string variableName, int value)
      {
      }

      [Token(Token = "0x60195F4")]
      [Address(RVA = "0x30033E4", Offset = "0x30033E4", VA = "0x30033E4")]
      private static int GetRewardPriority(RewardTypeEnum reward) => new int();

      [Token(Token = "0x60195F5")]
      [Address(RVA = "0x3003750", Offset = "0x3003750", VA = "0x3003750")]
      public LuaSequence.ParamControl.ComuParam SetCommunicationInAcquired(
        string comuRankName,
        string comuPointName)
      {
        return (LuaSequence.ParamControl.ComuParam) null;
      }

      [Token(Token = "0x60195F6")]
      [Address(RVA = "0x3003C30", Offset = "0x3003C30", VA = "0x3003C30")]
      public LuaSequence.ParamControl.ComuParam SetCommunicationInIntro(
        string comuRankName,
        string comuPointName)
      {
        return (LuaSequence.ParamControl.ComuParam) null;
      }

      [Token(Token = "0x60195F7")]
      [Address(RVA = "0x3003CA0", Offset = "0x3003CA0", VA = "0x3003CA0")]
      public LuaSequence.ParamControl.ComuParam SetCommunicationInNormal(
        string comuRankName,
        string comuPointName)
      {
        return (LuaSequence.ParamControl.ComuParam) null;
      }

      [Token(Token = "0x60195F8")]
      [Address(RVA = "0x3003D10", Offset = "0x3003D10", VA = "0x3003D10")]
      public LuaSequence.ParamControl.ComuParam SetCommunicationInRankup(
        string comuRankName,
        string comuPointName)
      {
        return (LuaSequence.ParamControl.ComuParam) null;
      }

      [Token(Token = "0x60195F9")]
      [Address(RVA = "0x3003D80", Offset = "0x3003D80", VA = "0x3003D80")]
      public LuaSequence.ParamControl.FacilityParam SetFacility(
        int dummyAttachID,
        int dummyRewardSetLabelID,
        int dummyBonusSetLabelID,
        bool isBonusWeather)
      {
        return (LuaSequence.ParamControl.FacilityParam) null;
      }

      [Token(Token = "0x60195FA")]
      [Address(RVA = "0x30042C4", Offset = "0x30042C4", VA = "0x30042C4")]
      public LuaSequence.ParamControl.HumanParameter SetHumanParameter(string[] variableNames)
      {
        return (LuaSequence.ParamControl.HumanParameter) null;
      }

      [Token(Token = "0x60195FB")]
      [Address(RVA = "0x3004BA0", Offset = "0x3004BA0", VA = "0x3004BA0")]
      public static void ClearActiveSubQuestTaskID(Adv2Manager instance)
      {
      }

      [Token(Token = "0x60195FC")]
      [Address(RVA = "0x3004C1C", Offset = "0x3004C1C", VA = "0x3004C1C")]
      public static void SetActiveSubQuestTaskID(Adv2Manager instance, int id)
      {
      }

      [Token(Token = "0x60195FD")]
      [Address(RVA = "0x3004C9C", Offset = "0x3004C9C", VA = "0x3004C9C")]
      public int GetActiveSubQuestTaskID() => new int();

      [Token(Token = "0x60195FE")]
      [Address(RVA = "0x2FF80FC", Offset = "0x2FF80FC", VA = "0x2FF80FC")]
      public ParamControl()
      {
      }

      [Token(Token = "0x2003ECC")]
      [MoonSharpUserData]
      public class ComuParam
      {
        [Token(Token = "0x401136E")]
        private const int USE_ITEM_REACTIONTYPE_NO_SELECT = 0;
        [Token(Token = "0x401136F")]
        private const int USE_ITEM_REACTIONTYPE_NOT_MATCH = 1;
        [Token(Token = "0x4011370")]
        private const int USE_ITEM_REACTIONTYPE_MATCH = 2;
        [Token(Token = "0x4011372")]
        [FieldOffset(Offset = "0x48")]
        public int GetRewardCount;
        [Token(Token = "0x4011374")]
        [FieldOffset(Offset = "0x58")]
        private int selectedNormalCommuItemId;
        [Token(Token = "0x4011375")]
        [FieldOffset(Offset = "0x5C")]
        public int OpenTutorialNum;
        [Token(Token = "0x4011376")]
        [FieldOffset(Offset = "0x60")]
        public List<int> OpenTutorialIds;

        [Token(Token = "0x170051E1")]
        public string CharacterName
        {
          [Token(Token = "0x60195FF"), Address(RVA = "0x3004D54", Offset = "0x3004D54", VA = "0x3004D54")] get
          {
            return (string) null;
          }
          [Token(Token = "0x6019600"), Address(RVA = "0x3004D5C", Offset = "0x3004D5C", VA = "0x3004D5C")] set
          {
          }
        }

        [Token(Token = "0x170051E2")]
        public string CharacterRubyName
        {
          [Token(Token = "0x6019601"), Address(RVA = "0x3004D64", Offset = "0x3004D64", VA = "0x3004D64")] get
          {
            return (string) null;
          }
          [Token(Token = "0x6019602"), Address(RVA = "0x3004D6C", Offset = "0x3004D6C", VA = "0x3004D6C")] set
          {
          }
        }

        [Token(Token = "0x170051E3")]
        public int RankNum
        {
          [Token(Token = "0x6019603"), Address(RVA = "0x3004D74", Offset = "0x3004D74", VA = "0x3004D74")] get
          {
            return new int();
          }
          [Token(Token = "0x6019604"), Address(RVA = "0x3004D7C", Offset = "0x3004D7C", VA = "0x3004D7C")] set
          {
          }
        }

        [Token(Token = "0x170051E4")]
        public int MaxRankNum
        {
          [Token(Token = "0x6019605"), Address(RVA = "0x3004D84", Offset = "0x3004D84", VA = "0x3004D84")] get
          {
            return new int();
          }
          [Token(Token = "0x6019606"), Address(RVA = "0x3004D8C", Offset = "0x3004D8C", VA = "0x3004D8C")] set
          {
          }
        }

        [Token(Token = "0x170051E5")]
        public int FromPoint
        {
          [Token(Token = "0x6019607"), Address(RVA = "0x3004D94", Offset = "0x3004D94", VA = "0x3004D94")] get
          {
            return new int();
          }
          [Token(Token = "0x6019608"), Address(RVA = "0x3004D9C", Offset = "0x3004D9C", VA = "0x3004D9C")] set
          {
          }
        }

        [Token(Token = "0x170051E6")]
        public int AddPoint
        {
          [Token(Token = "0x6019609"), Address(RVA = "0x3004DA4", Offset = "0x3004DA4", VA = "0x3004DA4")] get
          {
            return new int();
          }
          [Token(Token = "0x601960A"), Address(RVA = "0x3004DAC", Offset = "0x3004DAC", VA = "0x3004DAC")] set
          {
          }
        }

        [Token(Token = "0x170051E7")]
        public int ToPoint
        {
          [Token(Token = "0x601960B"), Address(RVA = "0x3004DB4", Offset = "0x3004DB4", VA = "0x3004DB4")] get
          {
            return new int();
          }
          [Token(Token = "0x601960C"), Address(RVA = "0x3004DBC", Offset = "0x3004DBC", VA = "0x3004DBC")] set
          {
          }
        }

        [Token(Token = "0x170051E8")]
        public float FromPointRate
        {
          [Token(Token = "0x601960D"), Address(RVA = "0x3004DC4", Offset = "0x3004DC4", VA = "0x3004DC4")] get
          {
            return new float();
          }
          [Token(Token = "0x601960E"), Address(RVA = "0x3004DCC", Offset = "0x3004DCC", VA = "0x3004DCC")] set
          {
          }
        }

        [Token(Token = "0x170051E9")]
        public float ToPointRate
        {
          [Token(Token = "0x601960F"), Address(RVA = "0x3004DD4", Offset = "0x3004DD4", VA = "0x3004DD4")] get
          {
            return new float();
          }
          [Token(Token = "0x6019610"), Address(RVA = "0x3004DDC", Offset = "0x3004DDC", VA = "0x3004DDC")] set
          {
          }
        }

        [Token(Token = "0x170051EA")]
        public int UseItemReactionType
        {
          [Token(Token = "0x6019611"), Address(RVA = "0x3004DE4", Offset = "0x3004DE4", VA = "0x3004DE4")] get
          {
            return new int();
          }
          [Token(Token = "0x6019612"), Address(RVA = "0x3004DEC", Offset = "0x3004DEC", VA = "0x3004DEC")] set
          {
          }
        }

        [Token(Token = "0x170051EB")]
        public string GetItemName
        {
          [Token(Token = "0x6019613"), Address(RVA = "0x3004DF4", Offset = "0x3004DF4", VA = "0x3004DF4")] get
          {
            return (string) null;
          }
          [Token(Token = "0x6019614"), Address(RVA = "0x3004DFC", Offset = "0x3004DFC", VA = "0x3004DFC")] set
          {
          }
        }

        [Token(Token = "0x170051EC")]
        public string SystemTelopText
        {
          [Token(Token = "0x6019615"), Address(RVA = "0x3004E04", Offset = "0x3004E04", VA = "0x3004E04")] get
          {
            return (string) null;
          }
          [Token(Token = "0x6019616"), Address(RVA = "0x3004E0C", Offset = "0x3004E0C", VA = "0x3004E0C")] set
          {
          }
        }

        [Token(Token = "0x6019617")]
        [Address(RVA = "0x30037C0", Offset = "0x30037C0", VA = "0x30037C0")]
        public ComuParam(
          string comuRankName,
          string comuPointName,
          LuaSequence.ParamControl.ComuParam.RequestType requestType)
        {
        }

        [Token(Token = "0x6019618")]
        [Address(RVA = "0x3004E18", Offset = "0x3004E18", VA = "0x3004E18")]
        public ComuParam(int commuID)
        {
        }

        [Token(Token = "0x6019619")]
        [Address(RVA = "0x3005120", Offset = "0x3005120", VA = "0x3005120")]
        public int GetOpenTutorialNum() => new int();

        [Token(Token = "0x601961A")]
        [Address(RVA = "0x3005168", Offset = "0x3005168", VA = "0x3005168")]
        public int GetTutorialID(int idx) => new int();

        [Token(Token = "0x601961B")]
        [Address(RVA = "0x30051C0", Offset = "0x30051C0", VA = "0x30051C0")]
        public bool IsValidItemSelect() => new bool();

        [Token(Token = "0x601961C")]
        [Address(RVA = "0x300551C", Offset = "0x300551C", VA = "0x300551C")]
        protected StoryCommunicationParamData UpdateBase() => (StoryCommunicationParamData) null;

        [Token(Token = "0x601961D")]
        [Address(RVA = "0x3005708", Offset = "0x3005708", VA = "0x3005708")]
        public LuaSequence.ParamControl.ComuParam.NormalCommuItem[] GetNormalCommuItems()
        {
          return (LuaSequence.ParamControl.ComuParam.NormalCommuItem[]) null;
        }

        [Token(Token = "0x601961E")]
        [Address(RVA = "0x3005B10", Offset = "0x3005B10", VA = "0x3005B10")]
        public void SetSelectedNormalCommuItem(int itemId)
        {
        }

        [Token(Token = "0x601961F")]
        [Address(RVA = "0x3005C00", Offset = "0x3005C00", VA = "0x3005C00")]
        public void UpdateNormalItem()
        {
        }

        [Token(Token = "0x6019620")]
        [Address(RVA = "0x3005D94", Offset = "0x3005D94", VA = "0x3005D94")]
        public void UpdateAcquired()
        {
        }

        [Token(Token = "0x6019621")]
        [Address(RVA = "0x3006608", Offset = "0x3006608", VA = "0x3006608")]
        public void UpdateNormal()
        {
        }

        [Token(Token = "0x6019622")]
        [Address(RVA = "0x3006710", Offset = "0x3006710", VA = "0x3006710")]
        public void UpdateRankup()
        {
        }

        [Token(Token = "0x6019623")]
        [Address(RVA = "0x300673C", Offset = "0x300673C", VA = "0x300673C")]
        public void Update(int addValue = 0)
        {
        }

        [Token(Token = "0x6019624")]
        [Address(RVA = "0x3005DC4", Offset = "0x3005DC4", VA = "0x3005DC4")]
        public void ComuRewardSet(StoryCommunicationParamData param)
        {
        }

        [Token(Token = "0x6019625")]
        [Address(RVA = "0x300674C", Offset = "0x300674C", VA = "0x300674C")]
        private int GetRankUpCommunicationSkillLevel(int ID) => new int();

        [Token(Token = "0x6019626")]
        [Address(RVA = "0x30068D8", Offset = "0x30068D8", VA = "0x30068D8")]
        private void SetupRewardTutorial()
        {
        }

        [Token(Token = "0x2003ECD")]
        public enum RequestType
        {
          [Token(Token = "0x4011378")] Normal,
          [Token(Token = "0x4011379")] Rankup,
          [Token(Token = "0x401137A")] Acquired,
          [Token(Token = "0x401137B")] Intro,
        }

        [Token(Token = "0x2003ECE")]
        [MoonSharpUserData]
        public class NormalCommuItem
        {
          [Token(Token = "0x401137C")]
          [FieldOffset(Offset = "0x10")]
          public int ItemId;
          [Token(Token = "0x401137D")]
          [FieldOffset(Offset = "0x18")]
          public string Name;
          [Token(Token = "0x401137E")]
          [FieldOffset(Offset = "0x20")]
          public int Num;

          [Token(Token = "0x6019628")]
          [Address(RVA = "0x3005AB8", Offset = "0x3005AB8", VA = "0x3005AB8")]
          public NormalCommuItem()
          {
          }
        }
      }

      [Token(Token = "0x2003ED0")]
      [MoonSharpUserData]
      public class FacilityParam
      {
        [Token(Token = "0x4011381")]
        [FieldOffset(Offset = "0x10")]
        public int FacilityID;
        [Token(Token = "0x4011382")]
        [FieldOffset(Offset = "0x14")]
        public int RewardSetLabelID;
        [Token(Token = "0x4011383")]
        [FieldOffset(Offset = "0x18")]
        public int BonusSetLabelID;
        [Token(Token = "0x4011384")]
        [FieldOffset(Offset = "0x1C")]
        public bool IsWeatherBonus;
        [Token(Token = "0x4011385")]
        [FieldOffset(Offset = "0x1D")]
        public bool IsDayBonus;

        [Token(Token = "0x601962C")]
        [Address(RVA = "0x3006B5C", Offset = "0x3006B5C", VA = "0x3006B5C")]
        public bool IsValidItemSelect() => new bool();

        [Token(Token = "0x601962D")]
        [Address(RVA = "0x3006F44", Offset = "0x3006F44", VA = "0x3006F44")]
        protected void ReflectReward(int rewardSetLabelID)
        {
        }

        [Token(Token = "0x601962E")]
        [Address(RVA = "0x30073C4", Offset = "0x30073C4", VA = "0x30073C4")]
        public void Update()
        {
        }

        [Token(Token = "0x601962F")]
        [Address(RVA = "0x30042BC", Offset = "0x30042BC", VA = "0x30042BC")]
        public FacilityParam()
        {
        }
      }

      [Token(Token = "0x2003ED1")]
      [MoonSharpUserData]
      public class HumanParameter
      {
        [Token(Token = "0x4011386")]
        [FieldOffset(Offset = "0x10")]
        public LuaSequence.ParamControl.HumanParameter.HumanParameterElement[] Elements;

        [Token(Token = "0x170051ED")]
        public int LastUpdateIncrease
        {
          [Token(Token = "0x6019630"), Address(RVA = "0x30073F0", Offset = "0x30073F0", VA = "0x30073F0")] get
          {
            return new int();
          }
          [Token(Token = "0x6019631"), Address(RVA = "0x30073F8", Offset = "0x30073F8", VA = "0x30073F8")] protected set
          {
          }
        }

        [Token(Token = "0x6019632")]
        [Address(RVA = "0x3004570", Offset = "0x3004570", VA = "0x3004570")]
        public void Update()
        {
        }

        [Token(Token = "0x6019633")]
        [Address(RVA = "0x30074B0", Offset = "0x30074B0", VA = "0x30074B0")]
        public int GetTotalIncrease() => new int();

        [Token(Token = "0x6019634")]
        [Address(RVA = "0x300753C", Offset = "0x300753C", VA = "0x300753C")]
        public void ClearUpdateHistory()
        {
        }

        [Token(Token = "0x6019635")]
        [Address(RVA = "0x3004568", Offset = "0x3004568", VA = "0x3004568")]
        public HumanParameter()
        {
        }

        [Token(Token = "0x2003ED2")]
        [MoonSharpUserData]
        public class HumanParameterValue
        {
          [Token(Token = "0x4011388")]
          [FieldOffset(Offset = "0x10")]
          public int RankNum;
          [Token(Token = "0x4011389")]
          [FieldOffset(Offset = "0x14")]
          public bool isMaxRank;
          [Token(Token = "0x401138A")]
          [FieldOffset(Offset = "0x18")]
          public string RankName;
          [Token(Token = "0x401138B")]
          [FieldOffset(Offset = "0x20")]
          public int ExpValue;
          [Token(Token = "0x401138C")]
          [FieldOffset(Offset = "0x24")]
          public int NeedExpValueForNextRank;
          [Token(Token = "0x401138D")]
          [FieldOffset(Offset = "0x28")]
          public int BeforeNeedExpValueForNextRank;
          [Token(Token = "0x401138E")]
          [FieldOffset(Offset = "0x2C")]
          public float ExpRate;
          [Token(Token = "0x401138F")]
          [FieldOffset(Offset = "0x30")]
          public float BeforeExpRate;

          [Token(Token = "0x6019636")]
          [Address(RVA = "0x3007458", Offset = "0x3007458", VA = "0x3007458")]
          public void UpdateHisrtory(
            LuaSequence.ParamControl.HumanParameter.HumanParameterValue newValue)
          {
          }

          [Token(Token = "0x6019637")]
          [Address(RVA = "0x300759C", Offset = "0x300759C", VA = "0x300759C")]
          public void ClearHistory()
          {
          }

          [Token(Token = "0x6019638")]
          [Address(RVA = "0x3007400", Offset = "0x3007400", VA = "0x3007400")]
          public HumanParameterValue()
          {
          }
        }

        [Token(Token = "0x2003ED3")]
        [MoonSharpUserData]
        public class HumanParameterElement
        {
          [Token(Token = "0x4011390")]
          [FieldOffset(Offset = "0x10")]
          public int VariableID;
          [Token(Token = "0x4011391")]
          [FieldOffset(Offset = "0x18")]
          public string Title;
          [Token(Token = "0x4011392")]
          [FieldOffset(Offset = "0x20")]
          public LuaSequence.ParamControl.HumanParameter.HumanParameterValue[] Values;
          [Token(Token = "0x4011393")]
          [FieldOffset(Offset = "0x28")]
          public int BeforeUpdateRank;
          [Token(Token = "0x4011394")]
          [FieldOffset(Offset = "0x2C")]
          public int AfterUpdateRank;

          [Token(Token = "0x6019639")]
          [Address(RVA = "0x3733770", Offset = "0x3733770", VA = "0x3733770")]
          public void ClearHistory()
          {
          }

          [Token(Token = "0x601963A")]
          [Address(RVA = "0x37337D8", Offset = "0x37337D8", VA = "0x37337D8")]
          public HumanParameterElement()
          {
          }
        }
      }
    }
  }
}
