// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.BattleResultSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Network;
using Network.API;
using Network.Param;
using Scenes.OutGame.Battle;
using Scenes.Story.MainQuest;
using staq.SaveData;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003192")]
  public class BattleResultSubScene : SubScene
  {
    [Token(Token = "0x400D31A")]
    private const string ResultUIAssetBundleName = "ui_page_ingame_battleresult_prefab";
    [Token(Token = "0x400D31B")]
    private const string ThumbBaseAssetbundleName = "ui_common";
    [Token(Token = "0x400D31C")]
    private const string ThumbRarityTextAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400D31D")]
    private const string ApPopAssetBundleName = "ui_page_aprecover_prefab";
    [Token(Token = "0x400D31E")]
    private const string directAssetBundleName = "content_effect_common_ui_effect_stylelvup_prefab";
    [Token(Token = "0x400D31F")]
    [FieldOffset(Offset = "0x58")]
    private string questResultActivateName;
    [Token(Token = "0x400D320")]
    [FieldOffset(Offset = "0x60")]
    private string resultMissionPartsPrefab;
    [Token(Token = "0x400D321")]
    private const string QUEST_PREPARE_BG_BUNDLE_NAME = "ui_bg";
    [Token(Token = "0x400D322")]
    private const string QUEST_PREPARE_BG_ASSET_NAME = "Container_QuestBG";
    [Token(Token = "0x400D323")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private string resultBgInAnimName;
    [Token(Token = "0x400D324")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private string resultBgOutAnimName;
    [Token(Token = "0x400D325")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400D326")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Transform safeArea;
    [Token(Token = "0x400D327")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Button screenButton;
    [Token(Token = "0x400D328")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ResultQuestMissionView missionPanelPrefab;
    [Token(Token = "0x400D329")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private UnitView unitViewPrefab;
    [Token(Token = "0x400D32A")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private ResultDropItemView resultDropItemViewPrefab;
    [Token(Token = "0x400D32B")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private RectTransform root;
    [Token(Token = "0x400D32C")]
    [FieldOffset(Offset = "0xB0")]
    private BattleResultSubScene.Parameter sceneParameter;
    [Token(Token = "0x400D32D")]
    [FieldOffset(Offset = "0xB8")]
    private Queue<IBattleResultFlow> viewBaseQueue;
    [Token(Token = "0x400D32E")]
    [FieldOffset(Offset = "0xC0")]
    private ResultQuestMissionView missionView;
    [Token(Token = "0x400D32F")]
    [FieldOffset(Offset = "0xC8")]
    private UnitView unitView;
    [Token(Token = "0x400D330")]
    [FieldOffset(Offset = "0xD0")]
    private SupportLevelupView supportLevelupView;
    [Token(Token = "0x400D331")]
    [FieldOffset(Offset = "0xD8")]
    private ResultDropItemView resultDropItemView;
    [Token(Token = "0x400D332")]
    [FieldOffset(Offset = "0xE0")]
    private MainQuestSceneParameter mainQuestSceneParameter;
    [Token(Token = "0x400D333")]
    [FieldOffset(Offset = "0xE8")]
    private List<BattleResultSubScene.MissionData> mainMissionDatas;
    [Token(Token = "0x400D334")]
    [FieldOffset(Offset = "0xF0")]
    private List<BattleResultSubScene.MissionData> subMissionDatas;
    [Token(Token = "0x400D335")]
    [FieldOffset(Offset = "0xF8")]
    public bool isLoadingAssetBundle;
    [Token(Token = "0x400D336")]
    [FieldOffset(Offset = "0x100")]
    private List<string>[] loadWaitAssetbundleNameList;
    [Token(Token = "0x400D337")]
    [FieldOffset(Offset = "0x108")]
    private int loadWaitAssetbundleNameListOfs;
    [Token(Token = "0x400D338")]
    [FieldOffset(Offset = "0x110")]
    private Coroutine loadAssetBundleCoroutine;
    [Token(Token = "0x400D339")]
    [FieldOffset(Offset = "0x118")]
    private int missionZenny;
    [Token(Token = "0x400D33A")]
    [FieldOffset(Offset = "0x120")]
    private GameCore.AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D33C")]
    [FieldOffset(Offset = "0x130")]
    private bool isDubugMode;

    [Token(Token = "0x6013571")]
    [Address(RVA = "0x4A33AE8", Offset = "0x4A33AE8", VA = "0x4A33AE8")]
    public static void ChangeSceneForSkip(
      QuestInfo questInfo,
      int deckNo,
      int skipCount,
      List<string> skipBattleUnitIds)
    {
    }

    [Token(Token = "0x170040A9")]
    public static string SceneName
    {
      [Token(Token = "0x6013572"), Address(RVA = "0x4A302A8", Offset = "0x4A302A8", VA = "0x4A302A8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170040AA")]
    public static string AssetBundleName
    {
      [Token(Token = "0x6013573"), Address(RVA = "0x4A302E8", Offset = "0x4A302E8", VA = "0x4A302E8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170040AB")]
    public static string AssetName
    {
      [Token(Token = "0x6013574"), Address(RVA = "0x4A30328", Offset = "0x4A30328", VA = "0x4A30328")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170040AC")]
    public UITweenGroup TweenGroup
    {
      [Token(Token = "0x6013575"), Address(RVA = "0x4A33D84", Offset = "0x4A33D84", VA = "0x4A33D84")] get
      {
        return (UITweenGroup) null;
      }
    }

    [Token(Token = "0x170040AD")]
    public ResultQuestMissionView MissionView
    {
      [Token(Token = "0x6013576"), Address(RVA = "0x4A33D8C", Offset = "0x4A33D8C", VA = "0x4A33D8C")] get
      {
        return (ResultQuestMissionView) null;
      }
    }

    [Token(Token = "0x170040AE")]
    public UnitView UnitView
    {
      [Token(Token = "0x6013577"), Address(RVA = "0x4A33E04", Offset = "0x4A33E04", VA = "0x4A33E04")] get
      {
        return (UnitView) null;
      }
    }

    [Token(Token = "0x170040AF")]
    public ResultDropItemView ResultDropItemView
    {
      [Token(Token = "0x6013578"), Address(RVA = "0x4A33E7C", Offset = "0x4A33E7C", VA = "0x4A33E7C")] get
      {
        return (ResultDropItemView) null;
      }
    }

    [Token(Token = "0x6013579")]
    [Address(RVA = "0x4A33F50", Offset = "0x4A33F50", VA = "0x4A33F50")]
    public GameCore.AssetCachedSpawner AssetCachedSpawner() => (GameCore.AssetCachedSpawner) null;

    [Token(Token = "0x170040B0")]
    public ItemDetailPopupProvider ItemDetailPopupProvider
    {
      [Token(Token = "0x601357A"), Address(RVA = "0x4A33F58", Offset = "0x4A33F58", VA = "0x4A33F58")] get
      {
        return (ItemDetailPopupProvider) null;
      }
      [Token(Token = "0x601357B"), Address(RVA = "0x4A33F60", Offset = "0x4A33F60", VA = "0x4A33F60")] private set
      {
      }
    }

    [Token(Token = "0x170040B1")]
    private bool IsBeforAreaQuestNodeClear
    {
      [Token(Token = "0x601357C"), Address(RVA = "0x4A33F68", Offset = "0x4A33F68", VA = "0x4A33F68")] get
      {
        return new bool();
      }
      [Token(Token = "0x601357D"), Address(RVA = "0x4A33F70", Offset = "0x4A33F70", VA = "0x4A33F70")] set
      {
      }
    }

    [Token(Token = "0x601357E")]
    [Address(RVA = "0x4A33F7C", Offset = "0x4A33F7C", VA = "0x4A33F7C", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x601357F")]
    [Address(RVA = "0x4A342D8", Offset = "0x4A342D8", VA = "0x4A342D8", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6013580")]
    [Address(RVA = "0x4A34340", Offset = "0x4A34340", VA = "0x4A34340")]
    private IEnumerator WaitLoadComplete(AssetSpawnOperationBase spawn) => (IEnumerator) null;

    [Token(Token = "0x6013581")]
    [Address(RVA = "0x4A343A8", Offset = "0x4A343A8", VA = "0x4A343A8", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6013582")]
    [Address(RVA = "0x4A348A8", Offset = "0x4A348A8", VA = "0x4A348A8")]
    private IEnumerator ShowResult() => (IEnumerator) null;

    [Token(Token = "0x6013583")]
    [Address(RVA = "0x4A34910", Offset = "0x4A34910", VA = "0x4A34910")]
    private void CreateBg(Sprite bgSprite)
    {
    }

    [Token(Token = "0x6013584")]
    [Address(RVA = "0x4A34B30", Offset = "0x4A34B30", VA = "0x4A34B30")]
    private IEnumerator PlayResultView(IBattleResultFlow flow) => (IEnumerator) null;

    [Token(Token = "0x6013585")]
    [Address(RVA = "0x4A34B98", Offset = "0x4A34B98", VA = "0x4A34B98")]
    public void SetEnableScreenButton(bool enable)
    {
    }

    [Token(Token = "0x6013586")]
    [Address(RVA = "0x4A34BB8", Offset = "0x4A34BB8", VA = "0x4A34BB8")]
    public void OnClickRetry()
    {
    }

    [Token(Token = "0x6013587")]
    [Address(RVA = "0x4A34BBC", Offset = "0x4A34BBC", VA = "0x4A34BBC")]
    private List<PlayerBattleUnitGrade> CreateBattleUnitGrades()
    {
      return (List<PlayerBattleUnitGrade>) null;
    }

    [Token(Token = "0x6013588")]
    [Address(RVA = "0x4A35384", Offset = "0x4A35384", VA = "0x4A35384")]
    private None CreateGuestUnitGrades() => (None) null;

    [Token(Token = "0x6013589")]
    [Address(RVA = "0x4A35A20", Offset = "0x4A35A20", VA = "0x4A35A20")]
    private List<PlayerUnitSupportType> CreateBattleUnitSupports()
    {
      return (List<PlayerUnitSupportType>) null;
    }

    [Token(Token = "0x601358A")]
    [Address(RVA = "0x4A362E4", Offset = "0x4A362E4", VA = "0x4A362E4")]
    private List<PlayerBattleCharacterLp> CreatePlayerBattleCharacterLp()
    {
      return (List<PlayerBattleCharacterLp>) null;
    }

    [Token(Token = "0x601358B")]
    [Address(RVA = "0x4A36840", Offset = "0x4A36840", VA = "0x4A36840")]
    public IEnumerator CallToBattleFinishApi(Action<bool> endCallback) => (IEnumerator) null;

    [Token(Token = "0x601358C")]
    [Address(RVA = "0x4A368B8", Offset = "0x4A368B8", VA = "0x4A368B8")]
    public IEnumerator CallToBattleSkipApi(Action<bool> endCallback) => (IEnumerator) null;

    [Token(Token = "0x601358D")]
    [Address(RVA = "0x4A3692C", Offset = "0x4A3692C", VA = "0x4A3692C")]
    private List<PlayerBattleWeaponGrade> CreatePlayerBattleWeaponGrades()
    {
      return (List<PlayerBattleWeaponGrade>) null;
    }

    [Token(Token = "0x601358E")]
    [Address(RVA = "0x4A37110", Offset = "0x4A37110", VA = "0x4A37110")]
    private List<PlayerBattleWeaponProficiency> CreatePlayerBattleWeaponProficiency(
      int? limitWeaponProficiency)
    {
      return (List<PlayerBattleWeaponProficiency>) null;
    }

    [Token(Token = "0x601358F")]
    [Address(RVA = "0x4A37B4C", Offset = "0x4A37B4C", VA = "0x4A37B4C")]
    private BattleSettingsParameters CreateBattleSettingsParameters(
      BattleSettingsSaveData battleSettings)
    {
      return (BattleSettingsParameters) null;
    }

    [Token(Token = "0x170040B2")]
    private IReadOnlyList<int> AchievedMissionIds
    {
      [Token(Token = "0x6013590"), Address(RVA = "0x4A37BD8", Offset = "0x4A37BD8", VA = "0x4A37BD8")] get
      {
        return (IReadOnlyList<int>) null;
      }
    }

    [Token(Token = "0x6013591")]
    [Address(RVA = "0x4A37CBC", Offset = "0x4A37CBC", VA = "0x4A37CBC")]
    private void CreateAchievedMainMission(int missionId = 0, IReadOnlyList<int> achievedMissionIds = null)
    {
    }

    [Token(Token = "0x6013592")]
    [Address(RVA = "0x4A37E7C", Offset = "0x4A37E7C", VA = "0x4A37E7C")]
    private void UpdateAfterAchievedMainMission(IReadOnlyList<int> achievedMissionIds)
    {
    }

    [Token(Token = "0x6013593")]
    [Address(RVA = "0x4A37FF0", Offset = "0x4A37FF0", VA = "0x4A37FF0")]
    private void CreateAchievedSubMission(
      int storyBattleMissionSetID = -1,
      IReadOnlyList<int> achievedMissionIds = null)
    {
    }

    [Token(Token = "0x6013594")]
    [Address(RVA = "0x4A381A8", Offset = "0x4A381A8", VA = "0x4A381A8")]
    private void UpdateAfterAchievedSubMission(IReadOnlyList<int> achievedMissionIds)
    {
    }

    [Token(Token = "0x6013595")]
    [Address(RVA = "0x4A3831C", Offset = "0x4A3831C", VA = "0x4A3831C")]
    public void OnClickExitResult()
    {
    }

    [Token(Token = "0x170040B3")]
    private HashSet<int> CharacterHashOnDeck
    {
      [Token(Token = "0x6013596"), Address(RVA = "0x4A35DA0", Offset = "0x4A35DA0", VA = "0x4A35DA0")] get
      {
        return (HashSet<int>) null;
      }
    }

    [Token(Token = "0x170040B4")]
    private List<int> StylePositionListOnDeck
    {
      [Token(Token = "0x6013597"), Address(RVA = "0x4A38474", Offset = "0x4A38474", VA = "0x4A38474")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x6013598")]
    [Address(RVA = "0x4A38860", Offset = "0x4A38860", VA = "0x4A38860")]
    private IEnumerator OnRequestFailed(NetworkErrorResult networkErrorResult, Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013599")]
    [Address(RVA = "0x4A388C8", Offset = "0x4A388C8", VA = "0x4A388C8")]
    private IEnumerator MainQuestBattleEndConnect(
      APIStoryMainquestBattleEnd api,
      APIStoryMainquestBattleEndRequest request,
      Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601359A")]
    [Address(RVA = "0x4A38950", Offset = "0x4A38950", VA = "0x4A38950")]
    private void OnSucceededMainBattleEnd(
      APIStoryMainquestBattleEndRequest request,
      APIStoryMainquestBattleEndResponse response)
    {
    }

    [Token(Token = "0x601359B")]
    [Address(RVA = "0x4A391A0", Offset = "0x4A391A0", VA = "0x4A391A0")]
    private IEnumerator SubQuestBattleEndConnect(APIStorySubquestBattleEnd api, Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601359C")]
    [Address(RVA = "0x4A3921C", Offset = "0x4A3921C", VA = "0x4A3921C")]
    private void OnSuceededSubBattleEnd(APIStorySubquestBattleEndResponse response)
    {
    }

    [Token(Token = "0x601359D")]
    [Address(RVA = "0x4A39820", Offset = "0x4A39820", VA = "0x4A39820")]
    private IEnumerator FreeBattleEndConnect(APIFreeQuestBattleEnd api, Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601359E")]
    [Address(RVA = "0x4A3989C", Offset = "0x4A3989C", VA = "0x4A3989C")]
    private void OnSuceededFreeBattleEnd(APIFreeQuestBattleEndResponse response)
    {
    }

    [Token(Token = "0x601359F")]
    [Address(RVA = "0x4A39D54", Offset = "0x4A39D54", VA = "0x4A39D54")]
    private IEnumerator ObliviaeBattleEndConnect(APIStoryObliviaeBattleEnd api, Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60135A0")]
    [Address(RVA = "0x4A39DD0", Offset = "0x4A39DD0", VA = "0x4A39DD0")]
    private void OnSuceededObliviaeBattleEnd(APIStoryObliviaeBattleEndResponse response)
    {
    }

    [Token(Token = "0x60135A1")]
    [Address(RVA = "0x4A3A2EC", Offset = "0x4A3A2EC", VA = "0x4A3A2EC")]
    private IEnumerator ScenarioMainQuestBattleEndConnect(
      APIScenarioEventMainQuestBattleEnd api,
      APIScenarioEventMainQuestBattleEndRequest request,
      Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60135A2")]
    [Address(RVA = "0x4A3A374", Offset = "0x4A3A374", VA = "0x4A3A374")]
    private void OnSucceededScenarioMainBattleEnd(
      APIScenarioEventMainQuestBattleEndRequest request,
      APIScenarioEventMainQuestBattleEndResponse response)
    {
    }

    [Token(Token = "0x60135A3")]
    [Address(RVA = "0x4A3A918", Offset = "0x4A3A918", VA = "0x4A3A918")]
    private IEnumerator ScenarioSubQuestBattleEndConnect(
      APIScenarioEventSubQuestBattleEnd api,
      Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60135A4")]
    [Address(RVA = "0x4A3A994", Offset = "0x4A3A994", VA = "0x4A3A994")]
    private void OnSuceededScenarioSubBattleEnd(APIScenarioEventSubQuestBattleEndResponse response)
    {
    }

    [Token(Token = "0x60135A5")]
    [Address(RVA = "0x4A3AF98", Offset = "0x4A3AF98", VA = "0x4A3AF98")]
    private IEnumerator ScenarioFreeBattleEndConnect(
      APIScenarioEventFreeQuestBattleEnd api,
      Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60135A6")]
    [Address(RVA = "0x4A3B014", Offset = "0x4A3B014", VA = "0x4A3B014")]
    private void OnSuceededScenarioFreeBattleEnd(
      APIScenarioEventFreeQuestBattleEndResponse response)
    {
    }

    [Token(Token = "0x60135A7")]
    [Address(RVA = "0x4A3B4CC", Offset = "0x4A3B4CC", VA = "0x4A3B4CC")]
    private void OnSuceededFreeBattleSkip(APIBattleFreequestSkipResponse response)
    {
    }

    [Token(Token = "0x60135A8")]
    [Address(RVA = "0x4A3B880", Offset = "0x4A3B880", VA = "0x4A3B880")]
    private void OnSuceededLimitedQuestBattleSkip(APIBattleLimitedeventquestSkipResponse response)
    {
    }

    [Token(Token = "0x60135A9")]
    [Address(RVA = "0x4A3BC34", Offset = "0x4A3BC34", VA = "0x4A3BC34")]
    private void OnSuceededScenarioFreeBattleSkip(
      APIScenarioEventFreeQuestBattleSkipResponse response)
    {
    }

    [Token(Token = "0x60135AA")]
    [Address(RVA = "0x4A3BFE8", Offset = "0x4A3BFE8", VA = "0x4A3BFE8")]
    private void OnSuceededAreaQuestBattleSkip(APIAreaQuestBattleSkipResponse response)
    {
    }

    [Token(Token = "0x60135AB")]
    [Address(RVA = "0x4A3C39C", Offset = "0x4A3C39C", VA = "0x4A3C39C")]
    private IEnumerator LimitedQuestBattleEndConnect(
      APILimitedEventQuestBattleEnd api,
      Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60135AC")]
    [Address(RVA = "0x4A3C418", Offset = "0x4A3C418", VA = "0x4A3C418")]
    private void OnSucceededLimitedQuestBattleBattleEnd(
      APILimitedEventQuestBattleEndResponse response)
    {
    }

    [Token(Token = "0x60135AD")]
    [Address(RVA = "0x4A3C8D0", Offset = "0x4A3C8D0", VA = "0x4A3C8D0")]
    private IEnumerator SpecialQuestBattleEndConnect(APISpecialQuestBattleEnd api, Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60135AE")]
    [Address(RVA = "0x4A3C94C", Offset = "0x4A3C94C", VA = "0x4A3C94C")]
    private void OnSucceededSpecialQuestBattleEnd(APISpecialQuestBattleEndResponse response)
    {
    }

    [Token(Token = "0x60135AF")]
    [Address(RVA = "0x4A3CE04", Offset = "0x4A3CE04", VA = "0x4A3CE04")]
    private IEnumerator AreaQuestBattleEndConnect(APIAreaQuestBattleEnd api, Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60135B0")]
    [Address(RVA = "0x4A3CE80", Offset = "0x4A3CE80", VA = "0x4A3CE80")]
    private void OnSucceededAreaQuestBattleEnd(APIAreaQuestBattleEndResponse response)
    {
    }

    [Token(Token = "0x60135B1")]
    [Address(RVA = "0x4A38EF4", Offset = "0x4A38EF4", VA = "0x4A38EF4")]
    private void ApplyBattle(PlayerBattleResult playerBattleResult)
    {
    }

    [Token(Token = "0x60135B2")]
    [Address(RVA = "0x4A39140", Offset = "0x4A39140", VA = "0x4A39140")]
    private void ApplyUnit(List<PlayerUnitType> afterUnits)
    {
    }

    [Token(Token = "0x60135B3")]
    [Address(RVA = "0x4A390E0", Offset = "0x4A390E0", VA = "0x4A390E0")]
    private void ApplySupport(IReadOnlyList<PlayerUnitSupportType> afterSupports)
    {
    }

    [Token(Token = "0x60135B4")]
    [Address(RVA = "0x4A3D358", Offset = "0x4A3D358", VA = "0x4A3D358")]
    public void AddLoadAssetBundle(string name)
    {
    }

    [Token(Token = "0x60135B5")]
    [Address(RVA = "0x4A34270", Offset = "0x4A34270", VA = "0x4A34270")]
    public IEnumerator SetLoadingAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x60135B6")]
    [Address(RVA = "0x4A3D430", Offset = "0x4A3D430", VA = "0x4A3D430")]
    private void Update()
    {
    }

    [Token(Token = "0x60135B7")]
    [Address(RVA = "0x4A37830", Offset = "0x4A37830", VA = "0x4A37830")]
    private IEnumerable<Style> GetLoadTargetStyles() => (IEnumerable<Style>) null;

    [Token(Token = "0x60135B8")]
    [Address(RVA = "0x4A3D44C", Offset = "0x4A3D44C", VA = "0x4A3D44C")]
    public BattleResultSubScene()
    {
    }

    [Token(Token = "0x2003193")]
    public sealed class Parameter : ChangeSceneParameter
    {
      [Token(Token = "0x400D33E")]
      [FieldOffset(Offset = "0x18")]
      public string battleUuid;
      [Token(Token = "0x400D33F")]
      [FieldOffset(Offset = "0x20")]
      public int questID;
      [Token(Token = "0x400D340")]
      [FieldOffset(Offset = "0x24")]
      public QuestTypeEnum questType;
      [Token(Token = "0x400D341")]
      [FieldOffset(Offset = "0x28")]
      public int subquestTaskID;
      [Token(Token = "0x400D342")]
      [FieldOffset(Offset = "0x2C")]
      public int deckIdx;
      [Token(Token = "0x400D343")]
      [FieldOffset(Offset = "0x30")]
      public IReadOnlyList<IUnitPlacementData> enemyPlacements;
      [Token(Token = "0x400D344")]
      [FieldOffset(Offset = "0x38")]
      public IReadOnlyList<UnitParameterData> playerUnits;
      [Token(Token = "0x400D345")]
      [FieldOffset(Offset = "0x40")]
      public IReadOnlyList<UnitParameterData> guestUnits;
      [Token(Token = "0x400D346")]
      [FieldOffset(Offset = "0x48")]
      public CharacterSupportData playerSupports;
      [Token(Token = "0x400D347")]
      [FieldOffset(Offset = "0x50")]
      public List<int> achievedMissionIds;
      [Token(Token = "0x400D348")]
      [FieldOffset(Offset = "0x58")]
      public List<int> achievedStoryBattlemissionIds;
      [Token(Token = "0x400D349")]
      [FieldOffset(Offset = "0x60")]
      public List<WatchedBattleAdvData> watchedAdvParams;
      [Token(Token = "0x400D34A")]
      [FieldOffset(Offset = "0x68")]
      public int firstClearRewardGroupID;
      [Token(Token = "0x400D34B")]
      [FieldOffset(Offset = "0x6C")]
      public int beforeClearCount;
      [Token(Token = "0x400D34C")]
      [FieldOffset(Offset = "0x70")]
      public List<PlayerBattleConsumedExpendable> expendableInfos;
      [Token(Token = "0x400D34D")]
      [FieldOffset(Offset = "0x78")]
      public List<int> openedChestIds;
      [Token(Token = "0x400D34E")]
      [FieldOffset(Offset = "0x80")]
      public int skipCount;
      [Token(Token = "0x400D34F")]
      [FieldOffset(Offset = "0x88")]
      public List<string> skipBattleUnitIds;
      [Token(Token = "0x400D350")]
      [FieldOffset(Offset = "0x90")]
      public Dictionary<int, int> UnitLevelReachedDic;

      [Token(Token = "0x60135B9")]
      [Address(RVA = "0x4DFE05C", Offset = "0x4DFE05C", VA = "0x4DFE05C")]
      public Parameter()
      {
      }
    }

    [Token(Token = "0x2003194")]
    public class MissionData
    {
      [Token(Token = "0x170040B5")]
      public int ID
      {
        [Token(Token = "0x60135BA"), Address(RVA = "0x4DFE0DC", Offset = "0x4DFE0DC", VA = "0x4DFE0DC")] get
        {
          return new int();
        }
        [Token(Token = "0x60135BB"), Address(RVA = "0x4DFE0E4", Offset = "0x4DFE0E4", VA = "0x4DFE0E4")] private set
        {
        }
      }

      [Token(Token = "0x170040B6")]
      public bool IsCompleteBefore
      {
        [Token(Token = "0x60135BC"), Address(RVA = "0x4DFE0EC", Offset = "0x4DFE0EC", VA = "0x4DFE0EC")] get
        {
          return new bool();
        }
        [Token(Token = "0x60135BD"), Address(RVA = "0x4DFE0F4", Offset = "0x4DFE0F4", VA = "0x4DFE0F4")] private set
        {
        }
      }

      [Token(Token = "0x170040B7")]
      public bool IsCompleteAfter
      {
        [Token(Token = "0x60135BE"), Address(RVA = "0x4DFE100", Offset = "0x4DFE100", VA = "0x4DFE100")] get
        {
          return new bool();
        }
        [Token(Token = "0x60135BF"), Address(RVA = "0x4DFE108", Offset = "0x4DFE108", VA = "0x4DFE108")] private set
        {
        }
      }

      [Token(Token = "0x60135C0")]
      [Address(RVA = "0x4DFE114", Offset = "0x4DFE114", VA = "0x4DFE114")]
      public MissionData(int id, bool isComplete)
      {
      }

      [Token(Token = "0x60135C1")]
      [Address(RVA = "0x4DFE14C", Offset = "0x4DFE14C", VA = "0x4DFE14C")]
      public void UpdateAfter(bool isComplete)
      {
      }
    }
  }
}
