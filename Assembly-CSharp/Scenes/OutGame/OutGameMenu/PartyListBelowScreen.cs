// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.PartyListBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AEF")]
  public class PartyListBelowScreen : OutGameMenuBelowScreenBase
  {
    [Token(Token = "0x401038B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x401038C")]
    private const string TimeLineAssetbundleName = "content_effect_common_outgamemenu_timeline";
    [Token(Token = "0x401038D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Transform teamObjParent;
    [Token(Token = "0x401038E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TeamCell teamCellObj;
    [Token(Token = "0x401038F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TemplateCell templateCell;
    [Token(Token = "0x4010390")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x4010391")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Transform teamParent;
    [Token(Token = "0x4010392")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Transform templateParent;
    [Token(Token = "0x4010393")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private RectTransform teamBadge;
    [Token(Token = "0x4010394")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RectTransform templateBadge;
    [Token(Token = "0x4010395")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private RectTransform teamLabelTransfer;
    [Token(Token = "0x4010396")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private RectTransform templateLabelTransfer;
    [Token(Token = "0x4010397")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Button jumpTeamButton;
    [Token(Token = "0x4010398")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Button jumpTemplateButton;
    [Token(Token = "0x4010399")]
    private const string InoutTimeLineAssetbundleName = "2dassets_ui_common";
    [Token(Token = "0x401039A")]
    private const string PartyListAssetBundleName = "ui_page_partylist";
    [Token(Token = "0x401039B")]
    private const string TeamNameChangePrefabName = "Com_Popup_Base_S_InputText";
    [Token(Token = "0x401039C")]
    private const string TeamDeletePrefabName = "Com_Popup_Base_S_QuitDelte";
    [Token(Token = "0x401039D")]
    private const string TeamCopyPrefabName = "Com_Popup_TeamCopy";
    [Token(Token = "0x401039E")]
    private const string PopupTimelineAssetLabelName = "ui_common_timeline";
    [Token(Token = "0x401039F")]
    private const string TemplateListPrefabName = "Com_Popup_PartyList";
    [Token(Token = "0x40103A0")]
    private const string PopupTimelineAssetName = "Com_Popup_Base_New";
    [Token(Token = "0x40103A1")]
    private const string PartyAIPopupName = "Com_Popup_PartyAI";
    [Token(Token = "0x40103A2")]
    private const string CommonPopupInAssetName = "Com_Popup_Base_Anim_in";
    [Token(Token = "0x40103A3")]
    private const string CommonPopupOutAssetName = "Com_Popup_Base_Anim_out";
    [Token(Token = "0x40103A4")]
    private const string PartyListItemEditAssetBundleName = "ui_page_partylist_itemedit";
    [Token(Token = "0x40103A5")]
    private const string ItemSetListPrefabName = "Com_Popup_ItemList";
    [Token(Token = "0x40103A6")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x40103A7")]
    [FieldOffset(Offset = "0xB0")]
    private readonly string[] thumbBaseAssetName;
    [Token(Token = "0x40103A8")]
    [FieldOffset(Offset = "0xB8")]
    private TeamNameChangePopup teamNameChangePrefab;
    [Token(Token = "0x40103A9")]
    [FieldOffset(Offset = "0xC0")]
    private TeamNameChangePopup teamNameChangePopup;
    [Token(Token = "0x40103AA")]
    [FieldOffset(Offset = "0xC8")]
    private TeamDeletePopup teamDeletePrefab;
    [Token(Token = "0x40103AB")]
    [FieldOffset(Offset = "0xD0")]
    private TeamDeletePopup teamDeletePopup;
    [Token(Token = "0x40103AC")]
    [FieldOffset(Offset = "0xD8")]
    private TeamCopyPopup teamCopyPrefab;
    [Token(Token = "0x40103AD")]
    [FieldOffset(Offset = "0xE0")]
    private TeamCopyPopup teamCopyPopup;
    [Token(Token = "0x40103AE")]
    [FieldOffset(Offset = "0xE8")]
    private GameObject partyAIPrefab;
    [Token(Token = "0x40103AF")]
    [FieldOffset(Offset = "0xF0")]
    private PartyAIView partyAIView;
    [Token(Token = "0x40103B0")]
    [FieldOffset(Offset = "0xF8")]
    private ItemSetListPopup itemSetListPrefab;
    [Token(Token = "0x40103B1")]
    [FieldOffset(Offset = "0x100")]
    private ItemSetListPopup itemSetListPopup;
    [Token(Token = "0x40103B2")]
    [FieldOffset(Offset = "0x108")]
    private TemplateListPopup templateListPrefab;
    [Token(Token = "0x40103B3")]
    [FieldOffset(Offset = "0x110")]
    private TemplateListPopup templateListPopup;
    [Token(Token = "0x40103B4")]
    [FieldOffset(Offset = "0x118")]
    private List<TeamCell> teamCellList;
    [Token(Token = "0x40103B5")]
    [FieldOffset(Offset = "0x120")]
    private int copyTeamId;
    [Token(Token = "0x40103B6")]
    [FieldOffset(Offset = "0x124")]
    private bool isOpenItemSetList;
    [Token(Token = "0x40103B7")]
    [FieldOffset(Offset = "0x128")]
    private int openItemSetListTeamId;
    [Token(Token = "0x40103B8")]
    [FieldOffset(Offset = "0x12C")]
    private bool isOpenTemplateList;
    [Token(Token = "0x40103B9")]
    [FieldOffset(Offset = "0x130")]
    private int openTemplateListEditIndex;
    [Token(Token = "0x40103BA")]
    [FieldOffset(Offset = "0x134")]
    private int selectTemplateIndex;
    [Token(Token = "0x40103BB")]
    [FieldOffset(Offset = "0x138")]
    private bool loadTemplate;
    [Token(Token = "0x40103BC")]
    [FieldOffset(Offset = "0x139")]
    private bool loadTemplateList;
    [Token(Token = "0x40103BD")]
    [FieldOffset(Offset = "0x140")]
    private int[] loadTemplateListDotStyleIds;
    [Token(Token = "0x40103BE")]
    [FieldOffset(Offset = "0x148")]
    private bool loadDeckDotAsset;
    [Token(Token = "0x40103BF")]
    [FieldOffset(Offset = "0x150")]
    private Coroutine loadAssetBundleCoroutine;
    [Token(Token = "0x40103C0")]
    [FieldOffset(Offset = "0x158")]
    private List<Expendable>[] loadWaitList;
    [Token(Token = "0x40103C1")]
    [FieldOffset(Offset = "0x160")]
    private int loadWaitIdOfs;
    [Token(Token = "0x40103C2")]
    [FieldOffset(Offset = "0x164")]
    private float jumpMoveTimeCount;
    [Token(Token = "0x40103C3")]
    [FieldOffset(Offset = "0x168")]
    private float jumpMoveLen;
    [Token(Token = "0x40103C4")]
    [FieldOffset(Offset = "0x16C")]
    private float jumpMoveSrcVal;
    [Token(Token = "0x40103C5")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private AnimationCurve jumpMoveCurve;
    [Token(Token = "0x40103C6")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private float jumpMoveTime;
    [Token(Token = "0x40103C7")]
    [FieldOffset(Offset = "0x180")]
    private PartyListBelowScreen.Param partyListParam;

    [Token(Token = "0x60172FA")]
    [Address(RVA = "0x30134E8", Offset = "0x30134E8", VA = "0x30134E8", Slot = "4")]
    public override void Initialize(ChangeBelowScreenParameter param = null)
    {
    }

    [Token(Token = "0x60172FB")]
    [Address(RVA = "0x3013F5C", Offset = "0x3013F5C", VA = "0x3013F5C", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60172FC")]
    [Address(RVA = "0x3013FEC", Offset = "0x3013FEC", VA = "0x3013FEC")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60172FD")]
    [Address(RVA = "0x3014074", Offset = "0x3014074", VA = "0x3014074", Slot = "6")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x60172FE")]
    [Address(RVA = "0x3014220", Offset = "0x3014220", VA = "0x3014220")]
    public void DestroyPopup()
    {
    }

    [Token(Token = "0x60172FF")]
    [Address(RVA = "0x30143DC", Offset = "0x30143DC", VA = "0x30143DC", Slot = "7")]
    public override void Open(string preBelowName)
    {
    }

    [Token(Token = "0x6017300")]
    [Address(RVA = "0x3014640", Offset = "0x3014640", VA = "0x3014640", Slot = "8")]
    public override void Close(string nextBelowName)
    {
    }

    [Token(Token = "0x6017301")]
    [Address(RVA = "0x3014768", Offset = "0x3014768", VA = "0x3014768")]
    public void DummyCatalogOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6017302")]
    [Address(RVA = "0x3014774", Offset = "0x3014774", VA = "0x3014774")]
    public void UpdateTeamCell()
    {
    }

    [Token(Token = "0x6017303")]
    [Address(RVA = "0x3013804", Offset = "0x3013804", VA = "0x3013804")]
    private void CreateTeamCells()
    {
    }

    [Token(Token = "0x6017304")]
    [Address(RVA = "0x3013EBC", Offset = "0x3013EBC", VA = "0x3013EBC")]
    private void CreateTemplateCell()
    {
    }

    [Token(Token = "0x6017305")]
    [Address(RVA = "0x301683C", Offset = "0x301683C", VA = "0x301683C")]
    private void OnTeamCellCopyButton(int teamId)
    {
    }

    [Token(Token = "0x6017306")]
    [Address(RVA = "0x3016AE4", Offset = "0x3016AE4", VA = "0x3016AE4")]
    private void OnTeamCellCliearButton()
    {
    }

    [Token(Token = "0x6017307")]
    [Address(RVA = "0x3016C48", Offset = "0x3016C48", VA = "0x3016C48")]
    private void OnTeamCellPasteButton(int teamId)
    {
    }

    [Token(Token = "0x6017308")]
    [Address(RVA = "0x3016FD0", Offset = "0x3016FD0", VA = "0x3016FD0")]
    public void OnTemplateCellPasteButton(int templateId, int copyTemplateId)
    {
    }

    [Token(Token = "0x6017309")]
    [Address(RVA = "0x3017328", Offset = "0x3017328", VA = "0x3017328")]
    private void OnTeamNameEdit(int teamId, string teamName)
    {
    }

    [Token(Token = "0x601730A")]
    [Address(RVA = "0x301765C", Offset = "0x301765C", VA = "0x301765C")]
    public void OnTemplateNameEdit(int templateId)
    {
    }

    [Token(Token = "0x601730B")]
    [Address(RVA = "0x3017954", Offset = "0x3017954", VA = "0x3017954")]
    private void OnTeamDeleteEdit(int teamId)
    {
    }

    [Token(Token = "0x601730C")]
    [Address(RVA = "0x3017C88", Offset = "0x3017C88", VA = "0x3017C88")]
    public void OnTemplateDeleteEdit(int templateId)
    {
    }

    [Token(Token = "0x601730D")]
    [Address(RVA = "0x3015D6C", Offset = "0x3015D6C", VA = "0x3015D6C")]
    public void OnTemplateListButton(int selectIndex, int editIndex)
    {
    }

    [Token(Token = "0x601730E")]
    [Address(RVA = "0x3017F80", Offset = "0x3017F80", VA = "0x3017F80")]
    private void OnPartyAiChange(int teamId)
    {
    }

    [Token(Token = "0x601730F")]
    [Address(RVA = "0x3017FA0", Offset = "0x3017FA0", VA = "0x3017FA0")]
    private IEnumerator OnPartyAiChangeInternal(int teamId) => (IEnumerator) null;

    [Token(Token = "0x6017310")]
    [Address(RVA = "0x3018040", Offset = "0x3018040", VA = "0x3018040")]
    protected IEnumerator ConnectAPIDeckAISetting(OrganizationTeam team) => (IEnumerator) null;

    [Token(Token = "0x6017311")]
    [Address(RVA = "0x30159D8", Offset = "0x30159D8", VA = "0x30159D8")]
    private void OnItemSetList(int teamId)
    {
    }

    [Token(Token = "0x6017312")]
    [Address(RVA = "0x30180E4", Offset = "0x30180E4", VA = "0x30180E4")]
    protected IEnumerator ConnectAPIDeckItemSetSetting(OrganizationTeam team) => (IEnumerator) null;

    [Token(Token = "0x6017313")]
    [Address(RVA = "0x3018180", Offset = "0x3018180", VA = "0x3018180")]
    private void FinishedAPIDeckItemSetSetting(int teamId)
    {
    }

    [Token(Token = "0x6017314")]
    [Address(RVA = "0x30182DC", Offset = "0x30182DC", VA = "0x30182DC")]
    public void AddThumbAssetBundle(Expendable expendable)
    {
    }

    [Token(Token = "0x6017315")]
    [Address(RVA = "0x30183A4", Offset = "0x30183A4", VA = "0x30183A4")]
    public void LoadTemplistDotAsset(int[] dotStyleIds)
    {
    }

    [Token(Token = "0x6017316")]
    [Address(RVA = "0x301400C", Offset = "0x301400C", VA = "0x301400C")]
    public IEnumerator SetLoadThumbAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6017317")]
    [Address(RVA = "0x30183DC", Offset = "0x30183DC", VA = "0x30183DC")]
    public string GetAseetBundleName(Expendable expendable) => (string) null;

    [Token(Token = "0x6017318")]
    [Address(RVA = "0x30183F8", Offset = "0x30183F8", VA = "0x30183F8")]
    public string GetAseetName(Expendable expendable) => (string) null;

    [Token(Token = "0x6017319")]
    [Address(RVA = "0x3018414", Offset = "0x3018414", VA = "0x3018414")]
    public Sprite GetRarityBaseImage(Expendable expendable) => (Sprite) null;

    [Token(Token = "0x601731A")]
    [Address(RVA = "0x3018510", Offset = "0x3018510", VA = "0x3018510")]
    private void Update()
    {
    }

    [Token(Token = "0x601731B")]
    [Address(RVA = "0x30185C0", Offset = "0x30185C0", VA = "0x30185C0")]
    private void ListLabelPlacement(Transform parent, RectTransform badge, RectTransform transfer)
    {
    }

    [Token(Token = "0x601731C")]
    [Address(RVA = "0x30187C4", Offset = "0x30187C4", VA = "0x30187C4")]
    private void SetJumpMove(float val)
    {
    }

    [Token(Token = "0x601731D")]
    [Address(RVA = "0x3018818", Offset = "0x3018818", VA = "0x3018818")]
    public PartyListBelowScreen()
    {
    }

    [Token(Token = "0x2003AF0")]
    public class Param : ChangeBelowScreenParameter
    {
      [Token(Token = "0x40103C8")]
      [FieldOffset(Offset = "0x18")]
      public string teststring;

      [Token(Token = "0x6017326")]
      [Address(RVA = "0x30137DC", Offset = "0x30137DC", VA = "0x30137DC")]
      public Param(string text)
      {
      }
    }
  }
}
