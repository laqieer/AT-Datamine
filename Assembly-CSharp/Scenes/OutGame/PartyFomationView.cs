// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PartyFomationView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using Il2CppDummyDll;
using QuestPrepare;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;
using TMPro;
using UI.Common;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200329C")]
  public class PartyFomationView : MonoBehaviour
  {
    [Token(Token = "0x400D8B4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400D8B5")]
    private const string PartyTimeLineAssetbundleName = "ui_page_partylist_partyformation_timeline";
    [Token(Token = "0x400D8B6")]
    private const string PartyTimeLinePartyFormationName = "Formation";
    [Token(Token = "0x400D8B7")]
    private const string PartyTimeLinePartyFormationChangeName = "Formation_Replacement";
    [Token(Token = "0x400D8B8")]
    private const string PartyTimeLineChangeMenu = "ChangeMenu";
    [Token(Token = "0x400D8B9")]
    private const string ColiseumPartyTimeLineAssetbundleName = "ui_page_arena_coliseumformation_timeline";
    [Token(Token = "0x400D8BA")]
    private const string ColiseumPartyTimeLinePartyFormationName = "ColiseumFormation";
    [Token(Token = "0x400D8BB")]
    private const string ColiseumPartyTimeLinePartyFormationChangeName = "ColiseumFormation_Replacement";
    [Token(Token = "0x400D8BC")]
    private const string StyleEditAssetBundleName = "ui_page_partylist";
    [Token(Token = "0x400D8BD")]
    private const string StyleEditPopupPrefabName = "Com_Popup_Bottom_Edit_Style";
    [Token(Token = "0x400D8BE")]
    private const string EquipmentEditPopupPrefabName = "Com_Popup_Bottom_Edit_Equip";
    [Token(Token = "0x400D8BF")]
    private const string AccessoryEditPopupPrefabName = "Com_Popup_Bottom_Edit_Shield";
    [Token(Token = "0x400D8C0")]
    private const string UnitTrustEditPopupPrefabName = "Com_Popup_Bottom_Edit_Trust";
    [Token(Token = "0x400D8C1")]
    private const string MindEquipmentEditPopupPrefabName = "Com_Popup_Bottom_Edit_Nensou";
    [Token(Token = "0x400D8C2")]
    private const string PartyAllClearPopupPrefabName = "Com_Popup_Base_S_PartyAllClear";
    [Token(Token = "0x400D8C3")]
    private const string PartyRevertPopupPrefabName = "Com_Popup_Base_S_PartyDiscardEdits";
    [Token(Token = "0x400D8C4")]
    private const string WeaponProficiencyAssetbundleName = "ui_page_partylist_weaponproficiency";
    [Token(Token = "0x400D8C5")]
    private const string WeaponProficiencyPopupName = "Com_Popup_WeaponProficiency";
    [Token(Token = "0x400D8C6")]
    private const string PartySkillPopupAssetbundleName = "ui_page_partylist_partyskill";
    [Token(Token = "0x400D8C7")]
    private const string PartySkillPopupName = "Com_Popup_PartySkill";
    [Token(Token = "0x400D8C8")]
    private const string PartyListAssetBundleName = "ui_page_partylist";
    [Token(Token = "0x400D8C9")]
    private const string TeamNameChangePrefabName = "Com_Popup_Base_S_InputText";
    [Token(Token = "0x400D8CA")]
    private const string PartyListItemEditAssetBundleName = "ui_page_partylist_itemedit";
    [Token(Token = "0x400D8CB")]
    private const string ItemSetListPrefabName = "Com_Popup_ItemList";
    [Token(Token = "0x400D8CC")]
    private const string TeamSelectPopupAssetbundleName = "ui_page_partylist_partyformation";
    [Token(Token = "0x400D8CD")]
    private const string TeamSelectPopupName = "Com_Popup_Base_L_TeamSelection";
    [Token(Token = "0x400D8CE")]
    private const string CopyTeamSelectPopupName = "Com_Popup_Base_L_TeamCopy";
    [Token(Token = "0x400D8CF")]
    public const string UnitNumberAssetBundleName = "ui_page_partylist_texture";
    [Token(Token = "0x400D8D0")]
    private const string UnitNumberAssetName = "Img_Num_UnitNumber_Atlas";
    [Token(Token = "0x400D8D1")]
    private const string SortieLimitAssetbundleName = "ui_page_questdetail_prefab";
    [Token(Token = "0x400D8D2")]
    private const string SortieLimitPopupName = "Com_Popup_QuestDetail_SortieRestrictOnly";
    [Token(Token = "0x400D8D3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup viewCanvasGroup;
    [Token(Token = "0x400D8D4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject loadingPanel;
    [Token(Token = "0x400D8D5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TeamView teamView;
    [Token(Token = "0x400D8D6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI teamNameText;
    [Token(Token = "0x400D8D7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text teamTotalCombatPowerText;
    [Token(Token = "0x400D8D8")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image teamNumImage1;
    [Token(Token = "0x400D8D9")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image teamNumImage2;
    [Token(Token = "0x400D8DA")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private FormationUnitNumDotView teamUnitNumDotView;
    [Token(Token = "0x400D8DB")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private PartyFormationSubMenuView subMenuView;
    [Token(Token = "0x400D8DC")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject prevButtonObj;
    [Token(Token = "0x400D8DD")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject nextButtonObj;
    [Token(Token = "0x400D8DE")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Transform partyFormationLayoutGroup;
    [Token(Token = "0x400D8DF")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Toggle partyTypeToggle1;
    [Token(Token = "0x400D8E0")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Toggle partyTypeToggle2;
    [Token(Token = "0x400D8E1")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Toggle partyTypeToggle3;
    [Token(Token = "0x400D8E2")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private FormationItemSetView itemSetView;
    [Token(Token = "0x400D8E3")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CanvasGroup partyFormationUnitChange;
    [Token(Token = "0x400D8E4")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private PartySlotSortingView teamSortingView;
    [Token(Token = "0x400D8E5")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CanvasGroup[] unitChangeOffCanvas;
    [Token(Token = "0x400D8E6")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject partyFormationSortieRestrictionsView;
    [Token(Token = "0x400D8E7")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CommonGesturePanel commonGesturePanel;
    [Token(Token = "0x400D8E8")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private CommonButton copyButton;
    [Token(Token = "0x400D8E9")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400D8EA")]
    [FieldOffset(Offset = "0xD8")]
    private int partyUnitIndex;
    [Token(Token = "0x400D8EB")]
    [FieldOffset(Offset = "0xDC")]
    private float partyInitpos;
    [Token(Token = "0x400D8EC")]
    [FieldOffset(Offset = "0xE0")]
    private StyleEditPopup styleEditPrefab;
    [Token(Token = "0x400D8ED")]
    [FieldOffset(Offset = "0xE8")]
    private StyleEditPopup styleEditPopup;
    [Token(Token = "0x400D8EE")]
    [FieldOffset(Offset = "0xF0")]
    private EquipEditPopup equipWeaponEditPrefab;
    [Token(Token = "0x400D8EF")]
    [FieldOffset(Offset = "0xF8")]
    private EquipEditPopup equipAccessoryEditPrefab;
    [Token(Token = "0x400D8F0")]
    [FieldOffset(Offset = "0x100")]
    private EquipEditPopup equipMindEditPrefab;
    [Token(Token = "0x400D8F1")]
    [FieldOffset(Offset = "0x108")]
    private EquipEditPopup equipTrustEditPrefab;
    [Token(Token = "0x400D8F2")]
    [FieldOffset(Offset = "0x110")]
    private EquipEditPopup equipEditPopup;
    [Token(Token = "0x400D8F3")]
    [FieldOffset(Offset = "0x118")]
    private GameObject weaponProficiencyPopupPrefab;
    [Token(Token = "0x400D8F4")]
    [FieldOffset(Offset = "0x120")]
    private WeaponProficiencyPopup weaponProficiencyPopup;
    [Token(Token = "0x400D8F5")]
    [FieldOffset(Offset = "0x128")]
    private GameObject partySkillPrefab;
    [Token(Token = "0x400D8F6")]
    [FieldOffset(Offset = "0x130")]
    private PartySkillPopup partySkillPopup;
    [Token(Token = "0x400D8F7")]
    [FieldOffset(Offset = "0x138")]
    private PartyConfirmationPopup partyAllClearPrefab;
    [Token(Token = "0x400D8F8")]
    [FieldOffset(Offset = "0x140")]
    private PartyConfirmationPopup partyAllClearPopup;
    [Token(Token = "0x400D8F9")]
    [FieldOffset(Offset = "0x148")]
    private PartyConfirmationPopup partyRevertPrefab;
    [Token(Token = "0x400D8FA")]
    [FieldOffset(Offset = "0x150")]
    private PartyConfirmationPopup partyRevertPopup;
    [Token(Token = "0x400D8FB")]
    [FieldOffset(Offset = "0x158")]
    private TeamNameChangePopup teamNameChangePrefab;
    [Token(Token = "0x400D8FC")]
    [FieldOffset(Offset = "0x160")]
    private TeamNameChangePopup teamNameChangePopup;
    [Token(Token = "0x400D8FD")]
    [FieldOffset(Offset = "0x168")]
    private ItemSetListPopup itemSetListPrefab;
    [Token(Token = "0x400D8FE")]
    [FieldOffset(Offset = "0x170")]
    private ItemSetListPopup itemSetListPopup;
    [Token(Token = "0x400D8FF")]
    [FieldOffset(Offset = "0x178")]
    private TeamSelectionPopup teamSelectPrefab;
    [Token(Token = "0x400D900")]
    [FieldOffset(Offset = "0x180")]
    private TeamSelectionPopup teamSelectPopup;
    [Token(Token = "0x400D901")]
    [FieldOffset(Offset = "0x188")]
    private SortieLimitPopup sortieLimitPrefab;
    [Token(Token = "0x400D902")]
    [FieldOffset(Offset = "0x190")]
    private SortieLimitPopup sortieLimitPopup;
    [Token(Token = "0x400D903")]
    [FieldOffset(Offset = "0x198")]
    private CopyTeamSelectionPopup copyTeamSelectionPrefab;
    [Token(Token = "0x400D904")]
    [FieldOffset(Offset = "0x1A0")]
    private CopyTeamSelectionPopup copyTeamSelectionPopup;
    [Token(Token = "0x400D905")]
    [FieldOffset(Offset = "0x1A8")]
    private OrganizationTeam organizationTeam;
    [Token(Token = "0x400D906")]
    [FieldOffset(Offset = "0x1B0")]
    private bool isQuest;
    [Token(Token = "0x400D907")]
    [FieldOffset(Offset = "0x1B4")]
    private int menberNum;
    [Token(Token = "0x400D908")]
    [FieldOffset(Offset = "0x1B8")]
    public ElementTypeEnum enemyElement;
    [Token(Token = "0x400D909")]
    [FieldOffset(Offset = "0x1C0")]
    private BattleSortieRestrictionsCheck battleSortieRestrictionsCheck;
    [Token(Token = "0x400D90A")]
    [FieldOffset(Offset = "0x1C8")]
    private BattleForcedSortieCheck battleForcedSortieCheck;
    [Token(Token = "0x400D90B")]
    [FieldOffset(Offset = "0x1D0")]
    private OrganizationTeam.TeamSizeType sizeType;
    [Token(Token = "0x400D90C")]
    [FieldOffset(Offset = "0x1D4")]
    private int teamId;
    [Token(Token = "0x400D90D")]
    [FieldOffset(Offset = "0x1D8")]
    private bool isOpenItemSetList;
    [Token(Token = "0x400D90E")]
    [FieldOffset(Offset = "0x1D9")]
    private bool isMovePaly;
    [Token(Token = "0x400D90F")]
    [FieldOffset(Offset = "0x1DC")]
    private float jumpMoveTimeCount;
    [Token(Token = "0x400D910")]
    [FieldOffset(Offset = "0x1E0")]
    [SerializeField]
    private AnimationCurve jumpMoveCurve;
    [Token(Token = "0x400D911")]
    [FieldOffset(Offset = "0x1E8")]
    [SerializeField]
    private float jumpMoveTime;
    [Token(Token = "0x400D912")]
    [FieldOffset(Offset = "0x1F0")]
    [SerializeField]
    private CanvasGroup[] alphaCanvasGroupList;
    [Token(Token = "0x400D913")]
    [FieldOffset(Offset = "0x1F8")]
    [SerializeField]
    private HomeTransitionButton homeTransitionButton;
    [Token(Token = "0x400D914")]
    [FieldOffset(Offset = "0x200")]
    private bool isSlotSorting;
    [Token(Token = "0x400D915")]
    [FieldOffset(Offset = "0x208")]
    private Action<OrganizationTeam, Action> loadAutoFormationListAsset;
    [Token(Token = "0x400D916")]
    [FieldOffset(Offset = "0x210")]
    private CrabWalkCtrl crabWalkCtrl;
    [Token(Token = "0x400D917")]
    [FieldOffset(Offset = "0x218")]
    private bool isOpenStyleOrEquipEditPopup;
    [Token(Token = "0x400D918")]
    [FieldOffset(Offset = "0x219")]
    public bool isNeedLp;
    [Token(Token = "0x400D919")]
    [FieldOffset(Offset = "0x220")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D91A")]
    [FieldOffset(Offset = "0x228")]
    private bool isTeamEdit;
    [Token(Token = "0x400D91B")]
    [FieldOffset(Offset = "0x229")]
    private bool isArena;
    [Token(Token = "0x400D91C")]
    [FieldOffset(Offset = "0x22C")]
    private DeckTypeEnum deckType;
    [Token(Token = "0x400D91D")]
    [FieldOffset(Offset = "0x230")]
    private bool isOpenTeamTypeToggle;
    [Token(Token = "0x400D91E")]
    [FieldOffset(Offset = "0x231")]
    private bool isGuildRaid;
    [Token(Token = "0x400D91F")]
    [FieldOffset(Offset = "0x238")]
    private List<string> usedStyleIds;

    [Token(Token = "0x17004188")]
    private TeamView curentTeamView
    {
      [Token(Token = "0x6013BCE"), Address(RVA = "0x18611E8", Offset = "0x18611E8", VA = "0x18611E8")] get
      {
        return (TeamView) null;
      }
    }

    [Token(Token = "0x17004189")]
    public Action OnHomeButtonClicked
    {
      [Token(Token = "0x6013BCF"), Address(RVA = "0x18611F0", Offset = "0x18611F0", VA = "0x18611F0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6013BD0"), Address(RVA = "0x186120C", Offset = "0x186120C", VA = "0x186120C")] set
      {
      }
    }

    [Token(Token = "0x6013BD1")]
    [Address(RVA = "0x1861228", Offset = "0x1861228", VA = "0x1861228")]
    public void InitPartyFomationView(
      int teamId,
      bool isNeedLp,
      Action<OrganizationTeam, Action> loadAutoFormationListAsset,
      AssetCachedSpawner assetCachedSpawner,
      bool isGuildRaid,
      List<string> usedStyleIds)
    {
    }

    [Token(Token = "0x6013BD2")]
    [Address(RVA = "0x18619FC", Offset = "0x18619FC", VA = "0x18619FC")]
    public void InitPartyFomationViewArena(
      DeckTypeEnum deckType,
      Action<OrganizationTeam, Action> loadAutoFormationListAsset,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6013BD3")]
    [Address(RVA = "0x18617D0", Offset = "0x18617D0", VA = "0x18617D0")]
    private OrganizationTeam.TeamSizeType GetTeamSizeType() => new OrganizationTeam.TeamSizeType();

    [Token(Token = "0x6013BD4")]
    [Address(RVA = "0x186185C", Offset = "0x186185C", VA = "0x186185C")]
    private void InitDeckData(int teamId)
    {
    }

    [Token(Token = "0x6013BD5")]
    [Address(RVA = "0x1861D80", Offset = "0x1861D80", VA = "0x1861D80")]
    private void InitDeckDataArena(DeckTypeEnum deckType)
    {
    }

    [Token(Token = "0x6013BD6")]
    [Address(RVA = "0x1861EA8", Offset = "0x1861EA8", VA = "0x1861EA8")]
    public void SetQuestData(
      int menberNum,
      ElementTypeEnum enemyElement,
      BattleSortieRestrictionsCheck battleSortieRestrictionsCheck,
      BattleForcedSortieCheck battleForcedSortieCheck,
      bool canUseItem)
    {
    }

    [Token(Token = "0x6013BD7")]
    [Address(RVA = "0x1861F50", Offset = "0x1861F50", VA = "0x1861F50")]
    public void AddLoadAssetLabel()
    {
    }

    [Token(Token = "0x6013BD8")]
    [Address(RVA = "0x18622D8", Offset = "0x18622D8", VA = "0x18622D8")]
    public void Open(bool isOpenAutoFormation)
    {
    }

    [Token(Token = "0x6013BD9")]
    [Address(RVA = "0x18624C0", Offset = "0x18624C0", VA = "0x18624C0")]
    public void Close()
    {
    }

    [Token(Token = "0x6013BDA")]
    [Address(RVA = "0x186265C", Offset = "0x186265C", VA = "0x186265C")]
    public void DestroyPopup()
    {
    }

    [Token(Token = "0x6013BDB")]
    [Address(RVA = "0x1862784", Offset = "0x1862784", VA = "0x1862784")]
    private void UpdateTeamText()
    {
    }

    [Token(Token = "0x6013BDC")]
    [Address(RVA = "0x18628A4", Offset = "0x18628A4", VA = "0x18628A4")]
    private void UpdateUnitNumber(int teamIndex)
    {
    }

    [Token(Token = "0x6013BDD")]
    [Address(RVA = "0x1862B30", Offset = "0x1862B30", VA = "0x1862B30")]
    private void UpdateTeamUI()
    {
    }

    [Token(Token = "0x6013BDE")]
    [Address(RVA = "0x1862C38", Offset = "0x1862C38", VA = "0x1862C38")]
    private void UpdateTeamUIArena()
    {
    }

    [Token(Token = "0x6013BDF")]
    [Address(RVA = "0x1862C88", Offset = "0x1862C88", VA = "0x1862C88")]
    public void UpdateTeamView()
    {
    }

    [Token(Token = "0x6013BE0")]
    [Address(RVA = "0x1862D2C", Offset = "0x1862D2C", VA = "0x1862D2C")]
    public void OnClickToSortieLimitPopup()
    {
    }

    [Token(Token = "0x6013BE1")]
    [Address(RVA = "0x1862FBC", Offset = "0x1862FBC", VA = "0x1862FBC")]
    public void OnLeftButton()
    {
    }

    [Token(Token = "0x6013BE2")]
    [Address(RVA = "0x1863070", Offset = "0x1863070", VA = "0x1863070")]
    public void OnRightButton()
    {
    }

    [Token(Token = "0x6013BE3")]
    [Address(RVA = "0x18630C8", Offset = "0x18630C8", VA = "0x18630C8")]
    public void OnFormationMenuButton()
    {
    }

    [Token(Token = "0x6013BE4")]
    [Address(RVA = "0x1863160", Offset = "0x1863160", VA = "0x1863160")]
    public void OnTeamCopyButton()
    {
    }

    [Token(Token = "0x6013BE5")]
    [Address(RVA = "0x1863540", Offset = "0x1863540", VA = "0x1863540")]
    public void OnBackSceneButton(Action<bool> backAction)
    {
    }

    [Token(Token = "0x6013BE6")]
    [Address(RVA = "0x1863914", Offset = "0x1863914", VA = "0x1863914")]
    public void OnBackToHomeButton(Action<bool> backAction)
    {
    }

    [Token(Token = "0x6013BE7")]
    [Address(RVA = "0x1863918", Offset = "0x1863918", VA = "0x1863918")]
    public bool CheckTeamDifference() => new bool();

    [Token(Token = "0x6013BE8")]
    [Address(RVA = "0x1863710", Offset = "0x1863710", VA = "0x1863710")]
    private void TrySaveDeck(Action<bool> backAction)
    {
    }

    [Token(Token = "0x6013BE9")]
    [Address(RVA = "0x18639E0", Offset = "0x18639E0", VA = "0x18639E0")]
    protected IEnumerator ConnectAPIDeckEdit(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6013BEA")]
    [Address(RVA = "0x1863A54", Offset = "0x1863A54", VA = "0x1863A54")]
    private void OnFinishConnect()
    {
    }

    [Token(Token = "0x6013BEB")]
    [Address(RVA = "0x1863A58", Offset = "0x1863A58", VA = "0x1863A58")]
    public void ChangeUnitIndivisual(Style style, int index)
    {
    }

    [Token(Token = "0x6013BEC")]
    [Address(RVA = "0x1863A90", Offset = "0x1863A90", VA = "0x1863A90")]
    public void OnBackScene()
    {
    }

    [Token(Token = "0x6013BED")]
    [Address(RVA = "0x1863DB8", Offset = "0x1863DB8", VA = "0x1863DB8")]
    public void OnAutoPartyFormation()
    {
    }

    [Token(Token = "0x6013BEE")]
    [Address(RVA = "0x18641E8", Offset = "0x18641E8", VA = "0x18641E8")]
    private void FinishAutoPartyFormation(OrganizationTeam autoTeam, bool isDecide)
    {
    }

    [Token(Token = "0x6013BEF")]
    [Address(RVA = "0x186429C", Offset = "0x186429C", VA = "0x186429C")]
    public void OnPartySlotSorting()
    {
    }

    [Token(Token = "0x6013BF0")]
    [Address(RVA = "0x1863570", Offset = "0x1863570", VA = "0x1863570")]
    private void BackPartySlotSorting()
    {
    }

    [Token(Token = "0x6013BF1")]
    [Address(RVA = "0x1864450", Offset = "0x1864450", VA = "0x1864450")]
    public void OnPartyEditRevert()
    {
    }

    [Token(Token = "0x6013BF2")]
    [Address(RVA = "0x18647C0", Offset = "0x18647C0", VA = "0x18647C0")]
    public void OnPartyReset()
    {
    }

    [Token(Token = "0x6013BF3")]
    [Address(RVA = "0x1863008", Offset = "0x1863008", VA = "0x1863008")]
    protected IEnumerator PartyChangeAnim() => (IEnumerator) null;

    [Token(Token = "0x6013BF4")]
    [Address(RVA = "0x1864B30", Offset = "0x1864B30", VA = "0x1864B30")]
    private void OnValueChangedTeamTypeToggle(OrganizationTeam.TeamSizeType sizeType, bool isOn)
    {
    }

    [Token(Token = "0x6013BF5")]
    [Address(RVA = "0x1864EBC", Offset = "0x1864EBC", VA = "0x1864EBC")]
    private void RestPartyTypeToggle()
    {
    }

    [Token(Token = "0x6013BF6")]
    [Address(RVA = "0x1865074", Offset = "0x1865074", VA = "0x1865074")]
    private void ChangeTeam(OrganizationTeam.TeamSizeType sizeType, int teamId, bool currentTeam)
    {
    }

    [Token(Token = "0x6013BF7")]
    [Address(RVA = "0x1865164", Offset = "0x1865164", VA = "0x1865164")]
    private void CopyTeam(OrganizationTeam baseTeam, OrganizationTeam copyTeam)
    {
    }

    [Token(Token = "0x6013BF8")]
    [Address(RVA = "0x186526C", Offset = "0x186526C", VA = "0x186526C")]
    public void OnClickPartyUnitSlot(
      OrganizationPartySlot partySlot,
      FormationSlotView partySlotView)
    {
    }

    [Token(Token = "0x6013BF9")]
    [Address(RVA = "0x18657B0", Offset = "0x18657B0", VA = "0x18657B0")]
    public void OnClickToWeaponProficiencyPopup()
    {
    }

    [Token(Token = "0x6013BFA")]
    [Address(RVA = "0x1865BA8", Offset = "0x1865BA8", VA = "0x1865BA8")]
    public void OnClickToPartySkillPopup()
    {
    }

    [Token(Token = "0x6013BFB")]
    [Address(RVA = "0x1865FD8", Offset = "0x1865FD8", VA = "0x1865FD8")]
    public void OnClickCustomSkillSlot(OrganizationPartySlot partySlot)
    {
    }

    [Token(Token = "0x6013BFC")]
    [Address(RVA = "0x1866110", Offset = "0x1866110", VA = "0x1866110")]
    public void OnClickEquipmentSlot(
      OrganizationPartySlot partySlot,
      OrganizationEquipmentSlot equipmentSlot,
      FormationSlotEquipmentView equipmentView)
    {
    }

    [Token(Token = "0x6013BFD")]
    [Address(RVA = "0x18668B4", Offset = "0x18668B4", VA = "0x18668B4")]
    public void OnSlotEnhanceMenuButton(OrganizationPartySlot partySlot)
    {
    }

    [Token(Token = "0x6013BFE")]
    [Address(RVA = "0x1866DDC", Offset = "0x1866DDC", VA = "0x1866DDC")]
    private void OnSlotEnhanceLevelUp(OrganizationPartySlot partySlot)
    {
    }

    [Token(Token = "0x6013BFF")]
    [Address(RVA = "0x1866DE4", Offset = "0x1866DE4", VA = "0x1866DE4")]
    private void OnSlotEnhanceStyleBoard(OrganizationPartySlot partySlot)
    {
    }

    [Token(Token = "0x6013C00")]
    [Address(RVA = "0x18668F8", Offset = "0x18668F8", VA = "0x18668F8")]
    private void ChangeSubSceneStyleStatus(
      OrganizationPartySlot partySlot,
      StyleStatusSubScene.eStyleStatusMode mode)
    {
    }

    [Token(Token = "0x6013C01")]
    [Address(RVA = "0x18656E4", Offset = "0x18656E4", VA = "0x18656E4")]
    private static UITimelineSettingAsset GetChageMenuTimelineAsset()
    {
      return (UITimelineSettingAsset) null;
    }

    [Token(Token = "0x6013C02")]
    [Address(RVA = "0x18663EC", Offset = "0x18663EC", VA = "0x18663EC")]
    private void SetEquipEditPrefab(
      OrganizationEquipmentSlot.EquipmentSlotType slotType,
      OrganizationPartySlot[] partySlot)
    {
    }

    [Token(Token = "0x6013C03")]
    [Address(RVA = "0x1866DEC", Offset = "0x1866DEC", VA = "0x1866DEC")]
    public void UpdateEquipmentSlot(
      UniqueID uniqueID,
      Equipment equipment,
      OrganizationEquipmentSlot.EquipmentSlotType equipmentSlotType,
      int partyIndex,
      int slotIndex)
    {
    }

    [Token(Token = "0x6013C04")]
    [Address(RVA = "0x1867024", Offset = "0x1867024", VA = "0x1867024")]
    private void UnEquipmentSlot(
      UniqueID uniqueID,
      OrganizationEquipmentSlot.EquipmentSlotType equipmentSlotType,
      int partyIndex,
      int slotIndex)
    {
    }

    [Token(Token = "0x6013C05")]
    [Address(RVA = "0x1865B40", Offset = "0x1865B40", VA = "0x1865B40")]
    private IEnumerator WaitPopupAnimation(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6013C06")]
    [Address(RVA = "0x1867110", Offset = "0x1867110", VA = "0x1867110")]
    public void OnTeamNameEdit()
    {
    }

    [Token(Token = "0x6013C07")]
    [Address(RVA = "0x1863AD4", Offset = "0x1863AD4", VA = "0x1863AD4")]
    public void OnItemSetList()
    {
    }

    [Token(Token = "0x6013C08")]
    [Address(RVA = "0x186738C", Offset = "0x186738C", VA = "0x186738C")]
    public void OnTeamSelectButton()
    {
    }

    [Token(Token = "0x6013C09")]
    [Address(RVA = "0x1863944", Offset = "0x1863944", VA = "0x1863944")]
    private Deck GetCurrentDeck() => (Deck) null;

    [Token(Token = "0x6013C0A")]
    [Address(RVA = "0x186406C", Offset = "0x186406C", VA = "0x186406C")]
    private void SetInteractable(bool flag)
    {
    }

    [Token(Token = "0x6013C0B")]
    [Address(RVA = "0x18676B4", Offset = "0x18676B4", VA = "0x18676B4")]
    public PartyFomationView()
    {
    }

    [Token(Token = "0x200329D")]
    private class SelectThumb
    {
      [Token(Token = "0x400D920")]
      [FieldOffset(Offset = "0x10")]
      private GameObject _gameObject;

      [Token(Token = "0x6013C24")]
      [Address(RVA = "0x1868128", Offset = "0x1868128", VA = "0x1868128")]
      public SelectThumb(GameObject gameObject)
      {
      }

      [Token(Token = "0x6013C25")]
      [Address(RVA = "0x1868150", Offset = "0x1868150", VA = "0x1868150")]
      public void SelectIn()
      {
      }

      [Token(Token = "0x6013C26")]
      [Address(RVA = "0x18681F0", Offset = "0x18681F0", VA = "0x18681F0")]
      public void SelectOut()
      {
      }

      [Token(Token = "0x6013C27")]
      [Address(RVA = "0x1868158", Offset = "0x1868158", VA = "0x1868158")]
      public void PlaySelect(bool select)
      {
      }
    }
  }
}
