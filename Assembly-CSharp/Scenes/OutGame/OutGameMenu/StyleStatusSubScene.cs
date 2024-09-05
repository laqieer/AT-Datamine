// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleStatusSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.Common;
using Scenes.OutGame.Icon;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Style.UI;
using Scenes.OutGame.UnitDetail.AbilityBoard;
using Scenes.OutGame.Utility;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;
using TMPro;
using UI.Common;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AA7")]
  public class StyleStatusSubScene : SubScene, ICanvasInteractableController
  {
    [Token(Token = "0x40101C3")]
    private const string ASSET_BUNDLE_STYLE_STATUS = "ui_page_stylestatus";
    [Token(Token = "0x40101C4")]
    private const string ASSET_STYLE_PARAMETER = "Container_StyleParameter";
    [Token(Token = "0x40101C5")]
    private const string ASSET_STYLE_STYLE_STATUS_DETAIL = "Container_Overlay_StatusDetail";
    [Token(Token = "0x40101C6")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x40101C7")]
    [FieldOffset(Offset = "0x60")]
    private IAssetProvider styleCategoryPopupProvider;
    [Token(Token = "0x40101C8")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton globalMenuButton;
    [Token(Token = "0x40101C9")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40101CA")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x40101CB")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x40101CC")]
    private const string inoutTimeLineAssetbundleName = "content_effect_common_outgamemenu_timeline";
    [Token(Token = "0x40101CD")]
    [FieldOffset(Offset = "0x88")]
    private readonly string[] timeLineSettingNameList;
    [Token(Token = "0x40101CE")]
    [FieldOffset(Offset = "0x90")]
    private bool isTimelineDirection;
    [Token(Token = "0x40101CF")]
    [FieldOffset(Offset = "0x94")]
    private StyleStatusSubScene.eStyleStatusMode nowStyleStatusMode;
    [Token(Token = "0x40101D0")]
    [FieldOffset(Offset = "0x98")]
    private StyleStatusSubScene.eStyleStatusMode nextStyleStatusMode;
    [Token(Token = "0x40101D1")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private StyleReincarnation styleReincarnation;
    [Token(Token = "0x40101D2")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private StyleReincarnationMemory styleReincarnationMemory;
    [Token(Token = "0x40101D3")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private StyleLimitBreak styleLimitBreak;
    [Token(Token = "0x40101D4")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private StyleRarityUP styleRarityUP;
    [Token(Token = "0x40101D5")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private StyleReinforcement styleReinforcement;
    [Token(Token = "0x40101D6")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private StyleViewer styleViewer;
    [Token(Token = "0x40101D7")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Image imgUnit;
    [Token(Token = "0x40101D8")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Image[] imgRarityStar;
    [Token(Token = "0x40101D9")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private LimitBreakIcons gemController;
    [Token(Token = "0x40101DA")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private TypeIcon[] typeIcons;
    [Token(Token = "0x40101DB")]
    [FieldOffset(Offset = "0xF0")]
    private int typeIconIndex;
    [Token(Token = "0x40101DC")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private Text nowLevelText;
    [Token(Token = "0x40101DD")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private Text maxLevelText;
    [Token(Token = "0x40101DE")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private GaugeScale expSlider;
    [Token(Token = "0x40101DF")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x40101E0")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private Text[] statusText;
    [Token(Token = "0x40101E1")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private Image imgEmblem;
    [Token(Token = "0x40101E2")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private Text StyleNameText;
    [Token(Token = "0x40101E3")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private Text characterNameText;
    [Token(Token = "0x40101E4")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private StyleTrainingRankIcon trainingRankIcon;
    [Token(Token = "0x40101E5")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private WeaponTypeIconWithText enableEquipMainWeaponIcon;
    [Token(Token = "0x40101E6")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private WeaponTypeIconWithText enableEquipSubWeaponIcon;
    [Token(Token = "0x40101E7")]
    [FieldOffset(Offset = "0x150")]
    private List<WeaponTypeIconWithText> enableEquipSubWeaponIcons;
    [Token(Token = "0x40101E8")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private Button charDetailButton;
    [Token(Token = "0x40101E9")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private Button statusDetailButton;
    [Token(Token = "0x40101EA")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private Button abilityBoardButton;
    [Token(Token = "0x40101EB")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private Button skillButton;
    [Token(Token = "0x40101EC")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private CommonButton viewerButton;
    [Token(Token = "0x40101ED")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    private Button returnButton;
    [Token(Token = "0x40101EE")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private Button prevStyleButton;
    [Token(Token = "0x40101EF")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private Button nextStyleButton;
    [Token(Token = "0x40101F0")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    private Button favoriteOffButton;
    [Token(Token = "0x40101F1")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    private Button favoriteOnButton;
    [Token(Token = "0x40101F2")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    private CommonButton limitBreakButton;
    [Token(Token = "0x40101F3")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    private TextMeshProUGUI limitBreakButtonText;
    [Token(Token = "0x40101F4")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    private CommonButton LvUpButton;
    [Token(Token = "0x40101F5")]
    [FieldOffset(Offset = "0x1C0")]
    [SerializeField]
    private CommonButton ReincarnationButton;
    [Token(Token = "0x40101F6")]
    [FieldOffset(Offset = "0x1C8")]
    [SerializeField]
    private CommonButton confirmBonusButton;
    [Token(Token = "0x40101F7")]
    [FieldOffset(Offset = "0x1D0")]
    [SerializeField]
    private CommonButton exSkillConfirmButton;
    [Token(Token = "0x40101F8")]
    [FieldOffset(Offset = "0x1D8")]
    private bool isRarityUP;
    [Token(Token = "0x40101F9")]
    [FieldOffset(Offset = "0x1D9")]
    private bool isMaxEnhance;
    [Token(Token = "0x40101FA")]
    [FieldOffset(Offset = "0x1DA")]
    private bool isMaxLevel;
    [Token(Token = "0x40101FB")]
    [FieldOffset(Offset = "0x1E0")]
    [SerializeField]
    private CommonButton typeIconGroup;
    [Token(Token = "0x40101FC")]
    [FieldOffset(Offset = "0x1E8")]
    [SerializeField]
    private GameObject trustThumbParent;
    [Token(Token = "0x40101FD")]
    [FieldOffset(Offset = "0x1F0")]
    [SerializeField]
    private TrustThumbIcon trustThumbIcon;
    [Token(Token = "0x40101FE")]
    [FieldOffset(Offset = "0x1F8")]
    [SerializeField]
    private LongPressButton trustBaseButton;
    [Token(Token = "0x40101FF")]
    [FieldOffset(Offset = "0x200")]
    [SerializeField]
    private LongPressButton trustImageButton;
    [Token(Token = "0x4010200")]
    [FieldOffset(Offset = "0x208")]
    [SerializeField]
    private Text Txt_Num_Reincarnation;
    [Token(Token = "0x4010201")]
    [FieldOffset(Offset = "0x210")]
    [SerializeField]
    private Text Txt_Num_Complete;
    [Token(Token = "0x4010202")]
    [FieldOffset(Offset = "0x218")]
    [SerializeField]
    private Canvas backUI_Canvas;
    [Token(Token = "0x4010203")]
    [FieldOffset(Offset = "0x220")]
    [SerializeField]
    private Camera backUI_Camera;
    [Token(Token = "0x4010204")]
    [FieldOffset(Offset = "0x228")]
    [SerializeField]
    private Canvas gestureCanvas;
    [Token(Token = "0x4010205")]
    [FieldOffset(Offset = "0x230")]
    [SerializeField]
    private Camera gestureCamera;
    [Token(Token = "0x4010206")]
    [FieldOffset(Offset = "0x238")]
    [SerializeField]
    private GameObject backCenter;
    [Token(Token = "0x4010207")]
    [FieldOffset(Offset = "0x240")]
    [SerializeField]
    private CanvasGroup canvasGroup_top;
    [Token(Token = "0x4010208")]
    [FieldOffset(Offset = "0x248")]
    [SerializeField]
    private HomeButtonAnimationController homeButtonAnimationController;
    [Token(Token = "0x4010209")]
    [FieldOffset(Offset = "0x250")]
    private StyleStatusSubScene.Param sceneParam;
    [Token(Token = "0x401020A")]
    private const string NoValueText = "--";
    [Token(Token = "0x401020B")]
    [FieldOffset(Offset = "0x258")]
    public StaqData.Style dispStyle;
    [Token(Token = "0x401020C")]
    [FieldOffset(Offset = "0x260")]
    private int styleIndex;
    [Token(Token = "0x401020D")]
    [FieldOffset(Offset = "0x264")]
    private bool FavoriteConnecting;
    [Token(Token = "0x401020E")]
    [FieldOffset(Offset = "0x265")]
    private bool isLoadingEmblem;
    [Token(Token = "0x401020F")]
    private const string ReincarnationDirectAssetbundleName = "ui_page_stylestatus";
    [Token(Token = "0x4010210")]
    private const string LvUPDirectPrefabAssetbundleName = "content_effect_common_ui_effect_stylelvup_prefab";
    [Token(Token = "0x4010211")]
    private const string LvUPDirectTimelineAssetbundleName = "content_effect_common_ui_effect_stylelvup_timeline";
    [Token(Token = "0x4010212")]
    private const string LimitBreakDirectPrefabAssetbundleName = "content_effect_common_ui_effect_limitbreakup_prefab";
    [Token(Token = "0x4010213")]
    private const string LimitBreakDirectTimelineAssetbundleName = "content_effect_common_ui_effect_limitbreakup_timeline";
    [Token(Token = "0x4010214")]
    private const string RaralityUPDirectPrefabAssetbundleName = "content_effect_common_ui_effect_raralityup_prefab";
    [Token(Token = "0x4010215")]
    private const string RaralityUPDirectTimelineAssetbundleName = "content_effect_common_ui_effect_raralityup_timeline";
    [Token(Token = "0x4010216")]
    [FieldOffset(Offset = "0x268")]
    private StyleReincarnation_Popup_Confirm styleStatusDialog;
    [Token(Token = "0x4010217")]
    private const string UnitDetailAssetBundleName = "2dassets_ui_unitdetail";
    [Token(Token = "0x4010218")]
    [FieldOffset(Offset = "0x270")]
    private AbilityBoardGenerator abilityBoardGenerator;
    [Token(Token = "0x4010219")]
    [FieldOffset(Offset = "0x278")]
    private AbilityBoardBehaviour abilityBoard;
    [Token(Token = "0x401021A")]
    [FieldOffset(Offset = "0x280")]
    private StyleStatusDetail styleStatusDetail;
    [Token(Token = "0x401021B")]
    [FieldOffset(Offset = "0x288")]
    private ConfirmBonusPopup confirmBonusPopup;
    [Token(Token = "0x401021C")]
    [FieldOffset(Offset = "0x290")]
    private int nowRarity;
    [Token(Token = "0x401021D")]
    [FieldOffset(Offset = "0x298")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x401021E")]
    [FieldOffset(Offset = "0x2A0")]
    private StyleCategoryPopup styleCategoryPopup;
    [Token(Token = "0x401021F")]
    [FieldOffset(Offset = "0x2A8")]
    private NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x4010220")]
    [FieldOffset(Offset = "0x2B0")]
    public Action onClickPrevAction;
    [Token(Token = "0x4010221")]
    [FieldOffset(Offset = "0x2B8")]
    public Action onClickNextAction;

    [Token(Token = "0x60170FE")]
    [Address(RVA = "0x2CE5CB4", Offset = "0x2CE5CB4", VA = "0x2CE5CB4")]
    public AssetCachedSpawner GetAssetCachedSpawner() => (AssetCachedSpawner) null;

    [Token(Token = "0x60170FF")]
    [Address(RVA = "0x2CE5CBC", Offset = "0x2CE5CBC", VA = "0x2CE5CBC")]
    private void Update()
    {
    }

    [Token(Token = "0x17004B77")]
    public PlayableDirector TimeLinePlayableDirector
    {
      [Token(Token = "0x6017100"), Address(RVA = "0x2CE5CD8", Offset = "0x2CE5CD8", VA = "0x2CE5CD8")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x17004B78")]
    public bool isDirection
    {
      [Token(Token = "0x6017101"), Address(RVA = "0x2CE5CE0", Offset = "0x2CE5CE0", VA = "0x2CE5CE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017102")]
    [Address(RVA = "0x2CE5CF0", Offset = "0x2CE5CF0", VA = "0x2CE5CF0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6017103")]
    [Address(RVA = "0x2CE5D78", Offset = "0x2CE5D78", VA = "0x2CE5D78", Slot = "32")]
    public void SetCanvasInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6017104")]
    [Address(RVA = "0x2CE5D98", Offset = "0x2CE5D98", VA = "0x2CE5D98", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6017105")]
    [Address(RVA = "0x2CE6068", Offset = "0x2CE6068", VA = "0x2CE6068", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6017106")]
    [Address(RVA = "0x2CE60F8", Offset = "0x2CE60F8", VA = "0x2CE60F8", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6017107")]
    [Address(RVA = "0x2CE6188", Offset = "0x2CE6188", VA = "0x2CE6188")]
    private void EnhanceMenuButtonUpdate()
    {
    }

    [Token(Token = "0x6017108")]
    [Address(RVA = "0x2CE653C", Offset = "0x2CE653C", VA = "0x2CE653C")]
    public void ChangeReincarnationMemory()
    {
    }

    [Token(Token = "0x6017109")]
    [Address(RVA = "0x2CE6610", Offset = "0x2CE6610", VA = "0x2CE6610")]
    public void BackToReincarnation(Action action = null)
    {
    }

    [Token(Token = "0x601710A")]
    [Address(RVA = "0x2CE1A18", Offset = "0x2CE1A18", VA = "0x2CE1A18")]
    public void OnBackButton()
    {
    }

    [Token(Token = "0x601710B")]
    [Address(RVA = "0x2CE6A70", Offset = "0x2CE6A70", VA = "0x2CE6A70", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x601710C")]
    [Address(RVA = "0x2CE6C0C", Offset = "0x2CE6C0C", VA = "0x2CE6C0C")]
    private void OnClickPrevButton()
    {
    }

    [Token(Token = "0x601710D")]
    [Address(RVA = "0x2CE6E20", Offset = "0x2CE6E20", VA = "0x2CE6E20")]
    private void OnClickNextButton()
    {
    }

    [Token(Token = "0x601710E")]
    [Address(RVA = "0x2CE6DB8", Offset = "0x2CE6DB8", VA = "0x2CE6DB8")]
    private IEnumerator UpdateNextPrev() => (IEnumerator) null;

    [Token(Token = "0x601710F")]
    [Address(RVA = "0x2CE6F48", Offset = "0x2CE6F48", VA = "0x2CE6F48")]
    private void PreloadAdjacentStyleInfo()
    {
    }

    [Token(Token = "0x6017110")]
    [Address(RVA = "0x2CE715C", Offset = "0x2CE715C", VA = "0x2CE715C")]
    private IEnumerator OpenAbilityBoard(bool playAnim = true, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017111")]
    [Address(RVA = "0x2CE7204", Offset = "0x2CE7204", VA = "0x2CE7204")]
    private IEnumerator InitializeAbilityBoard() => (IEnumerator) null;

    [Token(Token = "0x6017112")]
    [Address(RVA = "0x2CE6834", Offset = "0x2CE6834", VA = "0x2CE6834")]
    public void CloseRightSightMenu()
    {
    }

    [Token(Token = "0x6017113")]
    [Address(RVA = "0x2CE73B4", Offset = "0x2CE73B4", VA = "0x2CE73B4", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6017114")]
    [Address(RVA = "0x2CE6828", Offset = "0x2CE6828", VA = "0x2CE6828")]
    private void SetPrevNextInteractable(bool prevNext)
    {
    }

    [Token(Token = "0x6017115")]
    [Address(RVA = "0x2CE76E0", Offset = "0x2CE76E0", VA = "0x2CE76E0")]
    private void SetPrevNextInteractable(bool prev, bool next)
    {
    }

    [Token(Token = "0x6017116")]
    [Address(RVA = "0x2CE7328", Offset = "0x2CE7328", VA = "0x2CE7328")]
    private void SetPrevNextButtonActive(bool isActive)
    {
    }

    [Token(Token = "0x6017117")]
    [Address(RVA = "0x2CE6744", Offset = "0x2CE6744", VA = "0x2CE6744")]
    private IEnumerator playTimeline(
      StyleStatusSubScene.eStyleStatusMode mode,
      UITimelineController.DirectionType inout,
      Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017118")]
    [Address(RVA = "0x2CE77C0", Offset = "0x2CE77C0", VA = "0x2CE77C0")]
    public void PlayHomeButtonInAnimation(Action onFinished = null)
    {
    }

    [Token(Token = "0x6017119")]
    [Address(RVA = "0x2CE67FC", Offset = "0x2CE67FC", VA = "0x2CE67FC")]
    public void PlayHomeButtonOutAnimation(Action onFinished = null)
    {
    }

    [Token(Token = "0x601711A")]
    [Address(RVA = "0x2CE77EC", Offset = "0x2CE77EC", VA = "0x2CE77EC")]
    private void ClearStyleData()
    {
    }

    [Token(Token = "0x601711B")]
    [Address(RVA = "0x2CE7A1C", Offset = "0x2CE7A1C", VA = "0x2CE7A1C")]
    private void ClearTypeIcon()
    {
    }

    [Token(Token = "0x601711C")]
    [Address(RVA = "0x2CE7A94", Offset = "0x2CE7A94", VA = "0x2CE7A94")]
    private TypeIcon GetEmptyTypeIcon() => (TypeIcon) null;

    [Token(Token = "0x601711D")]
    [Address(RVA = "0x2CE7AE4", Offset = "0x2CE7AE4", VA = "0x2CE7AE4")]
    private void SetTypeIcon()
    {
    }

    [Token(Token = "0x601711E")]
    [Address(RVA = "0x2CE8208", Offset = "0x2CE8208", VA = "0x2CE8208")]
    private void SetTypeIconSprite(Sprite sprite, bool isClass)
    {
    }

    [Token(Token = "0x601711F")]
    [Address(RVA = "0x2CE8310", Offset = "0x2CE8310", VA = "0x2CE8310")]
    private void SetEnableEquipWeaponIcon()
    {
    }

    [Token(Token = "0x6017120")]
    [Address(RVA = "0x2CDE928", Offset = "0x2CDE928", VA = "0x2CDE928")]
    public void UpdateReincarnationParam()
    {
    }

    [Token(Token = "0x6017121")]
    [Address(RVA = "0x2CDE97C", Offset = "0x2CDE97C", VA = "0x2CDE97C")]
    public void SetStyleData()
    {
    }

    [Token(Token = "0x6017122")]
    [Address(RVA = "0x2CE83EC", Offset = "0x2CE83EC", VA = "0x2CE83EC")]
    private void SetTrustData()
    {
    }

    [Token(Token = "0x6017123")]
    [Address(RVA = "0x2CE8B08", Offset = "0x2CE8B08", VA = "0x2CE8B08")]
    public void ShowTrustDetail()
    {
    }

    [Token(Token = "0x6017124")]
    [Address(RVA = "0x2CE1700", Offset = "0x2CE1700", VA = "0x2CE1700")]
    public void SetOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6017125")]
    [Address(RVA = "0x2CE8C34", Offset = "0x2CE8C34", VA = "0x2CE8C34")]
    private IEnumerator ConnectAPIFavorite(StaqData.Style style, bool flg) => (IEnumerator) null;

    [Token(Token = "0x6017126")]
    [Address(RVA = "0x2CE8CE0", Offset = "0x2CE8CE0", VA = "0x2CE8CE0")]
    public void SetStyleViewer()
    {
    }

    [Token(Token = "0x6017127")]
    [Address(RVA = "0x2CE93EC", Offset = "0x2CE93EC", VA = "0x2CE93EC")]
    public void SetStyleStatusDialog(
      StyleReincarnation_Popup_Confirm.eStatusDialogKind kind,
      Action<StyleReincarnation_Popup_Confirm.eResult> finish,
      string txt = null)
    {
    }

    [Token(Token = "0x6017128")]
    [Address(RVA = "0x2CE9494", Offset = "0x2CE9494", VA = "0x2CE9494")]
    private IEnumerator WaitStyleStatusDialog(
      Action<StyleReincarnation_Popup_Confirm.eResult> finish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017129")]
    [Address(RVA = "0x2CE83E0", Offset = "0x2CE83E0", VA = "0x2CE83E0")]
    public string int2string(int num) => (string) null;

    [Token(Token = "0x601712A")]
    [Address(RVA = "0x2CE9530", Offset = "0x2CE9530", VA = "0x2CE9530")]
    private IEnumerator SetStyleStatus(StaqData.Style style) => (IEnumerator) null;

    [Token(Token = "0x601712B")]
    [Address(RVA = "0x2CE72C4", Offset = "0x2CE72C4", VA = "0x2CE72C4")]
    private void PlayAbilityBoardOutAnim(bool isClosedStyleStatus)
    {
    }

    [Token(Token = "0x601712C")]
    [Address(RVA = "0x2CE95CC", Offset = "0x2CE95CC", VA = "0x2CE95CC")]
    public IEnumerator OpenStatusDetail(StaqData.Style style) => (IEnumerator) null;

    [Token(Token = "0x601712D")]
    [Address(RVA = "0x2CE966C", Offset = "0x2CE966C", VA = "0x2CE966C")]
    private IEnumerator OpenConfirmBonusPopup() => (IEnumerator) null;

    [Token(Token = "0x601712E")]
    [Address(RVA = "0x2CE96FC", Offset = "0x2CE96FC", VA = "0x2CE96FC")]
    private IEnumerator OpenItemDetailAsync(
      ItemTypeEnum itemTypeEnum,
      int itemId,
      Action backSceneAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601712F")]
    [Address(RVA = "0x2CE97B0", Offset = "0x2CE97B0", VA = "0x2CE97B0")]
    public IEnumerator OpenStyleCategoryPopup() => (IEnumerator) null;

    [Token(Token = "0x6017130")]
    [Address(RVA = "0x2CE21FC", Offset = "0x2CE21FC", VA = "0x2CE21FC")]
    public void OpenItemDetail(ItemTypeEnum itemTypeEnum, int itemId, Action backSceneAction)
    {
    }

    [Token(Token = "0x6017131")]
    [Address(RVA = "0x2CE9840", Offset = "0x2CE9840", VA = "0x2CE9840")]
    private void LoadVoicePackFile()
    {
    }

    [Token(Token = "0x6017132")]
    [Address(RVA = "0x2CE6CEC", Offset = "0x2CE6CEC", VA = "0x2CE6CEC")]
    private void UnLoadVoicePackFile()
    {
    }

    [Token(Token = "0x6017133")]
    [Address(RVA = "0x2CE9910", Offset = "0x2CE9910", VA = "0x2CE9910")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6017134")]
    [Address(RVA = "0x2CE992C", Offset = "0x2CE992C", VA = "0x2CE992C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6017135")]
    [Address(RVA = "0x2CE67D0", Offset = "0x2CE67D0", VA = "0x2CE67D0")]
    private void NotifyBackEvent()
    {
    }

    [Token(Token = "0x6017136")]
    [Address(RVA = "0x2CE9948", Offset = "0x2CE9948", VA = "0x2CE9948")]
    public StyleStatusSubScene()
    {
    }

    [Token(Token = "0x2003AA8")]
    public enum eStyleStatusMode
    {
      [Token(Token = "0x4010223")] Status,
      [Token(Token = "0x4010224")] Reinforcement,
      [Token(Token = "0x4010225")] LimitBreak,
      [Token(Token = "0x4010226")] RarityUp,
      [Token(Token = "0x4010227")] StyleViewer,
      [Token(Token = "0x4010228")] StyleViewerProfile,
      [Token(Token = "0x4010229")] StyleViewerVoice,
      [Token(Token = "0x401022A")] StyleViewerVertical,
      [Token(Token = "0x401022B")] Reincarnation,
      [Token(Token = "0x401022C")] ReincarnationMemory,
      [Token(Token = "0x401022D")] AbilityBoard,
      [Token(Token = "0x401022E")] AbilityBoardSubMenu,
      [Token(Token = "0x401022F")] PrevNextTop,
      [Token(Token = "0x4010230")] PrevNextEnhance,
      [Token(Token = "0x4010231")] MODEMAX,
    }

    [Token(Token = "0x2003AA9")]
    public class Param : ChangeSceneParameter
    {
      [Token(Token = "0x4010232")]
      [FieldOffset(Offset = "0x14")]
      public StyleStatusSubScene.eStyleStatusMode StartMode;
      [Token(Token = "0x4010233")]
      [FieldOffset(Offset = "0x18")]
      public int listIndex;
      [Token(Token = "0x4010236")]
      [FieldOffset(Offset = "0x30")]
      public Action onInitializeAction;
      [Token(Token = "0x4010237")]
      [FieldOffset(Offset = "0x38")]
      public SafeObjectCallback onBackAction;

      [Token(Token = "0x17004B79")]
      public List<int> styleID
      {
        [Token(Token = "0x6017143"), Address(RVA = "0x2CEA7CC", Offset = "0x2CEA7CC", VA = "0x2CEA7CC")] get
        {
          return (List<int>) null;
        }
        [Token(Token = "0x6017144"), Address(RVA = "0x2CEA7D4", Offset = "0x2CEA7D4", VA = "0x2CEA7D4")] set
        {
        }
      }

      [Token(Token = "0x17004B7A")]
      public List<UniqueID> uniqueID
      {
        [Token(Token = "0x6017145"), Address(RVA = "0x2CEA7DC", Offset = "0x2CEA7DC", VA = "0x2CEA7DC")] get
        {
          return (List<UniqueID>) null;
        }
        [Token(Token = "0x6017146"), Address(RVA = "0x2CEA7E4", Offset = "0x2CEA7E4", VA = "0x2CEA7E4")] set
        {
        }
      }

      [Token(Token = "0x17004B7B")]
      public bool isResume
      {
        [Token(Token = "0x6017147"), Address(RVA = "0x2CEA7EC", Offset = "0x2CEA7EC", VA = "0x2CEA7EC")] get
        {
          return new bool();
        }
        [Token(Token = "0x6017148"), Address(RVA = "0x2CEA7F4", Offset = "0x2CEA7F4", VA = "0x2CEA7F4")] set
        {
        }
      }

      [Token(Token = "0x17004B7C")]
      public List<PlayerUnitAbilityBoardCustomALotteryType> AbiliryBoardResumeData
      {
        [Token(Token = "0x6017149"), Address(RVA = "0x2CEA800", Offset = "0x2CEA800", VA = "0x2CEA800")] get
        {
          return (List<PlayerUnitAbilityBoardCustomALotteryType>) null;
        }
        [Token(Token = "0x601714A"), Address(RVA = "0x2CEA808", Offset = "0x2CEA808", VA = "0x2CEA808")] set
        {
        }
      }

      [Token(Token = "0x601714B")]
      [Address(RVA = "0x2CEA810", Offset = "0x2CEA810", VA = "0x2CEA810")]
      public Param(
        StyleStatusSubScene.eStyleStatusMode mode,
        int index,
        List<int> styleId,
        List<UniqueID> uniqueId,
        Action onInitializeAction = null,
        SafeObjectCallback onBackAction = null)
      {
      }
    }
  }
}
