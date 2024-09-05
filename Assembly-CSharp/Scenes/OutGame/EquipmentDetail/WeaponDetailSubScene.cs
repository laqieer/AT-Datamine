// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.WeaponDetailSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.Common;
using Scenes.OutGame.Favorite;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
using Scenes.OutGame.Utility;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Common;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x200369E")]
  public class WeaponDetailSubScene : EquipmentDetailSubScene
  {
    [Token(Token = "0x400ED85")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private RarityIcon rarityIconImage;
    [Token(Token = "0x400ED86")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text weaponNameText;
    [Token(Token = "0x400ED87")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image weaponImage;
    [Token(Token = "0x400ED88")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton statusButton;
    [Token(Token = "0x400ED89")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonButton enhanceButton;
    [Token(Token = "0x400ED8A")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton optionEffectButton;
    [Token(Token = "0x400ED8B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton skillButton;
    [Token(Token = "0x400ED8C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400ED8D")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CanvasGroup enhanceMenuGroup;
    [Token(Token = "0x400ED8E")]
    [FieldOffset(Offset = "0xA0")]
    private bool enhanceMenuOn;
    [Token(Token = "0x400ED8F")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Image weaponTypeIcon;
    [Token(Token = "0x400ED90")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Image weaponSystemIcon;
    [Token(Token = "0x400ED91")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Image[] gemOffIconImage;
    [Token(Token = "0x400ED92")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Image[] gemOnIconImage;
    [Token(Token = "0x400ED93")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text levelText;
    [Token(Token = "0x400ED94")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Text levelMaxText;
    [Token(Token = "0x400ED95")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GaugeScale levelExpSlider;
    [Token(Token = "0x400ED96")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x400ED97")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private CommonButton detailButton;
    [Token(Token = "0x400ED98")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private Transform safeArea;
    [Token(Token = "0x400ED99")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private Text attackText;
    [Token(Token = "0x400ED9A")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private Text deathBlowText;
    [Token(Token = "0x400ED9B")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private Text averageText;
    [Token(Token = "0x400ED9C")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private Text weightText;
    [Token(Token = "0x400ED9D")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private Text dodgeText;
    [Token(Token = "0x400ED9E")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private Image[] rangeIconImage;
    [Token(Token = "0x400ED9F")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private Text rangeText;
    [Token(Token = "0x400EDA0")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private Text rangeMaxText;
    [Token(Token = "0x400EDA1")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private Text enduranceText;
    [Token(Token = "0x400EDA2")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private WeaponOptionEffectContainer[] weaponOptionEffectContainers;
    [Token(Token = "0x400EDA3")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private GameObject skillObject;
    [Token(Token = "0x400EDA4")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private DetailSkillListThumb detailSkillList;
    [Token(Token = "0x400EDA5")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private HomeButtonAnimationController homeButtonAnimationController;
    [Token(Token = "0x400EDA6")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private CommonButton returnButton;
    [Token(Token = "0x400EDA7")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private CommonButton prevButton;
    [Token(Token = "0x400EDA8")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400EDA9")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private FavoriteButton favoriteButton;
    [Token(Token = "0x400EDAA")]
    [FieldOffset(Offset = "0x180")]
    private bool favoriteConnecting;
    [Token(Token = "0x400EDAB")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private CommonButton limitBreakButton;
    [Token(Token = "0x400EDAC")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private CommonButton levelUpButton;
    [Token(Token = "0x400EDAD")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    private ContainerSkillSideWindow containerSkillSideWindow;
    [Token(Token = "0x400EDAE")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    private WeaponLimitBreak weaponLimitBreak;
    [Token(Token = "0x400EDAF")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    private WeaponLevelUp weaponLevelUp;
    [Token(Token = "0x400EDB0")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    private WeaponOptionEffect weaponOptionEffect;
    [Token(Token = "0x400EDB1")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    private SkillEnhanceController skillEnhanceController;
    [Token(Token = "0x400EDB2")]
    [FieldOffset(Offset = "0x1C0")]
    [SerializeField]
    private CanvasGroup canvasGroup_top;
    [Token(Token = "0x400EDB3")]
    [FieldOffset(Offset = "0x1C8")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400EDB4")]
    [FieldOffset(Offset = "0x1D0")]
    private bool isTimelineDirection;
    [Token(Token = "0x400EDB5")]
    private const string inoutTimeLineAssetbundleName = "ui_page_equipdetail_timeline";
    [Token(Token = "0x400EDB6")]
    private const string timeLineSettingName = "WeaponDetail";
    [Token(Token = "0x400EDB7")]
    [FieldOffset(Offset = "0x1D8")]
    private readonly string[] timeLineSettingNameList;
    [Token(Token = "0x400EDB8")]
    [FieldOffset(Offset = "0x1E0")]
    private WeaponDetailSubScene.eTimeLineMode timeLineMode;
    [Token(Token = "0x400EDB9")]
    [FieldOffset(Offset = "0x1E8")]
    private readonly string[] directAssetBundleName;
    [Token(Token = "0x400EDBA")]
    [FieldOffset(Offset = "0x1F0")]
    private IAssetProvider assetProvider;
    [Token(Token = "0x400EDBB")]
    [FieldOffset(Offset = "0x1F8")]
    private WeaponDetailSubScene.Param sceneParam;
    [Token(Token = "0x400EDBC")]
    [FieldOffset(Offset = "0x200")]
    public Weapon weaponData;
    [Token(Token = "0x400EDBD")]
    [FieldOffset(Offset = "0x208")]
    private int weaponDataIndex;
    [Token(Token = "0x400EDBE")]
    [FieldOffset(Offset = "0x210")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400EDC0")]
    [FieldOffset(Offset = "0x220")]
    private NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x400EDC1")]
    [FieldOffset(Offset = "0x228")]
    public Action onClickPrevAction;
    [Token(Token = "0x400EDC2")]
    [FieldOffset(Offset = "0x230")]
    public Action onClickNextAction;

    [Token(Token = "0x60157BD")]
    [Address(RVA = "0x1A56010", Offset = "0x1A56010", VA = "0x1A56010")]
    public static bool TryToChangeScene(PlayerWeaponOptionChangePending pending) => new bool();

    [Token(Token = "0x60157BE")]
    [Address(RVA = "0x1A56228", Offset = "0x1A56228", VA = "0x1A56228")]
    public static void ChangeScene(WeaponDetailSubScene.Param param)
    {
    }

    [Token(Token = "0x60157BF")]
    [Address(RVA = "0x1A562D8", Offset = "0x1A562D8", VA = "0x1A562D8")]
    public void SetSceneInteractable(bool state)
    {
    }

    [Token(Token = "0x1700473F")]
    public ItemDetailPopupProvider ItemDetailPopupProvider
    {
      [Token(Token = "0x60157C0"), Address(RVA = "0x1A562F8", Offset = "0x1A562F8", VA = "0x1A562F8")] get
      {
        return (ItemDetailPopupProvider) null;
      }
      [Token(Token = "0x60157C1"), Address(RVA = "0x1A56300", Offset = "0x1A56300", VA = "0x1A56300")] private set
      {
      }
    }

    [Token(Token = "0x60157C2")]
    [Address(RVA = "0x1A56308", Offset = "0x1A56308", VA = "0x1A56308")]
    public AssetCachedSpawner GetAssetCachedSpawner() => (AssetCachedSpawner) null;

    [Token(Token = "0x60157C3")]
    [Address(RVA = "0x1A56310", Offset = "0x1A56310", VA = "0x1A56310")]
    private void Awake()
    {
    }

    [Token(Token = "0x60157C4")]
    [Address(RVA = "0x1A56398", Offset = "0x1A56398", VA = "0x1A56398", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60157C5")]
    [Address(RVA = "0x1A5667C", Offset = "0x1A5667C", VA = "0x1A5667C", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60157C6")]
    [Address(RVA = "0x1A5670C", Offset = "0x1A5670C", VA = "0x1A5670C")]
    private bool IsDisabledLimitBreak() => new bool();

    [Token(Token = "0x60157C7")]
    [Address(RVA = "0x1A567C0", Offset = "0x1A567C0", VA = "0x1A567C0")]
    private bool IsDisabledLevelUp() => new bool();

    [Token(Token = "0x60157C8")]
    [Address(RVA = "0x1A567DC", Offset = "0x1A567DC", VA = "0x1A567DC")]
    private void UpdateLeftMenuButton()
    {
    }

    [Token(Token = "0x60157C9")]
    [Address(RVA = "0x1A56854", Offset = "0x1A56854", VA = "0x1A56854")]
    private void SetDisabledLeftMenuSkillButton(bool isDisabled)
    {
    }

    [Token(Token = "0x60157CA")]
    [Address(RVA = "0x1A568A0", Offset = "0x1A568A0", VA = "0x1A568A0")]
    private void SetDisabledColorLimitBreakButton(bool isDisabled)
    {
    }

    [Token(Token = "0x60157CB")]
    [Address(RVA = "0x1A568C0", Offset = "0x1A568C0", VA = "0x1A568C0")]
    private void SetDisabledColorLevelUpButton(bool isDisabled)
    {
    }

    [Token(Token = "0x60157CC")]
    [Address(RVA = "0x1A568E0", Offset = "0x1A568E0", VA = "0x1A568E0")]
    public void OnBackButton()
    {
    }

    [Token(Token = "0x60157CD")]
    [Address(RVA = "0x1A5703C", Offset = "0x1A5703C", VA = "0x1A5703C", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x60157CE")]
    [Address(RVA = "0x1A571D8", Offset = "0x1A571D8", VA = "0x1A571D8")]
    private void OnClickPrevButton()
    {
    }

    [Token(Token = "0x60157CF")]
    [Address(RVA = "0x1A57328", Offset = "0x1A57328", VA = "0x1A57328")]
    private void OnClickNextButton()
    {
    }

    [Token(Token = "0x60157D0")]
    [Address(RVA = "0x1A5741C", Offset = "0x1A5741C", VA = "0x1A5741C")]
    public void SetOperationPossible(bool flg, WeaponDetailSubScene.eTimeLineMode state)
    {
    }

    [Token(Token = "0x60157D1")]
    [Address(RVA = "0x1A57560", Offset = "0x1A57560", VA = "0x1A57560")]
    private void SetPrevNextInteractable(bool prevNext)
    {
    }

    [Token(Token = "0x60157D2")]
    [Address(RVA = "0x1A5756C", Offset = "0x1A5756C", VA = "0x1A5756C")]
    private void SetPrevNextInteractable(bool prev, bool next)
    {
    }

    [Token(Token = "0x60157D3")]
    [Address(RVA = "0x1A57624", Offset = "0x1A57624", VA = "0x1A57624")]
    public void SetWeaponData()
    {
    }

    [Token(Token = "0x60157D4")]
    [Address(RVA = "0x1A57E0C", Offset = "0x1A57E0C", VA = "0x1A57E0C")]
    private void UpdateStatusSkill()
    {
    }

    [Token(Token = "0x60157D5")]
    [Address(RVA = "0x1A57F78", Offset = "0x1A57F78", VA = "0x1A57F78")]
    public void UpdateStatus(Weapon weaponData, int level)
    {
    }

    [Token(Token = "0x60157D6")]
    [Address(RVA = "0x1A56A78", Offset = "0x1A56A78", VA = "0x1A56A78")]
    public void UpdateStatus(Weapon weaponData, WeaponStandardStatus assumption = null)
    {
    }

    [Token(Token = "0x60157D7")]
    [Address(RVA = "0x1A56FB0", Offset = "0x1A56FB0", VA = "0x1A56FB0")]
    private IEnumerator playTimeline(
      WeaponDetailSubScene.eTimeLineMode mode,
      UITimelineController.DirectionType inout,
      Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60157D8")]
    [Address(RVA = "0x1A5801C", Offset = "0x1A5801C", VA = "0x1A5801C", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x60157D9")]
    [Address(RVA = "0x1A58054", Offset = "0x1A58054", VA = "0x1A58054", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x60157DA")]
    [Address(RVA = "0x1A572B4", Offset = "0x1A572B4", VA = "0x1A572B4")]
    private IEnumerator LoadingWeaponImage(Action finish = null) => (IEnumerator) null;

    [Token(Token = "0x60157DB")]
    [Address(RVA = "0x1A580C4", Offset = "0x1A580C4", VA = "0x1A580C4")]
    private IEnumerator ConnectAPIFavorite(Weapon weapon, bool flg) => (IEnumerator) null;

    [Token(Token = "0x60157DC")]
    [Address(RVA = "0x1A58170", Offset = "0x1A58170", VA = "0x1A58170")]
    private void onClickSkillEnhance(int count)
    {
    }

    [Token(Token = "0x60157DD")]
    [Address(RVA = "0x1A58208", Offset = "0x1A58208", VA = "0x1A58208")]
    private void onClickInvalidEnhance(int count)
    {
    }

    [Token(Token = "0x60157DE")]
    [Address(RVA = "0x1A58328", Offset = "0x1A58328", VA = "0x1A58328")]
    private void OnClickLvInfo()
    {
    }

    [Token(Token = "0x60157DF")]
    [Address(RVA = "0x1A58190", Offset = "0x1A58190", VA = "0x1A58190")]
    private IEnumerator ConnectSkillEnhanceAPI(int tryCount) => (IEnumerator) null;

    [Token(Token = "0x60157E0")]
    [Address(RVA = "0x1A582A4", Offset = "0x1A582A4", VA = "0x1A582A4")]
    public void SetToaster(string txt)
    {
    }

    [Token(Token = "0x60157E1")]
    [Address(RVA = "0x1A58390", Offset = "0x1A58390", VA = "0x1A58390")]
    private void OpenOptionEffect()
    {
    }

    [Token(Token = "0x60157E2")]
    [Address(RVA = "0x1A5849C", Offset = "0x1A5849C", VA = "0x1A5849C")]
    private void OpenSkillMenu()
    {
    }

    [Token(Token = "0x60157E3")]
    [Address(RVA = "0x1A585FC", Offset = "0x1A585FC", VA = "0x1A585FC")]
    private void AddedStatusWindow()
    {
    }

    [Token(Token = "0x60157E4")]
    [Address(RVA = "0x1A5859C", Offset = "0x1A5859C", VA = "0x1A5859C")]
    private void InitSkillSideWindow()
    {
    }

    [Token(Token = "0x60157E5")]
    [Address(RVA = "0x1A58678", Offset = "0x1A58678", VA = "0x1A58678")]
    private bool CanSkillEnhance() => new bool();

    [Token(Token = "0x60157E6")]
    [Address(RVA = "0x1A58764", Offset = "0x1A58764", VA = "0x1A58764")]
    private void Update()
    {
    }

    [Token(Token = "0x60157E7")]
    [Address(RVA = "0x1A58780", Offset = "0x1A58780", VA = "0x1A58780")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60157E8")]
    [Address(RVA = "0x1A5879C", Offset = "0x1A5879C", VA = "0x1A5879C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60157E9")]
    [Address(RVA = "0x1A587B8", Offset = "0x1A587B8", VA = "0x1A587B8")]
    public WeaponDetailSubScene()
    {
    }

    [Token(Token = "0x200369F")]
    public enum eTimeLineMode
    {
      [Token(Token = "0x400EDC4")] WeaponDetail,
      [Token(Token = "0x400EDC5")] WeaponLimitBreak,
      [Token(Token = "0x400EDC6")] WeaponLvup,
      [Token(Token = "0x400EDC7")] WeaponOpitonEff,
      [Token(Token = "0x400EDC8")] WeaponSkill,
      [Token(Token = "0x400EDC9")] WeaponSkillLvUp,
    }

    [Token(Token = "0x20036A0")]
    public class Param : ChangeSceneParameter
    {
      [Token(Token = "0x400EDCE")]
      [FieldOffset(Offset = "0x30")]
      public Action onInitializeAction;
      [Token(Token = "0x400EDCF")]
      [FieldOffset(Offset = "0x38")]
      public SafeObjectCallback onDestroyAction;
      [Token(Token = "0x400EDD0")]
      [FieldOffset(Offset = "0x40")]
      public Action<int> OnBackSceneAction;

      [Token(Token = "0x17004740")]
      public WeaponDetailSubScene.eTimeLineMode TimeLineMode
      {
        [Token(Token = "0x60157F1"), Address(RVA = "0x1A58CA8", Offset = "0x1A58CA8", VA = "0x1A58CA8")] get
        {
          return new WeaponDetailSubScene.eTimeLineMode();
        }
        [Token(Token = "0x60157F2"), Address(RVA = "0x1A58CB0", Offset = "0x1A58CB0", VA = "0x1A58CB0")] protected set
        {
        }
      }

      [Token(Token = "0x17004741")]
      public int WeaponDataIndex
      {
        [Token(Token = "0x60157F3"), Address(RVA = "0x1A58CB8", Offset = "0x1A58CB8", VA = "0x1A58CB8")] get
        {
          return new int();
        }
        [Token(Token = "0x60157F4"), Address(RVA = "0x1A58CC0", Offset = "0x1A58CC0", VA = "0x1A58CC0")] protected set
        {
        }
      }

      [Token(Token = "0x17004742")]
      public List<Weapon> WeaponDataList
      {
        [Token(Token = "0x60157F5"), Address(RVA = "0x1A58CC8", Offset = "0x1A58CC8", VA = "0x1A58CC8")] get
        {
          return (List<Weapon>) null;
        }
        [Token(Token = "0x60157F6"), Address(RVA = "0x1A58CD0", Offset = "0x1A58CD0", VA = "0x1A58CD0")] protected set
        {
        }
      }

      [Token(Token = "0x17004743")]
      public bool EnhanceMenuOn
      {
        [Token(Token = "0x60157F7"), Address(RVA = "0x1A58CD8", Offset = "0x1A58CD8", VA = "0x1A58CD8")] get
        {
          return new bool();
        }
        [Token(Token = "0x60157F8"), Address(RVA = "0x1A58CE0", Offset = "0x1A58CE0", VA = "0x1A58CE0")] protected set
        {
        }
      }

      [Token(Token = "0x17004744")]
      public PlayerWeaponOptionChangePending OptionPending
      {
        [Token(Token = "0x60157F9"), Address(RVA = "0x1A58CEC", Offset = "0x1A58CEC", VA = "0x1A58CEC")] get
        {
          return (PlayerWeaponOptionChangePending) null;
        }
        [Token(Token = "0x60157FA"), Address(RVA = "0x1A58CF4", Offset = "0x1A58CF4", VA = "0x1A58CF4")] protected set
        {
        }
      }

      [Token(Token = "0x60157FB")]
      [Address(RVA = "0x1A561B8", Offset = "0x1A561B8", VA = "0x1A561B8")]
      public Param(
        WeaponDetailSubScene.eTimeLineMode timeLineMode,
        int index,
        List<Weapon> weaponList,
        bool enhanceMenuOn = false,
        Action onInitializeAction = null,
        SafeObjectCallback onDestroyAction = null,
        PlayerWeaponOptionChangePending optionPending = null)
      {
      }
    }
  }
}
