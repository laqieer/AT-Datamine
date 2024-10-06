// Decompiled with JetBrains decompiler
// Type: TeamOrganization.CustomSkillEditListPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.EquipmentDetail;
using Scenes.OutGame.Favorite;
using Scenes.OutGame.Info.Common.UI;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200078E")]
  public class CustomSkillEditListPopup : MonoBehaviour
  {
    [Token(Token = "0x40022D7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40022D8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x40022D9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI styleName;
    [Token(Token = "0x40022DA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x40022DB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x40022DC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RectTransform selectContent;
    [Token(Token = "0x40022DD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform battleskillThumbParent;
    [Token(Token = "0x40022DE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Transform grantThumbParent;
    [Token(Token = "0x40022DF")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Transform strategyThumbParent;
    [Token(Token = "0x40022E0")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Transform charaThumbParent;
    [Token(Token = "0x40022E1")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject srcBattleskillThumbGroup;
    [Token(Token = "0x40022E2")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject srcGrantThumbGroup;
    [Token(Token = "0x40022E3")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject srcStrategyThumbGroup;
    [Token(Token = "0x40022E4")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject srcCharaThumbGroup;
    [Token(Token = "0x40022E5")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Transform battleskillSelectParent;
    [Token(Token = "0x40022E6")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Transform grantSelectParent;
    [Token(Token = "0x40022E7")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Transform strategySelectParent;
    [Token(Token = "0x40022E8")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Transform charaSelectParent;
    [Token(Token = "0x40022E9")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject srcBattleskillSelectGroup;
    [Token(Token = "0x40022EA")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject srcGrantSelectGroup;
    [Token(Token = "0x40022EB")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject srcStrategySelectGroup;
    [Token(Token = "0x40022EC")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject srcCharaSelectGroup;
    [Token(Token = "0x40022ED")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject battleskillNothing;
    [Token(Token = "0x40022EE")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject grantNothing;
    [Token(Token = "0x40022EF")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GameObject strategyNothing;
    [Token(Token = "0x40022F0")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject charaNothing;
    [Token(Token = "0x40022F1")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private RectTransform battleskillBadge;
    [Token(Token = "0x40022F2")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private RectTransform grantBadge;
    [Token(Token = "0x40022F3")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private RectTransform strategyBadge;
    [Token(Token = "0x40022F4")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private RectTransform charaBadge;
    [Token(Token = "0x40022F5")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private RectTransform battleskillLabelTransfer;
    [Token(Token = "0x40022F6")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private RectTransform grantLabelTransfer;
    [Token(Token = "0x40022F7")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private RectTransform strategyLabelTransfer;
    [Token(Token = "0x40022F8")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private RectTransform charaLabelTransfer;
    [Token(Token = "0x40022F9")]
    public const int BaseEntryMax = 4;
    [Token(Token = "0x40022FA")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private CommonButton fillterButton;
    [Token(Token = "0x40022FB")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private CommonButton battleskillButton;
    [Token(Token = "0x40022FC")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private CommonButton grantButton;
    [Token(Token = "0x40022FD")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private CommonButton strategyButton;
    [Token(Token = "0x40022FE")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private CommonButton charaButton;
    [Token(Token = "0x40022FF")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private GameObject selectButtonsObject;
    [Token(Token = "0x4002300")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private GameObject changeButtonObject;
    [Token(Token = "0x4002301")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private GameObject removeButtonObject;
    [Token(Token = "0x4002302")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private Text changeButtonText;
    [Token(Token = "0x4002303")]
    private const string TimeLineAssetbundleName = "content_effect_common_outgamemenu_timeline";
    [Token(Token = "0x4002304")]
    [FieldOffset(Offset = "0x170")]
    private List<CustomSkillEditListPopup.ThumbData> battleskillList;
    [Token(Token = "0x4002305")]
    [FieldOffset(Offset = "0x178")]
    private List<CustomSkillEditListPopup.ThumbData> grantList;
    [Token(Token = "0x4002306")]
    [FieldOffset(Offset = "0x180")]
    private List<CustomSkillEditListPopup.ThumbData> strategyList;
    [Token(Token = "0x4002307")]
    [FieldOffset(Offset = "0x188")]
    private List<CustomSkillEditListPopup.ThumbData> charaList;
    [Token(Token = "0x4002308")]
    [FieldOffset(Offset = "0x190")]
    private List<CustomSkillEditListThumbElement> battleskillBaseList;
    [Token(Token = "0x4002309")]
    [FieldOffset(Offset = "0x198")]
    private List<CustomSkillEditListThumbElement> grantBaseList;
    [Token(Token = "0x400230A")]
    [FieldOffset(Offset = "0x1A0")]
    private List<CustomSkillEditListThumbElement> strategyBaseList;
    [Token(Token = "0x400230B")]
    [FieldOffset(Offset = "0x1A8")]
    private List<CustomSkillEditListThumbElement> charaBaseList;
    [Token(Token = "0x400230C")]
    [FieldOffset(Offset = "0x1B0")]
    private List<CustomSkillEditListSelectElement> battleskillSelectBaseList;
    [Token(Token = "0x400230D")]
    [FieldOffset(Offset = "0x1B8")]
    private List<CustomSkillEditListSelectElement> grantSelectBaseList;
    [Token(Token = "0x400230E")]
    [FieldOffset(Offset = "0x1C0")]
    private List<CustomSkillEditListSelectElement> strategySelectBaseList;
    [Token(Token = "0x400230F")]
    [FieldOffset(Offset = "0x1C8")]
    private List<CustomSkillEditListSelectElement> charaSelectBaseList;
    [Token(Token = "0x4002310")]
    [FieldOffset(Offset = "0x1D0")]
    private readonly Dictionary<CustomSkillEditListPopup.eCustomSkillListKind, CustomSkillEditListPopup.VariantObject> variantCache;
    [Token(Token = "0x4002311")]
    [FieldOffset(Offset = "0x1D8")]
    private GameObject backSpaceObj;
    [Token(Token = "0x4002312")]
    [FieldOffset(Offset = "0x1E0")]
    private bool isJump;
    [Token(Token = "0x4002313")]
    [FieldOffset(Offset = "0x1E4")]
    private float jumpMoveTimeCount;
    [Token(Token = "0x4002314")]
    [FieldOffset(Offset = "0x1E8")]
    private float jumpMoveLen;
    [Token(Token = "0x4002315")]
    [FieldOffset(Offset = "0x1EC")]
    private float jumpMoveSrcVal;
    [Token(Token = "0x4002316")]
    [FieldOffset(Offset = "0x1F0")]
    [SerializeField]
    private AnimationCurve jumpMoveCurve;
    [Token(Token = "0x4002317")]
    [FieldOffset(Offset = "0x1F8")]
    [SerializeField]
    private float jumpMoveTime;
    [Token(Token = "0x4002318")]
    [FieldOffset(Offset = "0x200")]
    [SerializeField]
    private SkillDetailWindowPresenter skillDetailWindow;
    [Token(Token = "0x4002319")]
    [FieldOffset(Offset = "0x208")]
    [SerializeField]
    private FavoriteButton favoriteButton;
    [Token(Token = "0x400231A")]
    [FieldOffset(Offset = "0x210")]
    [SerializeField]
    private GameObject enhanceButtonGroup;
    [Token(Token = "0x400231B")]
    [FieldOffset(Offset = "0x218")]
    [SerializeField]
    private CommonButton enhanceButton;
    [Token(Token = "0x400231D")]
    [FieldOffset(Offset = "0x228")]
    private IAssetProvider assetProvider;
    [Token(Token = "0x400231E")]
    [FieldOffset(Offset = "0x230")]
    private int setItemIndex;
    [Token(Token = "0x400231F")]
    [FieldOffset(Offset = "0x238")]
    private CustomSkill setCustomSkill;
    [Token(Token = "0x4002320")]
    [FieldOffset(Offset = "0x240")]
    private int selectIndex;
    [Token(Token = "0x4002321")]
    [FieldOffset(Offset = "0x244")]
    private CustomSkillEditListPopup.eCustomSkillListKind selectKind;
    [Token(Token = "0x4002322")]
    [FieldOffset(Offset = "0x248")]
    private CustomSkill selectCustomSkill;
    [Token(Token = "0x4002323")]
    [FieldOffset(Offset = "0x250")]
    private bool isSelectListItem;
    [Token(Token = "0x4002324")]
    [FieldOffset(Offset = "0x258")]
    private CustomSkillEditListSelect selectListThumb;
    [Token(Token = "0x4002325")]
    [FieldOffset(Offset = "0x260")]
    private Action closeAction;
    [Token(Token = "0x4002326")]
    [FieldOffset(Offset = "0x268")]
    private Action<CustomSkill> onChangeItemAction;
    [Token(Token = "0x4002327")]
    [FieldOffset(Offset = "0x270")]
    private Action onRemoveItemAction;
    [Token(Token = "0x4002328")]
    [FieldOffset(Offset = "0x278")]
    private Action updateSkillAction;
    [Token(Token = "0x400232A")]
    [FieldOffset(Offset = "0x288")]
    private Action addLoadRequest;
    [Token(Token = "0x400232B")]
    [FieldOffset(Offset = "0x290")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400232C")]
    [FieldOffset(Offset = "0x298")]
    private int editSytleId;
    [Token(Token = "0x400232D")]
    [FieldOffset(Offset = "0x2A0")]
    private Coroutine instantiateThumbCoroutine;

    [Token(Token = "0x17000657")]
    public CoroutineHandler CoroutineHandler
    {
      [Token(Token = "0x6002A5E"), Address(RVA = "0x350199C", Offset = "0x350199C", VA = "0x350199C")] get
      {
        return (CoroutineHandler) null;
      }
      [Token(Token = "0x6002A5F"), Address(RVA = "0x35019A4", Offset = "0x35019A4", VA = "0x35019A4")] private set
      {
      }
    }

    [Token(Token = "0x17000658")]
    public List<UniqueID> partySetUniqueIdList
    {
      [Token(Token = "0x6002A60"), Address(RVA = "0x35019AC", Offset = "0x35019AC", VA = "0x35019AC")] get
      {
        return (List<UniqueID>) null;
      }
      [Token(Token = "0x6002A61"), Address(RVA = "0x35019B4", Offset = "0x35019B4", VA = "0x35019B4")] private set
      {
      }
    }

    [Token(Token = "0x17000659")]
    public bool IsEnableTapBlock
    {
      [Token(Token = "0x6002A62"), Address(RVA = "0x35019BC", Offset = "0x35019BC", VA = "0x35019BC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002A63"), Address(RVA = "0x35019C4", Offset = "0x35019C4", VA = "0x35019C4")] private set
      {
      }
    }

    [Token(Token = "0x6002A64")]
    [Address(RVA = "0x35019D0", Offset = "0x35019D0", VA = "0x35019D0")]
    public void Initialized(
      Action closeAction,
      Action addLoadRequest,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002A65")]
    [Address(RVA = "0x35020AC", Offset = "0x35020AC", VA = "0x35020AC")]
    private float CalcScrollMove(Transform parentTrans) => new float();

    [Token(Token = "0x6002A66")]
    [Address(RVA = "0x3502168", Offset = "0x3502168", VA = "0x3502168")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6002A67")]
    [Address(RVA = "0x3502194", Offset = "0x3502194", VA = "0x3502194")]
    public void SetCharaName(string charaName)
    {
    }

    [Token(Token = "0x6002A68")]
    [Address(RVA = "0x3502234", Offset = "0x3502234", VA = "0x3502234")]
    public void SetStyleId(int styleId)
    {
    }

    [Token(Token = "0x6002A69")]
    [Address(RVA = "0x350223C", Offset = "0x350223C", VA = "0x350223C")]
    public void Open(
      int styleId,
      List<UniqueID> setUniqueIDs,
      int selectItemIndex,
      CustomSkill customSkill)
    {
    }

    [Token(Token = "0x6002A6A")]
    [Address(RVA = "0x3502AD4", Offset = "0x3502AD4", VA = "0x3502AD4")]
    private IEnumerator OpenAsync() => (IEnumerator) null;

    [Token(Token = "0x6002A6B")]
    [Address(RVA = "0x3502F90", Offset = "0x3502F90", VA = "0x3502F90")]
    public void Close()
    {
    }

    [Token(Token = "0x6002A6C")]
    [Address(RVA = "0x3503060", Offset = "0x3503060", VA = "0x3503060")]
    private void FinishedClose()
    {
    }

    [Token(Token = "0x6002A6D")]
    [Address(RVA = "0x3503108", Offset = "0x3503108", VA = "0x3503108")]
    public void UpdateSetCustomSkillUniqueIds(List<UniqueID> setUniqueIDs)
    {
    }

    [Token(Token = "0x6002A6E")]
    [Address(RVA = "0x35034D8", Offset = "0x35034D8", VA = "0x35034D8")]
    public void SetOnButtonAction(Action<CustomSkill> onChange, Action onRemove)
    {
    }

    [Token(Token = "0x6002A6F")]
    [Address(RVA = "0x35034E4", Offset = "0x35034E4", VA = "0x35034E4")]
    public void SetUpdateSkillAction(Action updateSkill)
    {
    }

    [Token(Token = "0x6002A70")]
    [Address(RVA = "0x35034EC", Offset = "0x35034EC", VA = "0x35034EC")]
    public void SelectOnClickChange()
    {
    }

    [Token(Token = "0x6002A71")]
    [Address(RVA = "0x35035C4", Offset = "0x35035C4", VA = "0x35035C4")]
    public void SelectOnClickRemove()
    {
    }

    [Token(Token = "0x6002A72")]
    [Address(RVA = "0x35035C8", Offset = "0x35035C8", VA = "0x35035C8")]
    public void ThumbnailOnClickSelect(
      int index,
      CustomSkillEditListPopup.eCustomSkillListKind kind,
      bool isUpdateInfo)
    {
    }

    [Token(Token = "0x6002A73")]
    [Address(RVA = "0x3503EA8", Offset = "0x3503EA8", VA = "0x3503EA8")]
    public void ThumbnailOnClickRemove()
    {
    }

    [Token(Token = "0x6002A74")]
    [Address(RVA = "0x3503544", Offset = "0x3503544", VA = "0x3503544")]
    private void OnRemoveItemAction()
    {
    }

    [Token(Token = "0x6002A75")]
    [Address(RVA = "0x3503EAC", Offset = "0x3503EAC", VA = "0x3503EAC")]
    public void ChangeSelectItemSetItem(int selectItemIndex, CustomSkill customSkill)
    {
    }

    [Token(Token = "0x6002A76")]
    [Address(RVA = "0x3502C90", Offset = "0x3502C90", VA = "0x3502C90")]
    private void UpdateSkillInfoUI(CustomSkill customSkill)
    {
    }

    [Token(Token = "0x6002A77")]
    [Address(RVA = "0x3504118", Offset = "0x3504118", VA = "0x3504118")]
    private EquipmentClassificationData GetSkillWeaponSysTemType(SkillDetailData detailData)
    {
      return (EquipmentClassificationData) null;
    }

    [Token(Token = "0x6002A78")]
    [Address(RVA = "0x3504344", Offset = "0x3504344", VA = "0x3504344")]
    private string[] GetSkillTags(int tagId) => (string[]) null;

    [Token(Token = "0x6002A79")]
    [Address(RVA = "0x35045DC", Offset = "0x35045DC", VA = "0x35045DC")]
    public void OnSortFilterButton()
    {
    }

    [Token(Token = "0x6002A7A")]
    [Address(RVA = "0x350469C", Offset = "0x350469C", VA = "0x350469C")]
    public void CustomSkillListOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6002A7B")]
    [Address(RVA = "0x3503EB8", Offset = "0x3503EB8", VA = "0x3503EB8")]
    public void UpdateCustomSkillList()
    {
    }

    [Token(Token = "0x6002A7C")]
    [Address(RVA = "0x3504E34", Offset = "0x3504E34", VA = "0x3504E34")]
    private void UpdateSkillListElementsList(
      List<CustomSkillEditListPopup.ThumbData> skillList,
      GameObject skillNothing,
      CustomSkillEditListPopup.eCustomSkillListKind customSkillListKind,
      List<CustomSkillEditListThumbElement> skillEditListThumbElements,
      List<CustomSkillEditListSelectElement> skillEditListSelectElements)
    {
    }

    [Token(Token = "0x6002A7D")]
    [Address(RVA = "0x35052BC", Offset = "0x35052BC", VA = "0x35052BC")]
    private void ClearCustomSkill()
    {
    }

    [Token(Token = "0x6002A7E")]
    [Address(RVA = "0x3505754", Offset = "0x3505754", VA = "0x3505754")]
    private IEnumerator SetNormalizedPosition() => (IEnumerator) null;

    [Token(Token = "0x6002A7F")]
    [Address(RVA = "0x35057E4", Offset = "0x35057E4", VA = "0x35057E4")]
    private IEnumerator DestroyAsync(
      List<CustomSkillEditListThumbElement> thumbElements,
      List<CustomSkillEditListSelectElement> selectElements)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002A80")]
    [Address(RVA = "0x3505880", Offset = "0x3505880", VA = "0x3505880")]
    private IEnumerator UpdateSortFilterAction(List<CustomSkill> sortFilterList)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002A81")]
    [Address(RVA = "0x3505264", Offset = "0x3505264", VA = "0x3505264")]
    private int GetIndexAppliedSort(
      CustomSkillEditListPopup.eCustomSkillListKind kind,
      CustomSkill customSkill)
    {
      return new int();
    }

    [Token(Token = "0x6002A82")]
    [Address(RVA = "0x350591C", Offset = "0x350591C", VA = "0x350591C")]
    private int GetIndexAppliedSort(
      CustomSkill customSkill,
      List<CustomSkillEditListPopup.ThumbData> thumbList)
    {
      return new int();
    }

    [Token(Token = "0x6002A83")]
    [Address(RVA = "0x35059F0", Offset = "0x35059F0", VA = "0x35059F0")]
    private List<CustomSkill> GetCanEquipSkillList(List<CustomSkill> customSkills)
    {
      return (List<CustomSkill>) null;
    }

    [Token(Token = "0x6002A84")]
    [Address(RVA = "0x3502428", Offset = "0x3502428", VA = "0x3502428")]
    private void CreateCustomSkillList()
    {
    }

    [Token(Token = "0x6002A85")]
    [Address(RVA = "0x3506214", Offset = "0x3506214", VA = "0x3506214")]
    private void CreateCustomSkillList(List<CustomSkill> customSkills)
    {
    }

    [Token(Token = "0x6002A86")]
    [Address(RVA = "0x35067C8", Offset = "0x35067C8", VA = "0x35067C8")]
    private IEnumerator SetCustomSkillList() => (IEnumerator) null;

    [Token(Token = "0x6002A87")]
    [Address(RVA = "0x3506858", Offset = "0x3506858", VA = "0x3506858")]
    private IEnumerator SetCustomSkillList(
      List<CustomSkillEditListPopup.ThumbData> skillList,
      GameObject skillNothing,
      CustomSkillEditListPopup.eCustomSkillListKind customSkillListKind,
      List<CustomSkillEditListThumbElement> skillBaseList,
      List<CustomSkillEditListSelectElement> skillSelectBaseList)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002A88")]
    [Address(RVA = "0x3506920", Offset = "0x3506920", VA = "0x3506920")]
    private IEnumerator CreateThumbElement(
      int baseNum,
      CustomSkillEditListThumbElement srcSkillThumb,
      Transform skillThumbParent,
      List<CustomSkillEditListThumbElement> skillBaseList,
      CustomSkillEditListPopup.eCustomSkillListKind customSkillListKind)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002A89")]
    [Address(RVA = "0x35069E8", Offset = "0x35069E8", VA = "0x35069E8")]
    private IEnumerator CreateSelectElement(
      int baseNum,
      CustomSkillEditListSelectElement srcSkillSelect,
      Transform skillSelectParent,
      List<CustomSkillEditListSelectElement> skillSelectBaseList,
      CustomSkillEditListPopup.eCustomSkillListKind customSkillListKind)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002A8A")]
    [Address(RVA = "0x3505354", Offset = "0x3505354", VA = "0x3505354")]
    private int CalcNumColumns(int listCount) => new int();

    [Token(Token = "0x6002A8B")]
    [Address(RVA = "0x3502B3C", Offset = "0x3502B3C", VA = "0x3502B3C")]
    private void SetBackSpace()
    {
    }

    [Token(Token = "0x6002A8C")]
    [Address(RVA = "0x3503AA8", Offset = "0x3503AA8", VA = "0x3503AA8")]
    public CustomSkillEditListPopup.ThumbData GetItemList(
      int idx,
      CustomSkillEditListPopup.eCustomSkillListKind kind)
    {
      return (CustomSkillEditListPopup.ThumbData) null;
    }

    [Token(Token = "0x6002A8D")]
    [Address(RVA = "0x3503A58", Offset = "0x3503A58", VA = "0x3503A58")]
    public CustomSkillEditListSelect GetSelectItem(
      int idx,
      CustomSkillEditListPopup.eCustomSkillListKind kind)
    {
      return (CustomSkillEditListSelect) null;
    }

    [Token(Token = "0x6002A8E")]
    [Address(RVA = "0x3506AB0", Offset = "0x3506AB0", VA = "0x3506AB0")]
    private CustomSkillEditListSelect GetSelectItem(
      int idx,
      List<CustomSkillEditListSelectElement> skillSelectBaseList)
    {
      return (CustomSkillEditListSelect) null;
    }

    [Token(Token = "0x6002A8F")]
    [Address(RVA = "0x3503E48", Offset = "0x3503E48", VA = "0x3503E48")]
    public CustomSkillEditListThumb GetSelectThumb(
      int idx,
      CustomSkillEditListPopup.eCustomSkillListKind kind)
    {
      return (CustomSkillEditListThumb) null;
    }

    [Token(Token = "0x6002A90")]
    [Address(RVA = "0x3506CA8", Offset = "0x3506CA8", VA = "0x3506CA8")]
    private CustomSkillEditListThumb GetSelectThumb(
      int idx,
      List<CustomSkillEditListThumbElement> skillSelectBaseList)
    {
      return (CustomSkillEditListThumb) null;
    }

    [Token(Token = "0x6002A91")]
    [Address(RVA = "0x3506EA0", Offset = "0x3506EA0", VA = "0x3506EA0")]
    public bool isView(CustomSkillEditListThumbElement thumb) => new bool();

    [Token(Token = "0x6002A92")]
    [Address(RVA = "0x3506FD8", Offset = "0x3506FD8", VA = "0x3506FD8")]
    private void Update()
    {
    }

    [Token(Token = "0x6002A93")]
    [Address(RVA = "0x3507324", Offset = "0x3507324", VA = "0x3507324")]
    private void SetJumpMove(float val)
    {
    }

    [Token(Token = "0x6002A94")]
    [Address(RVA = "0x3507120", Offset = "0x3507120", VA = "0x3507120")]
    private void ListLabelPlacement(Transform parent, RectTransform badge, RectTransform transfer)
    {
    }

    [Token(Token = "0x6002A95")]
    [Address(RVA = "0x350737C", Offset = "0x350737C", VA = "0x350737C")]
    private void OnMoveEnhanced(CustomSkill customSkill)
    {
    }

    [Token(Token = "0x6002A96")]
    [Address(RVA = "0x35075E4", Offset = "0x35075E4", VA = "0x35075E4")]
    private void OpenAbilityBoard(Style style)
    {
    }

    [Token(Token = "0x6002A97")]
    [Address(RVA = "0x3507974", Offset = "0x3507974", VA = "0x3507974")]
    private IEnumerator ConnectAPIFavorite(CustomSkill customSkill, bool flg) => (IEnumerator) null;

    [Token(Token = "0x6002A98")]
    [Address(RVA = "0x3501F50", Offset = "0x3501F50", VA = "0x3501F50")]
    private void CreateVariantCache()
    {
    }

    [Token(Token = "0x6002A99")]
    [Address(RVA = "0x3507AC0", Offset = "0x3507AC0", VA = "0x3507AC0")]
    public CustomSkillEditListPopup()
    {
    }

    [Token(Token = "0x200078F")]
    public class ThumbData
    {
      [Token(Token = "0x1700065A")]
      public CustomSkill CustomSkill
      {
        [Token(Token = "0x6002AA2"), Address(RVA = "0x3507BF0", Offset = "0x3507BF0", VA = "0x3507BF0")] get
        {
          return (CustomSkill) null;
        }
        [Token(Token = "0x6002AA3"), Address(RVA = "0x3507BF8", Offset = "0x3507BF8", VA = "0x3507BF8")] private set
        {
        }
      }

      [Token(Token = "0x1700065B")]
      public bool IsRemove
      {
        [Token(Token = "0x6002AA4"), Address(RVA = "0x3507C00", Offset = "0x3507C00", VA = "0x3507C00")] get
        {
          return new bool();
        }
        [Token(Token = "0x6002AA5"), Address(RVA = "0x3507C08", Offset = "0x3507C08", VA = "0x3507C08")] private set
        {
        }
      }

      [Token(Token = "0x1700065C")]
      public bool IsSelect
      {
        [Token(Token = "0x6002AA6"), Address(RVA = "0x3507C14", Offset = "0x3507C14", VA = "0x3507C14")] get
        {
          return new bool();
        }
        [Token(Token = "0x6002AA7"), Address(RVA = "0x3507C1C", Offset = "0x3507C1C", VA = "0x3507C1C")] set
        {
        }
      }

      [Token(Token = "0x1700065D")]
      public bool IsNew
      {
        [Token(Token = "0x6002AA8"), Address(RVA = "0x3507C28", Offset = "0x3507C28", VA = "0x3507C28")] get
        {
          return new bool();
        }
        [Token(Token = "0x6002AA9"), Address(RVA = "0x3507C30", Offset = "0x3507C30", VA = "0x3507C30")] set
        {
        }
      }

      [Token(Token = "0x6002AAA")]
      [Address(RVA = "0x35061DC", Offset = "0x35061DC", VA = "0x35061DC")]
      public ThumbData(CustomSkill customSkill, bool isNew)
      {
      }

      [Token(Token = "0x6002AAB")]
      [Address(RVA = "0x35061B4", Offset = "0x35061B4", VA = "0x35061B4")]
      public ThumbData()
      {
      }
    }

    [Token(Token = "0x2000790")]
    public enum eCustomSkillListKind
    {
      [Token(Token = "0x4002334")] Battleskill,
      [Token(Token = "0x4002335")] Grant,
      [Token(Token = "0x4002336")] Strategy,
      [Token(Token = "0x4002337")] Chara,
    }

    [Token(Token = "0x2000791")]
    private struct VariantObject
    {
      [Token(Token = "0x4002338")]
      [FieldOffset(Offset = "0x0")]
      public readonly Transform ThumbParentTransform;
      [Token(Token = "0x4002339")]
      [FieldOffset(Offset = "0x8")]
      public readonly Transform SelectElementParentTransform;
      [Token(Token = "0x400233A")]
      [FieldOffset(Offset = "0x10")]
      public readonly CustomSkillEditListThumbElement SrcThumbElementComponent;
      [Token(Token = "0x400233B")]
      [FieldOffset(Offset = "0x18")]
      public readonly CustomSkillEditListSelectElement SrcSelectElementComponent;

      [Token(Token = "0x6002AAC")]
      [Address(RVA = "0x3507A1C", Offset = "0x3507A1C", VA = "0x3507A1C")]
      public VariantObject(
        Transform thumbParentTransform,
        Transform selectElementParentTransform,
        GameObject srcThumbGroup,
        GameObject srcSelectElementGroup)
      {
      }
    }
  }
}
