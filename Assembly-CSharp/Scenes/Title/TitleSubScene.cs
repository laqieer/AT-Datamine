// Decompiled with JetBrains decompiler
// Type: Scenes.Title.TitleSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Connection;
using DataLinkage;
using FgGIDMission;
using GameCore;
using GameCore.DLC;
using GameCore.Popup;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.API;
using System;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028FA")]
  public class TitleSubScene : SubScene, ConnectionPlayerProfile.IConnectionEvent
  {
    [Token(Token = "0x400AEC8")]
    private const string ADVMANAGER_ASSET_BUNDLE_LABEL = "adv_manager";
    [Token(Token = "0x400AEC9")]
    private const string ADVMANAGER_ASSET_NAME = "AdvManager";
    [Token(Token = "0x400AECA")]
    private const string UI_TWEEN_IN = "in";
    [Token(Token = "0x400AECB")]
    private const string TtitleBGMName = "BGM_maintitle";
    [Token(Token = "0x400AECC")]
    [FieldOffset(Offset = "0x0")]
    private static Func<string> PLAYER_ID_SWITCH_TEXT;
    [Token(Token = "0x400AECD")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Canvas canvas;
    [Token(Token = "0x400AECE")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private string startSceneName;
    [Token(Token = "0x400AECF")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private string startSubSceneAssetBundleName;
    [Token(Token = "0x400AED0")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private string startSubSceneName;
    [Token(Token = "0x400AED1")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject aboutTrackingInfo;
    [Token(Token = "0x400AED2")]
    [FieldOffset(Offset = "0x80")]
    private PopupHandle qualityDefaultSettingsPopupHandle;
    [Token(Token = "0x400AED3")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TextMeshProUGUI versionText;
    [Token(Token = "0x400AED4")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private UITweenGroup uiTweenGroup;
    [Token(Token = "0x400AED5")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton playerIdButton;
    [Token(Token = "0x400AED6")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI playerIdText;
    [Token(Token = "0x400AED7")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject blockObject;
    [Token(Token = "0x400AED8")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject debugButton1;
    [Token(Token = "0x400AED9")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject debugButton2;
    [Token(Token = "0x400AEDA")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject debugButton3;
    [Token(Token = "0x400AEDB")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Slider progressSlider;
    [Token(Token = "0x400AEDC")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Slider progressSlider2;
    [Token(Token = "0x400AEDD")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text progressText;
    [Token(Token = "0x400AEDE")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Text progressText2;
    [Token(Token = "0x400AEDF")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private FgGIDLinkStatusView fgGIDLinkStatusView;
    [Token(Token = "0x400AEE0")]
    [FieldOffset(Offset = "0xF0")]
    private ConnectionPlayerProfile connectionPlayerProfile;
    [Token(Token = "0x400AEE1")]
    [FieldOffset(Offset = "0xF8")]
    private DLCProcess DlcProcess;
    [Token(Token = "0x400AEE2")]
    [FieldOffset(Offset = "0x100")]
    private bool nowMasterDataLoad;
    [Token(Token = "0x400AEE3")]
    [FieldOffset(Offset = "0x108")]
    private TitleMenuPopup titleMenuPopupPrefab;
    [Token(Token = "0x400AEE4")]
    [FieldOffset(Offset = "0x110")]
    private TitleMenuGeneartor titleMenuGeneartor;
    [Token(Token = "0x400AEE5")]
    [FieldOffset(Offset = "0x118")]
    private TitleMenuView titleMenuView;
    [Token(Token = "0x400AEE6")]
    [FieldOffset(Offset = "0x120")]
    private DataLinkagePopup dataLinkPopup;
    [Token(Token = "0x400AEE7")]
    [FieldOffset(Offset = "0x128")]
    private TitleMenuPopup titleMenuPopup;
    [Token(Token = "0x400AEE8")]
    [FieldOffset(Offset = "0x130")]
    private TitleStartup titleStartup;
    [Token(Token = "0x400AEE9")]
    [FieldOffset(Offset = "0x138")]
    private bool requestAccessToken;
    [Token(Token = "0x400AEEA")]
    [FieldOffset(Offset = "0x139")]
    private bool finisheRequestAccessToken;
    [Token(Token = "0x400AEEB")]
    [FieldOffset(Offset = "0x13A")]
    private bool playerIdShow;
    [Token(Token = "0x400AEEC")]
    [FieldOffset(Offset = "0x140")]
    private Coroutine tapSequence;
    [Token(Token = "0x400AEED")]
    [FieldOffset(Offset = "0x148")]
    private UITimelineController timelineController;
    [Token(Token = "0x400AEEE")]
    [FieldOffset(Offset = "0x150")]
    private TitleMoviePlayer moviePlayer;
    [Token(Token = "0x400AEEF")]
    [FieldOffset(Offset = "0x158")]
    private DataLinkagePresenter dataLinkagePresenter;
    [Token(Token = "0x400AEF0")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private GameObject noticesOpenButtonObj;
    [Token(Token = "0x400AEF1")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private GameObject dataLinkButtonObj;
    [Token(Token = "0x400AEF2")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private GameObject titleMenuButtonObj;
    [Token(Token = "0x400AEF3")]
    [FieldOffset(Offset = "0x178")]
    private Vector2 tapPos;
    [Token(Token = "0x400AEF4")]
    [FieldOffset(Offset = "0x180")]
    private bool isTransition;
    [Token(Token = "0x400AEF5")]
    [FieldOffset(Offset = "0x188")]
    private long totalDownloadSize;
    [Token(Token = "0x400AEF6")]
    [FieldOffset(Offset = "0x190")]
    private bool assetSetupEnded;
    [Token(Token = "0x400AEF7")]
    [FieldOffset(Offset = "0x194")]
    private TitleSubScene.TitleStartType startType;

    [Token(Token = "0x60101E9")]
    [Address(RVA = "0x4173ECC", Offset = "0x4173ECC", VA = "0x4173ECC", Slot = "6")]
    public override void Initialize(ChangeSceneParameter parameter = null)
    {
    }

    [Token(Token = "0x60101EA")]
    [Address(RVA = "0x4173F84", Offset = "0x4173F84", VA = "0x4173F84", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60101EB")]
    [Address(RVA = "0x4174014", Offset = "0x4174014", VA = "0x4174014")]
    private IEnumerator NotInServiceSetupSequence(Action onErrorResult) => (IEnumerator) null;

    [Token(Token = "0x60101EC")]
    [Address(RVA = "0x41740A4", Offset = "0x41740A4", VA = "0x41740A4", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x60101ED")]
    [Address(RVA = "0x4174144", Offset = "0x4174144", VA = "0x4174144", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x60101EE")]
    [Address(RVA = "0x41741CC", Offset = "0x41741CC", VA = "0x41741CC", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x60101EF")]
    [Address(RVA = "0x41747C8", Offset = "0x41747C8", VA = "0x41747C8")]
    private void ApplicationQuit()
    {
    }

    [Token(Token = "0x60101F0")]
    [Address(RVA = "0x41747D0", Offset = "0x41747D0", VA = "0x41747D0")]
    public void Update()
    {
    }

    [Token(Token = "0x60101F1")]
    [Address(RVA = "0x4174950", Offset = "0x4174950", VA = "0x4174950")]
    public static void DownloadAssetBundleProgress(DLCProgress progress)
    {
    }

    [Token(Token = "0x60101F2")]
    [Address(RVA = "0x41749E8", Offset = "0x41749E8", VA = "0x41749E8")]
    private IEnumerator TitleTapSequenceNotInServics() => (IEnumerator) null;

    [Token(Token = "0x60101F3")]
    [Address(RVA = "0x4174A50", Offset = "0x4174A50", VA = "0x4174A50")]
    private IEnumerator TitleTapSequence() => (IEnumerator) null;

    [Token(Token = "0x60101F4")]
    [Address(RVA = "0x4174AE0", Offset = "0x4174AE0", VA = "0x4174AE0")]
    private void LoadAdditionalSEPack()
    {
    }

    [Token(Token = "0x60101F5")]
    [Address(RVA = "0x4174C10", Offset = "0x4174C10", VA = "0x4174C10")]
    private IEnumerator DownloadAssetCoroutine() => (IEnumerator) null;

    [Token(Token = "0x60101F6")]
    [Address(RVA = "0x4174CA0", Offset = "0x4174CA0", VA = "0x4174CA0")]
    private IEnumerator SigninCoroutineIfNeed() => (IEnumerator) null;

    [Token(Token = "0x60101F7")]
    [Address(RVA = "0x4174D30", Offset = "0x4174D30", VA = "0x4174D30")]
    private IEnumerator DownloadAssetCoroutineAfterSigninIfNeed() => (IEnumerator) null;

    [Token(Token = "0x60101F8")]
    [Address(RVA = "0x4174DC0", Offset = "0x4174DC0", VA = "0x4174DC0")]
    private IEnumerator SetupParameterDataSequenceDebug() => (IEnumerator) null;

    [Token(Token = "0x60101F9")]
    [Address(RVA = "0x4174E50", Offset = "0x4174E50", VA = "0x4174E50")]
    private IEnumerator TermsOfServiceIfNeed(Action<bool> disagree) => (IEnumerator) null;

    [Token(Token = "0x60101FA")]
    [Address(RVA = "0x4174EE0", Offset = "0x4174EE0", VA = "0x4174EE0")]
    private IEnumerator SetupAssetCoroutineIfNeeded() => (IEnumerator) null;

    [Token(Token = "0x60101FB")]
    [Address(RVA = "0x4174F70", Offset = "0x4174F70", VA = "0x4174F70")]
    private IEnumerator MainAssetDownLoadAssetCoroutine() => (IEnumerator) null;

    [Token(Token = "0x60101FC")]
    [Address(RVA = "0x4175000", Offset = "0x4175000", VA = "0x4175000")]
    private IEnumerator SetupDownLoadAssetCoroutine() => (IEnumerator) null;

    [Token(Token = "0x60101FD")]
    [Address(RVA = "0x4175090", Offset = "0x4175090", VA = "0x4175090")]
    private IEnumerator LoadTextAsset() => (IEnumerator) null;

    [Token(Token = "0x60101FE")]
    [Address(RVA = "0x4175118", Offset = "0x4175118", VA = "0x4175118")]
    private void DownloadAssetBundleStart()
    {
    }

    [Token(Token = "0x60101FF")]
    [Address(RVA = "0x4175300", Offset = "0x4175300", VA = "0x4175300")]
    private IEnumerator RequestStoryInfoAsync() => (IEnumerator) null;

    [Token(Token = "0x6010200")]
    [Address(RVA = "0x4175388", Offset = "0x4175388", VA = "0x4175388")]
    private IEnumerator LoadAssetBundles() => (IEnumerator) null;

    [Token(Token = "0x6010201")]
    [Address(RVA = "0x4175418", Offset = "0x4175418", VA = "0x4175418")]
    private IEnumerator LoadAndCreateAdvManagerCoroutine() => (IEnumerator) null;

    [Token(Token = "0x6010202")]
    [Address(RVA = "0x41754A0", Offset = "0x41754A0", VA = "0x41754A0")]
    private IEnumerator PlayInAnimation() => (IEnumerator) null;

    [Token(Token = "0x6010203")]
    [Address(RVA = "0x4175530", Offset = "0x4175530", VA = "0x4175530")]
    private IEnumerator PlayOutAnimation() => (IEnumerator) null;

    [Token(Token = "0x6010204")]
    [Address(RVA = "0x41755C0", Offset = "0x41755C0", VA = "0x41755C0", Slot = "32")]
    private void Connection\u002EConnectionPlayerProfile\u002EIConnectionEvent\u002EOnFinish(
      APIPlayerProfile api)
    {
    }

    [Token(Token = "0x6010205")]
    [Address(RVA = "0x41756E8", Offset = "0x41756E8", VA = "0x41756E8")]
    private IEnumerator ShowAboutTrackingInfo() => (IEnumerator) null;

    [Token(Token = "0x6010206")]
    [Address(RVA = "0x41755E0", Offset = "0x41755E0", VA = "0x41755E0")]
    private void OnFinishSetup()
    {
    }

    [Token(Token = "0x6010207")]
    [Address(RVA = "0x4175770", Offset = "0x4175770", VA = "0x4175770")]
    private IEnumerator RequestAccessToken(Action finisheAction) => (IEnumerator) null;

    [Token(Token = "0x6010208")]
    [Address(RVA = "0x417580C", Offset = "0x417580C", VA = "0x417580C")]
    public void OnStartButtonClick()
    {
    }

    [Token(Token = "0x6010209")]
    [Address(RVA = "0x41758CC", Offset = "0x41758CC", VA = "0x41758CC")]
    public void OnDebugButtonClick()
    {
    }

    [Token(Token = "0x601020A")]
    [Address(RVA = "0x41758D8", Offset = "0x41758D8", VA = "0x41758D8")]
    public void OnDebugIntroChapterSkipButtonClick()
    {
    }

    [Token(Token = "0x601020B")]
    [Address(RVA = "0x41758E4", Offset = "0x41758E4", VA = "0x41758E4")]
    public void OnDebugSkipToHomeTutorialButtonClick()
    {
    }

    [Token(Token = "0x601020C")]
    [Address(RVA = "0x41758F0", Offset = "0x41758F0", VA = "0x41758F0")]
    public void OnTitleMenuButtonClick()
    {
    }

    [Token(Token = "0x601020D")]
    [Address(RVA = "0x4175920", Offset = "0x4175920", VA = "0x4175920")]
    private IEnumerator OpenTitleMenuAsync() => (IEnumerator) null;

    [Token(Token = "0x601020E")]
    [Address(RVA = "0x41759B0", Offset = "0x41759B0", VA = "0x41759B0")]
    private void OnOptionMovieStart()
    {
    }

    [Token(Token = "0x601020F")]
    [Address(RVA = "0x4175A3C", Offset = "0x4175A3C", VA = "0x4175A3C")]
    private void OnOptionMovieEnd()
    {
    }

    [Token(Token = "0x6010210")]
    [Address(RVA = "0x4175AC8", Offset = "0x4175AC8", VA = "0x4175AC8")]
    private IEnumerator OpenFgGIDMissionAsync() => (IEnumerator) null;

    [Token(Token = "0x6010211")]
    [Address(RVA = "0x4175B50", Offset = "0x4175B50", VA = "0x4175B50")]
    public void OnDataLinkClick()
    {
    }

    [Token(Token = "0x6010212")]
    [Address(RVA = "0x4175B80", Offset = "0x4175B80", VA = "0x4175B80")]
    private IEnumerator OpenDataLinkagePopupAsync() => (IEnumerator) null;

    [Token(Token = "0x6010213")]
    [Address(RVA = "0x4175C10", Offset = "0x4175C10", VA = "0x4175C10")]
    public void OnInformationClick()
    {
    }

    [Token(Token = "0x6010214")]
    [Address(RVA = "0x4175C3C", Offset = "0x4175C3C", VA = "0x4175C3C")]
    private void SetPlayerIdView()
    {
    }

    [Token(Token = "0x6010215")]
    [Address(RVA = "0x4175E08", Offset = "0x4175E08", VA = "0x4175E08")]
    private void SwitchPlayerIdText()
    {
    }

    [Token(Token = "0x6010216")]
    [Address(RVA = "0x4175F7C", Offset = "0x4175F7C", VA = "0x4175F7C")]
    public void OnFgGIDClick()
    {
    }

    [Token(Token = "0x6010217")]
    [Address(RVA = "0x4175FAC", Offset = "0x4175FAC", VA = "0x4175FAC")]
    private void StartQualityDefaultSettingsPopup()
    {
    }

    [Token(Token = "0x6010218")]
    [Address(RVA = "0x4174684", Offset = "0x4174684", VA = "0x4174684")]
    private void OnClickCloseSetQualityDefaultSettingsPopup()
    {
    }

    [Token(Token = "0x6010219")]
    [Address(RVA = "0x4176238", Offset = "0x4176238", VA = "0x4176238")]
    private string GetQualityDefaultSettingsTitleText() => (string) null;

    [Token(Token = "0x601021A")]
    [Address(RVA = "0x41762B8", Offset = "0x41762B8", VA = "0x41762B8")]
    private string GetQualityDefaultSettingsBaseText() => (string) null;

    [Token(Token = "0x601021B")]
    [Address(RVA = "0x4176338", Offset = "0x4176338", VA = "0x4176338")]
    private string GetQualityDefaultSettingsGraphicsText(AppQualitySettings.QualityType qualityType)
    {
      return (string) null;
    }

    [Token(Token = "0x601021C")]
    [Address(RVA = "0x4176440", Offset = "0x4176440", VA = "0x4176440")]
    private string GetQualityDefaultSettingsFpsText(int currentFPS) => (string) null;

    [Token(Token = "0x601021D")]
    [Address(RVA = "0x41764E0", Offset = "0x41764E0", VA = "0x41764E0")]
    private string GetQualityDefaultSettingsButtonText() => (string) null;

    [Token(Token = "0x601021E")]
    [Address(RVA = "0x4176560", Offset = "0x4176560", VA = "0x4176560")]
    private IEnumerator RequestConnectListCoroutine() => (IEnumerator) null;

    [Token(Token = "0x601021F")]
    [Address(RVA = "0x41765F0", Offset = "0x41765F0", VA = "0x41765F0")]
    private void SendSceneAccessLog()
    {
    }

    [Token(Token = "0x6010220")]
    [Address(RVA = "0x41766C8", Offset = "0x41766C8", VA = "0x41766C8")]
    private void SendDownloadProgressLog(DLCProgress dlcProgress)
    {
    }

    [Token(Token = "0x6010221")]
    [Address(RVA = "0x417676C", Offset = "0x417676C", VA = "0x417676C")]
    private void SendDownloadProgressLog(string type, long progress, long target, int percent)
    {
    }

    [Token(Token = "0x6010222")]
    [Address(RVA = "0x4176898", Offset = "0x4176898", VA = "0x4176898")]
    public TitleSubScene()
    {
    }

    [Token(Token = "0x6010223")]
    [Address(RVA = "0x4176948", Offset = "0x4176948", VA = "0x4176948")]
    static TitleSubScene()
    {
    }

    [Token(Token = "0x20028FB")]
    private enum TitleStartType
    {
      [Token(Token = "0x400AEF9")] NormalStart,
      [Token(Token = "0x400AEFA")] SkipToHomeTutorialStart,
      [Token(Token = "0x400AEFB")] IntroSkip,
      [Token(Token = "0x400AEFC")] DebugStart,
    }
  }
}
