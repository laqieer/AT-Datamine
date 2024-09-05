// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelReverseLookup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2;
using FreeMap;
using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.ButtonEvent.Facility.Types;
using GameCore.MasterData;
using Il2CppDummyDll;
using Network.API;
using Story.Adv;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2003010")]
  public class AdvViewerModelReverseLookup : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CD06")]
    [FieldOffset(Offset = "0x10")]
    private AdvViewerModel parentModel;
    [Token(Token = "0x400CD09")]
    [FieldOffset(Offset = "0x28")]
    private string scriptFileName;
    [Token(Token = "0x400CD0A")]
    [FieldOffset(Offset = "0x30")]
    private string sequenceName;
    [Token(Token = "0x400CD0B")]
    [FieldOffset(Offset = "0x38")]
    private string[] fileNameList;
    [Token(Token = "0x400CD0C")]
    [FieldOffset(Offset = "0x40")]
    private bool isPrepare;
    [Token(Token = "0x400CD0D")]
    [FieldOffset(Offset = "0x48")]
    private IEnumerable<StoryMainQuestSequenceData> storyMainQuestSequenceDataList;
    [Token(Token = "0x400CD0E")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<string, ReverseLookupData> reverseLookupDictionary;
    [Token(Token = "0x400CD11")]
    [FieldOffset(Offset = "0x68")]
    private int commuId;
    [Token(Token = "0x400CD12")]
    [FieldOffset(Offset = "0x6C")]
    private int locationId;
    [Token(Token = "0x400CD13")]
    [FieldOffset(Offset = "0x70")]
    private Dictionary<string, StoryMainQuestSequenceData> storyMainQuestSequenceData;
    [Token(Token = "0x400CD14")]
    [FieldOffset(Offset = "0x78")]
    private bool selectCommuParamMax;
    [Token(Token = "0x400CD16")]
    [FieldOffset(Offset = "0x88")]
    private Dictionary<int, StoryFreeActionAreaSettingData> paramDict;
    [Token(Token = "0x400CD17")]
    [FieldOffset(Offset = "0x90")]
    private List<StoryMainQuestSequenceData> listFreeAction;
    [Token(Token = "0x400CD18")]
    [FieldOffset(Offset = "0x98")]
    private List<StoryMainQuestSequenceData> listAdvScene;
    [Token(Token = "0x400CD19")]
    [FieldOffset(Offset = "0xA0")]
    private List<StoryMainQuestSequenceData> listBattle;
    [Token(Token = "0x400CD1A")]
    [FieldOffset(Offset = "0xA8")]
    private List<StoryMainQuestSequenceData> listAreaEvent;
    [Token(Token = "0x400CD1B")]
    [FieldOffset(Offset = "0xB0")]
    private List<StoryMainQuestSequenceData> listEnding;
    [Token(Token = "0x400CD1C")]
    [FieldOffset(Offset = "0xB8")]
    private List<StoryMainQuestSequenceData> listReadBook;
    [Token(Token = "0x400CD1D")]
    [FieldOffset(Offset = "0xC0")]
    private List<StoryMainQuestSequenceData> listTutorialBattle;

    [Token(Token = "0x17003F6D")]
    public BindingParam<IEnumerable<string>> ScriptFileList
    {
      [Token(Token = "0x6012CB5"), Address(RVA = "0x3FB3674", Offset = "0x3FB3674", VA = "0x3FB3674")] get
      {
        return (BindingParam<IEnumerable<string>>) null;
      }
    }

    [Token(Token = "0x17003F6E")]
    public BindingParam<IEnumerable<string>> SequenceNameList
    {
      [Token(Token = "0x6012CB6"), Address(RVA = "0x3FB367C", Offset = "0x3FB367C", VA = "0x3FB367C")] get
      {
        return (BindingParam<IEnumerable<string>>) null;
      }
    }

    [Token(Token = "0x6012CB7")]
    [Address(RVA = "0x3FB3684", Offset = "0x3FB3684", VA = "0x3FB3684")]
    public AdvViewerModelReverseLookup(AdvViewerModel parent)
    {
    }

    [Token(Token = "0x6012CB8")]
    [Address(RVA = "0x3FB6524", Offset = "0x3FB6524", VA = "0x3FB6524")]
    private IEnumerable<string> SetFileList(string scriptFileName) => (IEnumerable<string>) null;

    [Token(Token = "0x6012CB9")]
    [Address(RVA = "0x3FB665C", Offset = "0x3FB665C", VA = "0x3FB665C")]
    private IEnumerable<string> SetSequenceList(string fileName) => (IEnumerable<string>) null;

    [Token(Token = "0x6012CBA")]
    [Address(RVA = "0x3FB6820", Offset = "0x3FB6820", VA = "0x3FB6820")]
    private IEnumerable<StoryMainQuestSequenceData> GetSequenceListFromReserveLookupMasterData(
      ReverseLookupData reserveLookupData)
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012CBB")]
    [Address(RVA = "0x3FB8948", Offset = "0x3FB8948", VA = "0x3FB8948")]
    private void registerReverseLookupDictionary(
      IReadOnlyDictionary<int, AdvDemoInfoData> dictionary,
      int id,
      ReserveLookupMasterData data)
    {
    }

    [Token(Token = "0x6012CBC")]
    [Address(RVA = "0x3FB3A04", Offset = "0x3FB3A04", VA = "0x3FB3A04")]
    private void InitializeLookupdata(
      IReadOnlyDictionary<int, AdvDemoInfoData> listDemoInfoDictionary)
    {
    }

    [Token(Token = "0x6012CBD")]
    [Address(RVA = "0x3FB614C", Offset = "0x3FB614C", VA = "0x3FB614C")]
    protected IEnumerator CreateFileList(
      IReadOnlyDictionary<int, AdvDemoInfoData> listDemoInfoDictionary)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6012CBE")]
    [Address(RVA = "0x3FB8F58", Offset = "0x3FB8F58", VA = "0x3FB8F58")]
    protected IEnumerator LoadLuaSampleAssetbundle(List<string> list) => (IEnumerator) null;

    [Token(Token = "0x6012CBF")]
    [Address(RVA = "0x3FB8FF4", Offset = "0x3FB8FF4", VA = "0x3FB8FF4", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012CC0")]
    [Address(RVA = "0x3FB8FF8", Offset = "0x3FB8FF8", VA = "0x3FB8FF8", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012CC1")]
    [Address(RVA = "0x3FB8B98", Offset = "0x3FB8B98", VA = "0x3FB8B98")]
    private int GetCommunicationCharacterCommunicationId(string key, string fileName) => new int();

    [Token(Token = "0x6012CC2")]
    [Address(RVA = "0x3FB8FFC", Offset = "0x3FB8FFC", VA = "0x3FB8FFC")]
    public void SetFilterString(string fileName)
    {
    }

    [Token(Token = "0x6012CC3")]
    [Address(RVA = "0x3FB9118", Offset = "0x3FB9118", VA = "0x3FB9118")]
    public void OnSelectSequence(string sequenceName)
    {
    }

    [Token(Token = "0x6012CC4")]
    [Address(RVA = "0x3FB9070", Offset = "0x3FB9070", VA = "0x3FB9070")]
    public void OnSelectScriptFile(string scriptfileName)
    {
    }

    [Token(Token = "0x6012CC5")]
    [Address(RVA = "0x3FB9120", Offset = "0x3FB9120", VA = "0x3FB9120")]
    private bool checkScripFileName(string scriptFileName) => new bool();

    [Token(Token = "0x6012CC6")]
    [Address(RVA = "0x3FB9C0C", Offset = "0x3FB9C0C", VA = "0x3FB9C0C")]
    public void OnPlayButton()
    {
    }

    [Token(Token = "0x6012CC7")]
    [Address(RVA = "0x3FBB8B4", Offset = "0x3FBB8B4", VA = "0x3FBB8B4")]
    private IEnumerable<StoryMainQuestSequenceData> GetSequenceListByLayoutAndObject(
      int layoutLableId,
      int objectId)
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012CC8")]
    [Address(RVA = "0x3FBBAF8", Offset = "0x3FBBAF8", VA = "0x3FBBAF8")]
    private IEnumerable<StoryMainQuestSequenceData> GetSequenceListByLayout(
      IEnumerable<StoryFreeActionLayoutData> freeActionLayouts)
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012CC9")]
    [Address(RVA = "0x3FBC810", Offset = "0x3FBC810", VA = "0x3FBC810")]
    private void PlayAdvDemoInfoWithObject(
      AdvDemoInfoData advDemoInfo,
      StoryMainQuestSequenceData sequenceData,
      int objectId)
    {
    }

    [Token(Token = "0x6012CCA")]
    [Address(RVA = "0x3FBCD08", Offset = "0x3FBCD08", VA = "0x3FBCD08")]
    private void TransitionOut()
    {
    }

    [Token(Token = "0x6012CCB")]
    [Address(RVA = "0x3FBCDDC", Offset = "0x3FBCDDC", VA = "0x3FBCDDC")]
    private void PlayAdvDemoInfo(AdvStage advStage, AdvDemoInfoData advDemoInfoData)
    {
    }

    [Token(Token = "0x6012CCC")]
    [Address(RVA = "0x3FBB834", Offset = "0x3FBB834", VA = "0x3FBB834")]
    private void PlayAdvDemoInfo(AdvDemoInfoData advDemoInfoData)
    {
    }

    [Token(Token = "0x6012CCD")]
    [Address(RVA = "0x3FB6C2C", Offset = "0x3FB6C2C", VA = "0x3FB6C2C")]
    private StoryMainQuestSequenceData GetSequenceAreaEventQuestTask(
      StoryAreaEventQuestTaskData storyAreaEventQuestTaskData)
    {
      return (StoryMainQuestSequenceData) null;
    }

    [Token(Token = "0x6012CCE")]
    [Address(RVA = "0x3FBA1B8", Offset = "0x3FBA1B8", VA = "0x3FBA1B8")]
    public void PlayStoryAreaEventQuestTaskData(ReverseLookupData data)
    {
    }

    [Token(Token = "0x6012CCF")]
    [Address(RVA = "0x3FBCEDC", Offset = "0x3FBCEDC", VA = "0x3FBCEDC")]
    private StoryFreeActionAreaSettingData SerchStoryFreeActionAreaSetting(
      StoryMainQuestSequenceData sequence,
      int objectID)
    {
      return (StoryFreeActionAreaSettingData) null;
    }

    [Token(Token = "0x6012CD0")]
    [Address(RVA = "0x3FBD750", Offset = "0x3FBD750", VA = "0x3FBD750")]
    private IEnumerator OnBeginReceiptStoryAreaEventQuestTask(StoryAreaEventQuestTaskData task)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6012CD1")]
    [Address(RVA = "0x3FBD7EC", Offset = "0x3FBD7EC", VA = "0x3FBD7EC")]
    private IEnumerator OnBeginTaskStoryAreaEventQuestTask(StoryAreaEventQuestTaskData task)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6012CD2")]
    [Address(RVA = "0x3FBD888", Offset = "0x3FBD888", VA = "0x3FBD888")]
    private IEnumerator OnBeginCompleteStoryAreaEventQuestTask(StoryAreaEventQuestTaskData task)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6012CD3")]
    [Address(RVA = "0x3FBD924", Offset = "0x3FBD924", VA = "0x3FBD924")]
    private void OnEndAdvStoryAreaEventQuestTask(FreeMapInstance instance)
    {
    }

    [Token(Token = "0x17003F6F")]
    public BindingParam<bool> ViewCommuLocationCharaSelect
    {
      [Token(Token = "0x6012CD4"), Address(RVA = "0x3FBD9CC", Offset = "0x3FBD9CC", VA = "0x3FBD9CC")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x17003F70")]
    public BindingParam<IEnumerable<string>> CommuLocationCharaList
    {
      [Token(Token = "0x6012CD5"), Address(RVA = "0x3FBD9D4", Offset = "0x3FBD9D4", VA = "0x3FBD9D4")] get
      {
        return (BindingParam<IEnumerable<string>>) null;
      }
    }

    [Token(Token = "0x6012CD6")]
    [Address(RVA = "0x3FB9298", Offset = "0x3FB9298", VA = "0x3FB9298")]
    private void onSelectScriptFileCommuLoacation(string scriptFileName, bool isExist)
    {
    }

    [Token(Token = "0x6012CD7")]
    [Address(RVA = "0x3FBD9DC", Offset = "0x3FBD9DC", VA = "0x3FBD9DC")]
    public void OnSelectCommuLocationChara(string charaName)
    {
    }

    [Token(Token = "0x6012CD8")]
    [Address(RVA = "0x3FB7600", Offset = "0x3FB7600", VA = "0x3FB7600")]
    private IEnumerable<StoryMainQuestSequenceData> GetSequenceListStoryCommunicationLocation()
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012CD9")]
    [Address(RVA = "0x3FBAA30", Offset = "0x3FBAA30", VA = "0x3FBAA30")]
    public void PlayStoryCommunicationLocationData()
    {
    }

    [Token(Token = "0x17003F71")]
    public BindingParam<bool> ViewCommuParamSelect
    {
      [Token(Token = "0x6012CDA"), Address(RVA = "0x3FBDD3C", Offset = "0x3FBDD3C", VA = "0x3FBDD3C")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x6012CDB")]
    [Address(RVA = "0x3FBDD44", Offset = "0x3FBDD44", VA = "0x3FBDD44")]
    public void PlayStoryCommunicationParamData()
    {
    }

    [Token(Token = "0x6012CDC")]
    [Address(RVA = "0x3FBDD48", Offset = "0x3FBDD48", VA = "0x3FBDD48")]
    private int scriptKeyToCommuParamID(string scriptKeyName) => new int();

    [Token(Token = "0x6012CDD")]
    [Address(RVA = "0x3FBE0D0", Offset = "0x3FBE0D0", VA = "0x3FBE0D0")]
    private StoryCommunicationParamData scriptKeyToCommuParam(int id)
    {
      return (StoryCommunicationParamData) null;
    }

    [Token(Token = "0x6012CDE")]
    [Address(RVA = "0x3FBA63C", Offset = "0x3FBA63C", VA = "0x3FBA63C")]
    private void PlayComminucationNormal()
    {
    }

    [Token(Token = "0x6012CDF")]
    [Address(RVA = "0x3FBA870", Offset = "0x3FBA870", VA = "0x3FBA870")]
    private void PlayComminucationRankup()
    {
    }

    [Token(Token = "0x6012CE0")]
    [Address(RVA = "0x3FBE4C4", Offset = "0x3FBE4C4", VA = "0x3FBE4C4")]
    private void PlayCommunication(
      StoryCommunicationParamData paramData,
      int seqId,
      bool isTargetRankup,
      bool humanParamMaxInPlay)
    {
    }

    [Token(Token = "0x6012CE1")]
    [Address(RVA = "0x3FBE910", Offset = "0x3FBE910", VA = "0x3FBE910")]
    private IEnumerator OnPlayCommunication(int commuParamID) => (IEnumerator) null;

    [Token(Token = "0x6012CE2")]
    [Address(RVA = "0x3FBE9B0", Offset = "0x3FBE9B0", VA = "0x3FBE9B0")]
    private IEnumerator OnPlayRankupCommunication(int commuParamID) => (IEnumerator) null;

    [Token(Token = "0x6012CE3")]
    [Address(RVA = "0x3FBE448", Offset = "0x3FBE448", VA = "0x3FBE448")]
    private int GetFirstSeq(ReserveLookupMasterData reverseLookupMasterData) => new int();

    [Token(Token = "0x6012CE4")]
    [Address(RVA = "0x3FB6D80", Offset = "0x3FB6D80", VA = "0x3FB6D80")]
    public IEnumerable<StoryMainQuestSequenceData> GetSequenceListStoryCommunicationParamData(
      int commuParamID,
      bool isTargetRankup)
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012CE5")]
    [Address(RVA = "0x3FBEA58", Offset = "0x3FBEA58", VA = "0x3FBEA58")]
    private static StoryFreeActionAreaSettingData AnySearchAreaSetting(
      AdvViewerModelFreeMap freemapModel,
      StoryCommunicationParamData commuParam,
      StoryMainQuestSequenceData seq,
      bool isTargetRaunlup,
      StoryCommunicationRankupTermData[] conditions)
    {
      return (StoryFreeActionAreaSettingData) null;
    }

    [Token(Token = "0x6012CE6")]
    [Address(RVA = "0x3FBF8CC", Offset = "0x3FBF8CC", VA = "0x3FBF8CC")]
    private static bool RouteAndTermCondition(
      StoryMainQuestSequenceData seq,
      StoryCommunicationRankupTermData[] conditions)
    {
      return new bool();
    }

    [Token(Token = "0x6012CE7")]
    [Address(RVA = "0x3FBFA30", Offset = "0x3FBFA30", VA = "0x3FBFA30")]
    public void OnSelectCommuParamMax(bool value)
    {
    }

    [Token(Token = "0x6012CE8")]
    [Address(RVA = "0x3FB9198", Offset = "0x3FB9198", VA = "0x3FB9198")]
    private void onSelectScriptCommuParams(string scriptFileName, bool isExist)
    {
    }

    [Token(Token = "0x6012CE9")]
    [Address(RVA = "0x3FB7B0C", Offset = "0x3FB7B0C", VA = "0x3FB7B0C")]
    private IEnumerable<StoryMainQuestSequenceData> GetSequenceListFecilityAttatch()
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012CEA")]
    [Address(RVA = "0x3FBABDC", Offset = "0x3FBABDC", VA = "0x3FBABDC")]
    public void PlayStoryFecilityAttatch(string sequenceName)
    {
    }

    [Token(Token = "0x6012CEB")]
    [Address(RVA = "0x3FBFA4C", Offset = "0x3FBFA4C", VA = "0x3FBFA4C")]
    private IEnumerator OnBegin(
      StoryFacilityAttachData attach,
      StoryFacilityEncountBonusDetailData detail)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6012CEC")]
    [Address(RVA = "0x3FBFAF0", Offset = "0x3FBFAF0", VA = "0x3FBFAF0")]
    private FreeMapFacilityIconEvent CreateDebugFacilityIconEvent(
      StaqData.Facility facility,
      FreeMapCommonElement element)
    {
      return (FreeMapFacilityIconEvent) null;
    }

    [Token(Token = "0x6012CED")]
    [Address(RVA = "0x3FBB45C", Offset = "0x3FBB45C", VA = "0x3FBB45C")]
    public void PlayStoryFacilityEncountBonusDetailData(ReverseLookupData reverseLookupData)
    {
    }

    [Token(Token = "0x6012CEE")]
    [Address(RVA = "0x3FB7E18", Offset = "0x3FB7E18", VA = "0x3FB7E18")]
    private IEnumerable<StoryMainQuestSequenceData> GetSequenceListOblibiae()
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012CEF")]
    [Address(RVA = "0x3FBB4C4", Offset = "0x3FBB4C4", VA = "0x3FBB4C4")]
    public void PlayStoryFreeActionObliviaeLayoutData(string sequenceName)
    {
    }

    [Token(Token = "0x6012CF0")]
    [Address(RVA = "0x3FBFE98", Offset = "0x3FBFE98", VA = "0x3FBFE98")]
    public IEnumerable<StoryMainQuestSequenceData> GetFreeActionTalkADVEnentSequenceList(
      string scriptName)
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012CF1")]
    [Address(RVA = "0x3FB6C14", Offset = "0x3FB6C14", VA = "0x3FB6C14")]
    public IEnumerable<StoryMainQuestSequenceData> GetFreeActionTalkADVEnentSequenceList(
      StoryFreeActionTalkADVEventTextData masterData)
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012CF2")]
    [Address(RVA = "0x3FBFF30", Offset = "0x3FBFF30", VA = "0x3FBFF30")]
    public IEnumerable<StoryMainQuestSequenceData> GetFreeActionTalkADVEnentSequenceList(
      int talkAdvEventId)
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012CF3")]
    [Address(RVA = "0x3FBA1B0", Offset = "0x3FBA1B0", VA = "0x3FBA1B0")]
    public void PlayStoryFreeActionTalkADVEventTextData()
    {
    }

    [Token(Token = "0x6012CF4")]
    [Address(RVA = "0x3FC0D58", Offset = "0x3FC0D58", VA = "0x3FC0D58")]
    public void PlayStoryFreeActionTalkADVEventTextData(string scriptFileName)
    {
    }

    [Token(Token = "0x6012CF5")]
    [Address(RVA = "0x3FC0DF4", Offset = "0x3FC0DF4", VA = "0x3FC0DF4")]
    public void PlayStoryFreeActionTalkADVEventTextData(int talkAdvEventId, int talkAdvEventTextId)
    {
    }

    [Token(Token = "0x6012CF6")]
    [Address(RVA = "0x3FC11AC", Offset = "0x3FC11AC", VA = "0x3FC11AC")]
    private IEnumerator OnBeginAdv(int demoInfoID) => (IEnumerator) null;

    [Token(Token = "0x6012CF7")]
    [Address(RVA = "0x3FC124C", Offset = "0x3FC124C", VA = "0x3FC124C")]
    private void OnEndAdv()
    {
    }

    [Token(Token = "0x6012CF8")]
    [Address(RVA = "0x3FB83DC", Offset = "0x3FB83DC", VA = "0x3FB83DC")]
    private IEnumerable<StoryMainQuestSequenceData> GetSequenceListStoryFreeActionTimeElapseLayout()
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012CF9")]
    [Address(RVA = "0x3FBB688", Offset = "0x3FBB688", VA = "0x3FBB688")]
    public void PlayStoryFreeActionTimeElapseLayoutData(string sequenceName)
    {
    }

    [Token(Token = "0x6012CFA")]
    [Address(RVA = "0x3FB9FAC", Offset = "0x3FB9FAC", VA = "0x3FB9FAC")]
    public void PlayStoryMainQuestSequenceData(string scriptFileName, string sequenceName)
    {
    }

    [Token(Token = "0x6012CFB")]
    [Address(RVA = "0x3FB9EDC", Offset = "0x3FB9EDC", VA = "0x3FB9EDC")]
    private void PlaySample()
    {
    }

    [Token(Token = "0x6012CFC")]
    [Address(RVA = "0x3FBA4E0", Offset = "0x3FBA4E0", VA = "0x3FBA4E0")]
    public void PlayStorySubquestTaskData()
    {
    }

    [Token(Token = "0x6012CFD")]
    [Address(RVA = "0x3FC19B8", Offset = "0x3FC19B8", VA = "0x3FC19B8")]
    public void PlayStorySubquestTaskData(int taskId, int sequenceId)
    {
    }

    [Token(Token = "0x6012CFE")]
    [Address(RVA = "0x3FC1E38", Offset = "0x3FC1E38", VA = "0x3FC1E38")]
    private IEnumerator OnBeginReceiptStorySubquestTaskData(StorySubquestTaskData task)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6012CFF")]
    [Address(RVA = "0x3FC1268", Offset = "0x3FC1268", VA = "0x3FC1268")]
    public IEnumerable<StoryMainQuestSequenceData> GetSubquestTaskSequenceList(string scriptFileName)
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x6012D00")]
    [Address(RVA = "0x3FC1EAC", Offset = "0x3FC1EAC", VA = "0x3FC1EAC")]
    private IEnumerator OnBeginTaskStorySubquestTaskData(StorySubquestTaskData task)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6012D01")]
    [Address(RVA = "0x3FC1F20", Offset = "0x3FC1F20", VA = "0x3FC1F20")]
    private IEnumerator OnBeginCompleteStorySubquestTaskData(StorySubquestTaskData task)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6012D02")]
    [Address(RVA = "0x3FC28C4", Offset = "0x3FC28C4", VA = "0x3FC28C4")]
    private void OnEndAdvStorySubquestTaskData(FreeMapInstance instance)
    {
    }

    [Token(Token = "0x6012D03")]
    [Address(RVA = "0x3FC296C", Offset = "0x3FC296C", VA = "0x3FC296C")]
    public void debugTest()
    {
    }

    [Token(Token = "0x2003011")]
    private interface IEncounter
    {
      [Token(Token = "0x6012D0B")]
      void Set(int detalID);
    }

    [Token(Token = "0x2003012")]
    private interface IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x6012D0C")]
      void Load(FreeMapPlayerInstance activePlayer);

      [Token(Token = "0x6012D0D")]
      IEnumerator DebugPlay();
    }

    [Token(Token = "0x2003013")]
    private class DebugGeneral : 
      General,
      AdvViewerModelReverseLookup.IDebugFacilityAdvPlayer,
      AdvViewerModelReverseLookup.IEncounter
    {
      [Token(Token = "0x6012D0E")]
      [Address(RVA = "0x3FBFE50", Offset = "0x3FBFE50", VA = "0x3FBFE50")]
      public DebugGeneral(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012D0F")]
      [Address(RVA = "0x3FC3594", Offset = "0x3FC3594", VA = "0x3FC3594", Slot = "30")]
      public void Set(int encountDetailID)
      {
      }

      [Token(Token = "0x6012D10")]
      [Address(RVA = "0x3FC367C", Offset = "0x3FC367C", VA = "0x3FC367C", Slot = "28")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012D11")]
      [Address(RVA = "0x3FC368C", Offset = "0x3FC368C", VA = "0x3FC368C", Slot = "29")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012D12")]
      [Address(RVA = "0x3FC371C", Offset = "0x3FC371C", VA = "0x3FC371C", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012D13")]
      [Address(RVA = "0x3FC37A4", Offset = "0x3FC37A4", VA = "0x3FC37A4", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012D14")]
      [Address(RVA = "0x3FC382C", Offset = "0x3FC382C", VA = "0x3FC382C", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012D15")]
      [Address(RVA = "0x3FC3830", Offset = "0x3FC3830", VA = "0x3FC3830", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x2003014")]
      private class DebugPrepare : General.Prepare
      {
        [Token(Token = "0x6012D16")]
        [Address(RVA = "0x3FC3600", Offset = "0x3FC3600", VA = "0x3FC3600")]
        public DebugPrepare(int encounterDetailID)
        {
        }

        [Token(Token = "0x6012D17")]
        [Address(RVA = "0x3FC38B8", Offset = "0x3FC38B8", VA = "0x3FC38B8", Slot = "4")]
        public override IEnumerator Execute(int facilityID) => (IEnumerator) null;
      }
    }

    [Token(Token = "0x200301A")]
    private class DebugMenu : Menu, AdvViewerModelReverseLookup.IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x6012D36")]
      [Address(RVA = "0x3FBFE58", Offset = "0x3FBFE58", VA = "0x3FBFE58")]
      public DebugMenu(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012D37")]
      [Address(RVA = "0x3FC3CFC", Offset = "0x3FC3CFC", VA = "0x3FC3CFC", Slot = "28")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012D38")]
      [Address(RVA = "0x3FC3D0C", Offset = "0x3FC3D0C", VA = "0x3FC3D0C", Slot = "29")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012D39")]
      [Address(RVA = "0x3FC3D1C", Offset = "0x3FC3D1C", VA = "0x3FC3D1C", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012D3A")]
      [Address(RVA = "0x3FC3DA4", Offset = "0x3FC3DA4", VA = "0x3FC3DA4", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012D3B")]
      [Address(RVA = "0x3FC3E2C", Offset = "0x3FC3E2C", VA = "0x3FC3E2C", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012D3C")]
      [Address(RVA = "0x3FC3E30", Offset = "0x3FC3E30", VA = "0x3FC3E30", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }
    }

    [Token(Token = "0x200301E")]
    private class DebugReading : Reading, AdvViewerModelReverseLookup.IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x6012D4F")]
      [Address(RVA = "0x3FBFE60", Offset = "0x3FBFE60", VA = "0x3FBFE60")]
      public DebugReading(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012D50")]
      [Address(RVA = "0x3FC3FFC", Offset = "0x3FC3FFC", VA = "0x3FC3FFC", Slot = "28")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012D51")]
      [Address(RVA = "0x3FC400C", Offset = "0x3FC400C", VA = "0x3FC400C", Slot = "29")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012D52")]
      [Address(RVA = "0x3FC401C", Offset = "0x3FC401C", VA = "0x3FC401C", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012D53")]
      [Address(RVA = "0x3FC40A4", Offset = "0x3FC40A4", VA = "0x3FC40A4", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012D54")]
      [Address(RVA = "0x3FC412C", Offset = "0x3FC412C", VA = "0x3FC412C", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012D55")]
      [Address(RVA = "0x3FC4130", Offset = "0x3FC4130", VA = "0x3FC4130", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }
    }

    [Token(Token = "0x2003022")]
    private class DebugLottery : Lottery, AdvViewerModelReverseLookup.IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x17003F88")]
      public bool IsSuccess
      {
        [Token(Token = "0x6012D68"), Address(RVA = "0x3FC42FC", Offset = "0x3FC42FC", VA = "0x3FC42FC")] get
        {
          return new bool();
        }
        [Token(Token = "0x6012D69"), Address(RVA = "0x3FC4304", Offset = "0x3FC4304", VA = "0x3FC4304")] set
        {
        }
      }

      [Token(Token = "0x6012D6A")]
      [Address(RVA = "0x3FBFE68", Offset = "0x3FBFE68", VA = "0x3FBFE68")]
      public DebugLottery(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012D6B")]
      [Address(RVA = "0x3FC4310", Offset = "0x3FC4310", VA = "0x3FC4310", Slot = "29")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012D6C")]
      [Address(RVA = "0x3FC4320", Offset = "0x3FC4320", VA = "0x3FC4320", Slot = "30")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012D6D")]
      [Address(RVA = "0x3FC4330", Offset = "0x3FC4330", VA = "0x3FC4330", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012D6E")]
      [Address(RVA = "0x3FC43B8", Offset = "0x3FC43B8", VA = "0x3FC43B8", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012D6F")]
      [Address(RVA = "0x3FC4440", Offset = "0x3FC4440", VA = "0x3FC4440", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012D70")]
      [Address(RVA = "0x3FC4444", Offset = "0x3FC4444", VA = "0x3FC4444", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6012D71")]
      [Address(RVA = "0x3FC44CC", Offset = "0x3FC44CC", VA = "0x3FC44CC", Slot = "28")]
      protected override void ApiCall(Adv2Manager.OnProccessSignal signal)
      {
      }
    }

    [Token(Token = "0x2003026")]
    private class DebugDifficulty : Difficulty, AdvViewerModelReverseLookup.IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x6012D88")]
      [Address(RVA = "0x3FBFE70", Offset = "0x3FBFE70", VA = "0x3FBFE70")]
      public DebugDifficulty(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012D89")]
      [Address(RVA = "0x3FC4C7C", Offset = "0x3FC4C7C", VA = "0x3FC4C7C", Slot = "28")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012D8A")]
      [Address(RVA = "0x3FC4C8C", Offset = "0x3FC4C8C", VA = "0x3FC4C8C", Slot = "29")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012D8B")]
      [Address(RVA = "0x3FC4C9C", Offset = "0x3FC4C9C", VA = "0x3FC4C9C", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012D8C")]
      [Address(RVA = "0x3FC4D24", Offset = "0x3FC4D24", VA = "0x3FC4D24", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012D8D")]
      [Address(RVA = "0x3FC4DAC", Offset = "0x3FC4DAC", VA = "0x3FC4DAC", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012D8E")]
      [Address(RVA = "0x3FC4DB0", Offset = "0x3FC4DB0", VA = "0x3FC4DB0", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }
    }

    [Token(Token = "0x200302A")]
    private class DebugRental : Rental, AdvViewerModelReverseLookup.IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x6012DA1")]
      [Address(RVA = "0x3FBFE78", Offset = "0x3FBFE78", VA = "0x3FBFE78")]
      public DebugRental(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012DA2")]
      [Address(RVA = "0x3FC4F7C", Offset = "0x3FC4F7C", VA = "0x3FC4F7C", Slot = "28")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012DA3")]
      [Address(RVA = "0x3FC4F8C", Offset = "0x3FC4F8C", VA = "0x3FC4F8C", Slot = "29")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012DA4")]
      [Address(RVA = "0x3FC4F9C", Offset = "0x3FC4F9C", VA = "0x3FC4F9C", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012DA5")]
      [Address(RVA = "0x3FC5024", Offset = "0x3FC5024", VA = "0x3FC5024", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012DA6")]
      [Address(RVA = "0x3FC50AC", Offset = "0x3FC50AC", VA = "0x3FC50AC", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012DA7")]
      [Address(RVA = "0x3FC50B0", Offset = "0x3FC50B0", VA = "0x3FC50B0", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }
    }

    [Token(Token = "0x200302E")]
    private class DebugWorkMediation : 
      WorkMediation,
      AdvViewerModelReverseLookup.IDebugFacilityAdvPlayer
    {
      [Token(Token = "0x6012DBA")]
      [Address(RVA = "0x3FBFE80", Offset = "0x3FBFE80", VA = "0x3FBFE80")]
      public DebugWorkMediation(
        FreeMapFacilityEventUIParam param,
        FreeMapCommonElement commonElement)
      {
      }

      [Token(Token = "0x6012DBB")]
      [Address(RVA = "0x3FC527C", Offset = "0x3FC527C", VA = "0x3FC527C", Slot = "28")]
      public void Load(FreeMapPlayerInstance activePlayer)
      {
      }

      [Token(Token = "0x6012DBC")]
      [Address(RVA = "0x3FC528C", Offset = "0x3FC528C", VA = "0x3FC528C", Slot = "29")]
      public IEnumerator DebugPlay() => (IEnumerator) null;

      [Token(Token = "0x6012DBD")]
      [Address(RVA = "0x3FC531C", Offset = "0x3FC531C", VA = "0x3FC531C", Slot = "23")]
      protected override IEnumerator OnIconEventBegin() => (IEnumerator) null;

      [Token(Token = "0x6012DBE")]
      [Address(RVA = "0x3FC53A4", Offset = "0x3FC53A4", VA = "0x3FC53A4", Slot = "24")]
      protected override IEnumerator OnIconEventFinish() => (IEnumerator) null;

      [Token(Token = "0x6012DBF")]
      [Address(RVA = "0x3FC542C", Offset = "0x3FC542C", VA = "0x3FC542C", Slot = "25")]
      protected override void OnCancel()
      {
      }

      [Token(Token = "0x6012DC0")]
      [Address(RVA = "0x3FC5430", Offset = "0x3FC5430", VA = "0x3FC5430", Slot = "26")]
      protected override IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
      {
        return (IEnumerator) null;
      }
    }
  }
}
